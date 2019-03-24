using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mono.Cecil;

static class Extensions
{
    public static List<TypeDefinition> GetAllClasses(this ModuleDefinition moduleDefinition)
    {
        var definitions = new List<TypeDefinition>();
        //First is always module so we will skip that;
        GetTypes(moduleDefinition.Types.Skip(1), definitions);
        return definitions;
    }

    static void GetTypes(IEnumerable<TypeDefinition> typeDefinitions, List<TypeDefinition> definitions)
    {
        foreach (var typeDefinition in typeDefinitions)
        {
            GetTypes(typeDefinition.NestedTypes, definitions);

            if (typeDefinition.IsInterface)
            {
                continue;
            }
            if (typeDefinition.IsEnum)
            {
                continue;
            }
            definitions.Add(typeDefinition);
        }
    }

    public static bool IsIndexer(this PropertyDefinition property)
    {
        return property.Name == "Item" && (property.GetMethod?.Parameters.Count == 1 || property.SetMethod?.Parameters.Count == 2);
    }

    public static bool ContainsAttribute(this IEnumerable<CustomAttribute> attributes, string attributeName)
    {
        return attributes.Any(attribute => attribute.Constructor.DeclaringType.Name == attributeName);
    }

    public static MethodDefinition GetEmptyConstructor(this TypeDefinition type)
    {
        return type.Methods.FirstOrDefault(IsEmptyConstructor);
    }

    public static bool IsStatic(this TypeDefinition type)
    {
        return !type.Methods.Any(x => x.IsConstructor && !x.IsStatic);
    }

    public static string CSharpName(this TypeReference type)
    {
        if (type.IsGenericParameter)
        {
            return type.Name;
        }
        string value;
        if (type.IsNested)
        {
            value = type.DeclaringType.CSharpName();
        }
        else
        {
            if (type.Namespace == string.Empty)
            {
                return type.Name;
            }
            value = type.Namespace;
        }

        var builder = new StringBuilder(value + "." + type.Name.Split('`').First());

        if (type is GenericInstanceType genericInstanceType)
        {
            builder.Append("<");
            for (var index = 0; index < genericInstanceType.GenericArguments.Count; index++)
            {
                var argument = genericInstanceType.GenericArguments[index];
                builder.Append(argument.CSharpName());
                if (index < genericInstanceType.GenericArguments.Count-1)
                {
                    builder.Append(", ");
                }
            }

            builder.Append(">");
        }
        return builder.ToString();
    }

    public static bool IsStatic(this PropertyDefinition propertyDefinition)
    {
        if (propertyDefinition.GetMethod != null)
        {
            return propertyDefinition.GetMethod.IsStatic;
        }
        return propertyDefinition.SetMethod.IsStatic;
    }

    public static bool IsProperty(this MethodDefinition method)
    {
        return method.Name.StartsWith("get_") || method.Name.StartsWith("set_");
    }

    public static bool IsEvent(this MethodDefinition method)
    {
        return method.Name.StartsWith("add_") || method.Name.StartsWith("remove_");
    }

    public static bool IsObsolete(this MethodDefinition method)
    {
        return method.CustomAttributes.ContainsAttribute(nameof(ObsoleteAttribute));
    }

    public static bool IsObsolete(this TypeDefinition method)
    {
        return method.CustomAttributes.ContainsAttribute(nameof(ObsoleteAttribute));
    }

    public static bool IsObsolete(this PropertyDefinition method)
    {
        return method.CustomAttributes.ContainsAttribute(nameof(ObsoleteAttribute));
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