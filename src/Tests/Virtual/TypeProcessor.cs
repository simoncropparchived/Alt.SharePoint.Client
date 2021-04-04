using System.Diagnostics;
using Mono.Cecil;

public partial class Virtual
{
    public void ProcessType(TypeDefinition type)
    {
        if (type.IsEnum ||
            type.IsValueType ||
            type.IsDelegate())
        {
            return;
        }
        Trace.WriteLine($"\t{type.FullName}");
        type.IsSealed = false;
        foreach (var method in type.Methods)
        {
            if (method.IsConstructor)
            {
                continue;
            }
            ProcessMethod(method);
        }
    }

    void ProcessMethod(MethodDefinition? method)
    {
        if (method == null)
        {
            return;
        }

        if (method.IsFinal && method.IsVirtual)
        {
            method.IsFinal = false;
            AddMethodToCache(method);
            return;
        }
        if (method.IsFinal)
        {
            return;
        }
        if (method.IsVirtual)
        {
            return;
        }
        if (method.IsStatic)
        {
            return;
        }
        if (method.IsPrivate)
        {
            return;
        }

        if (MethodIsSerializationCallback(method))
        {
            return;
        }

        AddMethodToCache(method);
        method.IsVirtual = true;
        method.IsNewSlot = true;
    }

    bool MethodIsSerializationCallback(MethodDefinition method)
    {
        return method.CustomAttributes.ContainsAttribute("OnSerializingAttribute")
               || method.CustomAttributes.ContainsAttribute("OnSerializedAttribute")
               || method.CustomAttributes.ContainsAttribute("OnDeserializingAttribute")
               || method.CustomAttributes.ContainsAttribute("OnDeserializedAttribute");
    }
}