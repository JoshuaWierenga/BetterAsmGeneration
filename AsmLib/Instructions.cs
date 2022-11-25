using Iced.Intel;

namespace AsmLib;

public static class Instructions
{
    public static readonly Instruction invalid = new (Mnemonic.INVALID);

    public static readonly Instruction aaa = new (Mnemonic.Aaa);

    public static readonly Instruction aad = new (Mnemonic.Aad);

    public static readonly Instruction aam = new (Mnemonic.Aam);

    public static readonly Instruction aas = new (Mnemonic.Aas);

    public static readonly Instruction adc = new (Mnemonic.Adc);

    public static readonly Instruction adcx = new (Mnemonic.Adcx);

    public static readonly Instruction add = new (Mnemonic.Add);

    public static readonly Instruction addpd = new (Mnemonic.Addpd);

    public static readonly Instruction addps = new (Mnemonic.Addps);

    public static readonly Instruction addsd = new (Mnemonic.Addsd);

    public static readonly Instruction addss = new (Mnemonic.Addss);

    public static readonly Instruction addsubpd = new (Mnemonic.Addsubpd);

    public static readonly Instruction addsubps = new (Mnemonic.Addsubps);

    public static readonly Instruction adox = new (Mnemonic.Adox);

    public static readonly Instruction aesdec = new (Mnemonic.Aesdec);

    public static readonly Instruction aesdeclast = new (Mnemonic.Aesdeclast);

    public static readonly Instruction aesenc = new (Mnemonic.Aesenc);

    public static readonly Instruction aesenclast = new (Mnemonic.Aesenclast);

    public static readonly Instruction aesimc = new (Mnemonic.Aesimc);

    public static readonly Instruction aeskeygenassist = new (Mnemonic.Aeskeygenassist);

    public static readonly Instruction and = new (Mnemonic.And);

    public static readonly Instruction andn = new (Mnemonic.Andn);

    public static readonly Instruction andnpd = new (Mnemonic.Andnpd);

    public static readonly Instruction andnps = new (Mnemonic.Andnps);

    public static readonly Instruction andpd = new (Mnemonic.Andpd);

    public static readonly Instruction andps = new (Mnemonic.Andps);

    public static readonly Instruction arpl = new (Mnemonic.Arpl);

    public static readonly Instruction bextr = new (Mnemonic.Bextr);

    public static readonly Instruction blcfill = new (Mnemonic.Blcfill);

    public static readonly Instruction blci = new (Mnemonic.Blci);

    public static readonly Instruction blcic = new (Mnemonic.Blcic);

    public static readonly Instruction blcmsk = new (Mnemonic.Blcmsk);

    public static readonly Instruction blcs = new (Mnemonic.Blcs);

    public static readonly Instruction blendpd = new (Mnemonic.Blendpd);

    public static readonly Instruction blendps = new (Mnemonic.Blendps);

    public static readonly Instruction blendvpd = new (Mnemonic.Blendvpd);

    public static readonly Instruction blendvps = new (Mnemonic.Blendvps);

    public static readonly Instruction blsfill = new (Mnemonic.Blsfill);

    public static readonly Instruction blsi = new (Mnemonic.Blsi);

    public static readonly Instruction blsic = new (Mnemonic.Blsic);

    public static readonly Instruction blsmsk = new (Mnemonic.Blsmsk);

    public static readonly Instruction blsr = new (Mnemonic.Blsr);

    public static readonly Instruction bndcl = new (Mnemonic.Bndcl);

    public static readonly Instruction bndcn = new (Mnemonic.Bndcn);

    public static readonly Instruction bndcu = new (Mnemonic.Bndcu);

    public static readonly Instruction bndldx = new (Mnemonic.Bndldx);

    public static readonly Instruction bndmk = new (Mnemonic.Bndmk);

    public static readonly Instruction bndmov = new (Mnemonic.Bndmov);

    public static readonly Instruction bndstx = new (Mnemonic.Bndstx);

    public static readonly Instruction bound = new (Mnemonic.Bound);

    public static readonly Instruction bsf = new (Mnemonic.Bsf);

    public static readonly Instruction bsr = new (Mnemonic.Bsr);

    public static readonly Instruction bswap = new (Mnemonic.Bswap);

    public static readonly Instruction bt = new (Mnemonic.Bt);

    public static readonly Instruction btc = new (Mnemonic.Btc);

    public static readonly Instruction btr = new (Mnemonic.Btr);

    public static readonly Instruction bts = new (Mnemonic.Bts);

    public static readonly Instruction bzhi = new (Mnemonic.Bzhi);

    public static readonly Instruction call = new (Mnemonic.Call);

    public static readonly Instruction cbw = new (Mnemonic.Cbw);

    public static readonly Instruction cdq = new (Mnemonic.Cdq);

    public static readonly Instruction cdqe = new (Mnemonic.Cdqe);

    public static readonly Instruction cl1invmb = new (Mnemonic.Cl1invmb);

    public static readonly Instruction clac = new (Mnemonic.Clac);

    public static readonly Instruction clc = new (Mnemonic.Clc);

    public static readonly Instruction cld = new (Mnemonic.Cld);

    public static readonly Instruction cldemote = new (Mnemonic.Cldemote);

    public static readonly Instruction clflush = new (Mnemonic.Clflush);

    public static readonly Instruction clflushopt = new (Mnemonic.Clflushopt);

    public static readonly Instruction clgi = new (Mnemonic.Clgi);

    public static readonly Instruction cli = new (Mnemonic.Cli);

    public static readonly Instruction clrssbsy = new (Mnemonic.Clrssbsy);

    public static readonly Instruction clts = new (Mnemonic.Clts);

    public static readonly Instruction clwb = new (Mnemonic.Clwb);

    public static readonly Instruction clzero = new (Mnemonic.Clzero);

    public static readonly Instruction cmc = new (Mnemonic.Cmc);

    public static readonly Instruction cmova = new (Mnemonic.Cmova);

    public static readonly Instruction cmovae = new (Mnemonic.Cmovae);

    public static readonly Instruction cmovb = new (Mnemonic.Cmovb);

    public static readonly Instruction cmovbe = new (Mnemonic.Cmovbe);

    public static readonly Instruction cmove = new (Mnemonic.Cmove);

    public static readonly Instruction cmovg = new (Mnemonic.Cmovg);

    public static readonly Instruction cmovge = new (Mnemonic.Cmovge);

    public static readonly Instruction cmovl = new (Mnemonic.Cmovl);

    public static readonly Instruction cmovle = new (Mnemonic.Cmovle);

    public static readonly Instruction cmovne = new (Mnemonic.Cmovne);

    public static readonly Instruction cmovno = new (Mnemonic.Cmovno);

    public static readonly Instruction cmovnp = new (Mnemonic.Cmovnp);

    public static readonly Instruction cmovns = new (Mnemonic.Cmovns);

    public static readonly Instruction cmovo = new (Mnemonic.Cmovo);

    public static readonly Instruction cmovp = new (Mnemonic.Cmovp);

    public static readonly Instruction cmovs = new (Mnemonic.Cmovs);

    public static readonly Instruction cmp = new (Mnemonic.Cmp);

    public static readonly Instruction cmppd = new (Mnemonic.Cmppd);

    public static readonly Instruction cmpps = new (Mnemonic.Cmpps);

    public static readonly Instruction cmpsb = new (Mnemonic.Cmpsb);

    public static readonly Instruction cmpsd = new (Mnemonic.Cmpsd);

    public static readonly Instruction cmpsq = new (Mnemonic.Cmpsq);

    public static readonly Instruction cmpss = new (Mnemonic.Cmpss);

    public static readonly Instruction cmpsw = new (Mnemonic.Cmpsw);

    public static readonly Instruction cmpxchg = new (Mnemonic.Cmpxchg);

    public static readonly Instruction cmpxchg16b = new (Mnemonic.Cmpxchg16b);

    public static readonly Instruction cmpxchg8b = new (Mnemonic.Cmpxchg8b);

    public static readonly Instruction comisd = new (Mnemonic.Comisd);

    public static readonly Instruction comiss = new (Mnemonic.Comiss);

    public static readonly Instruction cpuid = new (Mnemonic.Cpuid);

    public static readonly Instruction cqo = new (Mnemonic.Cqo);

    public static readonly Instruction crc32 = new (Mnemonic.Crc32);

    public static readonly Instruction cvtdq2pd = new (Mnemonic.Cvtdq2pd);

    public static readonly Instruction cvtdq2ps = new (Mnemonic.Cvtdq2ps);

    public static readonly Instruction cvtpd2dq = new (Mnemonic.Cvtpd2dq);

    public static readonly Instruction cvtpd2pi = new (Mnemonic.Cvtpd2pi);

    public static readonly Instruction cvtpd2ps = new (Mnemonic.Cvtpd2ps);

    public static readonly Instruction cvtpi2pd = new (Mnemonic.Cvtpi2pd);

    public static readonly Instruction cvtpi2ps = new (Mnemonic.Cvtpi2ps);

    public static readonly Instruction cvtps2dq = new (Mnemonic.Cvtps2dq);

    public static readonly Instruction cvtps2pd = new (Mnemonic.Cvtps2pd);

    public static readonly Instruction cvtps2pi = new (Mnemonic.Cvtps2pi);

    public static readonly Instruction cvtsd2si = new (Mnemonic.Cvtsd2si);

    public static readonly Instruction cvtsd2ss = new (Mnemonic.Cvtsd2ss);

    public static readonly Instruction cvtsi2sd = new (Mnemonic.Cvtsi2sd);

    public static readonly Instruction cvtsi2ss = new (Mnemonic.Cvtsi2ss);

    public static readonly Instruction cvtss2sd = new (Mnemonic.Cvtss2sd);

    public static readonly Instruction cvtss2si = new (Mnemonic.Cvtss2si);

    public static readonly Instruction cvttpd2dq = new (Mnemonic.Cvttpd2dq);

    public static readonly Instruction cvttpd2pi = new (Mnemonic.Cvttpd2pi);

    public static readonly Instruction cvttps2dq = new (Mnemonic.Cvttps2dq);

    public static readonly Instruction cvttps2pi = new (Mnemonic.Cvttps2pi);

    public static readonly Instruction cvttsd2si = new (Mnemonic.Cvttsd2si);

    public static readonly Instruction cvttss2si = new (Mnemonic.Cvttss2si);

    public static readonly Instruction cwd = new (Mnemonic.Cwd);

    public static readonly Instruction cwde = new (Mnemonic.Cwde);

    public static readonly Instruction daa = new (Mnemonic.Daa);

    public static readonly Instruction das = new (Mnemonic.Das);

    public static readonly Instruction db = new (Mnemonic.Db);

    public static readonly Instruction dd = new (Mnemonic.Dd);

    public static readonly Instruction dec = new (Mnemonic.Dec);

    public static readonly Instruction div = new (Mnemonic.Div);

    public static readonly Instruction divpd = new (Mnemonic.Divpd);

    public static readonly Instruction divps = new (Mnemonic.Divps);

    public static readonly Instruction divsd = new (Mnemonic.Divsd);

    public static readonly Instruction divss = new (Mnemonic.Divss);

    public static readonly Instruction dppd = new (Mnemonic.Dppd);

    public static readonly Instruction dpps = new (Mnemonic.Dpps);

    public static readonly Instruction dq = new (Mnemonic.Dq);

    public static readonly Instruction dw = new (Mnemonic.Dw);

    public static readonly Instruction emms = new (Mnemonic.Emms);

    public static readonly Instruction encls = new (Mnemonic.Encls);

    public static readonly Instruction enclu = new (Mnemonic.Enclu);

    public static readonly Instruction enclv = new (Mnemonic.Enclv);

    public static readonly Instruction endbr32 = new (Mnemonic.Endbr32);

    public static readonly Instruction endbr64 = new (Mnemonic.Endbr64);

    public static readonly Instruction enqcmd = new (Mnemonic.Enqcmd);

    public static readonly Instruction enqcmds = new (Mnemonic.Enqcmds);

    public static readonly Instruction enter = new (Mnemonic.Enter);

    public static readonly Instruction extractps = new (Mnemonic.Extractps);

    public static readonly Instruction extrq = new (Mnemonic.Extrq);

    public static readonly Instruction f2xm1 = new (Mnemonic.F2xm1);

    public static readonly Instruction fabs = new (Mnemonic.Fabs);

    public static readonly Instruction fadd = new (Mnemonic.Fadd);

    public static readonly Instruction faddp = new (Mnemonic.Faddp);

    public static readonly Instruction fbld = new (Mnemonic.Fbld);

    public static readonly Instruction fbstp = new (Mnemonic.Fbstp);

    public static readonly Instruction fchs = new (Mnemonic.Fchs);

    public static readonly Instruction fclex = new (Mnemonic.Fclex);

    public static readonly Instruction fcmovb = new (Mnemonic.Fcmovb);

    public static readonly Instruction fcmovbe = new (Mnemonic.Fcmovbe);

    public static readonly Instruction fcmove = new (Mnemonic.Fcmove);

    public static readonly Instruction fcmovnb = new (Mnemonic.Fcmovnb);

    public static readonly Instruction fcmovnbe = new (Mnemonic.Fcmovnbe);

    public static readonly Instruction fcmovne = new (Mnemonic.Fcmovne);

    public static readonly Instruction fcmovnu = new (Mnemonic.Fcmovnu);

    public static readonly Instruction fcmovu = new (Mnemonic.Fcmovu);

    public static readonly Instruction fcom = new (Mnemonic.Fcom);

    public static readonly Instruction fcomi = new (Mnemonic.Fcomi);

    public static readonly Instruction fcomip = new (Mnemonic.Fcomip);

    public static readonly Instruction fcomp = new (Mnemonic.Fcomp);

    public static readonly Instruction fcompp = new (Mnemonic.Fcompp);

    public static readonly Instruction fcos = new (Mnemonic.Fcos);

    public static readonly Instruction fdecstp = new (Mnemonic.Fdecstp);

    public static readonly Instruction fdisi = new (Mnemonic.Fdisi);

    public static readonly Instruction fdiv = new (Mnemonic.Fdiv);

    public static readonly Instruction fdivp = new (Mnemonic.Fdivp);

    public static readonly Instruction fdivr = new (Mnemonic.Fdivr);

    public static readonly Instruction fdivrp = new (Mnemonic.Fdivrp);

    public static readonly Instruction femms = new (Mnemonic.Femms);

    public static readonly Instruction feni = new (Mnemonic.Feni);

    public static readonly Instruction ffree = new (Mnemonic.Ffree);

    public static readonly Instruction ffreep = new (Mnemonic.Ffreep);

    public static readonly Instruction fiadd = new (Mnemonic.Fiadd);

    public static readonly Instruction ficom = new (Mnemonic.Ficom);

    public static readonly Instruction ficomp = new (Mnemonic.Ficomp);

    public static readonly Instruction fidiv = new (Mnemonic.Fidiv);

    public static readonly Instruction fidivr = new (Mnemonic.Fidivr);

    public static readonly Instruction fild = new (Mnemonic.Fild);

    public static readonly Instruction fimul = new (Mnemonic.Fimul);

    public static readonly Instruction fincstp = new (Mnemonic.Fincstp);

    public static readonly Instruction finit = new (Mnemonic.Finit);

    public static readonly Instruction fist = new (Mnemonic.Fist);

    public static readonly Instruction fistp = new (Mnemonic.Fistp);

    public static readonly Instruction fisttp = new (Mnemonic.Fisttp);

    public static readonly Instruction fisub = new (Mnemonic.Fisub);

    public static readonly Instruction fisubr = new (Mnemonic.Fisubr);

    public static readonly Instruction fld = new (Mnemonic.Fld);

    public static readonly Instruction fld1 = new (Mnemonic.Fld1);

    public static readonly Instruction fldcw = new (Mnemonic.Fldcw);

    public static readonly Instruction fldenv = new (Mnemonic.Fldenv);

    public static readonly Instruction fldl2e = new (Mnemonic.Fldl2e);

    public static readonly Instruction fldl2t = new (Mnemonic.Fldl2t);

    public static readonly Instruction fldlg2 = new (Mnemonic.Fldlg2);

    public static readonly Instruction fldln2 = new (Mnemonic.Fldln2);

    public static readonly Instruction fldpi = new (Mnemonic.Fldpi);

    public static readonly Instruction fldz = new (Mnemonic.Fldz);

    public static readonly Instruction fmul = new (Mnemonic.Fmul);

    public static readonly Instruction fmulp = new (Mnemonic.Fmulp);

    public static readonly Instruction fnclex = new (Mnemonic.Fnclex);

    public static readonly Instruction fndisi = new (Mnemonic.Fndisi);

    public static readonly Instruction fneni = new (Mnemonic.Fneni);

    public static readonly Instruction fninit = new (Mnemonic.Fninit);

    public static readonly Instruction fnop = new (Mnemonic.Fnop);

    public static readonly Instruction fnsave = new (Mnemonic.Fnsave);

    public static readonly Instruction fnsetpm = new (Mnemonic.Fnsetpm);

    public static readonly Instruction fnstcw = new (Mnemonic.Fnstcw);

    public static readonly Instruction fnstenv = new (Mnemonic.Fnstenv);

    public static readonly Instruction fnstsw = new (Mnemonic.Fnstsw);

    public static readonly Instruction fpatan = new (Mnemonic.Fpatan);

    public static readonly Instruction fprem = new (Mnemonic.Fprem);

    public static readonly Instruction fprem1 = new (Mnemonic.Fprem1);

    public static readonly Instruction fptan = new (Mnemonic.Fptan);

    public static readonly Instruction frndint = new (Mnemonic.Frndint);

    public static readonly Instruction frstor = new (Mnemonic.Frstor);

    public static readonly Instruction frstpm = new (Mnemonic.Frstpm);

    public static readonly Instruction fsave = new (Mnemonic.Fsave);

    public static readonly Instruction fscale = new (Mnemonic.Fscale);

    public static readonly Instruction fsetpm = new (Mnemonic.Fsetpm);

    public static readonly Instruction fsin = new (Mnemonic.Fsin);

    public static readonly Instruction fsincos = new (Mnemonic.Fsincos);

    public static readonly Instruction fsqrt = new (Mnemonic.Fsqrt);

    public static readonly Instruction fst = new (Mnemonic.Fst);

    public static readonly Instruction fstcw = new (Mnemonic.Fstcw);

    public static readonly Instruction fstdw = new (Mnemonic.Fstdw);

    public static readonly Instruction fstenv = new (Mnemonic.Fstenv);

    public static readonly Instruction fstp = new (Mnemonic.Fstp);

    public static readonly Instruction fstpnce = new (Mnemonic.Fstpnce);

    public static readonly Instruction fstsg = new (Mnemonic.Fstsg);

    public static readonly Instruction fstsw = new (Mnemonic.Fstsw);

    public static readonly Instruction fsub = new (Mnemonic.Fsub);

    public static readonly Instruction fsubp = new (Mnemonic.Fsubp);

    public static readonly Instruction fsubr = new (Mnemonic.Fsubr);

