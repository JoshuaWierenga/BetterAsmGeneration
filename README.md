# Inline Assembly for C#

This project attempts to support writing inline assembly in C# in a similar way to C's `asm` keyword.\
Currently, there are two quite different versions available with different shortcomings. Both rely quite heavily on [Iced](https://github.com/icedland/iced) for its assembler and lists of assembly mnemonics and registers and [AsmToDelegate](https://github.com/WhiteBlackGoose/AsmToDelegate) to turn the resulting binary into a function pointer.

## Params Format Assembly

This is the original format supported and offered some level of intellisense and error detection but little else. Additionally, since tokens are passed in as a params array, they must be comma separated which is quite different from any standard x86 assembly syntax.
```cs
Assembler paramsSimpleExample = new(bitness: 64);
paramsSimpleExample.AddInstructions
(
  mov, rax, rcx,
  add, rax, rdx,
  ret
);

AssemblerRegister64 a, b, c, d;
Assembler paramsVariableExample = new(bitness: 64);
paramsVariableExample.AddVariables
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

Assembler paramsMemoryAccessExample = new(bitness: 64);
paramsMemoryAccessExample.AddInstructions(
  movdqa, xmm0, __[rcx],
  movdqa, xmm1, __[rdx],
  paddd, xmm0, xmm1,
  movdqa, __[r8], xmm0,
  ret
);
```

## String Format Assembly

This format was designed to fix of some the major issues with the previous format but has introduced its own issues. It should have full syntax highlighting and be easier to add extra features to. However, the highlighting has proven a problem so far and requires both a vs extension and changing the file extension just to get subpar highlighting compared to [Asm-Dude](https://github.com/HJLebbink/asm-dude) for example.

```cs
Assembler stringSimpleExample = new(bitness: 64);
stringSimpleExample.AddInstructions(/* language=asm */ """
    mov rax rcx
    add rax rdx
    ret
""");

AssemblerRegister64 a, b, c, d;
Assembler stringVariableExample = new(bitness: 64);
stringVariableExample.AddVariables
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

Assembler stringMemoryAccessExample = new(bitness: 64);
stringMemoryAccessExample.AddInstructions(/* language=asm */ """
    movdqa xmm0 __[rcx]
    movdqa xmm1 __[rdx]
    paddd xmm0 xmm1
    movdqa __[r8] xmm0
    ret
""");
```

Here is the memory access example with the partial syntax highlighting currently available:\
![Image of string format assembly memory access example with syntax highlighting](/Assets/StringFormatSyntaxHighlightingExample.png)

## Project Structure

The main component of this is the AsmGenerator project which is a Roslyn Source Generator that looks for calls to AddVariables and AddInstructions while you write code and outputs Iced syntax assembly to match. To allow multiple calls to AddInstructions in a single project, the generator tags each with a hash that is determined based on the assembly code passed in. Then at runtime, this hash is regenerated to identify which Iced code to run.\
Next is AsmLib which handles providing some key features missing from Iced like a list of instructions as fields that can be used with params format without having to preface each with a type. It additionally houses a few other structures used with the runtime hashing system.\
Finally, there is AsmSourceHighlightingExtension which generates a special TextMate grammar based on Microsoft's [provided C# one](https://github.com/dotnet/csharp-tmLanguage) and one designed for [x86_64 assembly](https://github.com/13xforever/x86-assembly-textmate-bundle) to provide inline assembly syntax highlighting for the string format assembly, currently this only works for the `csasm` extension and so requires manually changing to it. However, later on, this extension will include support for automatically changing the extension back and forth when required.

Note that there are also tests for some features in AsmGenerator.Tests which I try to keep functional and up to date with changes to AsmGenerator.

See [Version.md](Version.md) for version information, this project uses semver to make the version numbers easy to decipher.

## Usage

### Setup

Until I create a NuGet package, download and add packagereferences for the AsmLib and AsmGenerator projects. Specifically for the AsmGenerator project, you also need to add the `OutputItemType="Analyzer"  ReferenceOutputAssembly="false"` attributes so that vs knows how to use it, check the AsmMessaround [project file](Tests/AsmMessaround/AsmMessaround.csproj) for an example if unsure.\
Then download AsmToDelegate and Iced.Intel from NuGet. At this point consider which format you plan on using, both will typically require `using static Iced.Intel.AssemblerRegisters;` and params format will require `using static AsmLib.Instructions;` as well as otherwise usage of registers and instructions will require prefacing with their respective type.\
Then you can finally use AddVariables and AddInstructions as shown in the examples above and the source generator will take care of almost everything else noting that AsmToDelegate only supports the [Microsoft x64 calling convention](https://learn.microsoft.com/en-us/cpp/build/x64-calling-convention?view=msvc-170) when this was written. At some point, there may be additional features shown in the testing library that can be used as well.

### Features and Weird Quirks

Some features require special care due to limitations of C# but this will hopefully get better over time.\
The first is register variables which must be defined before use as a variable of type AssemblerRegister64 and then assigned to a register inside of the AddVariables function as shown in the examples above. Note that currently the call to AddVariables only applies to connected AddInstructions calls and so you will have to reassign them if you want to use them again.\
Next is memory accesses which currently used the Iced syntax of __\[register\], optionally specifying the required size as for example __byte_ptr\[register\]. This will change in the future for string format assembly since it can support intel syntax indirect addressing. Note that it may be possible to use labels here as well but that is not been tested. See the Iced [source](https://github.com/icedland/iced/blob/24cb8f23aef84b193f7f80b2d27e1dcf3cb69319/src/csharp/Intel/Iced/Intel/Assembler/AssemblerRegisters2.g.cs) for a full list of sizes.\
Finally there are labels which are handled differently for both assembly formats. In params format, you must first define them using CreateLabel noting that the name must agree in both C# and asm for example `Label test = paramsAsm.CreateLabel("testl");`. Then within AddInstructions, use the AsmLib defined mnemonic `EmitLabel` followed by the variable to set the location of the label. Finally use the variable whenever you want to reference the location you set.\
When using string format, you do not need the Label variable and can instead just use `variablename:` to set the location for the label and then reference it in the same way. Note that both formats support using the label before its defintion, just like in regular assembly.

### Running assembly

The only thing left now is using AsmToDelegate to run the result, this can get slightly messy depending on what features are used. If just using conventional registers, variables to them, indirect addressing and labels then just call `ToFunctionPointerWinX64` on the Assembler object which takes in type parameters for each argument to the resulting function and then the return type. Note that since this returns a function pointer, it must be called within either an unsafe block or within an unsafe project.\
The exception to this is when you want to use pass vectors in to use with vector registers where you need to do quite a bit of setup currently. The first step is to get a pointer to each vector using `void* pVector = Unsafe.AsPointer(ref vector);`, then you have to wrap each pointer in an IntPtr using `IntPtr iVector = new IntPtr(pVector);`, finally set the parameter type in `ToFunctionPointerWinX64` as IntPtr. If you desire a vector result, it is recommended to do the above process for a zero vector as well and then move the result into it before returning. Then the result will appear in the original vector object in C# as well. Note that all of this will again require an unsafe block.

For more detail on getting each feature to work correctly, see the tests and the following links for complete examples for both the [params](https://github.com/JoshuaWierenga/BetterAsmGeneration/blob/91b82531ad9c153c40e514f4d32201e1b27edfa4/Tests/AsmMessaround/Program.cs) and [string](https://github.com/JoshuaWierenga/BetterAsmGeneration/blob/91b82531ad9c153c40e514f4d32201e1b27edfa4/Tests/AsmMessaround/Class1.cs) formats.
