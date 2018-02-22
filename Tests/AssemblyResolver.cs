using System.Collections.Generic;
using System.IO;
using Mono.Cecil;

class AssemblyResolver : DefaultAssemblyResolver
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