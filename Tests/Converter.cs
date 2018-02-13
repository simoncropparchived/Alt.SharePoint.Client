using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Mono.Cecil;
using Xunit;
#pragma warning disable 618

public class Converter
{
    static string source;
    static string binariesPath;
    static string converted;
    static string keyPath;

    static Converter()
    {
        binariesPath = GetBinariesPath();
        source = Path.Combine(binariesPath, "Source");
        converted = Path.Combine(binariesPath, "Converted");
        keyPath = Path.Combine(GetSolutionPath(), "key.snk");
    }

    [Fact]
    public void Run()
    {
        var clientRuntime = "Microsoft.SharePoint.Client.Runtime.dll";
        byte[] runtimePublicKeyToken;
        using (var module = ModuleDefinition.ReadModule(Path.Combine(source, clientRuntime)))
        {
            new EmptyConstructor().Execute(module);
            var newFilePath = Path.Combine(converted, clientRuntime);
            var writerParameters = GetWriterParameters();
            module.Write(newFilePath, writerParameters);
            runtimePublicKeyToken = module.Assembly.Name.PublicKeyToken;
        }

        var client = "Microsoft.SharePoint.Client.dll";
        using (var module = ModuleDefinition.ReadModule(Path.Combine(source, client), new ReaderParameters
        {
            AssemblyResolver = new AssemblyResolver()
        }))
        {
            new EmptyConstructor().Execute(module);
            new Virtual().Execute(module);
            var runtimeRef = module.AssemblyReferences.Single(x => x.Name == "Microsoft.SharePoint.Client.Runtime");
            runtimeRef.PublicKeyToken = runtimePublicKeyToken;
            var newFilePath = Path.Combine(converted, client);
            var writerParameters = GetWriterParameters();
            module.Write(newFilePath, writerParameters);
        }
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
        public override AssemblyDefinition Resolve(AssemblyNameReference name, ReaderParameters parameters)
        {
            if (name.Name == "Microsoft.SharePoint.Client.Runtime")
            {
                return AssemblyDefinition.ReadAssembly(Path.Combine(source, "Microsoft.SharePoint.Client.Runtime.dll"));
            }

            return base.Resolve(name, parameters);
        }
    }

}