    public static readonly Instruction fsubrp = new (Mnemonic.Fsubrp);

    public static readonly Instruction ftst = new (Mnemonic.Ftst);

    public static readonly Instruction fucom = new (Mnemonic.Fucom);

    public static readonly Instruction fucomi = new (Mnemonic.Fucomi);

    public static readonly Instruction fucomip = new (Mnemonic.Fucomip);

    public static readonly Instruction fucomp = new (Mnemonic.Fucomp);

    public static readonly Instruction fucompp = new (Mnemonic.Fucompp);

    public static readonly Instruction fxam = new (Mnemonic.Fxam);

    public static readonly Instruction fxch = new (Mnemonic.Fxch);

    public static readonly Instruction fxrstor = new (Mnemonic.Fxrstor);

    public static readonly Instruction fxrstor64 = new (Mnemonic.Fxrstor64);

    public static readonly Instruction fxsave = new (Mnemonic.Fxsave);

    public static readonly Instruction fxsave64 = new (Mnemonic.Fxsave64);

    public static readonly Instruction fxtract = new (Mnemonic.Fxtract);

    public static readonly Instruction fyl2x = new (Mnemonic.Fyl2x);

    public static readonly Instruction fyl2xp1 = new (Mnemonic.Fyl2xp1);

    public static readonly Instruction getsec = new (Mnemonic.Getsec);

    public static readonly Instruction gf2p8affineinvqb = new (Mnemonic.Gf2p8affineinvqb);

    public static readonly Instruction gf2p8affineqb = new (Mnemonic.Gf2p8affineqb);

    public static readonly Instruction gf2p8mulb = new (Mnemonic.Gf2p8mulb);

    public static readonly Instruction haddpd = new (Mnemonic.Haddpd);

    public static readonly Instruction haddps = new (Mnemonic.Haddps);

    public static readonly Instruction hlt = new (Mnemonic.Hlt);

    public static readonly Instruction hsubpd = new (Mnemonic.Hsubpd);

    public static readonly Instruction hsubps = new (Mnemonic.Hsubps);

    public static readonly Instruction ibts = new (Mnemonic.Ibts);

    public static readonly Instruction idiv = new (Mnemonic.Idiv);

    public static readonly Instruction imul = new (Mnemonic.Imul);

    public static readonly Instruction @in = new (Mnemonic.In);

    public static readonly Instruction inc = new (Mnemonic.Inc);

    public static readonly Instruction incsspd = new (Mnemonic.Incsspd);

    public static readonly Instruction incsspq = new (Mnemonic.Incsspq);

    public static readonly Instruction insb = new (Mnemonic.Insb);

    public static readonly Instruction insd = new (Mnemonic.Insd);

    public static readonly Instruction insertps = new (Mnemonic.Insertps);

    public static readonly Instruction insertq = new (Mnemonic.Insertq);

    public static readonly Instruction insw = new (Mnemonic.Insw);

    public static readonly Instruction @int = new (Mnemonic.Int);

    public static readonly Instruction int1 = new (Mnemonic.Int1);

    public static readonly Instruction into = new (Mnemonic.Into);

    public static readonly Instruction invd = new (Mnemonic.Invd);

    public static readonly Instruction invept = new (Mnemonic.Invept);

    public static readonly Instruction invlpg = new (Mnemonic.Invlpg);

    public static readonly Instruction invlpga = new (Mnemonic.Invlpga);

    public static readonly Instruction invpcid = new (Mnemonic.Invpcid);

    public static readonly Instruction invvpid = new (Mnemonic.Invvpid);

    public static readonly Instruction iret = new (Mnemonic.Iret);

    public static readonly Instruction ja = new (Mnemonic.Ja);

    public static readonly Instruction jae = new (Mnemonic.Jae);

    public static readonly Instruction jb = new (Mnemonic.Jb);

    public static readonly Instruction jbe = new (Mnemonic.Jbe);

    public static readonly Instruction jcxz = new (Mnemonic.Jcxz);

    public static readonly Instruction je = new (Mnemonic.Je);

    public static readonly Instruction jecxz = new (Mnemonic.Jecxz);

    public static readonly Instruction jg = new (Mnemonic.Jg);

    public static readonly Instruction jge = new (Mnemonic.Jge);

    public static readonly Instruction jl = new (Mnemonic.Jl);

    public static readonly Instruction jle = new (Mnemonic.Jle);

    public static readonly Instruction jmp = new (Mnemonic.Jmp);

    public static readonly Instruction jmpe = new (Mnemonic.Jmpe);

    public static readonly Instruction jne = new (Mnemonic.Jne);

    public static readonly Instruction jno = new (Mnemonic.Jno);

    public static readonly Instruction jnp = new (Mnemonic.Jnp);

    public static readonly Instruction jns = new (Mnemonic.Jns);

    public static readonly Instruction jo = new (Mnemonic.Jo);

    public static readonly Instruction jp = new (Mnemonic.Jp);

    public static readonly Instruction jrcxz = new (Mnemonic.Jrcxz);

    public static readonly Instruction js = new (Mnemonic.Js);

    public static readonly Instruction kaddb = new (Mnemonic.Kaddb);

    public static readonly Instruction kaddd = new (Mnemonic.Kaddd);

    public static readonly Instruction kaddq = new (Mnemonic.Kaddq);

    public static readonly Instruction kaddw = new (Mnemonic.Kaddw);

    public static readonly Instruction kandb = new (Mnemonic.Kandb);

    public static readonly Instruction kandd = new (Mnemonic.Kandd);

    public static readonly Instruction kandnb = new (Mnemonic.Kandnb);

    public static readonly Instruction kandnd = new (Mnemonic.Kandnd);

    public static readonly Instruction kandnq = new (Mnemonic.Kandnq);

    public static readonly Instruction kandnw = new (Mnemonic.Kandnw);

    public static readonly Instruction kandq = new (Mnemonic.Kandq);

    public static readonly Instruction kandw = new (Mnemonic.Kandw);

    public static readonly Instruction kmovb = new (Mnemonic.Kmovb);

    public static readonly Instruction kmovd = new (Mnemonic.Kmovd);

    public static readonly Instruction kmovq = new (Mnemonic.Kmovq);

    public static readonly Instruction kmovw = new (Mnemonic.Kmovw);

    public static readonly Instruction knotb = new (Mnemonic.Knotb);

    public static readonly Instruction knotd = new (Mnemonic.Knotd);

    public static readonly Instruction knotq = new (Mnemonic.Knotq);

    public static readonly Instruction knotw = new (Mnemonic.Knotw);

    public static readonly Instruction korb = new (Mnemonic.Korb);

    public static readonly Instruction kord = new (Mnemonic.Kord);

    public static readonly Instruction korq = new (Mnemonic.Korq);

    public static readonly Instruction kortestb = new (Mnemonic.Kortestb);

    public static readonly Instruction kortestd = new (Mnemonic.Kortestd);

    public static readonly Instruction kortestq = new (Mnemonic.Kortestq);

    public static readonly Instruction kortestw = new (Mnemonic.Kortestw);

    public static readonly Instruction korw = new (Mnemonic.Korw);

    public static readonly Instruction kshiftlb = new (Mnemonic.Kshiftlb);

    public static readonly Instruction kshiftld = new (Mnemonic.Kshiftld);

    public static readonly Instruction kshiftlq = new (Mnemonic.Kshiftlq);

    public static readonly Instruction kshiftlw = new (Mnemonic.Kshiftlw);

    public static readonly Instruction kshiftrb = new (Mnemonic.Kshiftrb);

    public static readonly Instruction kshiftrd = new (Mnemonic.Kshiftrd);

    public static readonly Instruction kshiftrq = new (Mnemonic.Kshiftrq);

    public static readonly Instruction kshiftrw = new (Mnemonic.Kshiftrw);

    public static readonly Instruction ktestb = new (Mnemonic.Ktestb);

    public static readonly Instruction ktestd = new (Mnemonic.Ktestd);

    public static readonly Instruction ktestq = new (Mnemonic.Ktestq);

    public static readonly Instruction ktestw = new (Mnemonic.Ktestw);

    public static readonly Instruction kunpckbw = new (Mnemonic.Kunpckbw);

    public static readonly Instruction kunpckdq = new (Mnemonic.Kunpckdq);

    public static readonly Instruction kunpckwd = new (Mnemonic.Kunpckwd);

    public static readonly Instruction kxnorb = new (Mnemonic.Kxnorb);

    public static readonly Instruction kxnord = new (Mnemonic.Kxnord);

    public static readonly Instruction kxnorq = new (Mnemonic.Kxnorq);

    public static readonly Instruction kxnorw = new (Mnemonic.Kxnorw);

    public static readonly Instruction kxorb = new (Mnemonic.Kxorb);

    public static readonly Instruction kxord = new (Mnemonic.Kxord);

    public static readonly Instruction kxorq = new (Mnemonic.Kxorq);

    public static readonly Instruction kxorw = new (Mnemonic.Kxorw);

    public static readonly Instruction lahf = new (Mnemonic.Lahf);

    public static readonly Instruction lar = new (Mnemonic.Lar);

    public static readonly Instruction lddqu = new (Mnemonic.Lddqu);

    public static readonly Instruction ldmxcsr = new (Mnemonic.Ldmxcsr);

    public static readonly Instruction lds = new (Mnemonic.Lds);

    public static readonly Instruction lea = new (Mnemonic.Lea);

    public static readonly Instruction leave = new (Mnemonic.Leave);

    public static readonly Instruction les = new (Mnemonic.Les);

    public static readonly Instruction lfence = new (Mnemonic.Lfence);

    public static readonly Instruction lfs = new (Mnemonic.Lfs);

    public static readonly Instruction lgdt = new (Mnemonic.Lgdt);

    public static readonly Instruction lgs = new (Mnemonic.Lgs);

    public static readonly Instruction lidt = new (Mnemonic.Lidt);

    public static readonly Instruction lldt = new (Mnemonic.Lldt);

    public static readonly Instruction llwpcb = new (Mnemonic.Llwpcb);

    public static readonly Instruction lmsw = new (Mnemonic.Lmsw);

    public static readonly Instruction loadall = new (Mnemonic.Loadall);

    public static readonly Instruction lodsb = new (Mnemonic.Lodsb);

    public static readonly Instruction lodsd = new (Mnemonic.Lodsd);

    public static readonly Instruction lodsq = new (Mnemonic.Lodsq);

    public static readonly Instruction lodsw = new (Mnemonic.Lodsw);

    public static readonly Instruction loop = new (Mnemonic.Loop);

    public static readonly Instruction loope = new (Mnemonic.Loope);

    public static readonly Instruction loopne = new (Mnemonic.Loopne);

    public static readonly Instruction lsl = new (Mnemonic.Lsl);

    public static readonly Instruction lss = new (Mnemonic.Lss);

    public static readonly Instruction ltr = new (Mnemonic.Ltr);

    public static readonly Instruction lwpins = new (Mnemonic.Lwpins);

    public static readonly Instruction lwpval = new (Mnemonic.Lwpval);

    public static readonly Instruction lzcnt = new (Mnemonic.Lzcnt);

    public static readonly Instruction maskmovdqu = new (Mnemonic.Maskmovdqu);

    public static readonly Instruction maskmovq = new (Mnemonic.Maskmovq);

    public static readonly Instruction maxpd = new (Mnemonic.Maxpd);

    public static readonly Instruction maxps = new (Mnemonic.Maxps);

    public static readonly Instruction maxsd = new (Mnemonic.Maxsd);

    public static readonly Instruction maxss = new (Mnemonic.Maxss);

    public static readonly Instruction mcommit = new (Mnemonic.Mcommit);

    public static readonly Instruction mfence = new (Mnemonic.Mfence);

    public static readonly Instruction minpd = new (Mnemonic.Minpd);

    public static readonly Instruction minps = new (Mnemonic.Minps);

    public static readonly Instruction minsd = new (Mnemonic.Minsd);

    public static readonly Instruction minss = new (Mnemonic.Minss);

    public static readonly Instruction monitor = new (Mnemonic.Monitor);

    public static readonly Instruction monitorx = new (Mnemonic.Monitorx);

    public static readonly Instruction montmul = new (Mnemonic.Montmul);

    public static readonly Instruction mov = new (Mnemonic.Mov);

    public static readonly Instruction movapd = new (Mnemonic.Movapd);

    public static readonly Instruction movaps = new (Mnemonic.Movaps);

    public static readonly Instruction movbe = new (Mnemonic.Movbe);

    public static readonly Instruction movd = new (Mnemonic.Movd);

    public static readonly Instruction movddup = new (Mnemonic.Movddup);

    public static readonly Instruction movdir64b = new (Mnemonic.Movdir64b);

    public static readonly Instruction movdiri = new (Mnemonic.Movdiri);

    public static readonly Instruction movdq2q = new (Mnemonic.Movdq2q);

    public static readonly Instruction movdqa = new (Mnemonic.Movdqa);

    public static readonly Instruction movdqu = new (Mnemonic.Movdqu);

    public static readonly Instruction movhlps = new (Mnemonic.Movhlps);

    public static readonly Instruction movhpd = new (Mnemonic.Movhpd);

    public static readonly Instruction movhps = new (Mnemonic.Movhps);

    public static readonly Instruction movlhps = new (Mnemonic.Movlhps);

    public static readonly Instruction movlpd = new (Mnemonic.Movlpd);

    public static readonly Instruction movlps = new (Mnemonic.Movlps);

    public static readonly Instruction movmskpd = new (Mnemonic.Movmskpd);

    public static readonly Instruction movmskps = new (Mnemonic.Movmskps);

    public static readonly Instruction movntdq = new (Mnemonic.Movntdq);

    public static readonly Instruction movntdqa = new (Mnemonic.Movntdqa);

    public static readonly Instruction movnti = new (Mnemonic.Movnti);

    public static readonly Instruction movntpd = new (Mnemonic.Movntpd);

    public static readonly Instruction movntps = new (Mnemonic.Movntps);

    public static readonly Instruction movntq = new (Mnemonic.Movntq);

    public static readonly Instruction movntsd = new (Mnemonic.Movntsd);

    public static readonly Instruction movntss = new (Mnemonic.Movntss);

    public static readonly Instruction movq = new (Mnemonic.Movq);

    public static readonly Instruction movq2dq = new (Mnemonic.Movq2dq);

    public static readonly Instruction movsb = new (Mnemonic.Movsb);

    public static readonly Instruction movsd = new (Mnemonic.Movsd);

    public static readonly Instruction movshdup = new (Mnemonic.Movshdup);

    public static readonly Instruction movsldup = new (Mnemonic.Movsldup);

    public static readonly Instruction movsq = new (Mnemonic.Movsq);

    public static readonly Instruction movss = new (Mnemonic.Movss);

    public static readonly Instruction movsw = new (Mnemonic.Movsw);

    public static readonly Instruction movsx = new (Mnemonic.Movsx);

    public static readonly Instruction movsxd = new (Mnemonic.Movsxd);

    public static readonly Instruction movupd = new (Mnemonic.Movupd);

    public static readonly Instruction movups = new (Mnemonic.Movups);

    public static readonly Instruction movzx = new (Mnemonic.Movzx);

    public static readonly Instruction mpsadbw = new (Mnemonic.Mpsadbw);

    public static readonly Instruction mul = new (Mnemonic.Mul);

    public static readonly Instruction mulpd = new (Mnemonic.Mulpd);

    public static readonly Instruction mulps = new (Mnemonic.Mulps);

    public static readonly Instruction mulsd = new (Mnemonic.Mulsd);

    public static readonly Instruction mulss = new (Mnemonic.Mulss);

    public static readonly Instruction mulx = new (Mnemonic.Mulx);

    public static readonly Instruction mwait = new (Mnemonic.Mwait);

    public static readonly Instruction mwaitx = new (Mnemonic.Mwaitx);

    public static readonly Instruction neg = new (Mnemonic.Neg);

    public static readonly Instruction nop = new (Mnemonic.Nop);

    public static readonly Instruction not = new (Mnemonic.Not);

    public static readonly Instruction or = new (Mnemonic.Or);

    public static readonly Instruction orpd = new (Mnemonic.Orpd);

    public static readonly Instruction orps = new (Mnemonic.Orps);

    public static readonly Instruction @out = new (Mnemonic.Out);

    public static readonly Instruction outsb = new (Mnemonic.Outsb);

    public static readonly Instruction outsd = new (Mnemonic.Outsd);

    public static readonly Instruction outsw = new (Mnemonic.Outsw);

    public static readonly Instruction pabsb = new (Mnemonic.Pabsb);

    public static readonly Instruction pabsd = new (Mnemonic.Pabsd);

    public static readonly Instruction pabsw = new (Mnemonic.Pabsw);

    public static readonly Instruction packssdw = new (Mnemonic.Packssdw);

    public static readonly Instruction packsswb = new (Mnemonic.Packsswb);

    public static readonly Instruction packusdw = new (Mnemonic.Packusdw);

    public static readonly Instruction packuswb = new (Mnemonic.Packuswb);

    public static readonly Instruction paddb = new (Mnemonic.Paddb);

    public static readonly Instruction paddd = new (Mnemonic.Paddd);

    public static readonly Instruction paddq = new (Mnemonic.Paddq);

    public static readonly Instruction paddsb = new (Mnemonic.Paddsb);

    public static readonly Instruction paddsw = new (Mnemonic.Paddsw);

    public static readonly Instruction paddusb = new (Mnemonic.Paddusb);

    public static readonly Instruction paddusw = new (Mnemonic.Paddusw);

    public static readonly Instruction paddw = new (Mnemonic.Paddw);

    public static readonly Instruction palignr = new (Mnemonic.Palignr);

    public static readonly Instruction pand = new (Mnemonic.Pand);

    public static readonly Instruction pandn = new (Mnemonic.Pandn);

    public static readonly Instruction pause = new (Mnemonic.Pause);

    public static readonly Instruction pavgb = new (Mnemonic.Pavgb);

    public static readonly Instruction pavgusb = new (Mnemonic.Pavgusb);

    public static readonly Instruction pavgw = new (Mnemonic.Pavgw);

    public static readonly Instruction pblendvb = new (Mnemonic.Pblendvb);

    public static readonly Instruction pblendw = new (Mnemonic.Pblendw);

    public static readonly Instruction pclmulqdq = new (Mnemonic.Pclmulqdq);

    public static readonly Instruction pcmpeqb = new (Mnemonic.Pcmpeqb);

    public static readonly Instruction pcmpeqd = new (Mnemonic.Pcmpeqd);

    public static readonly Instruction pcmpeqq = new (Mnemonic.Pcmpeqq);

    public static readonly Instruction pcmpeqw = new (Mnemonic.Pcmpeqw);

    public static readonly Instruction pcmpestri = new (Mnemonic.Pcmpestri);

    public static readonly Instruction pcmpestri64 = new (Mnemonic.Pcmpestri64);

    public static readonly Instruction pcmpestrm = new (Mnemonic.Pcmpestrm);

    public static readonly Instruction pcmpestrm64 = new (Mnemonic.Pcmpestrm64);

