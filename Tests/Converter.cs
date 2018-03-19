using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using Mono.Cecil;
using Mono.Collections.Generic;
using Xunit;
#pragma warning disable 618

public class Converter
{
    static string source;
    static string converted;
    static string keyPath;
    static string mocksDirectory;

    static Converter()
    {
        var binariesPath = GetBinariesPath();
        source = Path.Combine(binariesPath, "Source");
        converted = Path.Combine(binariesPath, "Converted");
        keyPath = Path.Combine(GetSolutionPath(), "key.snk");
        mocksDirectory = Path.GetFullPath(Path.Combine(GetSolutionPath(), "Mocks"));
    }

    [Fact]
    public void Run()
    {
        foreach (var directory in Directory.EnumerateDirectories(source))
        {
            ProcessDir(directory);
        }
    }

    void ProcessDir(string directory)
    {
        var newDirPath = Path.Combine(converted, Path.GetFileName(directory));
        PurgeDirectory(newDirPath);
        var readerParameters = new ReaderParameters
        {
            AssemblyResolver = new AssemblyResolver(newDirPath)
        };
        var modules = Directory.EnumerateFiles(directory).Select(x => ModuleDefinition.ReadModule(x, readerParameters)).ToList();
        foreach (var module in modules.OrderBy(x => SharePointRefs(x).Count()))
        {
            foreach (var reference in SharePointRefs(module))
            {
                var refModule = modules.Single(x => x.Assembly.Name.Name == reference.Name);
                reference.PublicKeyToken = refModule.Assembly.Name.PublicKeyToken;
            }

            EmptyConstructor.Execute(module);
            new Virtual().Execute(module);
            CreateMocks(directory, module);
            var newFilePath = Path.Combine(converted, Path.GetFileName(directory), module.Name);
            var writerParameters = GetWriterParameters();
            module.Write(newFilePath, writerParameters);
        }
    }

    void CreateMocks(string directory, ModuleDefinition module)
    {
        var mocksSubDir = Path.Combine(mocksDirectory, Path.GetFileName(directory), module.Name.Replace(".dll", "") + ".Mocks");
        PurgeDirectory(mocksSubDir);
        foreach (var type in module.GetTypes())
        {
            ProcessClass(type, mocksSubDir);
        }
    }

    static void PurgeDirectory(string dir)
    {
        if (!Directory.Exists(dir))
        {
            Directory.CreateDirectory(dir);
            return;
        }

        foreach (var file in Directory.EnumerateFiles(dir, "*.*", SearchOption.AllDirectories))
        {
            File.Delete(file);
        }
    }

