using System;
using AsmGenerator;
using AsmToDelegate;
using Iced.Intel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static AsmGenerator.Instructions;
using static Iced.Intel.AssemblerRegisters;

namespace AsmGeneratorTests;

[TestClass]
public unsafe class AsmToDelegateExamples
{
    [TestMethod]
    public void Add()
    {
        var asm = new Assembler(bitness: 64);
        asm.AddInstructions
        (
            mov, rax, rcx,
            add, rax, rdx,
            ret
        );

        var addFunction = asm.ToFunctionPointerWinX64<ulong, ulong, ulong>();
        Assert.AreEqual(44ul, addFunction(31, 13));
    }

    [TestMethod]
    public void Variables()
    {
        var asm = new Assembler(bitness: 64);
        AssemblerRegister64 a, b, c, d;

        asm.AddVariables
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

        var addFunction = asm.ToFunctionPointerWinX64<long, long, long, long, long>();
        Assert.AreEqual(210L, addFunction(5, 2, 10, 20));
    }

    [TestMethod]
    public void TSC()
    {
        var asm = new Assembler(bitness: 64);
        asm.AddInstructions
        (
            rdtsc,
            shl, rdx, 32,
            add, rax, rdx,
            ret
        );
        var tsc = asm.ToFunctionPointerWinX64<ulong>();
        Console.WriteLine($"{tsc()} cycles since last reset");
    }
}
