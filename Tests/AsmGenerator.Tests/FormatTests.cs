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
        string paramsGuid = AssemblyData.GetGuidParams(new AssemblyData[]
        {
            mov, rax, 3,
            ret
        });

        string stringGuid = AssemblyData.GetGuidString(@"
            mov rax 3
            ret
        ");

        Assert.AreEqual(paramsGuid, stringGuid);
    }

    [TestMethod]
    public void FormatMatchTestVariables()
    {
        AssemblerRegister64 r;

        Assembler asmParam = new(bitness: 64);
        asmParam.AddVariables
        (
            r = rax
        ).AddInstructions
        (
            mov, r, 3,
            ret
        );

        string hashParam = AssemblyData.GetGuidParams(new AssemblyData[]
        {
            mov, r, 3,
            ret
        });
        Action<Assembler> implParam = Generator.Implementations[hashParam];

        Assembler asmString = new(bitness: 64);
        asmString.AddVariables
        (
            r = rax
        ).AddInstructions( /* language = asm */ @"
            mov r 3
            ret
        ");

        string hashString = AssemblyData.GetGuidString(@"
            mov r 3
            ret
        ");
        Action<Assembler> implString = Generator.Implementations[hashString];

        Assert.AreEqual(implParam, implString);
    }

    [TestMethod]
    public void StringFormatFormattingIndependentTest()
    {
        string stringGuid1 = AssemblyData.GetGuidString(@"
            mov rax 3
            ret
        ");

        string stringGuid2 = AssemblyData.GetGuidString(@"
            mov rax 
3

                         ret
        ");

        Assert.AreEqual(stringGuid1, stringGuid2);
    }
}