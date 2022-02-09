using System;
using System.Collections.Generic;
using System.Linq;
using Iced.Intel;

#nullable enable

namespace BetterAsm;

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

#if DEBUG
        if (Operand != Register.None)
        {
#endif
            return Operand.ToString();
#if DEBUG
        }
#endif

        throw new ArgumentOutOfRangeException();
    }
}

public class OldBetterInstructionCollection
{
    private readonly List<Tuple<BetterInstruction, List<AssemblyData>>> _instructions = new();

    public OldBetterInstructionCollection(params AssemblyData[] assembly)
    {
        foreach (AssemblyData data in assembly)
        {
            if (data.Type == AssemblyDataType.Instruction)
            {
                _instructions.Add(
                    new Tuple<BetterInstruction, List<AssemblyData>>(data.Instruction, new List<AssemblyData>()));
            }
            else if (_instructions.Count != 0)
            {
                _instructions.Last().Item2.Add(data);
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(data));
            }
        }
    }

    public Assembler Parse()
    {
        Assembler assembler = new(64);

        foreach ((BetterInstruction instruction, List<AssemblyData>? operands) in _instructions)
        {
            string instructionName = instruction.ToString();

            if (instructionName == "Ret")
            {
                assembler.AddInstruction(Instruction.Create(Code.Retnq));
                continue;
            }

            if (operands.Count != 2) throw new ArgumentOutOfRangeException(nameof(operands));

            if (!operands[1].Operand.IsGPR64()) throw new ArgumentOutOfRangeException(nameof(operands));
            instructionName += "_r64";

            if (!operands[0].Operand.IsGPR64()) throw new ArgumentOutOfRangeException(nameof(operands));
            instructionName += "_rm64";

            Code code = (Code)Enum.Parse(typeof(Code), instructionName);

            assembler.AddInstruction(Instruction.Create(code, operands[0].Operand, operands[1].Operand));
        }

        return assembler;
    }
}

public static class BetterInstructionCollection
{
    public static Assembler Parse(params AssemblyData[] assembly)
    {
        List<Tuple<BetterInstruction, List<AssemblyData>>> instructions = new();

        foreach (AssemblyData data in assembly)
        {
            if (data.Type == AssemblyDataType.Instruction)
            {
                instructions.Add(
                    new Tuple<BetterInstruction, List<AssemblyData>>(data.Instruction, new List<AssemblyData>()));
            }
            else if (instructions.Count != 0)
            {
                instructions.Last().Item2.Add(data);
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(data));
            }
        }

        Assembler assembler = new(64);

        foreach ((BetterInstruction instruction, List<AssemblyData>? operands) in instructions)
        {
            string instructionName = instruction.ToString();

            if (instructionName == "Ret")
            {
                assembler.AddInstruction(Instruction.Create(Code.Retnq));
                continue;
            }

            if (operands.Count != 2) throw new ArgumentOutOfRangeException(nameof(operands));

            if (!operands[1].Operand.IsGPR64()) throw new ArgumentOutOfRangeException(nameof(operands));
            instructionName += "_r64";

            if (!operands[0].Operand.IsGPR64()) throw new ArgumentOutOfRangeException(nameof(operands));
            instructionName += "_rm64";

            Code code = (Code)Enum.Parse(typeof(Code), instructionName);

            assembler.AddInstruction(Instruction.Create(code, operands[0].Operand, operands[1].Operand));
        }

        return assembler;
    }
}