    public static readonly Instruction pcmpgtb = new (Mnemonic.Pcmpgtb);

    public static readonly Instruction pcmpgtd = new (Mnemonic.Pcmpgtd);

    public static readonly Instruction pcmpgtq = new (Mnemonic.Pcmpgtq);

    public static readonly Instruction pcmpgtw = new (Mnemonic.Pcmpgtw);

    public static readonly Instruction pcmpistri = new (Mnemonic.Pcmpistri);

    public static readonly Instruction pcmpistrm = new (Mnemonic.Pcmpistrm);

    public static readonly Instruction pcommit = new (Mnemonic.Pcommit);

    public static readonly Instruction pconfig = new (Mnemonic.Pconfig);

    public static readonly Instruction pdep = new (Mnemonic.Pdep);

    public static readonly Instruction pext = new (Mnemonic.Pext);

    public static readonly Instruction pextrb = new (Mnemonic.Pextrb);

    public static readonly Instruction pextrd = new (Mnemonic.Pextrd);

    public static readonly Instruction pextrq = new (Mnemonic.Pextrq);

    public static readonly Instruction pextrw = new (Mnemonic.Pextrw);

    public static readonly Instruction pf2id = new (Mnemonic.Pf2id);

    public static readonly Instruction pf2iw = new (Mnemonic.Pf2iw);

    public static readonly Instruction pfacc = new (Mnemonic.Pfacc);

    public static readonly Instruction pfadd = new (Mnemonic.Pfadd);

    public static readonly Instruction pfcmpeq = new (Mnemonic.Pfcmpeq);

    public static readonly Instruction pfcmpge = new (Mnemonic.Pfcmpge);

    public static readonly Instruction pfcmpgt = new (Mnemonic.Pfcmpgt);

    public static readonly Instruction pfmax = new (Mnemonic.Pfmax);

    public static readonly Instruction pfmin = new (Mnemonic.Pfmin);

    public static readonly Instruction pfmul = new (Mnemonic.Pfmul);

    public static readonly Instruction pfnacc = new (Mnemonic.Pfnacc);

    public static readonly Instruction pfpnacc = new (Mnemonic.Pfpnacc);

    public static readonly Instruction pfrcp = new (Mnemonic.Pfrcp);

    public static readonly Instruction pfrcpit1 = new (Mnemonic.Pfrcpit1);

    public static readonly Instruction pfrcpit2 = new (Mnemonic.Pfrcpit2);

    public static readonly Instruction pfrcpv = new (Mnemonic.Pfrcpv);

    public static readonly Instruction pfrsqit1 = new (Mnemonic.Pfrsqit1);

    public static readonly Instruction pfrsqrt = new (Mnemonic.Pfrsqrt);

    public static readonly Instruction pfrsqrtv = new (Mnemonic.Pfrsqrtv);

    public static readonly Instruction pfsub = new (Mnemonic.Pfsub);

    public static readonly Instruction pfsubr = new (Mnemonic.Pfsubr);

    public static readonly Instruction phaddd = new (Mnemonic.Phaddd);

    public static readonly Instruction phaddsw = new (Mnemonic.Phaddsw);

    public static readonly Instruction phaddw = new (Mnemonic.Phaddw);

    public static readonly Instruction phminposuw = new (Mnemonic.Phminposuw);

    public static readonly Instruction phsubd = new (Mnemonic.Phsubd);

    public static readonly Instruction phsubsw = new (Mnemonic.Phsubsw);

    public static readonly Instruction phsubw = new (Mnemonic.Phsubw);

    public static readonly Instruction pi2fd = new (Mnemonic.Pi2fd);

    public static readonly Instruction pi2fw = new (Mnemonic.Pi2fw);

    public static readonly Instruction pinsrb = new (Mnemonic.Pinsrb);

    public static readonly Instruction pinsrd = new (Mnemonic.Pinsrd);

    public static readonly Instruction pinsrq = new (Mnemonic.Pinsrq);

    public static readonly Instruction pinsrw = new (Mnemonic.Pinsrw);

    public static readonly Instruction pmaddubsw = new (Mnemonic.Pmaddubsw);

    public static readonly Instruction pmaddwd = new (Mnemonic.Pmaddwd);

    public static readonly Instruction pmaxsb = new (Mnemonic.Pmaxsb);

    public static readonly Instruction pmaxsd = new (Mnemonic.Pmaxsd);

    public static readonly Instruction pmaxsw = new (Mnemonic.Pmaxsw);

    public static readonly Instruction pmaxub = new (Mnemonic.Pmaxub);

    public static readonly Instruction pmaxud = new (Mnemonic.Pmaxud);

    public static readonly Instruction pmaxuw = new (Mnemonic.Pmaxuw);

    public static readonly Instruction pminsb = new (Mnemonic.Pminsb);

    public static readonly Instruction pminsd = new (Mnemonic.Pminsd);

    public static readonly Instruction pminsw = new (Mnemonic.Pminsw);

    public static readonly Instruction pminub = new (Mnemonic.Pminub);

    public static readonly Instruction pminud = new (Mnemonic.Pminud);

    public static readonly Instruction pminuw = new (Mnemonic.Pminuw);

    public static readonly Instruction pmovmskb = new (Mnemonic.Pmovmskb);

    public static readonly Instruction pmovsxbd = new (Mnemonic.Pmovsxbd);

    public static readonly Instruction pmovsxbq = new (Mnemonic.Pmovsxbq);

    public static readonly Instruction pmovsxbw = new (Mnemonic.Pmovsxbw);

    public static readonly Instruction pmovsxdq = new (Mnemonic.Pmovsxdq);

    public static readonly Instruction pmovsxwd = new (Mnemonic.Pmovsxwd);

    public static readonly Instruction pmovsxwq = new (Mnemonic.Pmovsxwq);

    public static readonly Instruction pmovzxbd = new (Mnemonic.Pmovzxbd);

    public static readonly Instruction pmovzxbq = new (Mnemonic.Pmovzxbq);

    public static readonly Instruction pmovzxbw = new (Mnemonic.Pmovzxbw);

    public static readonly Instruction pmovzxdq = new (Mnemonic.Pmovzxdq);

    public static readonly Instruction pmovzxwd = new (Mnemonic.Pmovzxwd);

    public static readonly Instruction pmovzxwq = new (Mnemonic.Pmovzxwq);

    public static readonly Instruction pmuldq = new (Mnemonic.Pmuldq);

    public static readonly Instruction pmulhrsw = new (Mnemonic.Pmulhrsw);

    public static readonly Instruction pmulhrw = new (Mnemonic.Pmulhrw);

    public static readonly Instruction pmulhuw = new (Mnemonic.Pmulhuw);

    public static readonly Instruction pmulhw = new (Mnemonic.Pmulhw);

    public static readonly Instruction pmulld = new (Mnemonic.Pmulld);

    public static readonly Instruction pmullw = new (Mnemonic.Pmullw);

    public static readonly Instruction pmuludq = new (Mnemonic.Pmuludq);

    public static readonly Instruction pop = new (Mnemonic.Pop);

    public static readonly Instruction popa = new (Mnemonic.Popa);

    public static readonly Instruction popcnt = new (Mnemonic.Popcnt);

    public static readonly Instruction popf = new (Mnemonic.Popf);

    public static readonly Instruction por = new (Mnemonic.Por);

    public static readonly Instruction prefetch = new (Mnemonic.Prefetch);

    public static readonly Instruction prefetchnta = new (Mnemonic.Prefetchnta);

    public static readonly Instruction prefetcht0 = new (Mnemonic.Prefetcht0);

    public static readonly Instruction prefetcht1 = new (Mnemonic.Prefetcht1);

    public static readonly Instruction prefetcht2 = new (Mnemonic.Prefetcht2);

    public static readonly Instruction prefetchw = new (Mnemonic.Prefetchw);

    public static readonly Instruction prefetchwt1 = new (Mnemonic.Prefetchwt1);

    public static readonly Instruction psadbw = new (Mnemonic.Psadbw);

    public static readonly Instruction pshufb = new (Mnemonic.Pshufb);

    public static readonly Instruction pshufd = new (Mnemonic.Pshufd);

    public static readonly Instruction pshufhw = new (Mnemonic.Pshufhw);

    public static readonly Instruction pshuflw = new (Mnemonic.Pshuflw);

    public static readonly Instruction pshufw = new (Mnemonic.Pshufw);

    public static readonly Instruction psignb = new (Mnemonic.Psignb);

    public static readonly Instruction psignd = new (Mnemonic.Psignd);

    public static readonly Instruction psignw = new (Mnemonic.Psignw);

    public static readonly Instruction pslld = new (Mnemonic.Pslld);

    public static readonly Instruction pslldq = new (Mnemonic.Pslldq);

    public static readonly Instruction psllq = new (Mnemonic.Psllq);

    public static readonly Instruction psllw = new (Mnemonic.Psllw);

    public static readonly Instruction psrad = new (Mnemonic.Psrad);

    public static readonly Instruction psraw = new (Mnemonic.Psraw);

    public static readonly Instruction psrld = new (Mnemonic.Psrld);

    public static readonly Instruction psrldq = new (Mnemonic.Psrldq);

    public static readonly Instruction psrlq = new (Mnemonic.Psrlq);

    public static readonly Instruction psrlw = new (Mnemonic.Psrlw);

    public static readonly Instruction psubb = new (Mnemonic.Psubb);

    public static readonly Instruction psubd = new (Mnemonic.Psubd);

    public static readonly Instruction psubq = new (Mnemonic.Psubq);

    public static readonly Instruction psubsb = new (Mnemonic.Psubsb);

    public static readonly Instruction psubsw = new (Mnemonic.Psubsw);

    public static readonly Instruction psubusb = new (Mnemonic.Psubusb);

    public static readonly Instruction psubusw = new (Mnemonic.Psubusw);

    public static readonly Instruction psubw = new (Mnemonic.Psubw);

    public static readonly Instruction pswapd = new (Mnemonic.Pswapd);

    public static readonly Instruction ptest = new (Mnemonic.Ptest);

    public static readonly Instruction ptwrite = new (Mnemonic.Ptwrite);

    public static readonly Instruction punpckhbw = new (Mnemonic.Punpckhbw);

    public static readonly Instruction punpckhdq = new (Mnemonic.Punpckhdq);

    public static readonly Instruction punpckhqdq = new (Mnemonic.Punpckhqdq);

    public static readonly Instruction punpckhwd = new (Mnemonic.Punpckhwd);

    public static readonly Instruction punpcklbw = new (Mnemonic.Punpcklbw);

    public static readonly Instruction punpckldq = new (Mnemonic.Punpckldq);

    public static readonly Instruction punpcklqdq = new (Mnemonic.Punpcklqdq);

    public static readonly Instruction punpcklwd = new (Mnemonic.Punpcklwd);

    public static readonly Instruction push = new (Mnemonic.Push);

    public static readonly Instruction pusha = new (Mnemonic.Pusha);

    public static readonly Instruction pushf = new (Mnemonic.Pushf);

    public static readonly Instruction pxor = new (Mnemonic.Pxor);

    public static readonly Instruction rcl = new (Mnemonic.Rcl);

    public static readonly Instruction rcpps = new (Mnemonic.Rcpps);

    public static readonly Instruction rcpss = new (Mnemonic.Rcpss);

    public static readonly Instruction rcr = new (Mnemonic.Rcr);

    public static readonly Instruction rdfsbase = new (Mnemonic.Rdfsbase);

    public static readonly Instruction rdgsbase = new (Mnemonic.Rdgsbase);

    public static readonly Instruction rdmsr = new (Mnemonic.Rdmsr);

    public static readonly Instruction rdpid = new (Mnemonic.Rdpid);

    public static readonly Instruction rdpkru = new (Mnemonic.Rdpkru);

    public static readonly Instruction rdpmc = new (Mnemonic.Rdpmc);

    public static readonly Instruction rdpru = new (Mnemonic.Rdpru);

    public static readonly Instruction rdrand = new (Mnemonic.Rdrand);

    public static readonly Instruction rdseed = new (Mnemonic.Rdseed);

    public static readonly Instruction rdsspd = new (Mnemonic.Rdsspd);

    public static readonly Instruction rdsspq = new (Mnemonic.Rdsspq);

    public static readonly Instruction rdtsc = new (Mnemonic.Rdtsc);

    public static readonly Instruction rdtscp = new (Mnemonic.Rdtscp);

    public static readonly Instruction reservednop = new (Mnemonic.Reservednop);

    public static readonly Instruction ret = new (Mnemonic.Ret);

    public static readonly Instruction retf = new (Mnemonic.Retf);

    public static readonly Instruction rol = new (Mnemonic.Rol);

    public static readonly Instruction ror = new (Mnemonic.Ror);

    public static readonly Instruction rorx = new (Mnemonic.Rorx);

    public static readonly Instruction roundpd = new (Mnemonic.Roundpd);

    public static readonly Instruction roundps = new (Mnemonic.Roundps);

    public static readonly Instruction roundsd = new (Mnemonic.Roundsd);

    public static readonly Instruction roundss = new (Mnemonic.Roundss);

    public static readonly Instruction rsm = new (Mnemonic.Rsm);

    public static readonly Instruction rsqrtps = new (Mnemonic.Rsqrtps);

    public static readonly Instruction rsqrtss = new (Mnemonic.Rsqrtss);

    public static readonly Instruction rstorssp = new (Mnemonic.Rstorssp);

    public static readonly Instruction sahf = new (Mnemonic.Sahf);

    public static readonly Instruction sal = new (Mnemonic.Sal);

    public static readonly Instruction salc = new (Mnemonic.Salc);

    public static readonly Instruction sar = new (Mnemonic.Sar);

    public static readonly Instruction sarx = new (Mnemonic.Sarx);

    public static readonly Instruction saveprevssp = new (Mnemonic.Saveprevssp);

    public static readonly Instruction sbb = new (Mnemonic.Sbb);

    public static readonly Instruction scasb = new (Mnemonic.Scasb);

    public static readonly Instruction scasd = new (Mnemonic.Scasd);

    public static readonly Instruction scasq = new (Mnemonic.Scasq);

    public static readonly Instruction scasw = new (Mnemonic.Scasw);

    public static readonly Instruction seta = new (Mnemonic.Seta);

    public static readonly Instruction setae = new (Mnemonic.Setae);

    public static readonly Instruction setb = new (Mnemonic.Setb);

    public static readonly Instruction setbe = new (Mnemonic.Setbe);

    public static readonly Instruction sete = new (Mnemonic.Sete);

    public static readonly Instruction setg = new (Mnemonic.Setg);

    public static readonly Instruction setge = new (Mnemonic.Setge);

    public static readonly Instruction setl = new (Mnemonic.Setl);

    public static readonly Instruction setle = new (Mnemonic.Setle);

    public static readonly Instruction setne = new (Mnemonic.Setne);

    public static readonly Instruction setno = new (Mnemonic.Setno);

    public static readonly Instruction setnp = new (Mnemonic.Setnp);

    public static readonly Instruction setns = new (Mnemonic.Setns);

    public static readonly Instruction seto = new (Mnemonic.Seto);

    public static readonly Instruction setp = new (Mnemonic.Setp);

    public static readonly Instruction sets = new (Mnemonic.Sets);

    public static readonly Instruction setssbsy = new (Mnemonic.Setssbsy);

    public static readonly Instruction sfence = new (Mnemonic.Sfence);

    public static readonly Instruction sgdt = new (Mnemonic.Sgdt);

    public static readonly Instruction sha1msg1 = new (Mnemonic.Sha1msg1);

    public static readonly Instruction sha1msg2 = new (Mnemonic.Sha1msg2);

    public static readonly Instruction sha1nexte = new (Mnemonic.Sha1nexte);

    public static readonly Instruction sha1rnds4 = new (Mnemonic.Sha1rnds4);

    public static readonly Instruction sha256msg1 = new (Mnemonic.Sha256msg1);

    public static readonly Instruction sha256msg2 = new (Mnemonic.Sha256msg2);

    public static readonly Instruction sha256rnds2 = new (Mnemonic.Sha256rnds2);

    public static readonly Instruction shl = new (Mnemonic.Shl);

    public static readonly Instruction shld = new (Mnemonic.Shld);

    public static readonly Instruction shlx = new (Mnemonic.Shlx);

    public static readonly Instruction shr = new (Mnemonic.Shr);

    public static readonly Instruction shrd = new (Mnemonic.Shrd);

    public static readonly Instruction shrx = new (Mnemonic.Shrx);

    public static readonly Instruction shufpd = new (Mnemonic.Shufpd);

    public static readonly Instruction shufps = new (Mnemonic.Shufps);

    public static readonly Instruction sidt = new (Mnemonic.Sidt);

    public static readonly Instruction skinit = new (Mnemonic.Skinit);

    public static readonly Instruction sldt = new (Mnemonic.Sldt);

    public static readonly Instruction slwpcb = new (Mnemonic.Slwpcb);

    public static readonly Instruction smsw = new (Mnemonic.Smsw);

    public static readonly Instruction sqrtpd = new (Mnemonic.Sqrtpd);

    public static readonly Instruction sqrtps = new (Mnemonic.Sqrtps);

    public static readonly Instruction sqrtsd = new (Mnemonic.Sqrtsd);

    public static readonly Instruction sqrtss = new (Mnemonic.Sqrtss);

    public static readonly Instruction stac = new (Mnemonic.Stac);

    public static readonly Instruction stc = new (Mnemonic.Stc);

    public static readonly Instruction std = new (Mnemonic.Std);

    public static readonly Instruction stgi = new (Mnemonic.Stgi);

    public static readonly Instruction sti = new (Mnemonic.Sti);

    public static readonly Instruction stmxcsr = new (Mnemonic.Stmxcsr);

    public static readonly Instruction stosb = new (Mnemonic.Stosb);

    public static readonly Instruction stosd = new (Mnemonic.Stosd);

    public static readonly Instruction stosq = new (Mnemonic.Stosq);

    public static readonly Instruction stosw = new (Mnemonic.Stosw);

    public static readonly Instruction str = new (Mnemonic.Str);

    public static readonly Instruction sub = new (Mnemonic.Sub);

    public static readonly Instruction subpd = new (Mnemonic.Subpd);

    public static readonly Instruction subps = new (Mnemonic.Subps);

    public static readonly Instruction subsd = new (Mnemonic.Subsd);

    public static readonly Instruction subss = new (Mnemonic.Subss);

    public static readonly Instruction swapgs = new (Mnemonic.Swapgs);

    public static readonly Instruction syscall = new (Mnemonic.Syscall);

    public static readonly Instruction sysenter = new (Mnemonic.Sysenter);

    public static readonly Instruction sysexit = new (Mnemonic.Sysexit);

    public static readonly Instruction sysret = new (Mnemonic.Sysret);

    public static readonly Instruction t1mskc = new (Mnemonic.T1mskc);

    public static readonly Instruction test = new (Mnemonic.Test);

    public static readonly Instruction tpause = new (Mnemonic.Tpause);