    static void ProcessClass(TypeDefinition type, string mocksSubDir)
    {
        if (!type.IsPublic ||
            !type.IsClass ||
            type.IsStatic() ||
            type.IsAbstract ||
            !type.HasGenericParameters ||
            type.IsEnum ||
            type.IsValueType ||
            type.IsDelegate() ||
            type.IsObsolete())
        {
            return;
        }

        var builder = new StringBuilder();
        string typeName;
        if (type.HasGenericParameters)
        {
            typeName = type.Name.Replace("`1", "Mock<T>");
        }
        else
        {
            typeName = type.Name+ "Mock";
        }
        string parentName;
        if (type.HasGenericParameters)
        {
            parentName = type.Name.Replace("`1", "<T>");
        }
        else
        {
            parentName = type.Name;
        }

        builder.AppendLine(
            $@"
// ReSharper disable IdentifierTypo
namespace {type.Namespace}
{{
    public class {typeName} : {parentName}
    {{
");
        foreach (var property in type.Properties)
        {
            AddProperty(property, builder);
        }

        var groupBy = GetMethodsToProcess(type).GroupBy(x=>x.Name);
        foreach (var method in groupBy)
        {
            AddMethod(builder, method.ToList());
        }

        builder.AppendLine(
            $@"
    }}
}}
");
        var namespacePath = Path.Combine(mocksSubDir, type.Namespace);
        Directory.CreateDirectory(namespacePath);
        var filePath = Path.Combine(namespacePath, $"{type.Name.Replace("`","_")}Mock.cs");
        File.WriteAllText(filePath, builder.ToString());
    }

    static void AddMethod(StringBuilder builder, List<MethodDefinition> methods)
    {
        if (methods.Count == 1)
        {
            AddMethod(methods.Single(), builder, false);
            return;
        }
        foreach (var method in methods)
        {
            AddMethod(method, builder, true);
        }
    }

    static void AddMethod(MethodDefinition method, StringBuilder builder, bool addParamTypeToMethod)
    {
        var returnType = method.ReturnType;
        if (returnType.Name == "Void")
        {
            builder.Append($@"
        public override void {method.Name}(");
            var parameters = method.Parameters;
            AddParams(builder, parameters);
            builder.AppendLine($@")
        {{
        }}");
            return;
        }

        var returnTypeName = returnType.CSharpName();
        builder.Append($@"
        public override {returnTypeName} {method.Name}(");
        var parameters1 = method.Parameters;
        AddParams(builder, parameters1);
        string exName;
        if (addParamTypeToMethod)
        {
            exName = $"{method.Name}{string.Concat(method.Parameters.Select(x=>x.ParameterType.Name))}Ex";
        }
        else
        {
            exName = $"{method.Name}Ex";
        }

        builder.AppendLine($@")
        {{
            return {exName};
        }}
        public {returnTypeName} {exName} {{ get; set;}}");
    }

    static void AddParams(StringBuilder builder, Collection<ParameterDefinition> parameters)
    {
        foreach (var parameter in parameters)
        {
            var paramType = parameter.ParameterType.CSharpName();

            if (parameter.IsIn)
            {
                builder.Append(@"ref ");
            }

            builder.Append($@"{paramType} @{parameter.Name}");
            if (parameters.Last() != parameter)
            {
                builder.Append(", ");
            }
        }
    }

    static IEnumerable<MethodDefinition> GetMethodsToProcess(TypeDefinition type)
    {
        return type.Methods
            .Where(method => !method.IsProperty() &&
                             //TODO: support generics
                             !method.HasGenericParameters &&
                             !method.IsStatic &&
                             !method.IsEvent() &&
                             method.IsPublic &&
                             !method.IsConstructor &&
                             !method.IsObsolete() &&
                             //TODO: support out
                             !method.Parameters.Any(x=>x.IsOut));
    }

    static void AddProperty(PropertyDefinition property, StringBuilder builder)
    {
        if (property.IsObsolete() ||
            property.IsStatic())
        {
            return;
        }

        if (property.IsIndexer())
        {
            GenerateIndexProperty(property, builder);
            return;
        }

        GenerateNormalProperty(property, builder);
    }
    static void GenerateIndexProperty(PropertyDefinition property, StringBuilder builder)
    {
        var getMethod = property.GetMethod;
        var setMethod = property.SetMethod;

        var returnTypeName = property.PropertyType.CSharpName();
        if (setMethod == null)
        {
            if (getMethod.IsPublic)
            {
                var getIndexTypeName = getMethod.Parameters.Single().ParameterType.CSharpName();
                builder.AppendLine($@"
        public override {returnTypeName} this[{getIndexTypeName} fieldName] => ItemEx[fieldName];
        public System.Collections.Generic.Dictionary<{getIndexTypeName}, {returnTypeName}> ItemEx {{ get; set; }}
");
            }

            return;
        }

        if (getMethod == null)
        {
            if (setMethod.IsPublic)
            {
                var setIndexTypeName = setMethod.Parameters.First().ParameterType.CSharpName();
                builder.AppendLine($@"
        public override {returnTypeName} this[{setIndexTypeName} fieldName] {{ set => ItemEx[fieldName] = value;}}
        public System.Collections.Generic.Dictionary<{setIndexTypeName}, {returnTypeName}> ItemEx {{ get; set; }}
");
            }

            return;
        }

        if (!getMethod.IsPublic && !setMethod.IsPublic)
        {
            return;
        }

        var indexTypeName = setMethod.Parameters.First().ParameterType.CSharpName();
        if (getMethod.IsPublic)
        {
            builder.AppendLine($@"
        public override {returnTypeName} this[{indexTypeName} fieldName] => ItemEx[fieldName];
        public System.Collections.Generic.Dictionary<{indexTypeName}, {returnTypeName}> ItemEx {{ get; set; }}
");

            return;
        }

        builder.AppendLine($@"
        public override {returnTypeName} this[{indexTypeName} fieldName] {{ set => ItemEx[fieldName] = value;}}
        public System.Collections.Generic.Dictionary<{indexTypeName}, {returnTypeName}> ItemEx {{ get; set; }}
");
    }

    static void GenerateNormalProperty(PropertyDefinition property, StringBuilder builder)
    {
        var getMethod = property.GetMethod;
        var setMethod = property.SetMethod;

        var cSharpName = property.PropertyType.CSharpName();
        if (setMethod == null)
        {
            if (getMethod.IsPublic)
            {
                builder.AppendLine($@"
        public override {cSharpName} {property.Name} => {property.Name}Ex;
        public {cSharpName} {property.Name}Ex {{ get; set; }}");
            }

            return;
        }

        if (getMethod == null)
        {
            if (setMethod.IsPublic)
            {
                builder.AppendLine($@"
        public override {cSharpName} {property.Name} {{ set {{ {property.Name}Ex = value; }} }};
        public {cSharpName} {property.Name}Ex {{ get; set; }}");
            }

            return;
        }

        if (!getMethod.IsPublic && !setMethod.IsPublic)
        {
            return;
        }

        if (getMethod.IsPublic)
        {
            builder.AppendLine($@"
        public override {cSharpName} {property.Name} => {property.Name}Ex;
        public {cSharpName} {property.Name}Ex {{ get; set; }}");
            return;
        }

        builder.AppendLine($@"
        public override {cSharpName} {property.Name} {{ set {{ {property.Name}Ex = value; }} }};
        public {cSharpName} {property.Name}Ex {{ get; set;}}");
    }

    static IEnumerable<AssemblyNameReference> SharePointRefs(ModuleDefinition x)
    {
        return x.AssemblyReferences.Where(y => y.Name.StartsWith("Microsoft.SharePoint"));
    }

    WriterParameters GetWriterParameters()
    {
        return new WriterParameters
        {
            StrongNameKeyPair = GetStrongName()
        };
    }

    StrongNameKeyPair GetStrongName()
    {
        using (var keyPairFile = File.OpenRead(keyPath))
        {
            return new StrongNameKeyPair(keyPairFile);
        }
    }

    static string GetBinariesPath()
    {
        return Path.GetFullPath(Path.Combine(GetSolutionPath(), "Binaries"));
    }

    static string GetSolutionPath([CallerFilePath] string sourceFilePath = "")
    {
        return Path.GetFullPath(Path.Combine(Path.GetDirectoryName(sourceFilePath), "../"));
    }
}