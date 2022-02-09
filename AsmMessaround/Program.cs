using System.Diagnostics;
using AsmToDelegate;
using static BetterAsmInstructions;
using static Iced.Intel.AssemblerRegisters;


unsafe
{
    var asm = AsmGeneration.CompileTimeBetterInstructionCollection.Parse
    (
        Mov,  rax, rcx,
        Add, rax, rdx,
        Ret
    );

    var add = asm.ToFunctionPointerWinX64<ulong, ulong, ulong>();
    Debug.Assert(44ul == add(31, 13));
    Console.WriteLine("Add two integers: 31 + 13 = " + add(31, 13));

    //TODO Support variables
    /*var a = rcx;
    var b = rdx;
    var c = r8;
    var d = r9;

    var asm2 = AsmGeneration.CompileTimeBetterInstructionCollection.Parse
    (
        Mov, rax, a,
        Imul, rax, b,
        Mov, rbx, c,
        Imul, rbx, d,
        Add, rax, rbx,
        Ret
    );

    var add2 = asm.ToFunctionPointerWinX64<long, long, long, long, long>();
    Debug.Assert(210L == add2(5, 2, 10, 20));
    Console.WriteLine("Something complex: 5 * 2 + 10 * 20 = " + add(5, 2, 10, 20));*/

    //TODO Support constants in generated Assembler
    /*var asm3 = AsmGeneration.CompileTimeBetterInstructionCollection.Parse
    (
        Rdtsc,
        Shl, rdx, 32,
        Add, rax, rdx,
        Ret
    );

    var tsc = asm3.ToFunctionPointerWinX64<ulong>();
    Console.WriteLine($"{tsc()} cycles since last reset");*/
}