    public static readonly Instruction tzcnt = new (Mnemonic.Tzcnt);

    public static readonly Instruction tzmsk = new (Mnemonic.Tzmsk);

    public static readonly Instruction ucomisd = new (Mnemonic.Ucomisd);

    public static readonly Instruction ucomiss = new (Mnemonic.Ucomiss);

    public static readonly Instruction ud0 = new (Mnemonic.Ud0);

    public static readonly Instruction ud1 = new (Mnemonic.Ud1);

    public static readonly Instruction ud2 = new (Mnemonic.Ud2);

    public static readonly Instruction umonitor = new (Mnemonic.Umonitor);

    public static readonly Instruction umov = new (Mnemonic.Umov);

    public static readonly Instruction umwait = new (Mnemonic.Umwait);

    public static readonly Instruction unpckhpd = new (Mnemonic.Unpckhpd);

    public static readonly Instruction unpckhps = new (Mnemonic.Unpckhps);

    public static readonly Instruction unpcklpd = new (Mnemonic.Unpcklpd);

    public static readonly Instruction unpcklps = new (Mnemonic.Unpcklps);

    public static readonly Instruction v4fmaddps = new (Mnemonic.V4fmaddps);

    public static readonly Instruction v4fmaddss = new (Mnemonic.V4fmaddss);

    public static readonly Instruction v4fnmaddps = new (Mnemonic.V4fnmaddps);

    public static readonly Instruction v4fnmaddss = new (Mnemonic.V4fnmaddss);

    public static readonly Instruction vaddpd = new (Mnemonic.Vaddpd);

    public static readonly Instruction vaddps = new (Mnemonic.Vaddps);

    public static readonly Instruction vaddsd = new (Mnemonic.Vaddsd);

    public static readonly Instruction vaddss = new (Mnemonic.Vaddss);

    public static readonly Instruction vaddsubpd = new (Mnemonic.Vaddsubpd);

    public static readonly Instruction vaddsubps = new (Mnemonic.Vaddsubps);

    public static readonly Instruction vaesdec = new (Mnemonic.Vaesdec);

    public static readonly Instruction vaesdeclast = new (Mnemonic.Vaesdeclast);

    public static readonly Instruction vaesenc = new (Mnemonic.Vaesenc);

    public static readonly Instruction vaesenclast = new (Mnemonic.Vaesenclast);

    public static readonly Instruction vaesimc = new (Mnemonic.Vaesimc);

    public static readonly Instruction vaeskeygenassist = new (Mnemonic.Vaeskeygenassist);

    public static readonly Instruction valignd = new (Mnemonic.Valignd);

    public static readonly Instruction valignq = new (Mnemonic.Valignq);

    public static readonly Instruction vandnpd = new (Mnemonic.Vandnpd);

    public static readonly Instruction vandnps = new (Mnemonic.Vandnps);

    public static readonly Instruction vandpd = new (Mnemonic.Vandpd);

    public static readonly Instruction vandps = new (Mnemonic.Vandps);

    public static readonly Instruction vblendmpd = new (Mnemonic.Vblendmpd);

    public static readonly Instruction vblendmps = new (Mnemonic.Vblendmps);

    public static readonly Instruction vblendpd = new (Mnemonic.Vblendpd);

    public static readonly Instruction vblendps = new (Mnemonic.Vblendps);

    public static readonly Instruction vblendvpd = new (Mnemonic.Vblendvpd);

    public static readonly Instruction vblendvps = new (Mnemonic.Vblendvps);

    public static readonly Instruction vbroadcastf128 = new (Mnemonic.Vbroadcastf128);

    public static readonly Instruction vbroadcastf32x2 = new (Mnemonic.Vbroadcastf32x2);

    public static readonly Instruction vbroadcastf32x4 = new (Mnemonic.Vbroadcastf32x4);

    public static readonly Instruction vbroadcastf32x8 = new (Mnemonic.Vbroadcastf32x8);

    public static readonly Instruction vbroadcastf64x2 = new (Mnemonic.Vbroadcastf64x2);

    public static readonly Instruction vbroadcastf64x4 = new (Mnemonic.Vbroadcastf64x4);

    public static readonly Instruction vbroadcasti128 = new (Mnemonic.Vbroadcasti128);

    public static readonly Instruction vbroadcasti32x2 = new (Mnemonic.Vbroadcasti32x2);

    public static readonly Instruction vbroadcasti32x4 = new (Mnemonic.Vbroadcasti32x4);

    public static readonly Instruction vbroadcasti32x8 = new (Mnemonic.Vbroadcasti32x8);

    public static readonly Instruction vbroadcasti64x2 = new (Mnemonic.Vbroadcasti64x2);

    public static readonly Instruction vbroadcasti64x4 = new (Mnemonic.Vbroadcasti64x4);

    public static readonly Instruction vbroadcastsd = new (Mnemonic.Vbroadcastsd);

    public static readonly Instruction vbroadcastss = new (Mnemonic.Vbroadcastss);

    public static readonly Instruction vcmppd = new (Mnemonic.Vcmppd);

    public static readonly Instruction vcmpps = new (Mnemonic.Vcmpps);

    public static readonly Instruction vcmpsd = new (Mnemonic.Vcmpsd);

    public static readonly Instruction vcmpss = new (Mnemonic.Vcmpss);

    public static readonly Instruction vcomisd = new (Mnemonic.Vcomisd);

    public static readonly Instruction vcomiss = new (Mnemonic.Vcomiss);

    public static readonly Instruction vcompresspd = new (Mnemonic.Vcompresspd);

    public static readonly Instruction vcompressps = new (Mnemonic.Vcompressps);

    public static readonly Instruction vcvtdq2pd = new (Mnemonic.Vcvtdq2pd);

    public static readonly Instruction vcvtdq2ps = new (Mnemonic.Vcvtdq2ps);

    public static readonly Instruction vcvtne2ps2bf16 = new (Mnemonic.Vcvtne2ps2bf16);

    public static readonly Instruction vcvtneps2bf16 = new (Mnemonic.Vcvtneps2bf16);

    public static readonly Instruction vcvtpd2dq = new (Mnemonic.Vcvtpd2dq);

    public static readonly Instruction vcvtpd2ps = new (Mnemonic.Vcvtpd2ps);

    public static readonly Instruction vcvtpd2qq = new (Mnemonic.Vcvtpd2qq);

    public static readonly Instruction vcvtpd2udq = new (Mnemonic.Vcvtpd2udq);

    public static readonly Instruction vcvtpd2uqq = new (Mnemonic.Vcvtpd2uqq);

    public static readonly Instruction vcvtph2ps = new (Mnemonic.Vcvtph2ps);

    public static readonly Instruction vcvtps2dq = new (Mnemonic.Vcvtps2dq);

    public static readonly Instruction vcvtps2pd = new (Mnemonic.Vcvtps2pd);

    public static readonly Instruction vcvtps2ph = new (Mnemonic.Vcvtps2ph);

    public static readonly Instruction vcvtps2qq = new (Mnemonic.Vcvtps2qq);

    public static readonly Instruction vcvtps2udq = new (Mnemonic.Vcvtps2udq);

    public static readonly Instruction vcvtps2uqq = new (Mnemonic.Vcvtps2uqq);

    public static readonly Instruction vcvtqq2pd = new (Mnemonic.Vcvtqq2pd);

    public static readonly Instruction vcvtqq2ps = new (Mnemonic.Vcvtqq2ps);

    public static readonly Instruction vcvtsd2si = new (Mnemonic.Vcvtsd2si);

    public static readonly Instruction vcvtsd2ss = new (Mnemonic.Vcvtsd2ss);

    public static readonly Instruction vcvtsd2usi = new (Mnemonic.Vcvtsd2usi);

    public static readonly Instruction vcvtsi2sd = new (Mnemonic.Vcvtsi2sd);

    public static readonly Instruction vcvtsi2ss = new (Mnemonic.Vcvtsi2ss);

    public static readonly Instruction vcvtss2sd = new (Mnemonic.Vcvtss2sd);

    public static readonly Instruction vcvtss2si = new (Mnemonic.Vcvtss2si);

    public static readonly Instruction vcvtss2usi = new (Mnemonic.Vcvtss2usi);

    public static readonly Instruction vcvttpd2dq = new (Mnemonic.Vcvttpd2dq);

    public static readonly Instruction vcvttpd2qq = new (Mnemonic.Vcvttpd2qq);

    public static readonly Instruction vcvttpd2udq = new (Mnemonic.Vcvttpd2udq);

    public static readonly Instruction vcvttpd2uqq = new (Mnemonic.Vcvttpd2uqq);

    public static readonly Instruction vcvttps2dq = new (Mnemonic.Vcvttps2dq);

    public static readonly Instruction vcvttps2qq = new (Mnemonic.Vcvttps2qq);

    public static readonly Instruction vcvttps2udq = new (Mnemonic.Vcvttps2udq);

    public static readonly Instruction vcvttps2uqq = new (Mnemonic.Vcvttps2uqq);

    public static readonly Instruction vcvttsd2si = new (Mnemonic.Vcvttsd2si);

    public static readonly Instruction vcvttsd2usi = new (Mnemonic.Vcvttsd2usi);

    public static readonly Instruction vcvttss2si = new (Mnemonic.Vcvttss2si);

    public static readonly Instruction vcvttss2usi = new (Mnemonic.Vcvttss2usi);

    public static readonly Instruction vcvtudq2pd = new (Mnemonic.Vcvtudq2pd);

    public static readonly Instruction vcvtudq2ps = new (Mnemonic.Vcvtudq2ps);

    public static readonly Instruction vcvtuqq2pd = new (Mnemonic.Vcvtuqq2pd);

    public static readonly Instruction vcvtuqq2ps = new (Mnemonic.Vcvtuqq2ps);

    public static readonly Instruction vcvtusi2sd = new (Mnemonic.Vcvtusi2sd);

    public static readonly Instruction vcvtusi2ss = new (Mnemonic.Vcvtusi2ss);

    public static readonly Instruction vdbpsadbw = new (Mnemonic.Vdbpsadbw);

    public static readonly Instruction vdivpd = new (Mnemonic.Vdivpd);

    public static readonly Instruction vdivps = new (Mnemonic.Vdivps);

    public static readonly Instruction vdivsd = new (Mnemonic.Vdivsd);

    public static readonly Instruction vdivss = new (Mnemonic.Vdivss);

    public static readonly Instruction vdpbf16ps = new (Mnemonic.Vdpbf16ps);

    public static readonly Instruction vdppd = new (Mnemonic.Vdppd);

    public static readonly Instruction vdpps = new (Mnemonic.Vdpps);

    public static readonly Instruction verr = new (Mnemonic.Verr);

    public static readonly Instruction verw = new (Mnemonic.Verw);

    public static readonly Instruction vexp2pd = new (Mnemonic.Vexp2pd);

    public static readonly Instruction vexp2ps = new (Mnemonic.Vexp2ps);

    public static readonly Instruction vexpandpd = new (Mnemonic.Vexpandpd);

    public static readonly Instruction vexpandps = new (Mnemonic.Vexpandps);

    public static readonly Instruction vextractf128 = new (Mnemonic.Vextractf128);

    public static readonly Instruction vextractf32x4 = new (Mnemonic.Vextractf32x4);

    public static readonly Instruction vextractf32x8 = new (Mnemonic.Vextractf32x8);

    public static readonly Instruction vextractf64x2 = new (Mnemonic.Vextractf64x2);

    public static readonly Instruction vextractf64x4 = new (Mnemonic.Vextractf64x4);

    public static readonly Instruction vextracti128 = new (Mnemonic.Vextracti128);

    public static readonly Instruction vextracti32x4 = new (Mnemonic.Vextracti32x4);

    public static readonly Instruction vextracti32x8 = new (Mnemonic.Vextracti32x8);

    public static readonly Instruction vextracti64x2 = new (Mnemonic.Vextracti64x2);

    public static readonly Instruction vextracti64x4 = new (Mnemonic.Vextracti64x4);

    public static readonly Instruction vextractps = new (Mnemonic.Vextractps);

    public static readonly Instruction vfixupimmpd = new (Mnemonic.Vfixupimmpd);

    public static readonly Instruction vfixupimmps = new (Mnemonic.Vfixupimmps);

    public static readonly Instruction vfixupimmsd = new (Mnemonic.Vfixupimmsd);

    public static readonly Instruction vfixupimmss = new (Mnemonic.Vfixupimmss);

    public static readonly Instruction vfmadd132pd = new (Mnemonic.Vfmadd132pd);

    public static readonly Instruction vfmadd132ps = new (Mnemonic.Vfmadd132ps);

    public static readonly Instruction vfmadd132sd = new (Mnemonic.Vfmadd132sd);

    public static readonly Instruction vfmadd132ss = new (Mnemonic.Vfmadd132ss);

    public static readonly Instruction vfmadd213pd = new (Mnemonic.Vfmadd213pd);

    public static readonly Instruction vfmadd213ps = new (Mnemonic.Vfmadd213ps);

    public static readonly Instruction vfmadd213sd = new (Mnemonic.Vfmadd213sd);

    public static readonly Instruction vfmadd213ss = new (Mnemonic.Vfmadd213ss);

    public static readonly Instruction vfmadd231pd = new (Mnemonic.Vfmadd231pd);

    public static readonly Instruction vfmadd231ps = new (Mnemonic.Vfmadd231ps);

    public static readonly Instruction vfmadd231sd = new (Mnemonic.Vfmadd231sd);

    public static readonly Instruction vfmadd231ss = new (Mnemonic.Vfmadd231ss);

    public static readonly Instruction vfmaddpd = new (Mnemonic.Vfmaddpd);

    public static readonly Instruction vfmaddps = new (Mnemonic.Vfmaddps);

    public static readonly Instruction vfmaddsd = new (Mnemonic.Vfmaddsd);

    public static readonly Instruction vfmaddss = new (Mnemonic.Vfmaddss);

    public static readonly Instruction vfmaddsub132pd = new (Mnemonic.Vfmaddsub132pd);

    public static readonly Instruction vfmaddsub132ps = new (Mnemonic.Vfmaddsub132ps);

    public static readonly Instruction vfmaddsub213pd = new (Mnemonic.Vfmaddsub213pd);

    public static readonly Instruction vfmaddsub213ps = new (Mnemonic.Vfmaddsub213ps);

    public static readonly Instruction vfmaddsub231pd = new (Mnemonic.Vfmaddsub231pd);

    public static readonly Instruction vfmaddsub231ps = new (Mnemonic.Vfmaddsub231ps);

    public static readonly Instruction vfmaddsubpd = new (Mnemonic.Vfmaddsubpd);

    public static readonly Instruction vfmaddsubps = new (Mnemonic.Vfmaddsubps);

    public static readonly Instruction vfmsub132pd = new (Mnemonic.Vfmsub132pd);

    public static readonly Instruction vfmsub132ps = new (Mnemonic.Vfmsub132ps);

    public static readonly Instruction vfmsub132sd = new (Mnemonic.Vfmsub132sd);

    public static readonly Instruction vfmsub132ss = new (Mnemonic.Vfmsub132ss);

    public static readonly Instruction vfmsub213pd = new (Mnemonic.Vfmsub213pd);

    public static readonly Instruction vfmsub213ps = new (Mnemonic.Vfmsub213ps);

    public static readonly Instruction vfmsub213sd = new (Mnemonic.Vfmsub213sd);

    public static readonly Instruction vfmsub213ss = new (Mnemonic.Vfmsub213ss);

    public static readonly Instruction vfmsub231pd = new (Mnemonic.Vfmsub231pd);

    public static readonly Instruction vfmsub231ps = new (Mnemonic.Vfmsub231ps);

    public static readonly Instruction vfmsub231sd = new (Mnemonic.Vfmsub231sd);

    public static readonly Instruction vfmsub231ss = new (Mnemonic.Vfmsub231ss);

    public static readonly Instruction vfmsubadd132pd = new (Mnemonic.Vfmsubadd132pd);

    public static readonly Instruction vfmsubadd132ps = new (Mnemonic.Vfmsubadd132ps);

    public static readonly Instruction vfmsubadd213pd = new (Mnemonic.Vfmsubadd213pd);

    public static readonly Instruction vfmsubadd213ps = new (Mnemonic.Vfmsubadd213ps);

    public static readonly Instruction vfmsubadd231pd = new (Mnemonic.Vfmsubadd231pd);

    public static readonly Instruction vfmsubadd231ps = new (Mnemonic.Vfmsubadd231ps);

    public static readonly Instruction vfmsubaddpd = new (Mnemonic.Vfmsubaddpd);

    public static readonly Instruction vfmsubaddps = new (Mnemonic.Vfmsubaddps);

    public static readonly Instruction vfmsubpd = new (Mnemonic.Vfmsubpd);

    public static readonly Instruction vfmsubps = new (Mnemonic.Vfmsubps);

    public static readonly Instruction vfmsubsd = new (Mnemonic.Vfmsubsd);

    public static readonly Instruction vfmsubss = new (Mnemonic.Vfmsubss);

    public static readonly Instruction vfnmadd132pd = new (Mnemonic.Vfnmadd132pd);

    public static readonly Instruction vfnmadd132ps = new (Mnemonic.Vfnmadd132ps);

    public static readonly Instruction vfnmadd132sd = new (Mnemonic.Vfnmadd132sd);

    public static readonly Instruction vfnmadd132ss = new (Mnemonic.Vfnmadd132ss);

    public static readonly Instruction vfnmadd213pd = new (Mnemonic.Vfnmadd213pd);

    public static readonly Instruction vfnmadd213ps = new (Mnemonic.Vfnmadd213ps);

    public static readonly Instruction vfnmadd213sd = new (Mnemonic.Vfnmadd213sd);

    public static readonly Instruction vfnmadd213ss = new (Mnemonic.Vfnmadd213ss);

    public static readonly Instruction vfnmadd231pd = new (Mnemonic.Vfnmadd231pd);

    public static readonly Instruction vfnmadd231ps = new (Mnemonic.Vfnmadd231ps);

    public static readonly Instruction vfnmadd231sd = new (Mnemonic.Vfnmadd231sd);

    public static readonly Instruction vfnmadd231ss = new (Mnemonic.Vfnmadd231ss);

    public static readonly Instruction vfnmaddpd = new (Mnemonic.Vfnmaddpd);

    public static readonly Instruction vfnmaddps = new (Mnemonic.Vfnmaddps);

    public static readonly Instruction vfnmaddsd = new (Mnemonic.Vfnmaddsd);

    public static readonly Instruction vfnmaddss = new (Mnemonic.Vfnmaddss);

    public static readonly Instruction vfnmsub132pd = new (Mnemonic.Vfnmsub132pd);

    public static readonly Instruction vfnmsub132ps = new (Mnemonic.Vfnmsub132ps);

    public static readonly Instruction vfnmsub132sd = new (Mnemonic.Vfnmsub132sd);

    public static readonly Instruction vfnmsub132ss = new (Mnemonic.Vfnmsub132ss);

