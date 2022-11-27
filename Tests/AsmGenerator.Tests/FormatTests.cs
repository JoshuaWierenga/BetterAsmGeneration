using System;
using AsmLib;
using Iced.Intel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static AsmLib.Instructions;
using static Iced.Intel.AssemblerRegisters;

namespace AsmGenerator.Tests;

[TestClass]
public class FormatTests
{
    [TestMethod]
    public void FormatMatchTestSimple()
    {
        string paramsHash = HashGeneration.ToHash(new AssemblyData[]
        {
            mov, rax, 3,
            ret
        });

        string stringHash = HashGeneration.ToHash(@"
            mov rax 3
            ret
        ");

        Assert.AreEqual(paramsHash, stringHash);
    }

    [TestMethod]
    public void FormatMatchTestVariables()
    {
        AssemblerRegister64 r;

        Assembler paramsAsm = new(bitness: 64);
        paramsAsm.AddVariables
        (
            r = rax
        ).AddInstructions
        (
            mov, r, 3,
            ret
        );

        string paramsHash = HashGeneration.ToHash(new AssemblyData[]
        {
            mov, r, 3,
            ret
        });
        // TODO Fix warning about having multiple Generator classes in AsmLib
        Action<Assembler> paramsImpl = Generator.Implementations[paramsHash];

        Assembler stringAsm = new(bitness: 64);
        stringAsm.AddVariables
        (
            r = rax
        ).AddInstructions( /* language = asm */ @"
            mov r 3
            ret
        ");

        string stringHash = HashGeneration.ToHash(@"
            mov r 3
            ret
        ");
        // TODO Fix warning about having multiple Generator classes in AsmLib
        Action<Assembler> stringImpl = Generator.Implementations[stringHash];

        Assert.AreEqual(paramsImpl, stringImpl);
    }

    [TestMethod]
    public void StringFormatFormattingIndependentTest()
    {
        string stringHash1 = HashGeneration.ToHash(@"
            mov rax 3
            ret
        ");

        string stringHash2 = HashGeneration.ToHash(@"
            mov rax 
3

                         ret
        ");

        Assert.AreEqual(stringHash1, stringHash2);
    }
}