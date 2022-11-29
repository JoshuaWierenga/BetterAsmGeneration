using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using AsmLib;
using AsmToDelegate;
using Iced.Intel;
using static Iced.Intel.AssemblerRegisters;

// Change the extension to csasm within visual studio with the extension loaded for syntax highlighting
unsafe
{
    Assembler paramsSimpleExample = new(bitness: 64);
    paramsSimpleExample.AddInstructions(/* language=asm */ """
        mov rax rcx
        add rax rdx
        ret
    """);

    var paramsSimpleExampleFunc = paramsSimpleExample.ToFunctionPointerWinX64<ulong, ulong, ulong>();

    Debug.Assert(paramsSimpleExampleFunc(1, 2) == 3);
    Console.WriteLine("Param Simple Example: 1 + 2 = {0}", paramsSimpleExampleFunc(1, 2));

    AssemblerRegister64 a, b, c, d;
    Assembler paramsVariableExample = new(bitness: 64);
    paramsVariableExample.AddVariables
    (
        a = rcx,
        b = rdx,
        c = r8,
        d = r9
    ).AddInstructions(/* language=asm */ """ 
        mov rax a
        imul rax b
        mov rbx c
        imul rbx d
        add rax rbx
        ret
    """);

    var paramsVariableExampleFunc = paramsVariableExample.ToFunctionPointerWinX64<ulong, ulong, ulong, ulong, ulong>();
    
    Debug.Assert(paramsVariableExampleFunc(5, 2, 10, 20) == 210);
    Console.WriteLine("Params Variable Example: 5 * 2 + 10 * 20 = {0}", paramsVariableExampleFunc(5, 2, 10, 20));

    Vector128<int> lower = Vector128.Create(1, 2, 3, 4);
    Vector128<int> upper = Vector128.Create(5, 6, 7, 8);
    Vector128<int> result = Vector128<int>.Zero;
    void* pLower = Unsafe.AsPointer(ref lower);
    void* pUpper = Unsafe.AsPointer(ref upper);
    void* pResult = Unsafe.AsPointer(ref result);
    IntPtr iLower = new(pLower);
    IntPtr iUpper = new(pUpper);
    IntPtr iResult = new(pResult);
    Assembler paramsMemoryAccessExample = new(bitness: 64);
    paramsMemoryAccessExample.AddInstructions(/* language=asm */ """
        movdqa xmm0 __[rcx]
        movdqa xmm1 __[rdx]
        paddd xmm0 xmm1
        movdqa __[r8] xmm0
        ret
    """);

    var paramsMemoryAccessExampleFunc = paramsMemoryAccessExample.ToFunctionPointerWinX64<IntPtr, IntPtr, IntPtr, byte>();

    paramsMemoryAccessExampleFunc(iLower, iUpper, iResult);
    Debug.Assert(Sse2.Add(lower, upper).Equals(result));
    Console.WriteLine("<1, 2, 3, 4> + <5, 6, 7, 8> = {0}", result);
}
