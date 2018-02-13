using Mono.Cecil;

public partial class Virtual
{
    public void Execute(ModuleDefinition module)
    {
        ProcessAssembly(module);
        ConvertCallToCallVirtual(module);
        ConvertNewToOverrides(module);
        ConvertFunctionPointer(module);
    }
}