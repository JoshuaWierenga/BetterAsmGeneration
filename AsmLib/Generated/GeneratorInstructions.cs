﻿namespace AsmLib;

internal static class GeneratorInstructions
{
    // This list allows AsmGenerator to check if a token is an instruction when given string format assembly
    // without having to use reflection to access full instructions list directly
    internal static string[] Instructions = {
        "invalid",
        "aaa",
        "aad",
        "aam",
        "aas",
        "adc",
        "adcx",
        "add",
        "addpd",
        "addps",
        "addsd",
        "addss",
        "addsubpd",
        "addsubps",
        "adox",
        "aesdec",
        "aesdeclast",
        "aesenc",
        "aesenclast",
        "aesimc",
        "aeskeygenassist",
        "and",
        "andn",
        "andnpd",
        "andnps",
        "andpd",
        "andps",
        "arpl",
        "bextr",
        "blcfill",
        "blci",
        "blcic",
        "blcmsk",
        "blcs",
        "blendpd",
        "blendps",
        "blendvpd",
        "blendvps",
        "blsfill",
        "blsi",
        "blsic",
        "blsmsk",
        "blsr",
        "bndcl",
        "bndcn",
        "bndcu",
        "bndldx",
        "bndmk",
        "bndmov",
        "bndstx",
        "bound",
        "bsf",
        "bsr",
        "bswap",
        "bt",
        "btc",
        "btr",
        "bts",
        "bzhi",
        "call",
        "cbw",
        "cdq",
        "cdqe",
        "cl1invmb",
        "clac",
        "clc",
        "cld",
        "cldemote",
        "clflush",
        "clflushopt",
        "clgi",
        "cli",
        "clrssbsy",
        "clts",
        "clwb",
        "clzero",
        "cmc",
        "cmova",
        "cmovae",
        "cmovb",
        "cmovbe",
        "cmove",
        "cmovg",
        "cmovge",
        "cmovl",
        "cmovle",
        "cmovne",
        "cmovno",
        "cmovnp",
        "cmovns",
        "cmovo",
        "cmovp",
        "cmovs",
        "cmp",
        "cmppd",
        "cmpps",
        "cmpsb",
        "cmpsd",
        "cmpsq",
        "cmpss",
        "cmpsw",
        "cmpxchg",
        "cmpxchg16b",
        "cmpxchg8b",
        "comisd",
        "comiss",
        "cpuid",
        "cqo",
        "crc32",
        "cvtdq2pd",
        "cvtdq2ps",
        "cvtpd2dq",
        "cvtpd2pi",
        "cvtpd2ps",
        "cvtpi2pd",
        "cvtpi2ps",
        "cvtps2dq",
        "cvtps2pd",
        "cvtps2pi",
        "cvtsd2si",
        "cvtsd2ss",
        "cvtsi2sd",
        "cvtsi2ss",
        "cvtss2sd",
        "cvtss2si",
        "cvttpd2dq",
        "cvttpd2pi",
        "cvttps2dq",
        "cvttps2pi",
        "cvttsd2si",
        "cvttss2si",
        "cwd",
        "cwde",
        "daa",
        "das",
        "db",
        "dd",
        "dec",
        "div",
        "divpd",
        "divps",
        "divsd",
        "divss",
        "dppd",
        "dpps",
        "dq",
        "dw",
        "emms",
        "encls",
        "enclu",
        "enclv",
        "endbr32",
        "endbr64",
        "enqcmd",
        "enqcmds",
        "enter",
        "extractps",
        "extrq",
        "f2xm1",
        "fabs",
        "fadd",
        "faddp",
        "fbld",
        "fbstp",
        "fchs",
        "fclex",
        "fcmovb",
        "fcmovbe",
        "fcmove",
        "fcmovnb",
        "fcmovnbe",
        "fcmovne",
        "fcmovnu",
        "fcmovu",
        "fcom",
        "fcomi",
        "fcomip",
        "fcomp",
        "fcompp",
        "fcos",
        "fdecstp",
        "fdisi",
        "fdiv",
        "fdivp",
        "fdivr",
        "fdivrp",
        "femms",
        "feni",
        "ffree",
        "ffreep",
        "fiadd",
        "ficom",
        "ficomp",
        "fidiv",
        "fidivr",
        "fild",
        "fimul",
        "fincstp",
        "finit",
        "fist",
        "fistp",
        "fisttp",
        "fisub",
        "fisubr",
        "fld",
        "fld1",
        "fldcw",
        "fldenv",
        "fldl2e",
        "fldl2t",
        "fldlg2",
        "fldln2",
        "fldpi",
        "fldz",
        "fmul",
        "fmulp",
        "fnclex",
        "fndisi",
        "fneni",
        "fninit",
        "fnop",
        "fnsave",
        "fnsetpm",
        "fnstcw",
        "fnstenv",
        "fnstsw",
        "fpatan",
        "fprem",
        "fprem1",
        "fptan",
        "frndint",
        "frstor",
        "frstpm",
        "fsave",
        "fscale",
        "fsetpm",
        "fsin",
        "fsincos",
        "fsqrt",
        "fst",
        "fstcw",
        "fstdw",
        "fstenv",
        "fstp",
        "fstpnce",
        "fstsg",
        "fstsw",
        "fsub",
        "fsubp",
        "fsubr",
        "fsubrp",
        "ftst",
        "fucom",
        "fucomi",
        "fucomip",
        "fucomp",
        "fucompp",
        "fxam",
        "fxch",
        "fxrstor",
        "fxrstor64",
        "fxsave",
        "fxsave64",
        "fxtract",
        "fyl2x",
        "fyl2xp1",
        "getsec",
        "gf2p8affineinvqb",
        "gf2p8affineqb",
        "gf2p8mulb",
        "haddpd",
        "haddps",
        "hlt",
        "hsubpd",
        "hsubps",
        "ibts",
        "idiv",
        "imul",
        "@in",
        "inc",
        "incsspd",
        "incsspq",
        "insb",
        "insd",
        "insertps",
        "insertq",
        "insw",
        "@int",
        "int1",
        "into",
        "invd",
        "invept",
        "invlpg",
        "invlpga",
        "invpcid",
        "invvpid",
        "iret",
        "ja",
        "jae",
        "jb",
        "jbe",
        "jcxz",
        "je",
        "jecxz",
        "jg",
        "jge",
        "jl",
        "jle",
        "jmp",
        "jmpe",
        "jne",
        "jno",
        "jnp",
        "jns",
        "jo",
        "jp",
        "jrcxz",
        "js",
        "kaddb",
        "kaddd",
        "kaddq",
        "kaddw",
        "kandb",
        "kandd",
        "kandnb",
        "kandnd",
        "kandnq",
        "kandnw",
        "kandq",
        "kandw",
        "kmovb",
        "kmovd",
        "kmovq",
        "kmovw",
        "knotb",
        "knotd",
        "knotq",
        "knotw",
        "korb",
        "kord",
        "korq",
        "kortestb",
        "kortestd",
        "kortestq",
        "kortestw",
        "korw",
        "kshiftlb",
        "kshiftld",
        "kshiftlq",
        "kshiftlw",
        "kshiftrb",
        "kshiftrd",
        "kshiftrq",
        "kshiftrw",
        "ktestb",
        "ktestd",
        "ktestq",
        "ktestw",
        "kunpckbw",
        "kunpckdq",
        "kunpckwd",
        "kxnorb",
        "kxnord",
        "kxnorq",
        "kxnorw",
        "kxorb",
        "kxord",
        "kxorq",
        "kxorw",
        "lahf",
        "lar",
        "lddqu",
        "ldmxcsr",
        "lds",
        "lea",
        "leave",
        "les",
        "lfence",
        "lfs",
        "lgdt",
        "lgs",
        "lidt",
        "lldt",
        "llwpcb",
        "lmsw",
        "loadall",
        "lodsb",
        "lodsd",
        "lodsq",
        "lodsw",
        "loop",
        "loope",
        "loopne",
        "lsl",
        "lss",
        "ltr",
        "lwpins",
        "lwpval",
        "lzcnt",
        "maskmovdqu",
        "maskmovq",
        "maxpd",
        "maxps",
        "maxsd",
        "maxss",
        "mcommit",
        "mfence",
        "minpd",
        "minps",
        "minsd",
        "minss",
        "monitor",
        "monitorx",
        "montmul",
        "mov",
        "movapd",
        "movaps",
        "movbe",
        "movd",
        "movddup",
        "movdir64b",
        "movdiri",
        "movdq2q",
        "movdqa",
        "movdqu",
        "movhlps",
        "movhpd",
        "movhps",
        "movlhps",
        "movlpd",
        "movlps",
        "movmskpd",
        "movmskps",
        "movntdq",
        "movntdqa",
        "movnti",
        "movntpd",
        "movntps",
        "movntq",
        "movntsd",
        "movntss",
        "movq",
        "movq2dq",
        "movsb",
        "movsd",
        "movshdup",
        "movsldup",
        "movsq",
        "movss",
        "movsw",
        "movsx",
        "movsxd",
        "movupd",
        "movups",
        "movzx",
        "mpsadbw",
        "mul",
        "mulpd",
        "mulps",
        "mulsd",
        "mulss",
        "mulx",
        "mwait",
        "mwaitx",
        "neg",
        "nop",
        "not",
        "or",
        "orpd",
        "orps",
        "@out",
        "outsb",
        "outsd",
        "outsw",
        "pabsb",
        "pabsd",
        "pabsw",
        "packssdw",
        "packsswb",
        "packusdw",
        "packuswb",
        "paddb",
        "paddd",
        "paddq",
        "paddsb",
        "paddsw",
        "paddusb",
        "paddusw",
        "paddw",
        "palignr",
        "pand",
        "pandn",
        "pause",
        "pavgb",
        "pavgusb",
        "pavgw",
        "pblendvb",
        "pblendw",
        "pclmulqdq",
        "pcmpeqb",
        "pcmpeqd",
        "pcmpeqq",
        "pcmpeqw",
        "pcmpestri",
        "pcmpestri64",
        "pcmpestrm",
        "pcmpestrm64",
        "pcmpgtb",
        "pcmpgtd",
        "pcmpgtq",
        "pcmpgtw",
        "pcmpistri",
        "pcmpistrm",
        "pcommit",
        "pconfig",
        "pdep",
        "pext",
        "pextrb",
        "pextrd",
        "pextrq",
        "pextrw",
        "pf2id",
        "pf2iw",
        "pfacc",
        "pfadd",
        "pfcmpeq",
        "pfcmpge",
        "pfcmpgt",
        "pfmax",
        "pfmin",
        "pfmul",
        "pfnacc",
        "pfpnacc",
        "pfrcp",
        "pfrcpit1",
        "pfrcpit2",
        "pfrcpv",
        "pfrsqit1",
        "pfrsqrt",
        "pfrsqrtv",
        "pfsub",
        "pfsubr",
        "phaddd",
        "phaddsw",
        "phaddw",
        "phminposuw",
        "phsubd",
        "phsubsw",
        "phsubw",
        "pi2fd",
        "pi2fw",
        "pinsrb",
        "pinsrd",
        "pinsrq",
        "pinsrw",
        "pmaddubsw",
        "pmaddwd",
        "pmaxsb",
        "pmaxsd",
        "pmaxsw",
        "pmaxub",
        "pmaxud",
        "pmaxuw",
        "pminsb",
        "pminsd",
        "pminsw",
        "pminub",
        "pminud",
        "pminuw",
        "pmovmskb",
        "pmovsxbd",
        "pmovsxbq",
        "pmovsxbw",
        "pmovsxdq",
        "pmovsxwd",
        "pmovsxwq",
        "pmovzxbd",
        "pmovzxbq",
        "pmovzxbw",
        "pmovzxdq",
        "pmovzxwd",
        "pmovzxwq",
        "pmuldq",
        "pmulhrsw",
        "pmulhrw",
        "pmulhuw",
        "pmulhw",
        "pmulld",
        "pmullw",
        "pmuludq",
        "pop",
        "popa",
        "popcnt",
        "popf",
        "por",
        "prefetch",
        "prefetchnta",
        "prefetcht0",
        "prefetcht1",
        "prefetcht2",
        "prefetchw",
        "prefetchwt1",
        "psadbw",
        "pshufb",
        "pshufd",
        "pshufhw",
        "pshuflw",
        "pshufw",
        "psignb",
        "psignd",
        "psignw",
        "pslld",
        "pslldq",
        "psllq",
        "psllw",
        "psrad",
        "psraw",
        "psrld",
        "psrldq",
        "psrlq",
        "psrlw",
        "psubb",
        "psubd",
        "psubq",
        "psubsb",
        "psubsw",
        "psubusb",
        "psubusw",
        "psubw",
        "pswapd",
        "ptest",
        "ptwrite",
        "punpckhbw",
        "punpckhdq",
        "punpckhqdq",
        "punpckhwd",
        "punpcklbw",
        "punpckldq",
        "punpcklqdq",
        "punpcklwd",
        "push",
        "pusha",
        "pushf",
        "pxor",
        "rcl",
        "rcpps",
        "rcpss",
        "rcr",
        "rdfsbase",
        "rdgsbase",
        "rdmsr",
        "rdpid",
        "rdpkru",
        "rdpmc",
        "rdpru",
        "rdrand",
        "rdseed",
        "rdsspd",
        "rdsspq",
        "rdtsc",
        "rdtscp",
        "reservednop",
        "ret",
        "retf",
        "rol",
        "ror",
        "rorx",
        "roundpd",
        "roundps",
        "roundsd",
        "roundss",
        "rsm",
        "rsqrtps",
        "rsqrtss",
        "rstorssp",
        "sahf",
        "sal",
        "salc",
        "sar",
        "sarx",
        "saveprevssp",
        "sbb",
        "scasb",
        "scasd",
        "scasq",
        "scasw",
        "seta",
        "setae",
        "setb",
        "setbe",
        "sete",
        "setg",
        "setge",
        "setl",
        "setle",
        "setne",
        "setno",
        "setnp",
        "setns",
        "seto",
        "setp",
        "sets",
        "setssbsy",
        "sfence",
        "sgdt",
        "sha1msg1",
        "sha1msg2",
        "sha1nexte",
        "sha1rnds4",
        "sha256msg1",
        "sha256msg2",
        "sha256rnds2",
        "shl",
        "shld",
        "shlx",
        "shr",
        "shrd",
        "shrx",
        "shufpd",
        "shufps",
        "sidt",
        "skinit",
        "sldt",
        "slwpcb",
        "smsw",
        "sqrtpd",
        "sqrtps",
        "sqrtsd",
        "sqrtss",
        "stac",
        "stc",
        "std",
        "stgi",
        "sti",
        "stmxcsr",
        "stosb",
        "stosd",
        "stosq",
        "stosw",
        "str",
        "sub",
        "subpd",
        "subps",
        "subsd",
        "subss",
        "swapgs",
        "syscall",
        "sysenter",
        "sysexit",
        "sysret",
        "t1mskc",
        "test",
        "tpause",
        "tzcnt",
        "tzmsk",
        "ucomisd",
        "ucomiss",
        "ud0",
        "ud1",
        "ud2",
        "umonitor",
        "umov",
        "umwait",
        "unpckhpd",
        "unpckhps",
        "unpcklpd",
        "unpcklps",
        "v4fmaddps",
        "v4fmaddss",
        "v4fnmaddps",
        "v4fnmaddss",
        "vaddpd",
        "vaddps",
        "vaddsd",
        "vaddss",
        "vaddsubpd",
        "vaddsubps",
        "vaesdec",
        "vaesdeclast",
        "vaesenc",
        "vaesenclast",
        "vaesimc",
        "vaeskeygenassist",
        "valignd",
        "valignq",
        "vandnpd",
        "vandnps",
        "vandpd",
        "vandps",
        "vblendmpd",
        "vblendmps",
        "vblendpd",
        "vblendps",
        "vblendvpd",
        "vblendvps",
        "vbroadcastf128",
        "vbroadcastf32x2",
        "vbroadcastf32x4",
        "vbroadcastf32x8",
        "vbroadcastf64x2",
        "vbroadcastf64x4",
        "vbroadcasti128",
        "vbroadcasti32x2",
        "vbroadcasti32x4",
        "vbroadcasti32x8",
        "vbroadcasti64x2",
        "vbroadcasti64x4",
        "vbroadcastsd",
        "vbroadcastss",
        "vcmppd",
        "vcmpps",
        "vcmpsd",
        "vcmpss",
        "vcomisd",
        "vcomiss",
        "vcompresspd",
        "vcompressps",
        "vcvtdq2pd",
        "vcvtdq2ps",
        "vcvtne2ps2bf16",
        "vcvtneps2bf16",
        "vcvtpd2dq",
        "vcvtpd2ps",
        "vcvtpd2qq",
        "vcvtpd2udq",
        "vcvtpd2uqq",
        "vcvtph2ps",
        "vcvtps2dq",
        "vcvtps2pd",
        "vcvtps2ph",
        "vcvtps2qq",
        "vcvtps2udq",
        "vcvtps2uqq",
        "vcvtqq2pd",
        "vcvtqq2ps",
        "vcvtsd2si",
        "vcvtsd2ss",
        "vcvtsd2usi",
        "vcvtsi2sd",
        "vcvtsi2ss",
        "vcvtss2sd",
        "vcvtss2si",
        "vcvtss2usi",
        "vcvttpd2dq",
        "vcvttpd2qq",
        "vcvttpd2udq",
        "vcvttpd2uqq",
        "vcvttps2dq",
        "vcvttps2qq",
        "vcvttps2udq",
        "vcvttps2uqq",
        "vcvttsd2si",
        "vcvttsd2usi",
        "vcvttss2si",
        "vcvttss2usi",
        "vcvtudq2pd",
        "vcvtudq2ps",
        "vcvtuqq2pd",
        "vcvtuqq2ps",
        "vcvtusi2sd",
        "vcvtusi2ss",
        "vdbpsadbw",
        "vdivpd",
        "vdivps",
        "vdivsd",
        "vdivss",
        "vdpbf16ps",
        "vdppd",
        "vdpps",
        "verr",
        "verw",
        "vexp2pd",
        "vexp2ps",
        "vexpandpd",
        "vexpandps",
        "vextractf128",
        "vextractf32x4",
        "vextractf32x8",
        "vextractf64x2",
        "vextractf64x4",
        "vextracti128",
        "vextracti32x4",
        "vextracti32x8",
        "vextracti64x2",
        "vextracti64x4",
        "vextractps",
        "vfixupimmpd",
        "vfixupimmps",
        "vfixupimmsd",
        "vfixupimmss",
        "vfmadd132pd",
        "vfmadd132ps",
        "vfmadd132sd",
        "vfmadd132ss",
        "vfmadd213pd",
        "vfmadd213ps",
        "vfmadd213sd",
        "vfmadd213ss",
        "vfmadd231pd",
        "vfmadd231ps",
        "vfmadd231sd",
        "vfmadd231ss",
        "vfmaddpd",
        "vfmaddps",
        "vfmaddsd",
        "vfmaddss",
        "vfmaddsub132pd",
        "vfmaddsub132ps",
        "vfmaddsub213pd",
        "vfmaddsub213ps",
        "vfmaddsub231pd",
        "vfmaddsub231ps",
        "vfmaddsubpd",
        "vfmaddsubps",
        "vfmsub132pd",
        "vfmsub132ps",
        "vfmsub132sd",
        "vfmsub132ss",
        "vfmsub213pd",
        "vfmsub213ps",
        "vfmsub213sd",
        "vfmsub213ss",
        "vfmsub231pd",
        "vfmsub231ps",
        "vfmsub231sd",
        "vfmsub231ss",
        "vfmsubadd132pd",
        "vfmsubadd132ps",
        "vfmsubadd213pd",
        "vfmsubadd213ps",
        "vfmsubadd231pd",
        "vfmsubadd231ps",
        "vfmsubaddpd",
        "vfmsubaddps",
        "vfmsubpd",
        "vfmsubps",
        "vfmsubsd",
        "vfmsubss",
        "vfnmadd132pd",
        "vfnmadd132ps",
        "vfnmadd132sd",
        "vfnmadd132ss",
        "vfnmadd213pd",
        "vfnmadd213ps",
        "vfnmadd213sd",
        "vfnmadd213ss",
        "vfnmadd231pd",
        "vfnmadd231ps",
        "vfnmadd231sd",
        "vfnmadd231ss",
        "vfnmaddpd",
        "vfnmaddps",
        "vfnmaddsd",
        "vfnmaddss",
        "vfnmsub132pd",
        "vfnmsub132ps",
        "vfnmsub132sd",
        "vfnmsub132ss",
        "vfnmsub213pd",
        "vfnmsub213ps",
        "vfnmsub213sd",
        "vfnmsub213ss",
        "vfnmsub231pd",
        "vfnmsub231ps",
        "vfnmsub231sd",
        "vfnmsub231ss",
        "vfnmsubpd",
        "vfnmsubps",
        "vfnmsubsd",
        "vfnmsubss",
        "vfpclasspd",
        "vfpclassps",
        "vfpclasssd",
        "vfpclassss",
        "vfrczpd",
        "vfrczps",
        "vfrczsd",
        "vfrczss",
        "vgatherdpd",
        "vgatherdps",
        "vgatherpf0dpd",
        "vgatherpf0dps",
        "vgatherpf0qpd",
        "vgatherpf0qps",
        "vgatherpf1dpd",
        "vgatherpf1dps",
        "vgatherpf1qpd",
        "vgatherpf1qps",
        "vgatherqpd",
        "vgatherqps",
        "vgetexppd",
        "vgetexpps",
        "vgetexpsd",
        "vgetexpss",
        "vgetmantpd",
        "vgetmantps",
        "vgetmantsd",
        "vgetmantss",
        "vgf2p8affineinvqb",
        "vgf2p8affineqb",
        "vgf2p8mulb",
        "vhaddpd",
        "vhaddps",
        "vhsubpd",
        "vhsubps",
        "vinsertf128",
        "vinsertf32x4",
        "vinsertf32x8",
        "vinsertf64x2",
        "vinsertf64x4",
        "vinserti128",
        "vinserti32x4",
        "vinserti32x8",
        "vinserti64x2",
        "vinserti64x4",
        "vinsertps",
        "vlddqu",
        "vldmxcsr",
        "vmaskmovdqu",
        "vmaskmovpd",
        "vmaskmovps",
        "vmaxpd",
        "vmaxps",
        "vmaxsd",
        "vmaxss",
        "vmcall",
        "vmclear",
        "vmfunc",
        "vminpd",
        "vminps",
        "vminsd",
        "vminss",
        "vmlaunch",
        "vmload",
        "vmmcall",
        "vmovapd",
        "vmovaps",
        "vmovd",
        "vmovddup",
        "vmovdqa",
        "vmovdqa32",
        "vmovdqa64",
        "vmovdqu",
        "vmovdqu16",
        "vmovdqu32",
        "vmovdqu64",
        "vmovdqu8",
        "vmovhlps",
        "vmovhpd",
        "vmovhps",
        "vmovlhps",
        "vmovlpd",
        "vmovlps",
        "vmovmskpd",
        "vmovmskps",
        "vmovntdq",
        "vmovntdqa",
        "vmovntpd",
        "vmovntps",
        "vmovq",
        "vmovsd",
        "vmovshdup",
        "vmovsldup",
        "vmovss",
        "vmovupd",
        "vmovups",
        "vmpsadbw",
        "vmptrld",
        "vmptrst",
        "vmread",
        "vmresume",
        "vmrun",
        "vmsave",
        "vmulpd",
        "vmulps",
        "vmulsd",
        "vmulss",
        "vmwrite",
        "vmxoff",
        "vmxon",
        "vorpd",
        "vorps",
        "vp2intersectd",
        "vp2intersectq",
        "vp4dpwssd",
        "vp4dpwssds",
        "vpabsb",
        "vpabsd",
        "vpabsq",
        "vpabsw",
        "vpackssdw",
        "vpacksswb",
        "vpackusdw",
        "vpackuswb",
        "vpaddb",
        "vpaddd",
        "vpaddq",
        "vpaddsb",
        "vpaddsw",
        "vpaddusb",
        "vpaddusw",
        "vpaddw",
        "vpalignr",
        "vpand",
        "vpandd",
        "vpandn",
        "vpandnd",
        "vpandnq",
        "vpandq",
        "vpavgb",
        "vpavgw",
        "vpblendd",
        "vpblendmb",
        "vpblendmd",
        "vpblendmq",
        "vpblendmw",
        "vpblendvb",
        "vpblendw",
        "vpbroadcastb",
        "vpbroadcastd",
        "vpbroadcastmb2q",
        "vpbroadcastmw2d",
        "vpbroadcastq",
        "vpbroadcastw",
        "vpclmulqdq",
        "vpcmov",
        "vpcmpb",
        "vpcmpd",
        "vpcmpeqb",
        "vpcmpeqd",
        "vpcmpeqq",
        "vpcmpeqw",
        "vpcmpestri",
        "vpcmpestri64",
        "vpcmpestrm",
        "vpcmpestrm64",
        "vpcmpgtb",
        "vpcmpgtd",
        "vpcmpgtq",
        "vpcmpgtw",
        "vpcmpistri",
        "vpcmpistrm",
        "vpcmpq",
        "vpcmpub",
        "vpcmpud",
        "vpcmpuq",
        "vpcmpuw",
        "vpcmpw",
        "vpcomb",
        "vpcomd",
        "vpcompressb",
        "vpcompressd",
        "vpcompressq",
        "vpcompressw",
        "vpcomq",
        "vpcomub",
        "vpcomud",
        "vpcomuq",
        "vpcomuw",
        "vpcomw",
        "vpconflictd",
        "vpconflictq",
        "vpdpbusd",
        "vpdpbusds",
        "vpdpwssd",
        "vpdpwssds",
        "vperm2f128",
        "vperm2i128",
        "vpermb",
        "vpermd",
        "vpermi2b",
        "vpermi2d",
        "vpermi2pd",
        "vpermi2ps",
        "vpermi2q",
        "vpermi2w",
        "vpermil2pd",
        "vpermil2ps",
        "vpermilpd",
        "vpermilps",
        "vpermpd",
        "vpermps",
        "vpermq",
        "vpermt2b",
        "vpermt2d",
        "vpermt2pd",
        "vpermt2ps",
        "vpermt2q",
        "vpermt2w",
        "vpermw",
        "vpexpandb",
        "vpexpandd",
        "vpexpandq",
        "vpexpandw",
        "vpextrb",
        "vpextrd",
        "vpextrq",
        "vpextrw",
        "vpgatherdd",
        "vpgatherdq",
        "vpgatherqd",
        "vpgatherqq",
        "vphaddbd",
        "vphaddbq",
        "vphaddbw",
        "vphaddd",
        "vphadddq",
        "vphaddsw",
        "vphaddubd",
        "vphaddubq",
        "vphaddubw",
        "vphaddudq",
        "vphadduwd",
        "vphadduwq",
        "vphaddw",
        "vphaddwd",
        "vphaddwq",
        "vphminposuw",
        "vphsubbw",
        "vphsubd",
        "vphsubdq",
        "vphsubsw",
        "vphsubw",
        "vphsubwd",
        "vpinsrb",
        "vpinsrd",
        "vpinsrq",
        "vpinsrw",
        "vplzcntd",
        "vplzcntq",
        "vpmacsdd",
        "vpmacsdqh",
        "vpmacsdql",
        "vpmacssdd",
        "vpmacssdqh",
        "vpmacssdql",
        "vpmacsswd",
        "vpmacssww",
        "vpmacswd",
        "vpmacsww",
        "vpmadcsswd",
        "vpmadcswd",
        "vpmadd52huq",
        "vpmadd52luq",
        "vpmaddubsw",
        "vpmaddwd",
        "vpmaskmovd",
        "vpmaskmovq",
        "vpmaxsb",
        "vpmaxsd",
        "vpmaxsq",
        "vpmaxsw",
        "vpmaxub",
        "vpmaxud",
        "vpmaxuq",
        "vpmaxuw",
        "vpminsb",
        "vpminsd",
        "vpminsq",
        "vpminsw",
        "vpminub",
        "vpminud",
        "vpminuq",
        "vpminuw",
        "vpmovb2m",
        "vpmovd2m",
        "vpmovdb",
        "vpmovdw",
        "vpmovm2b",
        "vpmovm2d",
        "vpmovm2q",
        "vpmovm2w",
        "vpmovmskb",
        "vpmovq2m",
        "vpmovqb",
        "vpmovqd",
        "vpmovqw",
        "vpmovsdb",
        "vpmovsdw",
        "vpmovsqb",
        "vpmovsqd",
        "vpmovsqw",
        "vpmovswb",
        "vpmovsxbd",
        "vpmovsxbq",
        "vpmovsxbw",
        "vpmovsxdq",
        "vpmovsxwd",
        "vpmovsxwq",
        "vpmovusdb",
        "vpmovusdw",
        "vpmovusqb",
        "vpmovusqd",
        "vpmovusqw",
        "vpmovuswb",
        "vpmovw2m",
        "vpmovwb",
        "vpmovzxbd",
        "vpmovzxbq",
        "vpmovzxbw",
        "vpmovzxdq",
        "vpmovzxwd",
        "vpmovzxwq",
        "vpmuldq",
        "vpmulhrsw",
        "vpmulhuw",
        "vpmulhw",
        "vpmulld",
        "vpmullq",
        "vpmullw",
        "vpmultishiftqb",
        "vpmuludq",
        "vpopcntb",
        "vpopcntd",
        "vpopcntq",
        "vpopcntw",
        "vpor",
        "vpord",
        "vporq",
        "vpperm",
        "vprold",
        "vprolq",
        "vprolvd",
        "vprolvq",
        "vprord",
        "vprorq",
        "vprorvd",
        "vprorvq",
        "vprotb",
        "vprotd",
        "vprotq",
        "vprotw",
        "vpsadbw",
        "vpscatterdd",
        "vpscatterdq",
        "vpscatterqd",
        "vpscatterqq",
        "vpshab",
        "vpshad",
        "vpshaq",
        "vpshaw",
        "vpshlb",
        "vpshld",
        "vpshldd",
        "vpshldq",
        "vpshldvd",
        "vpshldvq",
        "vpshldvw",
        "vpshldw",
        "vpshlq",
        "vpshlw",
        "vpshrdd",
        "vpshrdq",
        "vpshrdvd",
        "vpshrdvq",
        "vpshrdvw",
        "vpshrdw",
        "vpshufb",
        "vpshufbitqmb",
        "vpshufd",
        "vpshufhw",
        "vpshuflw",
        "vpsignb",
        "vpsignd",
        "vpsignw",
        "vpslld",
        "vpslldq",
        "vpsllq",
        "vpsllvd",
        "vpsllvq",
        "vpsllvw",
        "vpsllw",
        "vpsrad",
        "vpsraq",
        "vpsravd",
        "vpsravq",
        "vpsravw",
        "vpsraw",
        "vpsrld",
        "vpsrldq",
        "vpsrlq",
        "vpsrlvd",
        "vpsrlvq",
        "vpsrlvw",
        "vpsrlw",
        "vpsubb",
        "vpsubd",
        "vpsubq",
        "vpsubsb",
        "vpsubsw",
        "vpsubusb",
        "vpsubusw",
        "vpsubw",
        "vpternlogd",
        "vpternlogq",
        "vptest",
        "vptestmb",
        "vptestmd",
        "vptestmq",
        "vptestmw",
        "vptestnmb",
        "vptestnmd",
        "vptestnmq",
        "vptestnmw",
        "vpunpckhbw",
        "vpunpckhdq",
        "vpunpckhqdq",
        "vpunpckhwd",
        "vpunpcklbw",
        "vpunpckldq",
        "vpunpcklqdq",
        "vpunpcklwd",
        "vpxor",
        "vpxord",
        "vpxorq",
        "vrangepd",
        "vrangeps",
        "vrangesd",
        "vrangess",
        "vrcp14pd",
        "vrcp14ps",
        "vrcp14sd",
        "vrcp14ss",
        "vrcp28pd",
        "vrcp28ps",
        "vrcp28sd",
        "vrcp28ss",
        "vrcpps",
        "vrcpss",
        "vreducepd",
        "vreduceps",
        "vreducesd",
        "vreducess",
        "vrndscalepd",
        "vrndscaleps",
        "vrndscalesd",
        "vrndscaless",
        "vroundpd",
        "vroundps",
        "vroundsd",
        "vroundss",
        "vrsqrt14pd",
        "vrsqrt14ps",
        "vrsqrt14sd",
        "vrsqrt14ss",
        "vrsqrt28pd",
        "vrsqrt28ps",
        "vrsqrt28sd",
        "vrsqrt28ss",
        "vrsqrtps",
        "vrsqrtss",
        "vscalefpd",
        "vscalefps",
        "vscalefsd",
        "vscalefss",
        "vscatterdpd",
        "vscatterdps",
        "vscatterpf0dpd",
        "vscatterpf0dps",
        "vscatterpf0qpd",
        "vscatterpf0qps",
        "vscatterpf1dpd",
        "vscatterpf1dps",
        "vscatterpf1qpd",
        "vscatterpf1qps",
        "vscatterqpd",
        "vscatterqps",
        "vshuff32x4",
        "vshuff64x2",
        "vshufi32x4",
        "vshufi64x2",
        "vshufpd",
        "vshufps",
        "vsqrtpd",
        "vsqrtps",
        "vsqrtsd",
        "vsqrtss",
        "vstmxcsr",
        "vsubpd",
        "vsubps",
        "vsubsd",
        "vsubss",
        "vtestpd",
        "vtestps",
        "vucomisd",
        "vucomiss",
        "vunpckhpd",
        "vunpckhps",
        "vunpcklpd",
        "vunpcklps",
        "vxorpd",
        "vxorps",
        "vzeroall",
        "vzeroupper",
        "wait",
        "wbinvd",
        "wbnoinvd",
        "wrfsbase",
        "wrgsbase",
        "wrmsr",
        "wrpkru",
        "wrssd",
        "wrssq",
        "wrussd",
        "wrussq",
        "xabort",
        "xadd",
        "xbegin",
        "xbts",
        "xchg",
        "xcryptcbc",
        "xcryptcfb",
        "xcryptctr",
        "xcryptecb",
        "xcryptofb",
        "xend",
        "xgetbv",
        "xlatb",
        "xor",
        "xorpd",
        "xorps",
        "xrstor",
        "xrstor64",
        "xrstors",
        "xrstors64",
        "xsave",
        "xsave64",
        "xsavec",
        "xsavec64",
        "xsaveopt",
        "xsaveopt64",
        "xsaves",
        "xsaves64",
        "xsetbv",
        "xsha1",
        "xsha256",
        "xstore",
        "xtest",
        "rmpadjust",
        "rmpupdate",
        "psmash",
        "pvalidate",
        "serialize",
        "xsusldtrk",
        "xresldtrk",
        "invlpgb",
        "tlbsync",
        "vmgexit",
        "getsecq",
        "sysexitq",
        "ldtilecfg",
        "tilerelease",
        "sttilecfg",
        "tilezero",
        "tileloaddt1",
        "tilestored",
        "tileloadd",
        "tdpbf16ps",
        "tdpbuud",
        "tdpbusd",
        "tdpbsud",
        "tdpbssd",
        "sysretq",
        "fnstdw",
        "fnstsg",
        "rdshr",
        "wrshr",
        "smint",
        "dmint",
        "rdm",
        "svdc",
        "rsdc",
        "svldt",
        "rsldt",
        "svts",
        "rsts",
        "bb0_reset",
        "bb1_reset",
        "cpu_write",
        "cpu_read",
        "altinst",
        "paveb",
        "paddsiw",
        "pmagw",
        "pdistib",
        "psubsiw",
        "pmvzb",
        "pmvnzb",
        "pmvlzb",
        "pmvgezb",
        "pmulhriw",
        "pmachriw",
        "ftstp",
        "frint2",
        "frichop",
        "frinear",
        "undoc",
        "tdcall",
        "seamret",
        "seamops",
        "seamcall",
        "aesencwide128kl",
        "aesdecwide128kl",
        "aesencwide256kl",
        "aesdecwide256kl",
        "loadiwkey",
        "aesenc128kl",
        "aesdec128kl",
        "aesenc256kl",
        "aesdec256kl",
        "encodekey128",
        "encodekey256",
        "pushad",
        "popad",
        "pushfd",
        "pushfq",
        "popfd",
        "popfq",
        "iretd",
        "iretq",
        "int3",
        "uiret",
        "testui",
        "clui",
        "stui",
        "senduipi",
        "hreset",
        "ccs_hash",
        "ccs_encrypt",
        "lkgs",
        "eretu",
        "erets",
        "storeall",
        "vaddph",
        "vaddsh",
        "vcmpph",
        "vcmpsh",
        "vcomish",
        "vcvtdq2ph",
        "vcvtpd2ph",
        "vcvtph2dq",
        "vcvtph2pd",
        "vcvtph2psx",
        "vcvtph2qq",
        "vcvtph2udq",
        "vcvtph2uqq",
        "vcvtph2uw",
        "vcvtph2w",
        "vcvtps2phx",
        "vcvtqq2ph",
        "vcvtsd2sh",
        "vcvtsh2sd",
        "vcvtsh2si",
        "vcvtsh2ss",
        "vcvtsh2usi",
        "vcvtsi2sh",
        "vcvtss2sh",
        "vcvttph2dq",
        "vcvttph2qq",
        "vcvttph2udq",
        "vcvttph2uqq",
        "vcvttph2uw",
        "vcvttph2w",
        "vcvttsh2si",
        "vcvttsh2usi",
        "vcvtudq2ph",
        "vcvtuqq2ph",
        "vcvtusi2sh",
        "vcvtuw2ph",
        "vcvtw2ph",
        "vdivph",
        "vdivsh",
        "vfcmaddcph",
        "vfmaddcph",
        "vfcmaddcsh",
        "vfmaddcsh",
        "vfcmulcph",
        "vfmulcph",
        "vfcmulcsh",
        "vfmulcsh",
        "vfmaddsub132ph",
        "vfmaddsub213ph",
        "vfmaddsub231ph",
        "vfmsubadd132ph",
        "vfmsubadd213ph",
        "vfmsubadd231ph",
        "vfmadd132ph",
        "vfmadd213ph",
        "vfmadd231ph",
        "vfnmadd132ph",
        "vfnmadd213ph",
        "vfnmadd231ph",
        "vfmadd132sh",
        "vfmadd213sh",
        "vfmadd231sh",
        "vfnmadd132sh",
        "vfnmadd213sh",
        "vfnmadd231sh",
        "vfmsub132ph",
        "vfmsub213ph",
        "vfmsub231ph",
        "vfnmsub132ph",
        "vfnmsub213ph",
        "vfnmsub231ph",
        "vfmsub132sh",
        "vfmsub213sh",
        "vfmsub231sh",
        "vfnmsub132sh",
        "vfnmsub213sh",
        "vfnmsub231sh",
        "vfpclassph",
        "vfpclasssh",
        "vgetexpph",
        "vgetexpsh",
        "vgetmantph",
        "vgetmantsh",
        "vmaxph",
        "vmaxsh",
        "vminph",
        "vminsh",
        "vmovsh",
        "vmovw",
        "vmulph",
        "vmulsh",
        "vrcpph",
        "vrcpsh",
        "vreduceph",
        "vreducesh",
        "vrndscaleph",
        "vrndscalesh",
        "vrsqrtph",
        "vrsqrtsh",
        "vscalefph",
        "vscalefsh",
        "vsqrtph",
        "vsqrtsh",
        "vsubph",
        "vsubsh",
        "vucomish",
        "rdudbg",
        "wrudbg",
        "clevict0",
        "clevict1",
        "delay",
        "jknzd",
        "jkzd",
        "kand",
        "kandn",
        "kandnr",
        "kconcath",
        "kconcatl",
        "kextract",
        "kmerge2l1h",
        "kmerge2l1l",
        "kmov",
        "knot",
        "kor",
        "kortest",
        "kxnor",
        "kxor",
        "spflt",
        "tzcnti",
        "vaddnpd",
        "vaddnps",
        "vaddsetsps",
        "vcvtfxpntdq2ps",
        "vcvtfxpntpd2dq",
        "vcvtfxpntpd2udq",
        "vcvtfxpntps2dq",
        "vcvtfxpntps2udq",
        "vcvtfxpntudq2ps",
        "vexp223ps",
        "vfixupnanpd",
        "vfixupnanps",
        "vfmadd233ps",
        "vgatherpf0hintdpd",
        "vgatherpf0hintdps",
        "vgmaxabsps",
        "vgmaxpd",
        "vgmaxps",
        "vgminpd",
        "vgminps",
        "vloadunpackhd",
        "vloadunpackhpd",
        "vloadunpackhps",
        "vloadunpackhq",
        "vloadunpackld",
        "vloadunpacklpd",
        "vloadunpacklps",
        "vloadunpacklq",
        "vlog2ps",
        "vmovnrapd",
        "vmovnraps",
        "vmovnrngoapd",
        "vmovnrngoaps",
        "vpackstorehd",
        "vpackstorehpd",
        "vpackstorehps",
        "vpackstorehq",
        "vpackstoreld",
        "vpackstorelpd",
        "vpackstorelps",
        "vpackstorelq",
        "vpadcd",
        "vpaddsetcd",
        "vpaddsetsd",
        "vpcmpltd",
        "vpermf32x4",
        "vpmadd231d",
        "vpmadd233d",
        "vpmulhd",
        "vpmulhud",
        "vprefetch0",
        "vprefetch1",
        "vprefetch2",
        "vprefetche0",
        "vprefetche1",
        "vprefetche2",
        "vprefetchenta",
        "vprefetchnta",
        "vpsbbd",
        "vpsbbrd",
        "vpsubrd",
        "vpsubrsetbd",
        "vpsubsetbd",
        "vrcp23ps",
        "vrndfxpntpd",
        "vrndfxpntps",
        "vrsqrt23ps",
        "vscaleps",
        "vscatterpf0hintdpd",
        "vscatterpf0hintdps",
        "vsubrpd",
        "vsubrps",
        "xsha512",
        "xstore_alt",
        "xsha512_alt",
        "zero_bytes",
    };
}