    public static readonly Instruction vfnmsub213pd = new (Mnemonic.Vfnmsub213pd);

    public static readonly Instruction vfnmsub213ps = new (Mnemonic.Vfnmsub213ps);

    public static readonly Instruction vfnmsub213sd = new (Mnemonic.Vfnmsub213sd);

    public static readonly Instruction vfnmsub213ss = new (Mnemonic.Vfnmsub213ss);

    public static readonly Instruction vfnmsub231pd = new (Mnemonic.Vfnmsub231pd);

    public static readonly Instruction vfnmsub231ps = new (Mnemonic.Vfnmsub231ps);

    public static readonly Instruction vfnmsub231sd = new (Mnemonic.Vfnmsub231sd);

    public static readonly Instruction vfnmsub231ss = new (Mnemonic.Vfnmsub231ss);

    public static readonly Instruction vfnmsubpd = new (Mnemonic.Vfnmsubpd);

    public static readonly Instruction vfnmsubps = new (Mnemonic.Vfnmsubps);

    public static readonly Instruction vfnmsubsd = new (Mnemonic.Vfnmsubsd);

    public static readonly Instruction vfnmsubss = new (Mnemonic.Vfnmsubss);

    public static readonly Instruction vfpclasspd = new (Mnemonic.Vfpclasspd);

    public static readonly Instruction vfpclassps = new (Mnemonic.Vfpclassps);

    public static readonly Instruction vfpclasssd = new (Mnemonic.Vfpclasssd);

    public static readonly Instruction vfpclassss = new (Mnemonic.Vfpclassss);

    public static readonly Instruction vfrczpd = new (Mnemonic.Vfrczpd);

    public static readonly Instruction vfrczps = new (Mnemonic.Vfrczps);

    public static readonly Instruction vfrczsd = new (Mnemonic.Vfrczsd);

    public static readonly Instruction vfrczss = new (Mnemonic.Vfrczss);

    public static readonly Instruction vgatherdpd = new (Mnemonic.Vgatherdpd);

    public static readonly Instruction vgatherdps = new (Mnemonic.Vgatherdps);

    public static readonly Instruction vgatherpf0dpd = new (Mnemonic.Vgatherpf0dpd);

    public static readonly Instruction vgatherpf0dps = new (Mnemonic.Vgatherpf0dps);

    public static readonly Instruction vgatherpf0qpd = new (Mnemonic.Vgatherpf0qpd);

    public static readonly Instruction vgatherpf0qps = new (Mnemonic.Vgatherpf0qps);

    public static readonly Instruction vgatherpf1dpd = new (Mnemonic.Vgatherpf1dpd);

    public static readonly Instruction vgatherpf1dps = new (Mnemonic.Vgatherpf1dps);

    public static readonly Instruction vgatherpf1qpd = new (Mnemonic.Vgatherpf1qpd);

    public static readonly Instruction vgatherpf1qps = new (Mnemonic.Vgatherpf1qps);

    public static readonly Instruction vgatherqpd = new (Mnemonic.Vgatherqpd);

    public static readonly Instruction vgatherqps = new (Mnemonic.Vgatherqps);

    public static readonly Instruction vgetexppd = new (Mnemonic.Vgetexppd);

    public static readonly Instruction vgetexpps = new (Mnemonic.Vgetexpps);

    public static readonly Instruction vgetexpsd = new (Mnemonic.Vgetexpsd);

    public static readonly Instruction vgetexpss = new (Mnemonic.Vgetexpss);

    public static readonly Instruction vgetmantpd = new (Mnemonic.Vgetmantpd);

    public static readonly Instruction vgetmantps = new (Mnemonic.Vgetmantps);

    public static readonly Instruction vgetmantsd = new (Mnemonic.Vgetmantsd);

    public static readonly Instruction vgetmantss = new (Mnemonic.Vgetmantss);

    public static readonly Instruction vgf2p8affineinvqb = new (Mnemonic.Vgf2p8affineinvqb);

    public static readonly Instruction vgf2p8affineqb = new (Mnemonic.Vgf2p8affineqb);

    public static readonly Instruction vgf2p8mulb = new (Mnemonic.Vgf2p8mulb);

    public static readonly Instruction vhaddpd = new (Mnemonic.Vhaddpd);

    public static readonly Instruction vhaddps = new (Mnemonic.Vhaddps);

    public static readonly Instruction vhsubpd = new (Mnemonic.Vhsubpd);

    public static readonly Instruction vhsubps = new (Mnemonic.Vhsubps);

    public static readonly Instruction vinsertf128 = new (Mnemonic.Vinsertf128);

    public static readonly Instruction vinsertf32x4 = new (Mnemonic.Vinsertf32x4);

    public static readonly Instruction vinsertf32x8 = new (Mnemonic.Vinsertf32x8);

    public static readonly Instruction vinsertf64x2 = new (Mnemonic.Vinsertf64x2);

    public static readonly Instruction vinsertf64x4 = new (Mnemonic.Vinsertf64x4);

    public static readonly Instruction vinserti128 = new (Mnemonic.Vinserti128);

    public static readonly Instruction vinserti32x4 = new (Mnemonic.Vinserti32x4);

    public static readonly Instruction vinserti32x8 = new (Mnemonic.Vinserti32x8);

    public static readonly Instruction vinserti64x2 = new (Mnemonic.Vinserti64x2);

    public static readonly Instruction vinserti64x4 = new (Mnemonic.Vinserti64x4);

    public static readonly Instruction vinsertps = new (Mnemonic.Vinsertps);

    public static readonly Instruction vlddqu = new (Mnemonic.Vlddqu);

    public static readonly Instruction vldmxcsr = new (Mnemonic.Vldmxcsr);

    public static readonly Instruction vmaskmovdqu = new (Mnemonic.Vmaskmovdqu);

    public static readonly Instruction vmaskmovpd = new (Mnemonic.Vmaskmovpd);

    public static readonly Instruction vmaskmovps = new (Mnemonic.Vmaskmovps);

    public static readonly Instruction vmaxpd = new (Mnemonic.Vmaxpd);

    public static readonly Instruction vmaxps = new (Mnemonic.Vmaxps);

    public static readonly Instruction vmaxsd = new (Mnemonic.Vmaxsd);

    public static readonly Instruction vmaxss = new (Mnemonic.Vmaxss);

    public static readonly Instruction vmcall = new (Mnemonic.Vmcall);

    public static readonly Instruction vmclear = new (Mnemonic.Vmclear);

    public static readonly Instruction vmfunc = new (Mnemonic.Vmfunc);

    public static readonly Instruction vminpd = new (Mnemonic.Vminpd);

    public static readonly Instruction vminps = new (Mnemonic.Vminps);

    public static readonly Instruction vminsd = new (Mnemonic.Vminsd);

    public static readonly Instruction vminss = new (Mnemonic.Vminss);

    public static readonly Instruction vmlaunch = new (Mnemonic.Vmlaunch);

    public static readonly Instruction vmload = new (Mnemonic.Vmload);

    public static readonly Instruction vmmcall = new (Mnemonic.Vmmcall);

    public static readonly Instruction vmovapd = new (Mnemonic.Vmovapd);

    public static readonly Instruction vmovaps = new (Mnemonic.Vmovaps);

    public static readonly Instruction vmovd = new (Mnemonic.Vmovd);

    public static readonly Instruction vmovddup = new (Mnemonic.Vmovddup);

    public static readonly Instruction vmovdqa = new (Mnemonic.Vmovdqa);

    public static readonly Instruction vmovdqa32 = new (Mnemonic.Vmovdqa32);

    public static readonly Instruction vmovdqa64 = new (Mnemonic.Vmovdqa64);

    public static readonly Instruction vmovdqu = new (Mnemonic.Vmovdqu);

    public static readonly Instruction vmovdqu16 = new (Mnemonic.Vmovdqu16);

    public static readonly Instruction vmovdqu32 = new (Mnemonic.Vmovdqu32);

    public static readonly Instruction vmovdqu64 = new (Mnemonic.Vmovdqu64);

    public static readonly Instruction vmovdqu8 = new (Mnemonic.Vmovdqu8);

    public static readonly Instruction vmovhlps = new (Mnemonic.Vmovhlps);

    public static readonly Instruction vmovhpd = new (Mnemonic.Vmovhpd);

    public static readonly Instruction vmovhps = new (Mnemonic.Vmovhps);

    public static readonly Instruction vmovlhps = new (Mnemonic.Vmovlhps);

    public static readonly Instruction vmovlpd = new (Mnemonic.Vmovlpd);

    public static readonly Instruction vmovlps = new (Mnemonic.Vmovlps);

    public static readonly Instruction vmovmskpd = new (Mnemonic.Vmovmskpd);

    public static readonly Instruction vmovmskps = new (Mnemonic.Vmovmskps);

    public static readonly Instruction vmovntdq = new (Mnemonic.Vmovntdq);

    public static readonly Instruction vmovntdqa = new (Mnemonic.Vmovntdqa);

    public static readonly Instruction vmovntpd = new (Mnemonic.Vmovntpd);

    public static readonly Instruction vmovntps = new (Mnemonic.Vmovntps);

    public static readonly Instruction vmovq = new (Mnemonic.Vmovq);

    public static readonly Instruction vmovsd = new (Mnemonic.Vmovsd);

    public static readonly Instruction vmovshdup = new (Mnemonic.Vmovshdup);

    public static readonly Instruction vmovsldup = new (Mnemonic.Vmovsldup);

    public static readonly Instruction vmovss = new (Mnemonic.Vmovss);

    public static readonly Instruction vmovupd = new (Mnemonic.Vmovupd);

    public static readonly Instruction vmovups = new (Mnemonic.Vmovups);

    public static readonly Instruction vmpsadbw = new (Mnemonic.Vmpsadbw);

    public static readonly Instruction vmptrld = new (Mnemonic.Vmptrld);

    public static readonly Instruction vmptrst = new (Mnemonic.Vmptrst);

    public static readonly Instruction vmread = new (Mnemonic.Vmread);

    public static readonly Instruction vmresume = new (Mnemonic.Vmresume);

    public static readonly Instruction vmrun = new (Mnemonic.Vmrun);

    public static readonly Instruction vmsave = new (Mnemonic.Vmsave);

    public static readonly Instruction vmulpd = new (Mnemonic.Vmulpd);

    public static readonly Instruction vmulps = new (Mnemonic.Vmulps);

    public static readonly Instruction vmulsd = new (Mnemonic.Vmulsd);

    public static readonly Instruction vmulss = new (Mnemonic.Vmulss);

    public static readonly Instruction vmwrite = new (Mnemonic.Vmwrite);

    public static readonly Instruction vmxoff = new (Mnemonic.Vmxoff);

    public static readonly Instruction vmxon = new (Mnemonic.Vmxon);

    public static readonly Instruction vorpd = new (Mnemonic.Vorpd);

    public static readonly Instruction vorps = new (Mnemonic.Vorps);

    public static readonly Instruction vp2intersectd = new (Mnemonic.Vp2intersectd);

    public static readonly Instruction vp2intersectq = new (Mnemonic.Vp2intersectq);

    public static readonly Instruction vp4dpwssd = new (Mnemonic.Vp4dpwssd);

    public static readonly Instruction vp4dpwssds = new (Mnemonic.Vp4dpwssds);

    public static readonly Instruction vpabsb = new (Mnemonic.Vpabsb);

    public static readonly Instruction vpabsd = new (Mnemonic.Vpabsd);

    public static readonly Instruction vpabsq = new (Mnemonic.Vpabsq);

    public static readonly Instruction vpabsw = new (Mnemonic.Vpabsw);

    public static readonly Instruction vpackssdw = new (Mnemonic.Vpackssdw);

    public static readonly Instruction vpacksswb = new (Mnemonic.Vpacksswb);

    public static readonly Instruction vpackusdw = new (Mnemonic.Vpackusdw);

    public static readonly Instruction vpackuswb = new (Mnemonic.Vpackuswb);

    public static readonly Instruction vpaddb = new (Mnemonic.Vpaddb);

    public static readonly Instruction vpaddd = new (Mnemonic.Vpaddd);

    public static readonly Instruction vpaddq = new (Mnemonic.Vpaddq);

    public static readonly Instruction vpaddsb = new (Mnemonic.Vpaddsb);

    public static readonly Instruction vpaddsw = new (Mnemonic.Vpaddsw);

    public static readonly Instruction vpaddusb = new (Mnemonic.Vpaddusb);

    public static readonly Instruction vpaddusw = new (Mnemonic.Vpaddusw);

    public static readonly Instruction vpaddw = new (Mnemonic.Vpaddw);

    public static readonly Instruction vpalignr = new (Mnemonic.Vpalignr);

    public static readonly Instruction vpand = new (Mnemonic.Vpand);

    public static readonly Instruction vpandd = new (Mnemonic.Vpandd);

    public static readonly Instruction vpandn = new (Mnemonic.Vpandn);

    public static readonly Instruction vpandnd = new (Mnemonic.Vpandnd);

    public static readonly Instruction vpandnq = new (Mnemonic.Vpandnq);

    public static readonly Instruction vpandq = new (Mnemonic.Vpandq);

    public static readonly Instruction vpavgb = new (Mnemonic.Vpavgb);

    public static readonly Instruction vpavgw = new (Mnemonic.Vpavgw);

    public static readonly Instruction vpblendd = new (Mnemonic.Vpblendd);

    public static readonly Instruction vpblendmb = new (Mnemonic.Vpblendmb);

    public static readonly Instruction vpblendmd = new (Mnemonic.Vpblendmd);

    public static readonly Instruction vpblendmq = new (Mnemonic.Vpblendmq);

    public static readonly Instruction vpblendmw = new (Mnemonic.Vpblendmw);

    public static readonly Instruction vpblendvb = new (Mnemonic.Vpblendvb);

    public static readonly Instruction vpblendw = new (Mnemonic.Vpblendw);

    public static readonly Instruction vpbroadcastb = new (Mnemonic.Vpbroadcastb);

    public static readonly Instruction vpbroadcastd = new (Mnemonic.Vpbroadcastd);

    public static readonly Instruction vpbroadcastmb2q = new (Mnemonic.Vpbroadcastmb2q);

    public static readonly Instruction vpbroadcastmw2d = new (Mnemonic.Vpbroadcastmw2d);

    public static readonly Instruction vpbroadcastq = new (Mnemonic.Vpbroadcastq);

    public static readonly Instruction vpbroadcastw = new (Mnemonic.Vpbroadcastw);

    public static readonly Instruction vpclmulqdq = new (Mnemonic.Vpclmulqdq);

    public static readonly Instruction vpcmov = new (Mnemonic.Vpcmov);

    public static readonly Instruction vpcmpb = new (Mnemonic.Vpcmpb);

    public static readonly Instruction vpcmpd = new (Mnemonic.Vpcmpd);

    public static readonly Instruction vpcmpeqb = new (Mnemonic.Vpcmpeqb);

    public static readonly Instruction vpcmpeqd = new (Mnemonic.Vpcmpeqd);

    public static readonly Instruction vpcmpeqq = new (Mnemonic.Vpcmpeqq);

    public static readonly Instruction vpcmpeqw = new (Mnemonic.Vpcmpeqw);

    public static readonly Instruction vpcmpestri = new (Mnemonic.Vpcmpestri);

    public static readonly Instruction vpcmpestri64 = new (Mnemonic.Vpcmpestri64);

    public static readonly Instruction vpcmpestrm = new (Mnemonic.Vpcmpestrm);

    public static readonly Instruction vpcmpestrm64 = new (Mnemonic.Vpcmpestrm64);

    public static readonly Instruction vpcmpgtb = new (Mnemonic.Vpcmpgtb);

    public static readonly Instruction vpcmpgtd = new (Mnemonic.Vpcmpgtd);

    public static readonly Instruction vpcmpgtq = new (Mnemonic.Vpcmpgtq);

    public static readonly Instruction vpcmpgtw = new (Mnemonic.Vpcmpgtw);

    public static readonly Instruction vpcmpistri = new (Mnemonic.Vpcmpistri);

    public static readonly Instruction vpcmpistrm = new (Mnemonic.Vpcmpistrm);

    public static readonly Instruction vpcmpq = new (Mnemonic.Vpcmpq);

    public static readonly Instruction vpcmpub = new (Mnemonic.Vpcmpub);

    public static readonly Instruction vpcmpud = new (Mnemonic.Vpcmpud);

    public static readonly Instruction vpcmpuq = new (Mnemonic.Vpcmpuq);

    public static readonly Instruction vpcmpuw = new (Mnemonic.Vpcmpuw);

    public static readonly Instruction vpcmpw = new (Mnemonic.Vpcmpw);

    public static readonly Instruction vpcomb = new (Mnemonic.Vpcomb);

    public static readonly Instruction vpcomd = new (Mnemonic.Vpcomd);

    public static readonly Instruction vpcompressb = new (Mnemonic.Vpcompressb);

    public static readonly Instruction vpcompressd = new (Mnemonic.Vpcompressd);

    public static readonly Instruction vpcompressq = new (Mnemonic.Vpcompressq);

    public static readonly Instruction vpcompressw = new (Mnemonic.Vpcompressw);

    public static readonly Instruction vpcomq = new (Mnemonic.Vpcomq);

    public static readonly Instruction vpcomub = new (Mnemonic.Vpcomub);

    public static readonly Instruction vpcomud = new (Mnemonic.Vpcomud);

    public static readonly Instruction vpcomuq = new (Mnemonic.Vpcomuq);

    public static readonly Instruction vpcomuw = new (Mnemonic.Vpcomuw);

    public static readonly Instruction vpcomw = new (Mnemonic.Vpcomw);

    public static readonly Instruction vpconflictd = new (Mnemonic.Vpconflictd);

    public static readonly Instruction vpconflictq = new (Mnemonic.Vpconflictq);

    public static readonly Instruction vpdpbusd = new (Mnemonic.Vpdpbusd);

    public static readonly Instruction vpdpbusds = new (Mnemonic.Vpdpbusds);

    public static readonly Instruction vpdpwssd = new (Mnemonic.Vpdpwssd);

    public static readonly Instruction vpdpwssds = new (Mnemonic.Vpdpwssds);

    public static readonly Instruction vperm2f128 = new (Mnemonic.Vperm2f128);

    public static readonly Instruction vperm2i128 = new (Mnemonic.Vperm2i128);

    public static readonly Instruction vpermb = new (Mnemonic.Vpermb);

    public static readonly Instruction vpermd = new (Mnemonic.Vpermd);

    public static readonly Instruction vpermi2b = new (Mnemonic.Vpermi2b);

    public static readonly Instruction vpermi2d = new (Mnemonic.Vpermi2d);

    public static readonly Instruction vpermi2pd = new (Mnemonic.Vpermi2pd);

    public static readonly Instruction vpermi2ps = new (Mnemonic.Vpermi2ps);

    public static readonly Instruction vpermi2q = new (Mnemonic.Vpermi2q);

    public static readonly Instruction vpermi2w = new (Mnemonic.Vpermi2w);

    public static readonly Instruction vpermil2pd = new (Mnemonic.Vpermil2pd);

