using System;
using Iced.Intel;

namespace AsmGenerator;

public readonly struct Instruction
{
    private readonly Mnemonic _instruction;

    internal Instruction(Mnemonic instruction)
    {
        _instruction = instruction;
    }

    public override string ToString()
    {
        return Enum.GetName(typeof(Mnemonic), _instruction) ?? "Unknown Instruction";
    }
}