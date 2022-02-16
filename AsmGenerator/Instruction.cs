using System;
using Iced.Intel;

namespace AsmGenerator;

internal enum InstructionType : byte
{
    AsmInstruction,
    EmitLabel
}

public readonly struct Instruction
{
    private readonly InstructionType _type;

    private readonly Mnemonic _instruction;

    internal Instruction(Mnemonic instruction)
    {
        _type = InstructionType.AsmInstruction;
        _instruction = instruction;
    }

    internal Instruction(bool label)
    {
        _type = InstructionType.EmitLabel;
        _instruction = default;
    }

    public override string ToString()
    {
        return _type switch
        {
            InstructionType.AsmInstruction => Enum.GetName(typeof(Mnemonic), _instruction) ?? "Unknown Instruction",
            InstructionType.EmitLabel => "Emit Label",
            _ => throw new Exception()
        };
    }
}