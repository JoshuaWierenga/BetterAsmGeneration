using System;
using Iced.Intel;

#nullable enable

namespace AsmGenerator;

public readonly struct BetterInstruction
{
    private readonly Mnemonic _instruction;

    internal BetterInstruction(Mnemonic instruction)
    {
        _instruction = instruction;
    }

    public override string ToString()
    {
        return Enum.GetName(typeof(Mnemonic), _instruction) ?? "Unknown Instruction";
    }
}

internal enum AssemblyDataType : byte
{
    Instruction,
    Operand
}

public struct AssemblyData
{
    internal AssemblyDataType Type;

    internal BetterInstruction Instruction;

    internal Register Operand;

    public static implicit operator AssemblyData(BetterInstruction instruction) =>
        new()
        {
            Type = AssemblyDataType.Instruction,
            Instruction = instruction
        };

    public static implicit operator AssemblyData(AssemblerRegister64 r64) =>
        new()
        {
            Type = AssemblyDataType.Operand,
            Operand = r64
        };

    public override string ToString()
    {
        if (Type == AssemblyDataType.Instruction)
        {
            return Instruction.ToString();
        }

        if (Operand != Register.None)
        {
            return Operand.ToString();
        }

        throw new ArgumentOutOfRangeException();
    }
}
