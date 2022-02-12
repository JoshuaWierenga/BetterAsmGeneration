using System;
using Iced.Intel;

namespace AsmGenerator;

internal enum VariableDataType
{
    Register8,
    Register16,
    Register32,
    Register64
}

public class VariableData
{
    internal VariableDataType Type;

    internal AssemblerRegister8 R8;
    internal AssemblerRegister16 R16;
    internal AssemblerRegister32 R32;
    internal AssemblerRegister64 R64;


    public static implicit operator VariableData(AssemblerRegister8 r8) =>
        new()
        {
            Type = VariableDataType.Register8,
            R8 = r8
        };

    public static implicit operator VariableData(AssemblerRegister16 r16) =>
        new()
        {
            Type = VariableDataType.Register16,
            R16 = r16
        };

    public static implicit operator VariableData(AssemblerRegister32 r32) =>
        new()
        {
            Type = VariableDataType.Register32,
            R32 = r32
        };

    public static implicit operator VariableData(AssemblerRegister64 r64) =>
        new()
        {
            Type = VariableDataType.Register64,
            R64 = r64
        };


    public static implicit operator AssemblerRegister8(VariableData data)
    {
        if (data.Type == VariableDataType.Register8)
        {
            return data.R8;
        }

        //TODO Improve
        throw new Exception();
    }

    public static implicit operator AssemblerRegister16(VariableData data)
    {
        if (data.Type == VariableDataType.Register16)
        {
            return data.R16;
        }

        //TODO Improve
        throw new Exception();
    }

    public static implicit operator AssemblerRegister32(VariableData data)
    {
        if (data.Type == VariableDataType.Register32)
        {
            return data.R32;
        }

        //TODO Improve
        throw new Exception();
    }

    public static implicit operator AssemblerRegister64(VariableData data)
    {
        if (data.Type == VariableDataType.Register64)
        {
            return data.R64;
        }

        //TODO Improve
        throw new Exception();
    }
}