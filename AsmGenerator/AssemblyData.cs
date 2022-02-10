using System;
using Iced.Intel;

namespace AsmGenerator;

enum AssemblyDataType : byte
{
    Instruction,
    Operand
}

public struct AssemblyData
{
    internal AssemblyDataType Type;

    internal Instruction Instruction;

    internal Register Operand;

    public static implicit operator AssemblyData(Instruction instruction) =>
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
