using System;
using Iced.Intel;

namespace InlineAssembly;

internal enum VariableDataType
{
    Register8,
    Register16,
    Register32,
    Register64,
    RegisterFP,
    RegisterMMX,
    RegisterXMM,
    RegisterYMM,
    RegisterZMM
}

//TODO Generate with a template?
public class VariableData
{
    private VariableDataType Type;

    private AssemblerRegister8 R8;
    private AssemblerRegister16 R16;
    private AssemblerRegister32 R32;
    private AssemblerRegister64 R64;
    private AssemblerRegisterST RFP;
    private AssemblerRegisterMM RMMX;
    private AssemblerRegisterXMM RXMM;
    private AssemblerRegisterYMM RYMM;
    private AssemblerRegisterZMM RZMM;


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

    public static implicit operator VariableData(AssemblerRegisterST rFP) =>
        new()
        {
            Type = VariableDataType.RegisterFP,
            RFP = rFP
        };

    public static implicit operator VariableData(AssemblerRegisterMM rMMX) =>
        new()
        {
            Type = VariableDataType.RegisterMMX,
            RMMX = rMMX
        };

    public static implicit operator VariableData(AssemblerRegisterXMM rXMM) =>
        new()
        {
            Type = VariableDataType.RegisterXMM,
            RXMM = rXMM
        };

    public static implicit operator VariableData(AssemblerRegisterYMM rYMM) =>
        new()
        {
            Type = VariableDataType.RegisterYMM,
            RYMM = rYMM
        };

    public static implicit operator VariableData(AssemblerRegisterZMM rZMM) =>
        new()
        {
            Type = VariableDataType.RegisterZMM,
            RZMM = rZMM
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

    public static implicit operator AssemblerRegisterST(VariableData data)
    {
        if (data.Type == VariableDataType.RegisterFP)
        {
            return data.RFP;
        }

        //TODO Improve
        throw new Exception();
    }

    public static implicit operator AssemblerRegisterMM(VariableData data)
    {
        if (data.Type == VariableDataType.RegisterMMX)
        {
            return data.RMMX;
        }

        //TODO Improve
        throw new Exception();
    }

    public static implicit operator AssemblerRegisterXMM(VariableData data)
    {
        if (data.Type == VariableDataType.RegisterXMM)
        {
            return data.RXMM;
        }

        //TODO Improve
        throw new Exception();
    }

    public static implicit operator AssemblerRegisterYMM(VariableData data)
    {
        if (data.Type == VariableDataType.RegisterYMM)
        {
            return data.RYMM;
        }

        //TODO Improve
        throw new Exception();
    }

    public static implicit operator AssemblerRegisterZMM(VariableData data)
    {
        if (data.Type == VariableDataType.RegisterZMM)
        {
            return data.RZMM;
        }

        //TODO Improve
        throw new Exception();
    }
}
