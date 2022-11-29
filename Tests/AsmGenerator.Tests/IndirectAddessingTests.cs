using AsmToDelegate;
using Iced.Intel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.CompilerServices;
using AsmLib;
using static AsmLib.Instructions;
using static Iced.Intel.AssemblerRegisters;

namespace AsmGenerator.Tests;

[TestClass]
public unsafe class IndirectAddressingTests
{
    [TestMethod]
    public void DefaultSizeTest()
    {
        int input = 5;
        int output = 1;
        IntPtr iInput = new(Unsafe.AsPointer(ref input));
        IntPtr iOutput = new(Unsafe.AsPointer(ref output));

        Assembler paramsAsm = new(bitness: 64);
        paramsAsm.AddInstructions(
            mov, rax, __[rcx],
            inc, eax,
            mov, __[rdx], rax,
            ret
        );

        Assembler stringAsm = new(bitness: 64);
        stringAsm.AddInstructions(/* language = asm */ @"
            mov rax __[rcx]
            inc eax
            mov __[rdx] rax
            ret
        ");

        var paramsFunc = paramsAsm.ToFunctionPointerWinX64<IntPtr, IntPtr, byte>();

        paramsFunc(iInput, iOutput);
        Assert.AreEqual(6, output);
    }
}