    public static readonly Instruction vpermil2ps = new (Mnemonic.Vpermil2ps);

    public static readonly Instruction vpermilpd = new (Mnemonic.Vpermilpd);

    public static readonly Instruction vpermilps = new (Mnemonic.Vpermilps);

    public static readonly Instruction vpermpd = new (Mnemonic.Vpermpd);

    public static readonly Instruction vpermps = new (Mnemonic.Vpermps);

    public static readonly Instruction vpermq = new (Mnemonic.Vpermq);

    public static readonly Instruction vpermt2b = new (Mnemonic.Vpermt2b);

    public static readonly Instruction vpermt2d = new (Mnemonic.Vpermt2d);

    public static readonly Instruction vpermt2pd = new (Mnemonic.Vpermt2pd);

    public static readonly Instruction vpermt2ps = new (Mnemonic.Vpermt2ps);

    public static readonly Instruction vpermt2q = new (Mnemonic.Vpermt2q);

    public static readonly Instruction vpermt2w = new (Mnemonic.Vpermt2w);

    public static readonly Instruction vpermw = new (Mnemonic.Vpermw);

    public static readonly Instruction vpexpandb = new (Mnemonic.Vpexpandb);

    public static readonly Instruction vpexpandd = new (Mnemonic.Vpexpandd);

    public static readonly Instruction vpexpandq = new (Mnemonic.Vpexpandq);

    public static readonly Instruction vpexpandw = new (Mnemonic.Vpexpandw);

    public static readonly Instruction vpextrb = new (Mnemonic.Vpextrb);

    public static readonly Instruction vpextrd = new (Mnemonic.Vpextrd);

    public static readonly Instruction vpextrq = new (Mnemonic.Vpextrq);

    public static readonly Instruction vpextrw = new (Mnemonic.Vpextrw);

    public static readonly Instruction vpgatherdd = new (Mnemonic.Vpgatherdd);

    public static readonly Instruction vpgatherdq = new (Mnemonic.Vpgatherdq);

    public static readonly Instruction vpgatherqd = new (Mnemonic.Vpgatherqd);

    public static readonly Instruction vpgatherqq = new (Mnemonic.Vpgatherqq);

    public static readonly Instruction vphaddbd = new (Mnemonic.Vphaddbd);

    public static readonly Instruction vphaddbq = new (Mnemonic.Vphaddbq);

    public static readonly Instruction vphaddbw = new (Mnemonic.Vphaddbw);

    public static readonly Instruction vphaddd = new (Mnemonic.Vphaddd);

    public static readonly Instruction vphadddq = new (Mnemonic.Vphadddq);

    public static readonly Instruction vphaddsw = new (Mnemonic.Vphaddsw);

    public static readonly Instruction vphaddubd = new (Mnemonic.Vphaddubd);

    public static readonly Instruction vphaddubq = new (Mnemonic.Vphaddubq);

    public static readonly Instruction vphaddubw = new (Mnemonic.Vphaddubw);

    public static readonly Instruction vphaddudq = new (Mnemonic.Vphaddudq);

    public static readonly Instruction vphadduwd = new (Mnemonic.Vphadduwd);

    public static readonly Instruction vphadduwq = new (Mnemonic.Vphadduwq);

    public static readonly Instruction vphaddw = new (Mnemonic.Vphaddw);

    public static readonly Instruction vphaddwd = new (Mnemonic.Vphaddwd);

    public static readonly Instruction vphaddwq = new (Mnemonic.Vphaddwq);

    public static readonly Instruction vphminposuw = new (Mnemonic.Vphminposuw);

    public static readonly Instruction vphsubbw = new (Mnemonic.Vphsubbw);

    public static readonly Instruction vphsubd = new (Mnemonic.Vphsubd);

    public static readonly Instruction vphsubdq = new (Mnemonic.Vphsubdq);

    public static readonly Instruction vphsubsw = new (Mnemonic.Vphsubsw);

    public static readonly Instruction vphsubw = new (Mnemonic.Vphsubw);

    public static readonly Instruction vphsubwd = new (Mnemonic.Vphsubwd);

    public static readonly Instruction vpinsrb = new (Mnemonic.Vpinsrb);

    public static readonly Instruction vpinsrd = new (Mnemonic.Vpinsrd);

    public static readonly Instruction vpinsrq = new (Mnemonic.Vpinsrq);

    public static readonly Instruction vpinsrw = new (Mnemonic.Vpinsrw);

    public static readonly Instruction vplzcntd = new (Mnemonic.Vplzcntd);

    public static readonly Instruction vplzcntq = new (Mnemonic.Vplzcntq);

    public static readonly Instruction vpmacsdd = new (Mnemonic.Vpmacsdd);

    public static readonly Instruction vpmacsdqh = new (Mnemonic.Vpmacsdqh);

    public static readonly Instruction vpmacsdql = new (Mnemonic.Vpmacsdql);

    public static readonly Instruction vpmacssdd = new (Mnemonic.Vpmacssdd);

    public static readonly Instruction vpmacssdqh = new (Mnemonic.Vpmacssdqh);

    public static readonly Instruction vpmacssdql = new (Mnemonic.Vpmacssdql);

    public static readonly Instruction vpmacsswd = new (Mnemonic.Vpmacsswd);

    public static readonly Instruction vpmacssww = new (Mnemonic.Vpmacssww);

    public static readonly Instruction vpmacswd = new (Mnemonic.Vpmacswd);

    public static readonly Instruction vpmacsww = new (Mnemonic.Vpmacsww);

    public static readonly Instruction vpmadcsswd = new (Mnemonic.Vpmadcsswd);

    public static readonly Instruction vpmadcswd = new (Mnemonic.Vpmadcswd);

    public static readonly Instruction vpmadd52huq = new (Mnemonic.Vpmadd52huq);

    public static readonly Instruction vpmadd52luq = new (Mnemonic.Vpmadd52luq);

    public static readonly Instruction vpmaddubsw = new (Mnemonic.Vpmaddubsw);

    public static readonly Instruction vpmaddwd = new (Mnemonic.Vpmaddwd);

    public static readonly Instruction vpmaskmovd = new (Mnemonic.Vpmaskmovd);

    public static readonly Instruction vpmaskmovq = new (Mnemonic.Vpmaskmovq);

    public static readonly Instruction vpmaxsb = new (Mnemonic.Vpmaxsb);

    public static readonly Instruction vpmaxsd = new (Mnemonic.Vpmaxsd);

    public static readonly Instruction vpmaxsq = new (Mnemonic.Vpmaxsq);

    public static readonly Instruction vpmaxsw = new (Mnemonic.Vpmaxsw);

    public static readonly Instruction vpmaxub = new (Mnemonic.Vpmaxub);

    public static readonly Instruction vpmaxud = new (Mnemonic.Vpmaxud);

    public static readonly Instruction vpmaxuq = new (Mnemonic.Vpmaxuq);

    public static readonly Instruction vpmaxuw = new (Mnemonic.Vpmaxuw);

    public static readonly Instruction vpminsb = new (Mnemonic.Vpminsb);

    public static readonly Instruction vpminsd = new (Mnemonic.Vpminsd);

    public static readonly Instruction vpminsq = new (Mnemonic.Vpminsq);

    public static readonly Instruction vpminsw = new (Mnemonic.Vpminsw);

    public static readonly Instruction vpminub = new (Mnemonic.Vpminub);

    public static readonly Instruction vpminud = new (Mnemonic.Vpminud);

    public static readonly Instruction vpminuq = new (Mnemonic.Vpminuq);

    public static readonly Instruction vpminuw = new (Mnemonic.Vpminuw);

    public static readonly Instruction vpmovb2m = new (Mnemonic.Vpmovb2m);

    public static readonly Instruction vpmovd2m = new (Mnemonic.Vpmovd2m);

    public static readonly Instruction vpmovdb = new (Mnemonic.Vpmovdb);

    public static readonly Instruction vpmovdw = new (Mnemonic.Vpmovdw);

    public static readonly Instruction vpmovm2b = new (Mnemonic.Vpmovm2b);

    public static readonly Instruction vpmovm2d = new (Mnemonic.Vpmovm2d);

    public static readonly Instruction vpmovm2q = new (Mnemonic.Vpmovm2q);

    public static readonly Instruction vpmovm2w = new (Mnemonic.Vpmovm2w);

    public static readonly Instruction vpmovmskb = new (Mnemonic.Vpmovmskb);

    public static readonly Instruction vpmovq2m = new (Mnemonic.Vpmovq2m);

    public static readonly Instruction vpmovqb = new (Mnemonic.Vpmovqb);

    public static readonly Instruction vpmovqd = new (Mnemonic.Vpmovqd);

    public static readonly Instruction vpmovqw = new (Mnemonic.Vpmovqw);

    public static readonly Instruction vpmovsdb = new (Mnemonic.Vpmovsdb);

    public static readonly Instruction vpmovsdw = new (Mnemonic.Vpmovsdw);

    public static readonly Instruction vpmovsqb = new (Mnemonic.Vpmovsqb);

    public static readonly Instruction vpmovsqd = new (Mnemonic.Vpmovsqd);

    public static readonly Instruction vpmovsqw = new (Mnemonic.Vpmovsqw);

    public static readonly Instruction vpmovswb = new (Mnemonic.Vpmovswb);

    public static readonly Instruction vpmovsxbd = new (Mnemonic.Vpmovsxbd);

    public static readonly Instruction vpmovsxbq = new (Mnemonic.Vpmovsxbq);

    public static readonly Instruction vpmovsxbw = new (Mnemonic.Vpmovsxbw);

    public static readonly Instruction vpmovsxdq = new (Mnemonic.Vpmovsxdq);

    public static readonly Instruction vpmovsxwd = new (Mnemonic.Vpmovsxwd);

    public static readonly Instruction vpmovsxwq = new (Mnemonic.Vpmovsxwq);

    public static readonly Instruction vpmovusdb = new (Mnemonic.Vpmovusdb);

    public static readonly Instruction vpmovusdw = new (Mnemonic.Vpmovusdw);

    public static readonly Instruction vpmovusqb = new (Mnemonic.Vpmovusqb);

    public static readonly Instruction vpmovusqd = new (Mnemonic.Vpmovusqd);

    public static readonly Instruction vpmovusqw = new (Mnemonic.Vpmovusqw);

    public static readonly Instruction vpmovuswb = new (Mnemonic.Vpmovuswb);

    public static readonly Instruction vpmovw2m = new (Mnemonic.Vpmovw2m);

    public static readonly Instruction vpmovwb = new (Mnemonic.Vpmovwb);

    public static readonly Instruction vpmovzxbd = new (Mnemonic.Vpmovzxbd);

    public static readonly Instruction vpmovzxbq = new (Mnemonic.Vpmovzxbq);

    public static readonly Instruction vpmovzxbw = new (Mnemonic.Vpmovzxbw);

    public static readonly Instruction vpmovzxdq = new (Mnemonic.Vpmovzxdq);

    public static readonly Instruction vpmovzxwd = new (Mnemonic.Vpmovzxwd);

    public static readonly Instruction vpmovzxwq = new (Mnemonic.Vpmovzxwq);

    public static readonly Instruction vpmuldq = new (Mnemonic.Vpmuldq);

    public static readonly Instruction vpmulhrsw = new (Mnemonic.Vpmulhrsw);

    public static readonly Instruction vpmulhuw = new (Mnemonic.Vpmulhuw);

    public static readonly Instruction vpmulhw = new (Mnemonic.Vpmulhw);

    public static readonly Instruction vpmulld = new (Mnemonic.Vpmulld);

    public static readonly Instruction vpmullq = new (Mnemonic.Vpmullq);

    public static readonly Instruction vpmullw = new (Mnemonic.Vpmullw);

    public static readonly Instruction vpmultishiftqb = new (Mnemonic.Vpmultishiftqb);

    public static readonly Instruction vpmuludq = new (Mnemonic.Vpmuludq);

    public static readonly Instruction vpopcntb = new (Mnemonic.Vpopcntb);

    public static readonly Instruction vpopcntd = new (Mnemonic.Vpopcntd);

    public static readonly Instruction vpopcntq = new (Mnemonic.Vpopcntq);

    public static readonly Instruction vpopcntw = new (Mnemonic.Vpopcntw);

    public static readonly Instruction vpor = new (Mnemonic.Vpor);

    public static readonly Instruction vpord = new (Mnemonic.Vpord);

    public static readonly Instruction vporq = new (Mnemonic.Vporq);

    public static readonly Instruction vpperm = new (Mnemonic.Vpperm);

    public static readonly Instruction vprold = new (Mnemonic.Vprold);

    public static readonly Instruction vprolq = new (Mnemonic.Vprolq);

    public static readonly Instruction vprolvd = new (Mnemonic.Vprolvd);

    public static readonly Instruction vprolvq = new (Mnemonic.Vprolvq);

    public static readonly Instruction vprord = new (Mnemonic.Vprord);

    public static readonly Instruction vprorq = new (Mnemonic.Vprorq);

    public static readonly Instruction vprorvd = new (Mnemonic.Vprorvd);

    public static readonly Instruction vprorvq = new (Mnemonic.Vprorvq);

    public static readonly Instruction vprotb = new (Mnemonic.Vprotb);

    public static readonly Instruction vprotd = new (Mnemonic.Vprotd);

    public static readonly Instruction vprotq = new (Mnemonic.Vprotq);

    public static readonly Instruction vprotw = new (Mnemonic.Vprotw);

    public static readonly Instruction vpsadbw = new (Mnemonic.Vpsadbw);

    public static readonly Instruction vpscatterdd = new (Mnemonic.Vpscatterdd);

    public static readonly Instruction vpscatterdq = new (Mnemonic.Vpscatterdq);

    public static readonly Instruction vpscatterqd = new (Mnemonic.Vpscatterqd);

    public static readonly Instruction vpscatterqq = new (Mnemonic.Vpscatterqq);

    public static readonly Instruction vpshab = new (Mnemonic.Vpshab);

    public static readonly Instruction vpshad = new (Mnemonic.Vpshad);

    public static readonly Instruction vpshaq = new (Mnemonic.Vpshaq);

    public static readonly Instruction vpshaw = new (Mnemonic.Vpshaw);

    public static readonly Instruction vpshlb = new (Mnemonic.Vpshlb);

    public static readonly Instruction vpshld = new (Mnemonic.Vpshld);

    public static readonly Instruction vpshldd = new (Mnemonic.Vpshldd);

    public static readonly Instruction vpshldq = new (Mnemonic.Vpshldq);

    public static readonly Instruction vpshldvd = new (Mnemonic.Vpshldvd);

    public static readonly Instruction vpshldvq = new (Mnemonic.Vpshldvq);

    public static readonly Instruction vpshldvw = new (Mnemonic.Vpshldvw);

    public static readonly Instruction vpshldw = new (Mnemonic.Vpshldw);

    public static readonly Instruction vpshlq = new (Mnemonic.Vpshlq);

    public static readonly Instruction vpshlw = new (Mnemonic.Vpshlw);

    public static readonly Instruction vpshrdd = new (Mnemonic.Vpshrdd);

    public static readonly Instruction vpshrdq = new (Mnemonic.Vpshrdq);

    public static readonly Instruction vpshrdvd = new (Mnemonic.Vpshrdvd);

    public static readonly Instruction vpshrdvq = new (Mnemonic.Vpshrdvq);

    public static readonly Instruction vpshrdvw = new (Mnemonic.Vpshrdvw);

    public static readonly Instruction vpshrdw = new (Mnemonic.Vpshrdw);

    public static readonly Instruction vpshufb = new (Mnemonic.Vpshufb);

    public static readonly Instruction vpshufbitqmb = new (Mnemonic.Vpshufbitqmb);

    public static readonly Instruction vpshufd = new (Mnemonic.Vpshufd);

    public static readonly Instruction vpshufhw = new (Mnemonic.Vpshufhw);

    public static readonly Instruction vpshuflw = new (Mnemonic.Vpshuflw);

    public static readonly Instruction vpsignb = new (Mnemonic.Vpsignb);

    public static readonly Instruction vpsignd = new (Mnemonic.Vpsignd);

    public static readonly Instruction vpsignw = new (Mnemonic.Vpsignw);

    public static readonly Instruction vpslld = new (Mnemonic.Vpslld);

    public static readonly Instruction vpslldq = new (Mnemonic.Vpslldq);

    public static readonly Instruction vpsllq = new (Mnemonic.Vpsllq);

    public static readonly Instruction vpsllvd = new (Mnemonic.Vpsllvd);

    public static readonly Instruction vpsllvq = new (Mnemonic.Vpsllvq);

    public static readonly Instruction vpsllvw = new (Mnemonic.Vpsllvw);

    public static readonly Instruction vpsllw = new (Mnemonic.Vpsllw);

    public static readonly Instruction vpsrad = new (Mnemonic.Vpsrad);

    public static readonly Instruction vpsraq = new (Mnemonic.Vpsraq);

    public static readonly Instruction vpsravd = new (Mnemonic.Vpsravd);

    public static readonly Instruction vpsravq = new (Mnemonic.Vpsravq);

    public static readonly Instruction vpsravw = new (Mnemonic.Vpsravw);

    public static readonly Instruction vpsraw = new (Mnemonic.Vpsraw);

    public static readonly Instruction vpsrld = new (Mnemonic.Vpsrld);

    public static readonly Instruction vpsrldq = new (Mnemonic.Vpsrldq);

    public static readonly Instruction vpsrlq = new (Mnemonic.Vpsrlq);

    public static readonly Instruction vpsrlvd = new (Mnemonic.Vpsrlvd);

    public static readonly Instruction vpsrlvq = new (Mnemonic.Vpsrlvq);

    public static readonly Instruction vpsrlvw = new (Mnemonic.Vpsrlvw);

    public static readonly Instruction vpsrlw = new (Mnemonic.Vpsrlw);

    public static readonly Instruction vpsubb = new (Mnemonic.Vpsubb);

    public static readonly Instruction vpsubd = new (Mnemonic.Vpsubd);

    public static readonly Instruction vpsubq = new (Mnemonic.Vpsubq);

    public static readonly Instruction vpsubsb = new (Mnemonic.Vpsubsb);

    public static readonly Instruction vpsubsw = new (Mnemonic.Vpsubsw);

    public static readonly Instruction vpsubusb = new (Mnemonic.Vpsubusb);

    public static readonly Instruction vpsubusw = new (Mnemonic.Vpsubusw);

    public static readonly Instruction vpsubw = new (Mnemonic.Vpsubw);

    public static readonly Instruction vpternlogd = new (Mnemonic.Vpternlogd);

    public static readonly Instruction vpternlogq = new (Mnemonic.Vpternlogq);

    public static readonly Instruction vptest = new (Mnemonic.Vptest);

    public static readonly Instruction vptestmb = new (Mnemonic.Vptestmb);

    public static readonly Instruction vptestmd = new (Mnemonic.Vptestmd);

    public static readonly Instruction vptestmq = new (Mnemonic.Vptestmq);

