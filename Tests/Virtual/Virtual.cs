using Mono.Cecil;

public partial class Virtual
{
    public void Execute(ModuleDefinition module)
    {
        ProcessAssembly(module);
        //TODO: work out if the below are required
        //ConvertCallToCallVirtual(module);
        //ConvertNewToOverrides(module);
        //ConvertFunctionPointer(module);
    }
}