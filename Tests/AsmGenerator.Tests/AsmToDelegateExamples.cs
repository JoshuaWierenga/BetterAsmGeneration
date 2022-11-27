using AsmLib;
using AsmToDelegate;
using Iced.Intel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static AsmLib.Instructions;
using static Iced.Intel.AssemblerRegisters;

namespace AsmGenerator.Tests;

[TestClass]
public unsafe class AsmToDelegateExamples
{
    [TestMethod]
    public void Add()
    {
        Assembler paramsAsm = new(bitness: 64);
        paramsAsm.AddInstructions
        (
            mov, rax, rcx,
            add, rax, rdx,
            ret
        );

        Assembler stringAsm = new(bitness: 64);
        stringAsm.AddInstructions(/* language = asm */ @"
            mov rax rcx
            add rax rdx
            ret
        ");

        var paramsFunc = paramsAsm.ToFunctionPointerWinX64<ulong, ulong, ulong>();
        var stringFunc = stringAsm.ToFunctionPointerWinX64<ulong, ulong, ulong>();

        Assert.AreEqual(44ul, paramsFunc(31, 13));
        Assert.AreEqual(44ul, stringFunc(31, 13));
    }

    [TestMethod]
    public void Variables()
    {
        AssemblerRegister64 a, b, c, d;

        Assembler paramsAsm = new(bitness: 64);
        paramsAsm.AddVariables
        (
            a = rcx,
            b = rdx,
            c = r8,
            d = r9
        ).AddInstructions
        (
            mov, rax, a,
            imul, rax, b,
            mov, rbx, c,
            imul, rbx, d,
            add, rax, rbx,
            ret
        );

        Assembler stringAsm = new(bitness: 64);
        stringAsm.AddVariables
        (
            a = rcx,
            b = rdx,
            c = r8,
            d = r9
        ).AddInstructions(/* language = asm */ @"
            mov rax a
            imul rax b
            mov rbx c
            imul rbx d
            add rax rbx
            ret
        ");
        
        var paramsFunc = paramsAsm.ToFunctionPointerWinX64<long, long, long, long, long>();
        var stringFunc = stringAsm.ToFunctionPointerWinX64<long, long, long, long, long>();

        Assert.AreEqual(210L, paramsFunc(5, 2, 10, 20));
        Assert.AreEqual(210L, stringFunc(5, 2, 10, 20));
    }

    [TestMethod]
    public void TSC()
    {
        Assembler paramsAsm = new(bitness: 64);
        paramsAsm.AddInstructions
        (
            rdtsc,
            shl, rdx, 32,
            add, rax, rdx,
            ret
        );

        Assembler stringAsm = new(bitness: 64);
        stringAsm.AddInstructions(/* language = asm */ @"
            rdtsc
            shl rdx 32
            add rax rdx
            ret
        ");

        var paramsFunc = paramsAsm.ToFunctionPointerWinX64<ulong>();
        var stringFunc = stringAsm.ToFunctionPointerWinX64<ulong>();

        // This value of course changes over time so allow for some discrepancy
        Assert.AreEqual(paramsFunc(), stringFunc(), 1000.0);
    }
}