    public static readonly Instruction vptestmw = new (Mnemonic.Vptestmw);

    public static readonly Instruction vptestnmb = new (Mnemonic.Vptestnmb);

    public static readonly Instruction vptestnmd = new (Mnemonic.Vptestnmd);

    public static readonly Instruction vptestnmq = new (Mnemonic.Vptestnmq);

    public static readonly Instruction vptestnmw = new (Mnemonic.Vptestnmw);

    public static readonly Instruction vpunpckhbw = new (Mnemonic.Vpunpckhbw);

    public static readonly Instruction vpunpckhdq = new (Mnemonic.Vpunpckhdq);

    public static readonly Instruction vpunpckhqdq = new (Mnemonic.Vpunpckhqdq);

    public static readonly Instruction vpunpckhwd = new (Mnemonic.Vpunpckhwd);

    public static readonly Instruction vpunpcklbw = new (Mnemonic.Vpunpcklbw);

    public static readonly Instruction vpunpckldq = new (Mnemonic.Vpunpckldq);

    public static readonly Instruction vpunpcklqdq = new (Mnemonic.Vpunpcklqdq);

    public static readonly Instruction vpunpcklwd = new (Mnemonic.Vpunpcklwd);

    public static readonly Instruction vpxor = new (Mnemonic.Vpxor);

    public static readonly Instruction vpxord = new (Mnemonic.Vpxord);

    public static readonly Instruction vpxorq = new (Mnemonic.Vpxorq);

    public static readonly Instruction vrangepd = new (Mnemonic.Vrangepd);

    public static readonly Instruction vrangeps = new (Mnemonic.Vrangeps);

    public static readonly Instruction vrangesd = new (Mnemonic.Vrangesd);

    public static readonly Instruction vrangess = new (Mnemonic.Vrangess);

    public static readonly Instruction vrcp14pd = new (Mnemonic.Vrcp14pd);

    public static readonly Instruction vrcp14ps = new (Mnemonic.Vrcp14ps);

    public static readonly Instruction vrcp14sd = new (Mnemonic.Vrcp14sd);

    public static readonly Instruction vrcp14ss = new (Mnemonic.Vrcp14ss);

    public static readonly Instruction vrcp28pd = new (Mnemonic.Vrcp28pd);

    public static readonly Instruction vrcp28ps = new (Mnemonic.Vrcp28ps);

    public static readonly Instruction vrcp28sd = new (Mnemonic.Vrcp28sd);

    public static readonly Instruction vrcp28ss = new (Mnemonic.Vrcp28ss);

    public static readonly Instruction vrcpps = new (Mnemonic.Vrcpps);

    public static readonly Instruction vrcpss = new (Mnemonic.Vrcpss);

    public static readonly Instruction vreducepd = new (Mnemonic.Vreducepd);

    public static readonly Instruction vreduceps = new (Mnemonic.Vreduceps);

    public static readonly Instruction vreducesd = new (Mnemonic.Vreducesd);

    public static readonly Instruction vreducess = new (Mnemonic.Vreducess);

    public static readonly Instruction vrndscalepd = new (Mnemonic.Vrndscalepd);

    public static readonly Instruction vrndscaleps = new (Mnemonic.Vrndscaleps);

    public static readonly Instruction vrndscalesd = new (Mnemonic.Vrndscalesd);

    public static readonly Instruction vrndscaless = new (Mnemonic.Vrndscaless);

    public static readonly Instruction vroundpd = new (Mnemonic.Vroundpd);

    public static readonly Instruction vroundps = new (Mnemonic.Vroundps);

    public static readonly Instruction vroundsd = new (Mnemonic.Vroundsd);

    public static readonly Instruction vroundss = new (Mnemonic.Vroundss);

    public static readonly Instruction vrsqrt14pd = new (Mnemonic.Vrsqrt14pd);

    public static readonly Instruction vrsqrt14ps = new (Mnemonic.Vrsqrt14ps);

    public static readonly Instruction vrsqrt14sd = new (Mnemonic.Vrsqrt14sd);

    public static readonly Instruction vrsqrt14ss = new (Mnemonic.Vrsqrt14ss);

    public static readonly Instruction vrsqrt28pd = new (Mnemonic.Vrsqrt28pd);

    public static readonly Instruction vrsqrt28ps = new (Mnemonic.Vrsqrt28ps);

    public static readonly Instruction vrsqrt28sd = new (Mnemonic.Vrsqrt28sd);

    public static readonly Instruction vrsqrt28ss = new (Mnemonic.Vrsqrt28ss);

    public static readonly Instruction vrsqrtps = new (Mnemonic.Vrsqrtps);

    public static readonly Instruction vrsqrtss = new (Mnemonic.Vrsqrtss);

    public static readonly Instruction vscalefpd = new (Mnemonic.Vscalefpd);

    public static readonly Instruction vscalefps = new (Mnemonic.Vscalefps);

    public static readonly Instruction vscalefsd = new (Mnemonic.Vscalefsd);

    public static readonly Instruction vscalefss = new (Mnemonic.Vscalefss);

    public static readonly Instruction vscatterdpd = new (Mnemonic.Vscatterdpd);

    public static readonly Instruction vscatterdps = new (Mnemonic.Vscatterdps);

    public static readonly Instruction vscatterpf0dpd = new (Mnemonic.Vscatterpf0dpd);

    public static readonly Instruction vscatterpf0dps = new (Mnemonic.Vscatterpf0dps);

    public static readonly Instruction vscatterpf0qpd = new (Mnemonic.Vscatterpf0qpd);

    public static readonly Instruction vscatterpf0qps = new (Mnemonic.Vscatterpf0qps);

    public static readonly Instruction vscatterpf1dpd = new (Mnemonic.Vscatterpf1dpd);

    public static readonly Instruction vscatterpf1dps = new (Mnemonic.Vscatterpf1dps);

    public static readonly Instruction vscatterpf1qpd = new (Mnemonic.Vscatterpf1qpd);

    public static readonly Instruction vscatterpf1qps = new (Mnemonic.Vscatterpf1qps);

    public static readonly Instruction vscatterqpd = new (Mnemonic.Vscatterqpd);

    public static readonly Instruction vscatterqps = new (Mnemonic.Vscatterqps);

    public static readonly Instruction vshuff32x4 = new (Mnemonic.Vshuff32x4);

    public static readonly Instruction vshuff64x2 = new (Mnemonic.Vshuff64x2);

    public static readonly Instruction vshufi32x4 = new (Mnemonic.Vshufi32x4);

    public static readonly Instruction vshufi64x2 = new (Mnemonic.Vshufi64x2);

    public static readonly Instruction vshufpd = new (Mnemonic.Vshufpd);

    public static readonly Instruction vshufps = new (Mnemonic.Vshufps);

    public static readonly Instruction vsqrtpd = new (Mnemonic.Vsqrtpd);

    public static readonly Instruction vsqrtps = new (Mnemonic.Vsqrtps);

    public static readonly Instruction vsqrtsd = new (Mnemonic.Vsqrtsd);

    public static readonly Instruction vsqrtss = new (Mnemonic.Vsqrtss);

    public static readonly Instruction vstmxcsr = new (Mnemonic.Vstmxcsr);

    public static readonly Instruction vsubpd = new (Mnemonic.Vsubpd);

    public static readonly Instruction vsubps = new (Mnemonic.Vsubps);

    public static readonly Instruction vsubsd = new (Mnemonic.Vsubsd);

    public static readonly Instruction vsubss = new (Mnemonic.Vsubss);

    public static readonly Instruction vtestpd = new (Mnemonic.Vtestpd);

    public static readonly Instruction vtestps = new (Mnemonic.Vtestps);

    public static readonly Instruction vucomisd = new (Mnemonic.Vucomisd);

    public static readonly Instruction vucomiss = new (Mnemonic.Vucomiss);

    public static readonly Instruction vunpckhpd = new (Mnemonic.Vunpckhpd);

    public static readonly Instruction vunpckhps = new (Mnemonic.Vunpckhps);

    public static readonly Instruction vunpcklpd = new (Mnemonic.Vunpcklpd);

    public static readonly Instruction vunpcklps = new (Mnemonic.Vunpcklps);

    public static readonly Instruction vxorpd = new (Mnemonic.Vxorpd);

    public static readonly Instruction vxorps = new (Mnemonic.Vxorps);

    public static readonly Instruction vzeroall = new (Mnemonic.Vzeroall);

    public static readonly Instruction vzeroupper = new (Mnemonic.Vzeroupper);

    public static readonly Instruction wait = new (Mnemonic.Wait);

    public static readonly Instruction wbinvd = new (Mnemonic.Wbinvd);

    public static readonly Instruction wbnoinvd = new (Mnemonic.Wbnoinvd);

    public static readonly Instruction wrfsbase = new (Mnemonic.Wrfsbase);

    public static readonly Instruction wrgsbase = new (Mnemonic.Wrgsbase);

    public static readonly Instruction wrmsr = new (Mnemonic.Wrmsr);

    public static readonly Instruction wrpkru = new (Mnemonic.Wrpkru);

    public static readonly Instruction wrssd = new (Mnemonic.Wrssd);

    public static readonly Instruction wrssq = new (Mnemonic.Wrssq);

    public static readonly Instruction wrussd = new (Mnemonic.Wrussd);

    public static readonly Instruction wrussq = new (Mnemonic.Wrussq);

    public static readonly Instruction xabort = new (Mnemonic.Xabort);

    public static readonly Instruction xadd = new (Mnemonic.Xadd);

    public static readonly Instruction xbegin = new (Mnemonic.Xbegin);

    public static readonly Instruction xbts = new (Mnemonic.Xbts);

    public static readonly Instruction xchg = new (Mnemonic.Xchg);

    public static readonly Instruction xcryptcbc = new (Mnemonic.Xcryptcbc);

    public static readonly Instruction xcryptcfb = new (Mnemonic.Xcryptcfb);

    public static readonly Instruction xcryptctr = new (Mnemonic.Xcryptctr);

    public static readonly Instruction xcryptecb = new (Mnemonic.Xcryptecb);

    public static readonly Instruction xcryptofb = new (Mnemonic.Xcryptofb);

    public static readonly Instruction xend = new (Mnemonic.Xend);

    public static readonly Instruction xgetbv = new (Mnemonic.Xgetbv);

    public static readonly Instruction xlatb = new (Mnemonic.Xlatb);

    public static readonly Instruction xor = new (Mnemonic.Xor);

    public static readonly Instruction xorpd = new (Mnemonic.Xorpd);

    public static readonly Instruction xorps = new (Mnemonic.Xorps);

    public static readonly Instruction xrstor = new (Mnemonic.Xrstor);

    public static readonly Instruction xrstor64 = new (Mnemonic.Xrstor64);

    public static readonly Instruction xrstors = new (Mnemonic.Xrstors);

    public static readonly Instruction xrstors64 = new (Mnemonic.Xrstors64);

    public static readonly Instruction xsave = new (Mnemonic.Xsave);

    public static readonly Instruction xsave64 = new (Mnemonic.Xsave64);

    public static readonly Instruction xsavec = new (Mnemonic.Xsavec);

    public static readonly Instruction xsavec64 = new (Mnemonic.Xsavec64);

    public static readonly Instruction xsaveopt = new (Mnemonic.Xsaveopt);

    public static readonly Instruction xsaveopt64 = new (Mnemonic.Xsaveopt64);

    public static readonly Instruction xsaves = new (Mnemonic.Xsaves);

    public static readonly Instruction xsaves64 = new (Mnemonic.Xsaves64);

    public static readonly Instruction xsetbv = new (Mnemonic.Xsetbv);

    public static readonly Instruction xsha1 = new (Mnemonic.Xsha1);

    public static readonly Instruction xsha256 = new (Mnemonic.Xsha256);

    public static readonly Instruction xstore = new (Mnemonic.Xstore);

    public static readonly Instruction xtest = new (Mnemonic.Xtest);

    public static readonly Instruction rmpadjust = new (Mnemonic.Rmpadjust);

    public static readonly Instruction rmpupdate = new (Mnemonic.Rmpupdate);

    public static readonly Instruction psmash = new (Mnemonic.Psmash);

    public static readonly Instruction pvalidate = new (Mnemonic.Pvalidate);

    public static readonly Instruction serialize = new (Mnemonic.Serialize);

    public static readonly Instruction xsusldtrk = new (Mnemonic.Xsusldtrk);

    public static readonly Instruction xresldtrk = new (Mnemonic.Xresldtrk);

    public static readonly Instruction invlpgb = new (Mnemonic.Invlpgb);

    public static readonly Instruction tlbsync = new (Mnemonic.Tlbsync);

    public static readonly Instruction vmgexit = new (Mnemonic.Vmgexit);

    public static readonly Instruction getsecq = new (Mnemonic.Getsecq);

    public static readonly Instruction sysexitq = new (Mnemonic.Sysexitq);

    public static readonly Instruction ldtilecfg = new (Mnemonic.Ldtilecfg);

    public static readonly Instruction tilerelease = new (Mnemonic.Tilerelease);

    public static readonly Instruction sttilecfg = new (Mnemonic.Sttilecfg);

    public static readonly Instruction tilezero = new (Mnemonic.Tilezero);

    public static readonly Instruction tileloaddt1 = new (Mnemonic.Tileloaddt1);

    public static readonly Instruction tilestored = new (Mnemonic.Tilestored);

    public static readonly Instruction tileloadd = new (Mnemonic.Tileloadd);

    public static readonly Instruction tdpbf16ps = new (Mnemonic.Tdpbf16ps);

    public static readonly Instruction tdpbuud = new (Mnemonic.Tdpbuud);

    public static readonly Instruction tdpbusd = new (Mnemonic.Tdpbusd);

    public static readonly Instruction tdpbsud = new (Mnemonic.Tdpbsud);

    public static readonly Instruction tdpbssd = new (Mnemonic.Tdpbssd);

    public static readonly Instruction sysretq = new (Mnemonic.Sysretq);

    public static readonly Instruction fnstdw = new (Mnemonic.Fnstdw);

    public static readonly Instruction fnstsg = new (Mnemonic.Fnstsg);

    public static readonly Instruction rdshr = new (Mnemonic.Rdshr);

    public static readonly Instruction wrshr = new (Mnemonic.Wrshr);

    public static readonly Instruction smint = new (Mnemonic.Smint);

    public static readonly Instruction dmint = new (Mnemonic.Dmint);

    public static readonly Instruction rdm = new (Mnemonic.Rdm);

    public static readonly Instruction svdc = new (Mnemonic.Svdc);

    public static readonly Instruction rsdc = new (Mnemonic.Rsdc);

    public static readonly Instruction svldt = new (Mnemonic.Svldt);

    public static readonly Instruction rsldt = new (Mnemonic.Rsldt);

    public static readonly Instruction svts = new (Mnemonic.Svts);

    public static readonly Instruction rsts = new (Mnemonic.Rsts);

    public static readonly Instruction bb0_reset = new (Mnemonic.Bb0_reset);

    public static readonly Instruction bb1_reset = new (Mnemonic.Bb1_reset);

    public static readonly Instruction cpu_write = new (Mnemonic.Cpu_write);

    public static readonly Instruction cpu_read = new (Mnemonic.Cpu_read);

    public static readonly Instruction altinst = new (Mnemonic.Altinst);

    public static readonly Instruction paveb = new (Mnemonic.Paveb);

    public static readonly Instruction paddsiw = new (Mnemonic.Paddsiw);

    public static readonly Instruction pmagw = new (Mnemonic.Pmagw);

    public static readonly Instruction pdistib = new (Mnemonic.Pdistib);

    public static readonly Instruction psubsiw = new (Mnemonic.Psubsiw);

    public static readonly Instruction pmvzb = new (Mnemonic.Pmvzb);

    public static readonly Instruction pmvnzb = new (Mnemonic.Pmvnzb);

    public static readonly Instruction pmvlzb = new (Mnemonic.Pmvlzb);

    public static readonly Instruction pmvgezb = new (Mnemonic.Pmvgezb);

    public static readonly Instruction pmulhriw = new (Mnemonic.Pmulhriw);

    public static readonly Instruction pmachriw = new (Mnemonic.Pmachriw);

    public static readonly Instruction ftstp = new (Mnemonic.Ftstp);

    public static readonly Instruction frint2 = new (Mnemonic.Frint2);

    public static readonly Instruction frichop = new (Mnemonic.Frichop);

    public static readonly Instruction frinear = new (Mnemonic.Frinear);

    public static readonly Instruction undoc = new (Mnemonic.Undoc);

    public static readonly Instruction tdcall = new (Mnemonic.Tdcall);

    public static readonly Instruction seamret = new (Mnemonic.Seamret);

    public static readonly Instruction seamops = new (Mnemonic.Seamops);

    public static readonly Instruction seamcall = new (Mnemonic.Seamcall);

    public static readonly Instruction aesencwide128kl = new (Mnemonic.Aesencwide128kl);

    public static readonly Instruction aesdecwide128kl = new (Mnemonic.Aesdecwide128kl);

    public static readonly Instruction aesencwide256kl = new (Mnemonic.Aesencwide256kl);

    public static readonly Instruction aesdecwide256kl = new (Mnemonic.Aesdecwide256kl);

    public static readonly Instruction loadiwkey = new (Mnemonic.Loadiwkey);

    public static readonly Instruction aesenc128kl = new (Mnemonic.Aesenc128kl);

    public static readonly Instruction aesdec128kl = new (Mnemonic.Aesdec128kl);

    public static readonly Instruction aesenc256kl = new (Mnemonic.Aesenc256kl);

    public static readonly Instruction aesdec256kl = new (Mnemonic.Aesdec256kl);

    public static readonly Instruction encodekey128 = new (Mnemonic.Encodekey128);

    public static readonly Instruction encodekey256 = new (Mnemonic.Encodekey256);

    public static readonly Instruction pushad = new (Mnemonic.Pushad);

    public static readonly Instruction popad = new (Mnemonic.Popad);

    public static readonly Instruction pushfd = new (Mnemonic.Pushfd);

    public static readonly Instruction pushfq = new (Mnemonic.Pushfq);

    public static readonly Instruction popfd = new (Mnemonic.Popfd);

    public static readonly Instruction popfq = new (Mnemonic.Popfq);

    public static readonly Instruction iretd = new (Mnemonic.Iretd);

    public static readonly Instruction iretq = new (Mnemonic.Iretq);

    public static readonly Instruction int3 = new (Mnemonic.Int3);

    public static readonly Instruction uiret = new (Mnemonic.Uiret);

    public static readonly Instruction testui = new (Mnemonic.Testui);

    public static readonly Instruction clui = new (Mnemonic.Clui);

    public static readonly Instruction stui = new (Mnemonic.Stui);

    public static readonly Instruction senduipi = new (Mnemonic.Senduipi);

    public static readonly Instruction hreset = new (Mnemonic.Hreset);

    public static readonly Instruction ccs_hash = new (Mnemonic.Ccs_hash);

    public static readonly Instruction ccs_encrypt = new (Mnemonic.Ccs_encrypt);

