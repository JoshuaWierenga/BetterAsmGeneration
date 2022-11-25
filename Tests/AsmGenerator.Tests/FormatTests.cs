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

    // This test fails currently as the compiler turns r into rax before calling GetGuidParams but is unable to do
    // the same with GetGuidString
    [TestMethod]
    public void FormatMatchTestVariables()
    {
        AssemblerRegister64 r = rax;

        string paramsGuid = AssemblyData.GetGuidParams(new AssemblyData[]
        {
            mov, r, 3,
            ret
        });

        string stringGuid = AssemblyData.GetGuidString(@"
            mov r 3
            ret
        ");

        Assert.AreEqual(paramsGuid, stringGuid);
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