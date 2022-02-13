#nullable enable
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using Iced.Intel;

namespace AsmGenerator;

internal enum AssemblyDataType : byte
{
    Instruction,
    Register,
    ImmediateS8,
    ImmediateU8,
    ImmediateS16,
    ImmediateU16,
    ImmediateS32,
    ImmediateU32,
    ImmediateS64,
    ImmediateU64,
}

//TODO Generate with a template?
//TODO Support memory
public struct AssemblyData
{
    internal AssemblyDataType Type;

    internal Instruction Instruction;

    internal Register Register;

    //TODO Remove and just use a ulong with unchecked casts?
    internal IntegerWrapper Immediate;

    public static implicit operator AssemblyData(Instruction instruction) =>
        new()
        {
            Type = AssemblyDataType.Instruction,
            Instruction = instruction
        };

    public static implicit operator AssemblyData(AssemblerRegister8 r8) =>
        new()
        {
            Type = AssemblyDataType.Register,
            Register = r8
        };

    public static implicit operator AssemblyData(AssemblerRegister16 r16) =>
        new()
        {
            Type = AssemblyDataType.Register,
            Register = r16
        };

    public static implicit operator AssemblyData(AssemblerRegister32 r32) =>
        new()
        {
            Type = AssemblyDataType.Register,
            Register = r32
        };

    public static implicit operator AssemblyData(AssemblerRegister64 r64) =>
        new()
        {
            Type = AssemblyDataType.Register,
            Register = r64
        };

    public static implicit operator AssemblyData(AssemblerRegisterST rFP) =>
        new()
        {
            Type = AssemblyDataType.Register,
            Register = rFP
        };

    public static implicit operator AssemblyData(AssemblerRegisterMM rMMX) =>
        new()
        {
            Type = AssemblyDataType.Register,
            Register = rMMX
        };

    public static implicit operator AssemblyData(AssemblerRegisterXMM rXMM) =>
        new()
        {
            Type = AssemblyDataType.Register,
            Register = rXMM
        };

    public static implicit operator AssemblyData(AssemblerRegisterYMM rYMM) =>
        new()
        {
            Type = AssemblyDataType.Register,
            Register = rYMM
        };

    public static implicit operator AssemblyData(AssemblerRegisterZMM rZMM) =>
        new()
        {
            Type = AssemblyDataType.Register,
            Register = rZMM
        };

    public static implicit operator AssemblyData(sbyte immS8) =>
        new()
        {
            Type = AssemblyDataType.ImmediateS8,
            Immediate = new IntegerWrapper(immS8)
        };

    public static implicit operator AssemblyData(byte immU8) =>
        new()
        {
            Type = AssemblyDataType.ImmediateU8,
            Immediate = new IntegerWrapper(immU8)
        };

    public static implicit operator AssemblyData(short immS16) =>
        new()
        {
            Type = AssemblyDataType.ImmediateS16,
            Immediate = new IntegerWrapper(immS16)
        };

    public static implicit operator AssemblyData(ushort immU16) =>
        new()
        {
            Type = AssemblyDataType.ImmediateU16,
            Immediate = new IntegerWrapper(immU16)
        };

    public static implicit operator AssemblyData(int immS32) =>
        new()
        {
            Type = AssemblyDataType.ImmediateS32,
            Immediate = new IntegerWrapper(immS32)
        };

    public static implicit operator AssemblyData(uint immU32) =>
        new()
        {
            Type = AssemblyDataType.ImmediateU32,
            Immediate = new IntegerWrapper(immU32)
        };

    public static implicit operator AssemblyData(long immS64) =>
        new()
        {
            Type = AssemblyDataType.ImmediateS64,
            Immediate = new IntegerWrapper(immS64)
        };

    public static implicit operator AssemblyData(ulong immU64) =>
        new()
        {
            Type = AssemblyDataType.ImmediateU64,
            Immediate = new IntegerWrapper(immU64)
        };

    public override string ToString()
    {
        return Type switch
        {
            AssemblyDataType.Instruction => Instruction.ToString(),
            AssemblyDataType.Register => Register.ToString(),
            AssemblyDataType.ImmediateS8 => Immediate.intS8.ToString(),
            AssemblyDataType.ImmediateU8 => Immediate.intU8.ToString(),
            AssemblyDataType.ImmediateS16 => Immediate.intS16.ToString(),
            AssemblyDataType.ImmediateU16 => Immediate.intU16.ToString(),
            AssemblyDataType.ImmediateS32 => Immediate.intS32.ToString(),
            AssemblyDataType.ImmediateU32 => Immediate.intU32.ToString(),
            AssemblyDataType.ImmediateS64 => Immediate.intS64.ToString(),
            AssemblyDataType.ImmediateU64 => Immediate.intU64.ToString(),
            _ => throw new ArgumentOutOfRangeException()
        };
    }

    //TODO Revert changes to this file, ignoreIndices is no longer required
    public static string GetGuid(IEnumerable<AssemblyData> data, IEnumerable<int>? ignoreIndices = null)
    {
        StringBuilder sb = new();

        using IEnumerator<AssemblyData> dataEnumerator = data.GetEnumerator();
        using IEnumerator<int>? indexEnumerator = ignoreIndices?.GetEnumerator();
        bool stillRemoving = true;

        indexEnumerator?.MoveNext();
        for(int i = 0; dataEnumerator.MoveNext(); i++)
        {
            if (stillRemoving && i == indexEnumerator?.Current)
            {
                stillRemoving = indexEnumerator.MoveNext();
            }
            else
            {
                sb.Append(dataEnumerator.Current.ToString().ToLower());
            }
        }

        using MD5 md5 = MD5.Create();
        string asmString = sb.ToString();
        byte[] asmHash = md5.ComputeHash(Encoding.Default.GetBytes(asmString));
        string asmGuid = new Guid(asmHash).ToString("N");

        return asmGuid;
    }
}