    public static readonly Instruction lkgs = new (Mnemonic.Lkgs);

    public static readonly Instruction eretu = new (Mnemonic.Eretu);

    public static readonly Instruction erets = new (Mnemonic.Erets);

    public static readonly Instruction storeall = new (Mnemonic.Storeall);

    public static readonly Instruction vaddph = new (Mnemonic.Vaddph);

    public static readonly Instruction vaddsh = new (Mnemonic.Vaddsh);

    public static readonly Instruction vcmpph = new (Mnemonic.Vcmpph);

    public static readonly Instruction vcmpsh = new (Mnemonic.Vcmpsh);

    public static readonly Instruction vcomish = new (Mnemonic.Vcomish);

    public static readonly Instruction vcvtdq2ph = new (Mnemonic.Vcvtdq2ph);

    public static readonly Instruction vcvtpd2ph = new (Mnemonic.Vcvtpd2ph);

    public static readonly Instruction vcvtph2dq = new (Mnemonic.Vcvtph2dq);

    public static readonly Instruction vcvtph2pd = new (Mnemonic.Vcvtph2pd);

    public static readonly Instruction vcvtph2psx = new (Mnemonic.Vcvtph2psx);

    public static readonly Instruction vcvtph2qq = new (Mnemonic.Vcvtph2qq);

    public static readonly Instruction vcvtph2udq = new (Mnemonic.Vcvtph2udq);

    public static readonly Instruction vcvtph2uqq = new (Mnemonic.Vcvtph2uqq);

    public static readonly Instruction vcvtph2uw = new (Mnemonic.Vcvtph2uw);

    public static readonly Instruction vcvtph2w = new (Mnemonic.Vcvtph2w);

    public static readonly Instruction vcvtps2phx = new (Mnemonic.Vcvtps2phx);

    public static readonly Instruction vcvtqq2ph = new (Mnemonic.Vcvtqq2ph);

    public static readonly Instruction vcvtsd2sh = new (Mnemonic.Vcvtsd2sh);

    public static readonly Instruction vcvtsh2sd = new (Mnemonic.Vcvtsh2sd);

    public static readonly Instruction vcvtsh2si = new (Mnemonic.Vcvtsh2si);

    public static readonly Instruction vcvtsh2ss = new (Mnemonic.Vcvtsh2ss);

    public static readonly Instruction vcvtsh2usi = new (Mnemonic.Vcvtsh2usi);

    public static readonly Instruction vcvtsi2sh = new (Mnemonic.Vcvtsi2sh);

    public static readonly Instruction vcvtss2sh = new (Mnemonic.Vcvtss2sh);

    public static readonly Instruction vcvttph2dq = new (Mnemonic.Vcvttph2dq);

    public static readonly Instruction vcvttph2qq = new (Mnemonic.Vcvttph2qq);

    public static readonly Instruction vcvttph2udq = new (Mnemonic.Vcvttph2udq);

    public static readonly Instruction vcvttph2uqq = new (Mnemonic.Vcvttph2uqq);

    public static readonly Instruction vcvttph2uw = new (Mnemonic.Vcvttph2uw);

    public static readonly Instruction vcvttph2w = new (Mnemonic.Vcvttph2w);

    public static readonly Instruction vcvttsh2si = new (Mnemonic.Vcvttsh2si);

    public static readonly Instruction vcvttsh2usi = new (Mnemonic.Vcvttsh2usi);

    public static readonly Instruction vcvtudq2ph = new (Mnemonic.Vcvtudq2ph);

    public static readonly Instruction vcvtuqq2ph = new (Mnemonic.Vcvtuqq2ph);

    public static readonly Instruction vcvtusi2sh = new (Mnemonic.Vcvtusi2sh);

    public static readonly Instruction vcvtuw2ph = new (Mnemonic.Vcvtuw2ph);

    public static readonly Instruction vcvtw2ph = new (Mnemonic.Vcvtw2ph);

    public static readonly Instruction vdivph = new (Mnemonic.Vdivph);

    public static readonly Instruction vdivsh = new (Mnemonic.Vdivsh);

    public static readonly Instruction vfcmaddcph = new (Mnemonic.Vfcmaddcph);

    public static readonly Instruction vfmaddcph = new (Mnemonic.Vfmaddcph);

    public static readonly Instruction vfcmaddcsh = new (Mnemonic.Vfcmaddcsh);

    public static readonly Instruction vfmaddcsh = new (Mnemonic.Vfmaddcsh);

    public static readonly Instruction vfcmulcph = new (Mnemonic.Vfcmulcph);

    public static readonly Instruction vfmulcph = new (Mnemonic.Vfmulcph);

    public static readonly Instruction vfcmulcsh = new (Mnemonic.Vfcmulcsh);

    public static readonly Instruction vfmulcsh = new (Mnemonic.Vfmulcsh);

    public static readonly Instruction vfmaddsub132ph = new (Mnemonic.Vfmaddsub132ph);

    public static readonly Instruction vfmaddsub213ph = new (Mnemonic.Vfmaddsub213ph);

    public static readonly Instruction vfmaddsub231ph = new (Mnemonic.Vfmaddsub231ph);

    public static readonly Instruction vfmsubadd132ph = new (Mnemonic.Vfmsubadd132ph);

    public static readonly Instruction vfmsubadd213ph = new (Mnemonic.Vfmsubadd213ph);

    public static readonly Instruction vfmsubadd231ph = new (Mnemonic.Vfmsubadd231ph);

    public static readonly Instruction vfmadd132ph = new (Mnemonic.Vfmadd132ph);

    public static readonly Instruction vfmadd213ph = new (Mnemonic.Vfmadd213ph);

    public static readonly Instruction vfmadd231ph = new (Mnemonic.Vfmadd231ph);

    public static readonly Instruction vfnmadd132ph = new (Mnemonic.Vfnmadd132ph);

    public static readonly Instruction vfnmadd213ph = new (Mnemonic.Vfnmadd213ph);

    public static readonly Instruction vfnmadd231ph = new (Mnemonic.Vfnmadd231ph);

    public static readonly Instruction vfmadd132sh = new (Mnemonic.Vfmadd132sh);

    public static readonly Instruction vfmadd213sh = new (Mnemonic.Vfmadd213sh);

    public static readonly Instruction vfmadd231sh = new (Mnemonic.Vfmadd231sh);

    public static readonly Instruction vfnmadd132sh = new (Mnemonic.Vfnmadd132sh);

    public static readonly Instruction vfnmadd213sh = new (Mnemonic.Vfnmadd213sh);

    public static readonly Instruction vfnmadd231sh = new (Mnemonic.Vfnmadd231sh);

    public static readonly Instruction vfmsub132ph = new (Mnemonic.Vfmsub132ph);

    public static readonly Instruction vfmsub213ph = new (Mnemonic.Vfmsub213ph);

    public static readonly Instruction vfmsub231ph = new (Mnemonic.Vfmsub231ph);

    public static readonly Instruction vfnmsub132ph = new (Mnemonic.Vfnmsub132ph);

    public static readonly Instruction vfnmsub213ph = new (Mnemonic.Vfnmsub213ph);

    public static readonly Instruction vfnmsub231ph = new (Mnemonic.Vfnmsub231ph);

    public static readonly Instruction vfmsub132sh = new (Mnemonic.Vfmsub132sh);

    public static readonly Instruction vfmsub213sh = new (Mnemonic.Vfmsub213sh);

    public static readonly Instruction vfmsub231sh = new (Mnemonic.Vfmsub231sh);

    public static readonly Instruction vfnmsub132sh = new (Mnemonic.Vfnmsub132sh);

    public static readonly Instruction vfnmsub213sh = new (Mnemonic.Vfnmsub213sh);

    public static readonly Instruction vfnmsub231sh = new (Mnemonic.Vfnmsub231sh);

    public static readonly Instruction vfpclassph = new (Mnemonic.Vfpclassph);

    public static readonly Instruction vfpclasssh = new (Mnemonic.Vfpclasssh);

    public static readonly Instruction vgetexpph = new (Mnemonic.Vgetexpph);

    public static readonly Instruction vgetexpsh = new (Mnemonic.Vgetexpsh);

    public static readonly Instruction vgetmantph = new (Mnemonic.Vgetmantph);

    public static readonly Instruction vgetmantsh = new (Mnemonic.Vgetmantsh);

    public static readonly Instruction vmaxph = new (Mnemonic.Vmaxph);

    public static readonly Instruction vmaxsh = new (Mnemonic.Vmaxsh);

    public static readonly Instruction vminph = new (Mnemonic.Vminph);

    public static readonly Instruction vminsh = new (Mnemonic.Vminsh);

    public static readonly Instruction vmovsh = new (Mnemonic.Vmovsh);

    public static readonly Instruction vmovw = new (Mnemonic.Vmovw);

    public static readonly Instruction vmulph = new (Mnemonic.Vmulph);

    public static readonly Instruction vmulsh = new (Mnemonic.Vmulsh);

    public static readonly Instruction vrcpph = new (Mnemonic.Vrcpph);

    public static readonly Instruction vrcpsh = new (Mnemonic.Vrcpsh);

    public static readonly Instruction vreduceph = new (Mnemonic.Vreduceph);

    public static readonly Instruction vreducesh = new (Mnemonic.Vreducesh);

    public static readonly Instruction vrndscaleph = new (Mnemonic.Vrndscaleph);

    public static readonly Instruction vrndscalesh = new (Mnemonic.Vrndscalesh);

    public static readonly Instruction vrsqrtph = new (Mnemonic.Vrsqrtph);

    public static readonly Instruction vrsqrtsh = new (Mnemonic.Vrsqrtsh);

    public static readonly Instruction vscalefph = new (Mnemonic.Vscalefph);

    public static readonly Instruction vscalefsh = new (Mnemonic.Vscalefsh);

    public static readonly Instruction vsqrtph = new (Mnemonic.Vsqrtph);

    public static readonly Instruction vsqrtsh = new (Mnemonic.Vsqrtsh);

    public static readonly Instruction vsubph = new (Mnemonic.Vsubph);

    public static readonly Instruction vsubsh = new (Mnemonic.Vsubsh);

    public static readonly Instruction vucomish = new (Mnemonic.Vucomish);

    public static readonly Instruction rdudbg = new (Mnemonic.Rdudbg);

    public static readonly Instruction wrudbg = new (Mnemonic.Wrudbg);

    public static readonly Instruction clevict0 = new (Mnemonic.Clevict0);

    public static readonly Instruction clevict1 = new (Mnemonic.Clevict1);

    public static readonly Instruction delay = new (Mnemonic.Delay);

    public static readonly Instruction jknzd = new (Mnemonic.Jknzd);

    public static readonly Instruction jkzd = new (Mnemonic.Jkzd);

    public static readonly Instruction kand = new (Mnemonic.Kand);

    public static readonly Instruction kandn = new (Mnemonic.Kandn);

    public static readonly Instruction kandnr = new (Mnemonic.Kandnr);

    public static readonly Instruction kconcath = new (Mnemonic.Kconcath);

    public static readonly Instruction kconcatl = new (Mnemonic.Kconcatl);

    public static readonly Instruction kextract = new (Mnemonic.Kextract);

    public static readonly Instruction kmerge2l1h = new (Mnemonic.Kmerge2l1h);

    public static readonly Instruction kmerge2l1l = new (Mnemonic.Kmerge2l1l);

    public static readonly Instruction kmov = new (Mnemonic.Kmov);

    public static readonly Instruction knot = new (Mnemonic.Knot);

    public static readonly Instruction kor = new (Mnemonic.Kor);

    public static readonly Instruction kortest = new (Mnemonic.Kortest);

    public static readonly Instruction kxnor = new (Mnemonic.Kxnor);

    public static readonly Instruction kxor = new (Mnemonic.Kxor);

    public static readonly Instruction spflt = new (Mnemonic.Spflt);

    public static readonly Instruction tzcnti = new (Mnemonic.Tzcnti);

    public static readonly Instruction vaddnpd = new (Mnemonic.Vaddnpd);

    public static readonly Instruction vaddnps = new (Mnemonic.Vaddnps);

    public static readonly Instruction vaddsetsps = new (Mnemonic.Vaddsetsps);

    public static readonly Instruction vcvtfxpntdq2ps = new (Mnemonic.Vcvtfxpntdq2ps);

    public static readonly Instruction vcvtfxpntpd2dq = new (Mnemonic.Vcvtfxpntpd2dq);

    public static readonly Instruction vcvtfxpntpd2udq = new (Mnemonic.Vcvtfxpntpd2udq);

    public static readonly Instruction vcvtfxpntps2dq = new (Mnemonic.Vcvtfxpntps2dq);

    public static readonly Instruction vcvtfxpntps2udq = new (Mnemonic.Vcvtfxpntps2udq);

    public static readonly Instruction vcvtfxpntudq2ps = new (Mnemonic.Vcvtfxpntudq2ps);

    public static readonly Instruction vexp223ps = new (Mnemonic.Vexp223ps);

    public static readonly Instruction vfixupnanpd = new (Mnemonic.Vfixupnanpd);

    public static readonly Instruction vfixupnanps = new (Mnemonic.Vfixupnanps);

    public static readonly Instruction vfmadd233ps = new (Mnemonic.Vfmadd233ps);

    public static readonly Instruction vgatherpf0hintdpd = new (Mnemonic.Vgatherpf0hintdpd);

    public static readonly Instruction vgatherpf0hintdps = new (Mnemonic.Vgatherpf0hintdps);

    public static readonly Instruction vgmaxabsps = new (Mnemonic.Vgmaxabsps);

    public static readonly Instruction vgmaxpd = new (Mnemonic.Vgmaxpd);

    public static readonly Instruction vgmaxps = new (Mnemonic.Vgmaxps);

    public static readonly Instruction vgminpd = new (Mnemonic.Vgminpd);

    public static readonly Instruction vgminps = new (Mnemonic.Vgminps);

    public static readonly Instruction vloadunpackhd = new (Mnemonic.Vloadunpackhd);

    public static readonly Instruction vloadunpackhpd = new (Mnemonic.Vloadunpackhpd);

    public static readonly Instruction vloadunpackhps = new (Mnemonic.Vloadunpackhps);

    public static readonly Instruction vloadunpackhq = new (Mnemonic.Vloadunpackhq);

    public static readonly Instruction vloadunpackld = new (Mnemonic.Vloadunpackld);

    public static readonly Instruction vloadunpacklpd = new (Mnemonic.Vloadunpacklpd);

    public static readonly Instruction vloadunpacklps = new (Mnemonic.Vloadunpacklps);

    public static readonly Instruction vloadunpacklq = new (Mnemonic.Vloadunpacklq);

    public static readonly Instruction vlog2ps = new (Mnemonic.Vlog2ps);

    public static readonly Instruction vmovnrapd = new (Mnemonic.Vmovnrapd);

    public static readonly Instruction vmovnraps = new (Mnemonic.Vmovnraps);

    public static readonly Instruction vmovnrngoapd = new (Mnemonic.Vmovnrngoapd);

    public static readonly Instruction vmovnrngoaps = new (Mnemonic.Vmovnrngoaps);

    public static readonly Instruction vpackstorehd = new (Mnemonic.Vpackstorehd);

    public static readonly Instruction vpackstorehpd = new (Mnemonic.Vpackstorehpd);

    public static readonly Instruction vpackstorehps = new (Mnemonic.Vpackstorehps);

    public static readonly Instruction vpackstorehq = new (Mnemonic.Vpackstorehq);

    public static readonly Instruction vpackstoreld = new (Mnemonic.Vpackstoreld);

    public static readonly Instruction vpackstorelpd = new (Mnemonic.Vpackstorelpd);

    public static readonly Instruction vpackstorelps = new (Mnemonic.Vpackstorelps);

    public static readonly Instruction vpackstorelq = new (Mnemonic.Vpackstorelq);

    public static readonly Instruction vpadcd = new (Mnemonic.Vpadcd);

    public static readonly Instruction vpaddsetcd = new (Mnemonic.Vpaddsetcd);

    public static readonly Instruction vpaddsetsd = new (Mnemonic.Vpaddsetsd);

    public static readonly Instruction vpcmpltd = new (Mnemonic.Vpcmpltd);

    public static readonly Instruction vpermf32x4 = new (Mnemonic.Vpermf32x4);

    public static readonly Instruction vpmadd231d = new (Mnemonic.Vpmadd231d);

    public static readonly Instruction vpmadd233d = new (Mnemonic.Vpmadd233d);

    public static readonly Instruction vpmulhd = new (Mnemonic.Vpmulhd);

    public static readonly Instruction vpmulhud = new (Mnemonic.Vpmulhud);

    public static readonly Instruction vprefetch0 = new (Mnemonic.Vprefetch0);

    public static readonly Instruction vprefetch1 = new (Mnemonic.Vprefetch1);

    public static readonly Instruction vprefetch2 = new (Mnemonic.Vprefetch2);

    public static readonly Instruction vprefetche0 = new (Mnemonic.Vprefetche0);

    public static readonly Instruction vprefetche1 = new (Mnemonic.Vprefetche1);

    public static readonly Instruction vprefetche2 = new (Mnemonic.Vprefetche2);

    public static readonly Instruction vprefetchenta = new (Mnemonic.Vprefetchenta);

    public static readonly Instruction vprefetchnta = new (Mnemonic.Vprefetchnta);

    public static readonly Instruction vpsbbd = new (Mnemonic.Vpsbbd);

    public static readonly Instruction vpsbbrd = new (Mnemonic.Vpsbbrd);

    public static readonly Instruction vpsubrd = new (Mnemonic.Vpsubrd);

    public static readonly Instruction vpsubrsetbd = new (Mnemonic.Vpsubrsetbd);

    public static readonly Instruction vpsubsetbd = new (Mnemonic.Vpsubsetbd);

    public static readonly Instruction vrcp23ps = new (Mnemonic.Vrcp23ps);

    public static readonly Instruction vrndfxpntpd = new (Mnemonic.Vrndfxpntpd);

    public static readonly Instruction vrndfxpntps = new (Mnemonic.Vrndfxpntps);

    public static readonly Instruction vrsqrt23ps = new (Mnemonic.Vrsqrt23ps);

    public static readonly Instruction vscaleps = new (Mnemonic.Vscaleps);

    public static readonly Instruction vscatterpf0hintdpd = new (Mnemonic.Vscatterpf0hintdpd);

    public static readonly Instruction vscatterpf0hintdps = new (Mnemonic.Vscatterpf0hintdps);

    public static readonly Instruction vsubrpd = new (Mnemonic.Vsubrpd);

    public static readonly Instruction vsubrps = new (Mnemonic.Vsubrps);

    public static readonly Instruction xsha512 = new (Mnemonic.Xsha512);

    public static readonly Instruction xstore_alt = new (Mnemonic.Xstore_alt);

    public static readonly Instruction xsha512_alt = new (Mnemonic.Xsha512_alt);

    public static readonly Instruction zero_bytes = new (Mnemonic.Zero_bytes);

    public static readonly Instruction EmitLabel = new (true);
}