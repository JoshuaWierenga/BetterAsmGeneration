using System;
using Iced.Intel;

namespace AsmLib;

internal enum AssemblyDataType : byte
{
    Instruction,
    Register,
    Memory,
    Label,
    ImmediateS8,
    ImmediateU8,
    ImmediateS16,
    ImmediateU16,
    ImmediateS32,
    ImmediateU32,
    ImmediateS64,
    ImmediateU64
}

//TODO Generate with a template?
//TODO Fully support memory
public struct AssemblyData
{
    private AssemblyDataType _type;

    private Instruction _instruction;

    private Register _register;

    private AssemblerMemoryOperand _memory;

    private Label _label;

    //TODO Remove and just use a ulong with unchecked casts?
    private IntegerWrapper _immediate;

    public static implicit operator AssemblyData(Instruction instruction) =>
        new()
        {
            _type = AssemblyDataType.Instruction,
            _instruction = instruction
        };

    public static implicit operator AssemblyData(AssemblerRegister8 r8) =>
        new()
        {
            _type = AssemblyDataType.Register,
            _register = r8
        };

    public static implicit operator AssemblyData(AssemblerRegister16 r16) =>
        new()
        {
            _type = AssemblyDataType.Register,
            _register = r16
        };

    public static implicit operator AssemblyData(AssemblerRegister32 r32) =>
        new()
        {
            _type = AssemblyDataType.Register,
            _register = r32
        };

    public static implicit operator AssemblyData(AssemblerRegister64 r64) =>
        new()
        {
            _type = AssemblyDataType.Register,
            _register = r64
        };

    public static implicit operator AssemblyData(AssemblerRegisterST rFP) =>
        new()
        {
            _type = AssemblyDataType.Register,
            _register = rFP
        };

    public static implicit operator AssemblyData(AssemblerRegisterMM rMMX) =>
        new()
        {
            _type = AssemblyDataType.Register,
            _register = rMMX
        };

    public static implicit operator AssemblyData(AssemblerRegisterXMM rXMM) =>
        new()
        {
            _type = AssemblyDataType.Register,
            _register = rXMM
        };

    public static implicit operator AssemblyData(AssemblerRegisterYMM rYMM) =>
        new()
        {
            _type = AssemblyDataType.Register,
            _register = rYMM
        };

    public static implicit operator AssemblyData(AssemblerRegisterZMM rZMM) =>
        new()
        {
            _type = AssemblyDataType.Register,
            _register = rZMM
        };

    public static implicit operator AssemblyData(AssemblerMemoryOperand memory) =>
        new()
        {
            _type = AssemblyDataType.Memory,
            _memory = memory
        };

    public static implicit operator AssemblyData(Label label) =>
        new()
        {
            _type = AssemblyDataType.Label,
            _label = label
        };

    public static implicit operator AssemblyData(sbyte immS8) =>
        new()
        {
            _type = AssemblyDataType.ImmediateS8,
            _immediate = new IntegerWrapper(immS8)
        };

    public static implicit operator AssemblyData(byte immU8) =>
        new()
        {
            _type = AssemblyDataType.ImmediateU8,
            _immediate = new IntegerWrapper(immU8)
        };

    public static implicit operator AssemblyData(short immS16) =>
        new()
        {
            _type = AssemblyDataType.ImmediateS16,
            _immediate = new IntegerWrapper(immS16)
        };

    public static implicit operator AssemblyData(ushort immU16) =>
        new()
        {
            _type = AssemblyDataType.ImmediateU16,
            _immediate = new IntegerWrapper(immU16)
        };

    public static implicit operator AssemblyData(int immS32) =>
        new()
        {
            _type = AssemblyDataType.ImmediateS32,
            _immediate = new IntegerWrapper(immS32)
        };

    public static implicit operator AssemblyData(uint immU32) =>
        new()
        {
            _type = AssemblyDataType.ImmediateU32,
            _immediate = new IntegerWrapper(immU32)
        };

    public static implicit operator AssemblyData(long immS64) =>
        new()
        {
            _type = AssemblyDataType.ImmediateS64,
            _immediate = new IntegerWrapper(immS64)
        };

    public static implicit operator AssemblyData(ulong immU64) =>
        new()
        {
            _type = AssemblyDataType.ImmediateU64,
            _immediate = new IntegerWrapper(immU64)
        };

    public override string ToString()
    {
        return _type switch
        {
            AssemblyDataType.Instruction => _instruction.ToString(),
            AssemblyDataType.Register => _register.ToString(),
            AssemblyDataType.Memory => $"__[{_memory.Base.ToString().ToLower()}]",
            AssemblyDataType.Label => _label.Name.Substring(3),
            AssemblyDataType.ImmediateS8 => _immediate.intS8.ToString(),
            AssemblyDataType.ImmediateU8 => _immediate.intU8.ToString(),
            AssemblyDataType.ImmediateS16 => _immediate.intS16.ToString(),
            AssemblyDataType.ImmediateU16 => _immediate.intU16.ToString(),
            AssemblyDataType.ImmediateS32 => _immediate.intS32.ToString(),
            AssemblyDataType.ImmediateU32 => _immediate.intU32.ToString(),
            AssemblyDataType.ImmediateS64 => _immediate.intS64.ToString(),
            AssemblyDataType.ImmediateU64 => _immediate.intU64.ToString(),
            _ => throw new ArgumentOutOfRangeException()
        };
    }
}
