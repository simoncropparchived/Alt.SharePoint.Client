using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using Mono.Cecil;
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

        foreach (var file in Directory.EnumerateFiles(dir))
        {
            File.Delete(file);
        }

        foreach (var subDir in Directory.EnumerateDirectories(dir))
        {
            Directory.Delete(subDir, true);
        }
    }

    static void ProcessClass(TypeDefinition type, string mocksSubDir)
    {
        if (!type.IsPublic ||
            !type.IsClass ||
            type.IsStatic() ||
            type.Properties.Count == 0)
        {
            return;
        }

        var builder = new StringBuilder();
        builder.AppendLine(
            $@"
namespace {type.Namespace}
{{
    public class {type.Name}Mock
    {{
");
        foreach (var property in type.Properties)
        {
            AddProperty(property, builder);
        }

        builder.AppendLine(
            $@"
    }}
}}
");
        var namespacePath = Path.Combine(mocksSubDir, type.Namespace);
        Directory.CreateDirectory(namespacePath);
        var filePath = Path.Combine(namespacePath, $"{type.Name}Mock.cs");
        File.WriteAllText(filePath, builder.ToString());
    }

    static void AddProperty(PropertyDefinition property, StringBuilder builder)
    {
        if (property.IsStatic())
        {
            return;
        }
        var getMethod = property.GetMethod;
        var setMethod = property.SetMethod;

        if (setMethod == null)
        {
            if (getMethod.IsPublic)
            {
                builder.AppendLine($@"
        public override {property.PropertyType} {property.Name} => {property.Name}Ex;
        public {property.PropertyType} {property.Name}Ex {{ get; set; }}");
            }

            return;
        }
        if (getMethod == null)
        {
            if (setMethod.IsPublic)
            {
                builder.AppendLine($@"
        public override {property.PropertyType} {property.Name} {{ set {{ {property.Name}Ex = value; }} }};
        public {property.PropertyType} {property.Name}Ex {{ get; set; }}");
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
        public override {property.PropertyType} {property.Name} => {property.Name}Ex;
        public {property.PropertyType} {property.Name}Ex {{ get; set; }}");
            return;
        }

        builder.AppendLine($@"
        public override {property.PropertyType} {property.Name} {{ set {{ {property.Name}Ex = value; }} }};
        public {property.PropertyType} {property.Name}Ex {{ get; set;}}");
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

    public class AssemblyResolver : DefaultAssemblyResolver
    {
        string converted;
        Dictionary<string, AssemblyDefinition> refs = new Dictionary<string, AssemblyDefinition>();

        public AssemblyResolver(string converted)
        {
            this.converted = converted;
        }

        public override AssemblyDefinition Resolve(AssemblyNameReference name, ReaderParameters parameters)
        {
            if (name.Name.StartsWith("Microsoft.SharePoint"))
            {
                if (!refs.TryGetValue(name.Name, out var reference))
                {
                    reference = AssemblyDefinition.ReadAssembly(Path.Combine(converted, name.Name + ".dll"));
                    refs[name.Name] = reference;
                }

                return reference;
            }

            return base.Resolve(name, parameters);
        }
    }
}