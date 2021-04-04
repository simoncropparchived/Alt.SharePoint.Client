using Mono.Cecil;
using Mono.Cecil.Cil;
using Mono.Cecil.Rocks;

public partial class Virtual
{
    public void ConvertFunctionPointer(ModuleDefinition module)
    {
        foreach (var type in module.GetAllClasses())
        {
            foreach (var methodDefinition in type.Methods)
            {
                ReplaceUnmanaged(methodDefinition);
            }
        }
    }

    void ReplaceUnmanaged(MethodDefinition? method)
    {
        if (method == null)
        {
            return;
        }
        if (method.IsAbstract)
        {
            return;
        }
        //for delegates
        if (method.Body == null)
        {
            return;
        }
        method.Body.SimplifyMacros();
        var instructions = method.Body.Instructions;
        var foundUsageInMethod = false;
        for (var index = 0; index < instructions.Count; index++)
        {
            var instruction = instructions[index];
            if (instruction.OpCode != OpCodes.Ldftn)
            {
                continue;
            }

            var methodToLdvirtfn = DetermineMethodTo_Ldvirtftn(instruction.Operand);
            if (methodToLdvirtfn == null)
            {
                continue;
            }

            if (!foundUsageInMethod)
            {
                method.Body.SimplifyMacros();
                foundUsageInMethod = true;
            }

            index++;
            instructions.Insert(index, Instruction.Create(OpCodes.Ldvirtftn, methodToLdvirtfn));
            instruction.OpCode = OpCodes.Dup;
            instruction.Operand = null;
        }

        if (foundUsageInMethod)
        {
            method.Body.OptimizeMacros();
        }
    }

    MethodReference? DetermineMethodTo_Ldvirtftn(object operand)
    {
        foreach (var method in MethodCache)
        {
            if (operand == method)
            {
                return method;
            }

            if (!(operand is MethodReference operandMethodReference))
            {
                continue;
            }
            var operandMethodDefinition = operandMethodReference.Resolve();
            if (operandMethodDefinition == method)
            {
                return operandMethodReference;
            }
        }

        return null;
    }
}