using System.Collections.Generic;
using System.Linq;
using Mono.Cecil;
using Mono.Cecil.Cil;

static class Extensions
{
    public static bool HasEmptyConstructor(this TypeDefinition typeDefinition)
    {
        return typeDefinition.Methods.Any(IsEmptyConstructor);
    }

    public static bool ContainsAttribute(this IEnumerable<CustomAttribute> attributes, string attributeName)
    {
        return attributes.Any(attribute => attribute.Constructor.DeclaringType.Name == attributeName);
    }

    public static IEnumerable<string> NonEmpty(this IEnumerable<string> list)
    {
        return list.Select(x => x.Trim()).Where(x => x != string.Empty);
    }

    public static MethodDefinition GetEmptyConstructor(this TypeDefinition typeDefinition)
    {
        return typeDefinition.Methods.FirstOrDefault(IsEmptyConstructor);
    }

    public static bool IsStatic(this TypeDefinition typeDefinition)
    {
        return !typeDefinition.Methods.Any(x => x.IsConstructor && !x.IsStatic);
    }

    public static string CSharpName(this TypeReference typeDefinition)
    {
        return typeDefinition.ToString()
            .Replace("`1", "")
            .Replace("`2", "");

    }


    public static bool IsStatic(this PropertyDefinition propertyDefinition)
    {
        if (propertyDefinition.GetMethod != null)
        {
            return propertyDefinition.GetMethod.IsStatic;
        }
        return propertyDefinition.SetMethod.IsStatic;
    }

    public static Instruction Clone(this Instruction instruction)
    {
        var cloned = Instruction.Create(OpCodes.Ldarg_0);
        cloned.OpCode = instruction.OpCode;
        cloned.Operand = instruction.Operand;
        return cloned;
    }

    public static bool IsEmptyConstructor(this MethodDefinition x)
    {
        if (!x.IsConstructor)
        {
            return false;
        }
        if (x.IsStatic)
        {
            return false;
        }
        if (x.Parameters.Count == 0)
        {
            return true;
        }
        return false;
    }

    public static bool IsDelegate(this TypeDefinition typeDefinition)
    {
        if (typeDefinition.BaseType == null)
        {
            return false;
        }
        return typeDefinition.BaseType.FullName == "System.MulticastDelegate";
    }
}