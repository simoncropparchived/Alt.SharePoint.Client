using System.Collections.Generic;
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
    static string converted;
    static string keyPath;

    static Converter()
    {
        var binariesPath = GetBinariesPath();
        source = Path.Combine(binariesPath, "Source");
        converted = Path.Combine(binariesPath, "Converted");
        keyPath = Path.Combine(GetSolutionPath(), "key.snk");
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
            var newFilePath = Path.Combine(converted, Path.GetFileName(directory), module.Name);
            var writerParameters = GetWriterParameters();
            module.Write(newFilePath, writerParameters);
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