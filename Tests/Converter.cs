using System;
using System.IO;
using Mono.Cecil;
using Xunit;

public class Converter
{
    [Fact]
    public void Run()
    {
        var binariesPath = GetBinariesPath();
        var source = Path.Combine(binariesPath, "Source");
        var converted = Path.Combine(binariesPath, "Converted");
        ModuleDefinition.ReadModule()
    }

    string GetBinariesPath([System.Runtime.CompilerServices.CallerFilePath] string sourceFilePath = "")
    {
        return Path.GetFullPath(Path.Combine("../../Binaries", sourceFilePath));
    }
}