using Mono.Cecil;

public partial class Virtual
{
    public void ProcessAssembly(ModuleDefinition module)
    {
        foreach (var type in module.GetAllClasses())
        {
            ProcessType(type);
        }
    }
}