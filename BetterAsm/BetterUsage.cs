using BetterAsm;
using Iced.Intel;

public static class BetterAsmInstructions
{
    public static readonly BetterInstruction invalid = new (Mnemonic.INVALID);

    public static readonly BetterInstruction aaa = new (Mnemonic.Aaa);

    public static readonly BetterInstruction aad = new (Mnemonic.Aad);

    public static readonly BetterInstruction aam = new (Mnemonic.Aam);

    public static readonly BetterInstruction aas = new (Mnemonic.Aas);

    public static readonly BetterInstruction adc = new (Mnemonic.Adc);

    public static readonly BetterInstruction adcx = new (Mnemonic.Adcx);

    public static readonly BetterInstruction add = new (Mnemonic.Add);

    public static readonly BetterInstruction addpd = new (Mnemonic.Addpd);

    public static readonly BetterInstruction addps = new (Mnemonic.Addps);

    public static readonly BetterInstruction addsd = new (Mnemonic.Addsd);

    public static readonly BetterInstruction addss = new (Mnemonic.Addss);

    public static readonly BetterInstruction addsubpd = new (Mnemonic.Addsubpd);

    public static readonly BetterInstruction addsubps = new (Mnemonic.Addsubps);

    public static readonly BetterInstruction adox = new (Mnemonic.Adox);

    public static readonly BetterInstruction aesdec = new (Mnemonic.Aesdec);

    public static readonly BetterInstruction aesdeclast = new (Mnemonic.Aesdeclast);

    public static readonly BetterInstruction aesenc = new (Mnemonic.Aesenc);

    public static readonly BetterInstruction aesenclast = new (Mnemonic.Aesenclast);

    public static readonly BetterInstruction aesimc = new (Mnemonic.Aesimc);

    public static readonly BetterInstruction aeskeygenassist = new (Mnemonic.Aeskeygenassist);

    public static readonly BetterInstruction and = new (Mnemonic.And);

    public static readonly BetterInstruction andn = new (Mnemonic.Andn);

    public static readonly BetterInstruction andnpd = new (Mnemonic.Andnpd);

    public static readonly BetterInstruction andnps = new (Mnemonic.Andnps);

    public static readonly BetterInstruction andpd = new (Mnemonic.Andpd);

    public static readonly BetterInstruction andps = new (Mnemonic.Andps);

    public static readonly BetterInstruction arpl = new (Mnemonic.Arpl);

    public static readonly BetterInstruction bextr = new (Mnemonic.Bextr);

    public static readonly BetterInstruction blcfill = new (Mnemonic.Blcfill);

    public static readonly BetterInstruction blci = new (Mnemonic.Blci);

    public static readonly BetterInstruction blcic = new (Mnemonic.Blcic);

    public static readonly BetterInstruction blcmsk = new (Mnemonic.Blcmsk);

    public static readonly BetterInstruction blcs = new (Mnemonic.Blcs);

    public static readonly BetterInstruction blendpd = new (Mnemonic.Blendpd);

    public static readonly BetterInstruction blendps = new (Mnemonic.Blendps);

    public static readonly BetterInstruction blendvpd = new (Mnemonic.Blendvpd);

    public static readonly BetterInstruction blendvps = new (Mnemonic.Blendvps);

    public static readonly BetterInstruction blsfill = new (Mnemonic.Blsfill);

    public static readonly BetterInstruction blsi = new (Mnemonic.Blsi);

    public static readonly BetterInstruction blsic = new (Mnemonic.Blsic);

    public static readonly BetterInstruction blsmsk = new (Mnemonic.Blsmsk);

    public static readonly BetterInstruction blsr = new (Mnemonic.Blsr);

    public static readonly BetterInstruction bndcl = new (Mnemonic.Bndcl);

    public static readonly BetterInstruction bndcn = new (Mnemonic.Bndcn);

    public static readonly BetterInstruction bndcu = new (Mnemonic.Bndcu);

    public static readonly BetterInstruction bndldx = new (Mnemonic.Bndldx);

    public static readonly BetterInstruction bndmk = new (Mnemonic.Bndmk);

    public static readonly BetterInstruction bndmov = new (Mnemonic.Bndmov);

    public static readonly BetterInstruction bndstx = new (Mnemonic.Bndstx);

    public static readonly BetterInstruction bound = new (Mnemonic.Bound);

    public static readonly BetterInstruction bsf = new (Mnemonic.Bsf);

    public static readonly BetterInstruction bsr = new (Mnemonic.Bsr);

    public static readonly BetterInstruction bswap = new (Mnemonic.Bswap);

    public static readonly BetterInstruction bt = new (Mnemonic.Bt);

    public static readonly BetterInstruction btc = new (Mnemonic.Btc);

    public static readonly BetterInstruction btr = new (Mnemonic.Btr);

    public static readonly BetterInstruction bts = new (Mnemonic.Bts);

    public static readonly BetterInstruction bzhi = new (Mnemonic.Bzhi);

    public static readonly BetterInstruction call = new (Mnemonic.Call);

    public static readonly BetterInstruction cbw = new (Mnemonic.Cbw);

    public static readonly BetterInstruction cdq = new (Mnemonic.Cdq);

    public static readonly BetterInstruction cdqe = new (Mnemonic.Cdqe);

    public static readonly BetterInstruction cl1invmb = new (Mnemonic.Cl1invmb);

    public static readonly BetterInstruction clac = new (Mnemonic.Clac);

    public static readonly BetterInstruction clc = new (Mnemonic.Clc);

    public static readonly BetterInstruction cld = new (Mnemonic.Cld);

    public static readonly BetterInstruction cldemote = new (Mnemonic.Cldemote);

    public static readonly BetterInstruction clflush = new (Mnemonic.Clflush);

    public static readonly BetterInstruction clflushopt = new (Mnemonic.Clflushopt);

    public static readonly BetterInstruction clgi = new (Mnemonic.Clgi);

    public static readonly BetterInstruction cli = new (Mnemonic.Cli);

    public static readonly BetterInstruction clrssbsy = new (Mnemonic.Clrssbsy);

    public static readonly BetterInstruction clts = new (Mnemonic.Clts);

    public static readonly BetterInstruction clwb = new (Mnemonic.Clwb);

    public static readonly BetterInstruction clzero = new (Mnemonic.Clzero);

    public static readonly BetterInstruction cmc = new (Mnemonic.Cmc);

    public static readonly BetterInstruction cmova = new (Mnemonic.Cmova);

    public static readonly BetterInstruction cmovae = new (Mnemonic.Cmovae);

    public static readonly BetterInstruction cmovb = new (Mnemonic.Cmovb);

    public static readonly BetterInstruction cmovbe = new (Mnemonic.Cmovbe);

    public static readonly BetterInstruction cmove = new (Mnemonic.Cmove);

    public static readonly BetterInstruction cmovg = new (Mnemonic.Cmovg);

    public static readonly BetterInstruction cmovge = new (Mnemonic.Cmovge);

    public static readonly BetterInstruction cmovl = new (Mnemonic.Cmovl);

    public static readonly BetterInstruction cmovle = new (Mnemonic.Cmovle);

    public static readonly BetterInstruction cmovne = new (Mnemonic.Cmovne);

    public static readonly BetterInstruction cmovno = new (Mnemonic.Cmovno);

    public static readonly BetterInstruction cmovnp = new (Mnemonic.Cmovnp);

    public static readonly BetterInstruction cmovns = new (Mnemonic.Cmovns);

    public static readonly BetterInstruction cmovo = new (Mnemonic.Cmovo);

    public static readonly BetterInstruction cmovp = new (Mnemonic.Cmovp);

    public static readonly BetterInstruction cmovs = new (Mnemonic.Cmovs);

    public static readonly BetterInstruction cmp = new (Mnemonic.Cmp);

    public static readonly BetterInstruction cmppd = new (Mnemonic.Cmppd);

    public static readonly BetterInstruction cmpps = new (Mnemonic.Cmpps);

    public static readonly BetterInstruction cmpsb = new (Mnemonic.Cmpsb);

    public static readonly BetterInstruction cmpsd = new (Mnemonic.Cmpsd);

    public static readonly BetterInstruction cmpsq = new (Mnemonic.Cmpsq);

    public static readonly BetterInstruction cmpss = new (Mnemonic.Cmpss);

    public static readonly BetterInstruction cmpsw = new (Mnemonic.Cmpsw);

    public static readonly BetterInstruction cmpxchg = new (Mnemonic.Cmpxchg);

    public static readonly BetterInstruction cmpxchg16b = new (Mnemonic.Cmpxchg16b);

    public static readonly BetterInstruction cmpxchg8b = new (Mnemonic.Cmpxchg8b);

    public static readonly BetterInstruction comisd = new (Mnemonic.Comisd);

    public static readonly BetterInstruction comiss = new (Mnemonic.Comiss);

    public static readonly BetterInstruction cpuid = new (Mnemonic.Cpuid);

    public static readonly BetterInstruction cqo = new (Mnemonic.Cqo);

    public static readonly BetterInstruction crc32 = new (Mnemonic.Crc32);

    public static readonly BetterInstruction cvtdq2pd = new (Mnemonic.Cvtdq2pd);

    public static readonly BetterInstruction cvtdq2ps = new (Mnemonic.Cvtdq2ps);

    public static readonly BetterInstruction cvtpd2dq = new (Mnemonic.Cvtpd2dq);

    public static readonly BetterInstruction cvtpd2pi = new (Mnemonic.Cvtpd2pi);

    public static readonly BetterInstruction cvtpd2ps = new (Mnemonic.Cvtpd2ps);

    public static readonly BetterInstruction cvtpi2pd = new (Mnemonic.Cvtpi2pd);

    public static readonly BetterInstruction cvtpi2ps = new (Mnemonic.Cvtpi2ps);

    public static readonly BetterInstruction cvtps2dq = new (Mnemonic.Cvtps2dq);

    public static readonly BetterInstruction cvtps2pd = new (Mnemonic.Cvtps2pd);

    public static readonly BetterInstruction cvtps2pi = new (Mnemonic.Cvtps2pi);

    public static readonly BetterInstruction cvtsd2si = new (Mnemonic.Cvtsd2si);

    public static readonly BetterInstruction cvtsd2ss = new (Mnemonic.Cvtsd2ss);

    public static readonly BetterInstruction cvtsi2sd = new (Mnemonic.Cvtsi2sd);

    public static readonly BetterInstruction cvtsi2ss = new (Mnemonic.Cvtsi2ss);

    public static readonly BetterInstruction cvtss2sd = new (Mnemonic.Cvtss2sd);

    public static readonly BetterInstruction cvtss2si = new (Mnemonic.Cvtss2si);

    public static readonly BetterInstruction cvttpd2dq = new (Mnemonic.Cvttpd2dq);

    public static readonly BetterInstruction cvttpd2pi = new (Mnemonic.Cvttpd2pi);

    public static readonly BetterInstruction cvttps2dq = new (Mnemonic.Cvttps2dq);

    public static readonly BetterInstruction cvttps2pi = new (Mnemonic.Cvttps2pi);

    public static readonly BetterInstruction cvttsd2si = new (Mnemonic.Cvttsd2si);

    public static readonly BetterInstruction cvttss2si = new (Mnemonic.Cvttss2si);

    public static readonly BetterInstruction cwd = new (Mnemonic.Cwd);

    public static readonly BetterInstruction cwde = new (Mnemonic.Cwde);

    public static readonly BetterInstruction daa = new (Mnemonic.Daa);

    public static readonly BetterInstruction das = new (Mnemonic.Das);

    public static readonly BetterInstruction db = new (Mnemonic.Db);

    public static readonly BetterInstruction dd = new (Mnemonic.Dd);

    public static readonly BetterInstruction dec = new (Mnemonic.Dec);

    public static readonly BetterInstruction div = new (Mnemonic.Div);

    public static readonly BetterInstruction divpd = new (Mnemonic.Divpd);

    public static readonly BetterInstruction divps = new (Mnemonic.Divps);

    public static readonly BetterInstruction divsd = new (Mnemonic.Divsd);

    public static readonly BetterInstruction divss = new (Mnemonic.Divss);

    public static readonly BetterInstruction dppd = new (Mnemonic.Dppd);

    public static readonly BetterInstruction dpps = new (Mnemonic.Dpps);

    public static readonly BetterInstruction dq = new (Mnemonic.Dq);

    public static readonly BetterInstruction dw = new (Mnemonic.Dw);

    public static readonly BetterInstruction emms = new (Mnemonic.Emms);

    public static readonly BetterInstruction encls = new (Mnemonic.Encls);

    public static readonly BetterInstruction enclu = new (Mnemonic.Enclu);

    public static readonly BetterInstruction enclv = new (Mnemonic.Enclv);

    public static readonly BetterInstruction endbr32 = new (Mnemonic.Endbr32);

    public static readonly BetterInstruction endbr64 = new (Mnemonic.Endbr64);

    public static readonly BetterInstruction enqcmd = new (Mnemonic.Enqcmd);

    public static readonly BetterInstruction enqcmds = new (Mnemonic.Enqcmds);

    public static readonly BetterInstruction enter = new (Mnemonic.Enter);

    public static readonly BetterInstruction extractps = new (Mnemonic.Extractps);

    public static readonly BetterInstruction extrq = new (Mnemonic.Extrq);

    public static readonly BetterInstruction f2xm1 = new (Mnemonic.F2xm1);

    public static readonly BetterInstruction fabs = new (Mnemonic.Fabs);

    public static readonly BetterInstruction fadd = new (Mnemonic.Fadd);

    public static readonly BetterInstruction faddp = new (Mnemonic.Faddp);

    public static readonly BetterInstruction fbld = new (Mnemonic.Fbld);

    public static readonly BetterInstruction fbstp = new (Mnemonic.Fbstp);

    public static readonly BetterInstruction fchs = new (Mnemonic.Fchs);

    public static readonly BetterInstruction fclex = new (Mnemonic.Fclex);

    public static readonly BetterInstruction fcmovb = new (Mnemonic.Fcmovb);

    public static readonly BetterInstruction fcmovbe = new (Mnemonic.Fcmovbe);

    public static readonly BetterInstruction fcmove = new (Mnemonic.Fcmove);

    public static readonly BetterInstruction fcmovnb = new (Mnemonic.Fcmovnb);

    public static readonly BetterInstruction fcmovnbe = new (Mnemonic.Fcmovnbe);

    public static readonly BetterInstruction fcmovne = new (Mnemonic.Fcmovne);

    public static readonly BetterInstruction fcmovnu = new (Mnemonic.Fcmovnu);

    public static readonly BetterInstruction fcmovu = new (Mnemonic.Fcmovu);

    public static readonly BetterInstruction fcom = new (Mnemonic.Fcom);

    public static readonly BetterInstruction fcomi = new (Mnemonic.Fcomi);

    public static readonly BetterInstruction fcomip = new (Mnemonic.Fcomip);

    public static readonly BetterInstruction fcomp = new (Mnemonic.Fcomp);

    public static readonly BetterInstruction fcompp = new (Mnemonic.Fcompp);

    public static readonly BetterInstruction fcos = new (Mnemonic.Fcos);

    public static readonly BetterInstruction fdecstp = new (Mnemonic.Fdecstp);

    public static readonly BetterInstruction fdisi = new (Mnemonic.Fdisi);

    public static readonly BetterInstruction fdiv = new (Mnemonic.Fdiv);

    public static readonly BetterInstruction fdivp = new (Mnemonic.Fdivp);

    public static readonly BetterInstruction fdivr = new (Mnemonic.Fdivr);

    public static readonly BetterInstruction fdivrp = new (Mnemonic.Fdivrp);

    public static readonly BetterInstruction femms = new (Mnemonic.Femms);

    public static readonly BetterInstruction feni = new (Mnemonic.Feni);

    public static readonly BetterInstruction ffree = new (Mnemonic.Ffree);

    public static readonly BetterInstruction ffreep = new (Mnemonic.Ffreep);

    public static readonly BetterInstruction fiadd = new (Mnemonic.Fiadd);

    public static readonly BetterInstruction ficom = new (Mnemonic.Ficom);

    public static readonly BetterInstruction ficomp = new (Mnemonic.Ficomp);

    public static readonly BetterInstruction fidiv = new (Mnemonic.Fidiv);

    public static readonly BetterInstruction fidivr = new (Mnemonic.Fidivr);

    public static readonly BetterInstruction fild = new (Mnemonic.Fild);

    public static readonly BetterInstruction fimul = new (Mnemonic.Fimul);

    public static readonly BetterInstruction fincstp = new (Mnemonic.Fincstp);

    public static readonly BetterInstruction finit = new (Mnemonic.Finit);

    public static readonly BetterInstruction fist = new (Mnemonic.Fist);

    public static readonly BetterInstruction fistp = new (Mnemonic.Fistp);

    public static readonly BetterInstruction fisttp = new (Mnemonic.Fisttp);

    public static readonly BetterInstruction fisub = new (Mnemonic.Fisub);

    public static readonly BetterInstruction fisubr = new (Mnemonic.Fisubr);

    public static readonly BetterInstruction fld = new (Mnemonic.Fld);

    public static readonly BetterInstruction fld1 = new (Mnemonic.Fld1);

    public static readonly BetterInstruction fldcw = new (Mnemonic.Fldcw);

    public static readonly BetterInstruction fldenv = new (Mnemonic.Fldenv);

    public static readonly BetterInstruction fldl2e = new (Mnemonic.Fldl2e);

    public static readonly BetterInstruction fldl2t = new (Mnemonic.Fldl2t);

    public static readonly BetterInstruction fldlg2 = new (Mnemonic.Fldlg2);

    public static readonly BetterInstruction fldln2 = new (Mnemonic.Fldln2);

    public static readonly BetterInstruction fldpi = new (Mnemonic.Fldpi);

    public static readonly BetterInstruction fldz = new (Mnemonic.Fldz);

    public static readonly BetterInstruction fmul = new (Mnemonic.Fmul);

    public static readonly BetterInstruction fmulp = new (Mnemonic.Fmulp);

    public static readonly BetterInstruction fnclex = new (Mnemonic.Fnclex);

    public static readonly BetterInstruction fndisi = new (Mnemonic.Fndisi);

    public static readonly BetterInstruction fneni = new (Mnemonic.Fneni);

    public static readonly BetterInstruction fninit = new (Mnemonic.Fninit);

    public static readonly BetterInstruction fnop = new (Mnemonic.Fnop);

    public static readonly BetterInstruction fnsave = new (Mnemonic.Fnsave);

    public static readonly BetterInstruction fnsetpm = new (Mnemonic.Fnsetpm);

    public static readonly BetterInstruction fnstcw = new (Mnemonic.Fnstcw);

    public static readonly BetterInstruction fnstenv = new (Mnemonic.Fnstenv);

    public static readonly BetterInstruction fnstsw = new (Mnemonic.Fnstsw);

    public static readonly BetterInstruction fpatan = new (Mnemonic.Fpatan);

    public static readonly BetterInstruction fprem = new (Mnemonic.Fprem);

    public static readonly BetterInstruction fprem1 = new (Mnemonic.Fprem1);

    public static readonly BetterInstruction fptan = new (Mnemonic.Fptan);

    public static readonly BetterInstruction frndint = new (Mnemonic.Frndint);

    public static readonly BetterInstruction frstor = new (Mnemonic.Frstor);

    public static readonly BetterInstruction frstpm = new (Mnemonic.Frstpm);

    public static readonly BetterInstruction fsave = new (Mnemonic.Fsave);

    public static readonly BetterInstruction fscale = new (Mnemonic.Fscale);

    public static readonly BetterInstruction fsetpm = new (Mnemonic.Fsetpm);

    public static readonly BetterInstruction fsin = new (Mnemonic.Fsin);

    public static readonly BetterInstruction fsincos = new (Mnemonic.Fsincos);

    public static readonly BetterInstruction fsqrt = new (Mnemonic.Fsqrt);

    public static readonly BetterInstruction fst = new (Mnemonic.Fst);

    public static readonly BetterInstruction fstcw = new (Mnemonic.Fstcw);

    public static readonly BetterInstruction fstdw = new (Mnemonic.Fstdw);

    public static readonly BetterInstruction fstenv = new (Mnemonic.Fstenv);

    public static readonly BetterInstruction fstp = new (Mnemonic.Fstp);

    public static readonly BetterInstruction fstpnce = new (Mnemonic.Fstpnce);

    public static readonly BetterInstruction fstsg = new (Mnemonic.Fstsg);

    public static readonly BetterInstruction fstsw = new (Mnemonic.Fstsw);

    public static readonly BetterInstruction fsub = new (Mnemonic.Fsub);

    public static readonly BetterInstruction fsubp = new (Mnemonic.Fsubp);

    public static readonly BetterInstruction fsubr = new (Mnemonic.Fsubr);

    public static readonly BetterInstruction fsubrp = new (Mnemonic.Fsubrp);

    public static readonly BetterInstruction ftst = new (Mnemonic.Ftst);

    public static readonly BetterInstruction fucom = new (Mnemonic.Fucom);

    public static readonly BetterInstruction fucomi = new (Mnemonic.Fucomi);

    public static readonly BetterInstruction fucomip = new (Mnemonic.Fucomip);

    public static readonly BetterInstruction fucomp = new (Mnemonic.Fucomp);

    public static readonly BetterInstruction fucompp = new (Mnemonic.Fucompp);

    public static readonly BetterInstruction fxam = new (Mnemonic.Fxam);

    public static readonly BetterInstruction fxch = new (Mnemonic.Fxch);

    public static readonly BetterInstruction fxrstor = new (Mnemonic.Fxrstor);

    public static readonly BetterInstruction fxrstor64 = new (Mnemonic.Fxrstor64);

    public static readonly BetterInstruction fxsave = new (Mnemonic.Fxsave);

    public static readonly BetterInstruction fxsave64 = new (Mnemonic.Fxsave64);

    public static readonly BetterInstruction fxtract = new (Mnemonic.Fxtract);

    public static readonly BetterInstruction fyl2x = new (Mnemonic.Fyl2x);

    public static readonly BetterInstruction fyl2xp1 = new (Mnemonic.Fyl2xp1);

    public static readonly BetterInstruction getsec = new (Mnemonic.Getsec);

    public static readonly BetterInstruction gf2p8affineinvqb = new (Mnemonic.Gf2p8affineinvqb);

    public static readonly BetterInstruction gf2p8affineqb = new (Mnemonic.Gf2p8affineqb);

    public static readonly BetterInstruction gf2p8mulb = new (Mnemonic.Gf2p8mulb);

    public static readonly BetterInstruction haddpd = new (Mnemonic.Haddpd);

    public static readonly BetterInstruction haddps = new (Mnemonic.Haddps);

    public static readonly BetterInstruction hlt = new (Mnemonic.Hlt);

    public static readonly BetterInstruction hsubpd = new (Mnemonic.Hsubpd);

    public static readonly BetterInstruction hsubps = new (Mnemonic.Hsubps);

    public static readonly BetterInstruction ibts = new (Mnemonic.Ibts);

    public static readonly BetterInstruction idiv = new (Mnemonic.Idiv);

    public static readonly BetterInstruction imul = new (Mnemonic.Imul);

    public static readonly BetterInstruction @in = new (Mnemonic.In);

    public static readonly BetterInstruction inc = new (Mnemonic.Inc);

    public static readonly BetterInstruction incsspd = new (Mnemonic.Incsspd);

    public static readonly BetterInstruction incsspq = new (Mnemonic.Incsspq);

    public static readonly BetterInstruction insb = new (Mnemonic.Insb);

    public static readonly BetterInstruction insd = new (Mnemonic.Insd);

    public static readonly BetterInstruction insertps = new (Mnemonic.Insertps);

    public static readonly BetterInstruction insertq = new (Mnemonic.Insertq);

    public static readonly BetterInstruction insw = new (Mnemonic.Insw);

    public static readonly BetterInstruction @int = new (Mnemonic.Int);

    public static readonly BetterInstruction int1 = new (Mnemonic.Int1);

    public static readonly BetterInstruction into = new (Mnemonic.Into);

    public static readonly BetterInstruction invd = new (Mnemonic.Invd);

    public static readonly BetterInstruction invept = new (Mnemonic.Invept);

    public static readonly BetterInstruction invlpg = new (Mnemonic.Invlpg);

    public static readonly BetterInstruction invlpga = new (Mnemonic.Invlpga);

    public static readonly BetterInstruction invpcid = new (Mnemonic.Invpcid);

    public static readonly BetterInstruction invvpid = new (Mnemonic.Invvpid);

    public static readonly BetterInstruction iret = new (Mnemonic.Iret);

    public static readonly BetterInstruction ja = new (Mnemonic.Ja);

    public static readonly BetterInstruction jae = new (Mnemonic.Jae);

    public static readonly BetterInstruction jb = new (Mnemonic.Jb);

    public static readonly BetterInstruction jbe = new (Mnemonic.Jbe);

    public static readonly BetterInstruction jcxz = new (Mnemonic.Jcxz);

    public static readonly BetterInstruction je = new (Mnemonic.Je);

    public static readonly BetterInstruction jecxz = new (Mnemonic.Jecxz);

    public static readonly BetterInstruction jg = new (Mnemonic.Jg);

    public static readonly BetterInstruction jge = new (Mnemonic.Jge);

    public static readonly BetterInstruction jl = new (Mnemonic.Jl);

    public static readonly BetterInstruction jle = new (Mnemonic.Jle);

    public static readonly BetterInstruction jmp = new (Mnemonic.Jmp);

    public static readonly BetterInstruction jmpe = new (Mnemonic.Jmpe);

    public static readonly BetterInstruction jne = new (Mnemonic.Jne);

    public static readonly BetterInstruction jno = new (Mnemonic.Jno);

    public static readonly BetterInstruction jnp = new (Mnemonic.Jnp);

    public static readonly BetterInstruction jns = new (Mnemonic.Jns);

    public static readonly BetterInstruction jo = new (Mnemonic.Jo);

    public static readonly BetterInstruction jp = new (Mnemonic.Jp);

    public static readonly BetterInstruction jrcxz = new (Mnemonic.Jrcxz);

    public static readonly BetterInstruction js = new (Mnemonic.Js);

    public static readonly BetterInstruction kaddb = new (Mnemonic.Kaddb);

    public static readonly BetterInstruction kaddd = new (Mnemonic.Kaddd);

    public static readonly BetterInstruction kaddq = new (Mnemonic.Kaddq);

    public static readonly BetterInstruction kaddw = new (Mnemonic.Kaddw);

    public static readonly BetterInstruction kandb = new (Mnemonic.Kandb);

    public static readonly BetterInstruction kandd = new (Mnemonic.Kandd);

    public static readonly BetterInstruction kandnb = new (Mnemonic.Kandnb);

    public static readonly BetterInstruction kandnd = new (Mnemonic.Kandnd);

    public static readonly BetterInstruction kandnq = new (Mnemonic.Kandnq);

    public static readonly BetterInstruction kandnw = new (Mnemonic.Kandnw);

    public static readonly BetterInstruction kandq = new (Mnemonic.Kandq);

    public static readonly BetterInstruction kandw = new (Mnemonic.Kandw);

    public static readonly BetterInstruction kmovb = new (Mnemonic.Kmovb);

    public static readonly BetterInstruction kmovd = new (Mnemonic.Kmovd);

    public static readonly BetterInstruction kmovq = new (Mnemonic.Kmovq);

    public static readonly BetterInstruction kmovw = new (Mnemonic.Kmovw);

    public static readonly BetterInstruction knotb = new (Mnemonic.Knotb);

    public static readonly BetterInstruction knotd = new (Mnemonic.Knotd);

    public static readonly BetterInstruction knotq = new (Mnemonic.Knotq);

    public static readonly BetterInstruction knotw = new (Mnemonic.Knotw);

    public static readonly BetterInstruction korb = new (Mnemonic.Korb);

    public static readonly BetterInstruction kord = new (Mnemonic.Kord);

    public static readonly BetterInstruction korq = new (Mnemonic.Korq);

    public static readonly BetterInstruction kortestb = new (Mnemonic.Kortestb);

    public static readonly BetterInstruction kortestd = new (Mnemonic.Kortestd);

    public static readonly BetterInstruction kortestq = new (Mnemonic.Kortestq);

    public static readonly BetterInstruction kortestw = new (Mnemonic.Kortestw);

    public static readonly BetterInstruction korw = new (Mnemonic.Korw);

    public static readonly BetterInstruction kshiftlb = new (Mnemonic.Kshiftlb);

    public static readonly BetterInstruction kshiftld = new (Mnemonic.Kshiftld);

    public static readonly BetterInstruction kshiftlq = new (Mnemonic.Kshiftlq);

    public static readonly BetterInstruction kshiftlw = new (Mnemonic.Kshiftlw);

    public static readonly BetterInstruction kshiftrb = new (Mnemonic.Kshiftrb);

    public static readonly BetterInstruction kshiftrd = new (Mnemonic.Kshiftrd);

    public static readonly BetterInstruction kshiftrq = new (Mnemonic.Kshiftrq);

    public static readonly BetterInstruction kshiftrw = new (Mnemonic.Kshiftrw);

    public static readonly BetterInstruction ktestb = new (Mnemonic.Ktestb);

    public static readonly BetterInstruction ktestd = new (Mnemonic.Ktestd);

    public static readonly BetterInstruction ktestq = new (Mnemonic.Ktestq);

    public static readonly BetterInstruction ktestw = new (Mnemonic.Ktestw);

    public static readonly BetterInstruction kunpckbw = new (Mnemonic.Kunpckbw);

    public static readonly BetterInstruction kunpckdq = new (Mnemonic.Kunpckdq);

    public static readonly BetterInstruction kunpckwd = new (Mnemonic.Kunpckwd);

    public static readonly BetterInstruction kxnorb = new (Mnemonic.Kxnorb);

    public static readonly BetterInstruction kxnord = new (Mnemonic.Kxnord);

    public static readonly BetterInstruction kxnorq = new (Mnemonic.Kxnorq);

    public static readonly BetterInstruction kxnorw = new (Mnemonic.Kxnorw);

    public static readonly BetterInstruction kxorb = new (Mnemonic.Kxorb);

    public static readonly BetterInstruction kxord = new (Mnemonic.Kxord);

    public static readonly BetterInstruction kxorq = new (Mnemonic.Kxorq);

    public static readonly BetterInstruction kxorw = new (Mnemonic.Kxorw);

    public static readonly BetterInstruction lahf = new (Mnemonic.Lahf);

    public static readonly BetterInstruction lar = new (Mnemonic.Lar);

    public static readonly BetterInstruction lddqu = new (Mnemonic.Lddqu);

    public static readonly BetterInstruction ldmxcsr = new (Mnemonic.Ldmxcsr);

    public static readonly BetterInstruction lds = new (Mnemonic.Lds);

    public static readonly BetterInstruction lea = new (Mnemonic.Lea);

    public static readonly BetterInstruction leave = new (Mnemonic.Leave);

    public static readonly BetterInstruction les = new (Mnemonic.Les);

    public static readonly BetterInstruction lfence = new (Mnemonic.Lfence);

    public static readonly BetterInstruction lfs = new (Mnemonic.Lfs);

    public static readonly BetterInstruction lgdt = new (Mnemonic.Lgdt);

    public static readonly BetterInstruction lgs = new (Mnemonic.Lgs);

    public static readonly BetterInstruction lidt = new (Mnemonic.Lidt);

    public static readonly BetterInstruction lldt = new (Mnemonic.Lldt);

    public static readonly BetterInstruction llwpcb = new (Mnemonic.Llwpcb);

    public static readonly BetterInstruction lmsw = new (Mnemonic.Lmsw);

    public static readonly BetterInstruction loadall = new (Mnemonic.Loadall);

    public static readonly BetterInstruction lodsb = new (Mnemonic.Lodsb);

    public static readonly BetterInstruction lodsd = new (Mnemonic.Lodsd);

    public static readonly BetterInstruction lodsq = new (Mnemonic.Lodsq);

    public static readonly BetterInstruction lodsw = new (Mnemonic.Lodsw);

    public static readonly BetterInstruction loop = new (Mnemonic.Loop);

    public static readonly BetterInstruction loope = new (Mnemonic.Loope);

    public static readonly BetterInstruction loopne = new (Mnemonic.Loopne);

    public static readonly BetterInstruction lsl = new (Mnemonic.Lsl);

    public static readonly BetterInstruction lss = new (Mnemonic.Lss);

    public static readonly BetterInstruction ltr = new (Mnemonic.Ltr);

    public static readonly BetterInstruction lwpins = new (Mnemonic.Lwpins);

    public static readonly BetterInstruction lwpval = new (Mnemonic.Lwpval);

    public static readonly BetterInstruction lzcnt = new (Mnemonic.Lzcnt);

    public static readonly BetterInstruction maskmovdqu = new (Mnemonic.Maskmovdqu);

    public static readonly BetterInstruction maskmovq = new (Mnemonic.Maskmovq);

    public static readonly BetterInstruction maxpd = new (Mnemonic.Maxpd);

    public static readonly BetterInstruction maxps = new (Mnemonic.Maxps);

    public static readonly BetterInstruction maxsd = new (Mnemonic.Maxsd);

    public static readonly BetterInstruction maxss = new (Mnemonic.Maxss);

    public static readonly BetterInstruction mcommit = new (Mnemonic.Mcommit);

    public static readonly BetterInstruction mfence = new (Mnemonic.Mfence);

    public static readonly BetterInstruction minpd = new (Mnemonic.Minpd);

    public static readonly BetterInstruction minps = new (Mnemonic.Minps);

    public static readonly BetterInstruction minsd = new (Mnemonic.Minsd);

    public static readonly BetterInstruction minss = new (Mnemonic.Minss);

    public static readonly BetterInstruction monitor = new (Mnemonic.Monitor);

    public static readonly BetterInstruction monitorx = new (Mnemonic.Monitorx);

    public static readonly BetterInstruction montmul = new (Mnemonic.Montmul);

    public static readonly BetterInstruction mov = new (Mnemonic.Mov);

    public static readonly BetterInstruction movapd = new (Mnemonic.Movapd);

    public static readonly BetterInstruction movaps = new (Mnemonic.Movaps);

    public static readonly BetterInstruction movbe = new (Mnemonic.Movbe);

    public static readonly BetterInstruction movd = new (Mnemonic.Movd);

    public static readonly BetterInstruction movddup = new (Mnemonic.Movddup);

    public static readonly BetterInstruction movdir64b = new (Mnemonic.Movdir64b);

    public static readonly BetterInstruction movdiri = new (Mnemonic.Movdiri);

    public static readonly BetterInstruction movdq2q = new (Mnemonic.Movdq2q);

    public static readonly BetterInstruction movdqa = new (Mnemonic.Movdqa);

    public static readonly BetterInstruction movdqu = new (Mnemonic.Movdqu);

    public static readonly BetterInstruction movhlps = new (Mnemonic.Movhlps);

    public static readonly BetterInstruction movhpd = new (Mnemonic.Movhpd);

    public static readonly BetterInstruction movhps = new (Mnemonic.Movhps);

    public static readonly BetterInstruction movlhps = new (Mnemonic.Movlhps);

    public static readonly BetterInstruction movlpd = new (Mnemonic.Movlpd);

    public static readonly BetterInstruction movlps = new (Mnemonic.Movlps);

    public static readonly BetterInstruction movmskpd = new (Mnemonic.Movmskpd);

    public static readonly BetterInstruction movmskps = new (Mnemonic.Movmskps);

    public static readonly BetterInstruction movntdq = new (Mnemonic.Movntdq);

    public static readonly BetterInstruction movntdqa = new (Mnemonic.Movntdqa);

    public static readonly BetterInstruction movnti = new (Mnemonic.Movnti);

    public static readonly BetterInstruction movntpd = new (Mnemonic.Movntpd);

    public static readonly BetterInstruction movntps = new (Mnemonic.Movntps);

    public static readonly BetterInstruction movntq = new (Mnemonic.Movntq);

    public static readonly BetterInstruction movntsd = new (Mnemonic.Movntsd);

    public static readonly BetterInstruction movntss = new (Mnemonic.Movntss);

    public static readonly BetterInstruction movq = new (Mnemonic.Movq);

    public static readonly BetterInstruction movq2dq = new (Mnemonic.Movq2dq);

    public static readonly BetterInstruction movsb = new (Mnemonic.Movsb);

    public static readonly BetterInstruction movsd = new (Mnemonic.Movsd);

    public static readonly BetterInstruction movshdup = new (Mnemonic.Movshdup);

    public static readonly BetterInstruction movsldup = new (Mnemonic.Movsldup);

    public static readonly BetterInstruction movsq = new (Mnemonic.Movsq);

    public static readonly BetterInstruction movss = new (Mnemonic.Movss);

    public static readonly BetterInstruction movsw = new (Mnemonic.Movsw);

    public static readonly BetterInstruction movsx = new (Mnemonic.Movsx);

    public static readonly BetterInstruction movsxd = new (Mnemonic.Movsxd);

    public static readonly BetterInstruction movupd = new (Mnemonic.Movupd);

    public static readonly BetterInstruction movups = new (Mnemonic.Movups);

    public static readonly BetterInstruction movzx = new (Mnemonic.Movzx);

    public static readonly BetterInstruction mpsadbw = new (Mnemonic.Mpsadbw);

    public static readonly BetterInstruction mul = new (Mnemonic.Mul);

    public static readonly BetterInstruction mulpd = new (Mnemonic.Mulpd);

    public static readonly BetterInstruction mulps = new (Mnemonic.Mulps);

    public static readonly BetterInstruction mulsd = new (Mnemonic.Mulsd);

    public static readonly BetterInstruction mulss = new (Mnemonic.Mulss);

    public static readonly BetterInstruction mulx = new (Mnemonic.Mulx);

    public static readonly BetterInstruction mwait = new (Mnemonic.Mwait);

    public static readonly BetterInstruction mwaitx = new (Mnemonic.Mwaitx);

    public static readonly BetterInstruction neg = new (Mnemonic.Neg);

    public static readonly BetterInstruction nop = new (Mnemonic.Nop);

    public static readonly BetterInstruction not = new (Mnemonic.Not);

    public static readonly BetterInstruction or = new (Mnemonic.Or);

    public static readonly BetterInstruction orpd = new (Mnemonic.Orpd);

    public static readonly BetterInstruction orps = new (Mnemonic.Orps);

    public static readonly BetterInstruction @out = new (Mnemonic.Out);

    public static readonly BetterInstruction outsb = new (Mnemonic.Outsb);

    public static readonly BetterInstruction outsd = new (Mnemonic.Outsd);

    public static readonly BetterInstruction outsw = new (Mnemonic.Outsw);

    public static readonly BetterInstruction pabsb = new (Mnemonic.Pabsb);

    public static readonly BetterInstruction pabsd = new (Mnemonic.Pabsd);

    public static readonly BetterInstruction pabsw = new (Mnemonic.Pabsw);

    public static readonly BetterInstruction packssdw = new (Mnemonic.Packssdw);

    public static readonly BetterInstruction packsswb = new (Mnemonic.Packsswb);

    public static readonly BetterInstruction packusdw = new (Mnemonic.Packusdw);

    public static readonly BetterInstruction packuswb = new (Mnemonic.Packuswb);

    public static readonly BetterInstruction paddb = new (Mnemonic.Paddb);

    public static readonly BetterInstruction paddd = new (Mnemonic.Paddd);

    public static readonly BetterInstruction paddq = new (Mnemonic.Paddq);

    public static readonly BetterInstruction paddsb = new (Mnemonic.Paddsb);

    public static readonly BetterInstruction paddsw = new (Mnemonic.Paddsw);

    public static readonly BetterInstruction paddusb = new (Mnemonic.Paddusb);

    public static readonly BetterInstruction paddusw = new (Mnemonic.Paddusw);

    public static readonly BetterInstruction paddw = new (Mnemonic.Paddw);

    public static readonly BetterInstruction palignr = new (Mnemonic.Palignr);

    public static readonly BetterInstruction pand = new (Mnemonic.Pand);

    public static readonly BetterInstruction pandn = new (Mnemonic.Pandn);

    public static readonly BetterInstruction pause = new (Mnemonic.Pause);

    public static readonly BetterInstruction pavgb = new (Mnemonic.Pavgb);

    public static readonly BetterInstruction pavgusb = new (Mnemonic.Pavgusb);

    public static readonly BetterInstruction pavgw = new (Mnemonic.Pavgw);

    public static readonly BetterInstruction pblendvb = new (Mnemonic.Pblendvb);

    public static readonly BetterInstruction pblendw = new (Mnemonic.Pblendw);

    public static readonly BetterInstruction pclmulqdq = new (Mnemonic.Pclmulqdq);

    public static readonly BetterInstruction pcmpeqb = new (Mnemonic.Pcmpeqb);

    public static readonly BetterInstruction pcmpeqd = new (Mnemonic.Pcmpeqd);

    public static readonly BetterInstruction pcmpeqq = new (Mnemonic.Pcmpeqq);

    public static readonly BetterInstruction pcmpeqw = new (Mnemonic.Pcmpeqw);

    public static readonly BetterInstruction pcmpestri = new (Mnemonic.Pcmpestri);

    public static readonly BetterInstruction pcmpestri64 = new (Mnemonic.Pcmpestri64);

    public static readonly BetterInstruction pcmpestrm = new (Mnemonic.Pcmpestrm);

    public static readonly BetterInstruction pcmpestrm64 = new (Mnemonic.Pcmpestrm64);

    public static readonly BetterInstruction pcmpgtb = new (Mnemonic.Pcmpgtb);

    public static readonly BetterInstruction pcmpgtd = new (Mnemonic.Pcmpgtd);

    public static readonly BetterInstruction pcmpgtq = new (Mnemonic.Pcmpgtq);

    public static readonly BetterInstruction pcmpgtw = new (Mnemonic.Pcmpgtw);

    public static readonly BetterInstruction pcmpistri = new (Mnemonic.Pcmpistri);

    public static readonly BetterInstruction pcmpistrm = new (Mnemonic.Pcmpistrm);

    public static readonly BetterInstruction pcommit = new (Mnemonic.Pcommit);

    public static readonly BetterInstruction pconfig = new (Mnemonic.Pconfig);

    public static readonly BetterInstruction pdep = new (Mnemonic.Pdep);

    public static readonly BetterInstruction pext = new (Mnemonic.Pext);

    public static readonly BetterInstruction pextrb = new (Mnemonic.Pextrb);

    public static readonly BetterInstruction pextrd = new (Mnemonic.Pextrd);

    public static readonly BetterInstruction pextrq = new (Mnemonic.Pextrq);

    public static readonly BetterInstruction pextrw = new (Mnemonic.Pextrw);

    public static readonly BetterInstruction pf2id = new (Mnemonic.Pf2id);

    public static readonly BetterInstruction pf2iw = new (Mnemonic.Pf2iw);

    public static readonly BetterInstruction pfacc = new (Mnemonic.Pfacc);

    public static readonly BetterInstruction pfadd = new (Mnemonic.Pfadd);

    public static readonly BetterInstruction pfcmpeq = new (Mnemonic.Pfcmpeq);

    public static readonly BetterInstruction pfcmpge = new (Mnemonic.Pfcmpge);

    public static readonly BetterInstruction pfcmpgt = new (Mnemonic.Pfcmpgt);

    public static readonly BetterInstruction pfmax = new (Mnemonic.Pfmax);

    public static readonly BetterInstruction pfmin = new (Mnemonic.Pfmin);

    public static readonly BetterInstruction pfmul = new (Mnemonic.Pfmul);

    public static readonly BetterInstruction pfnacc = new (Mnemonic.Pfnacc);

    public static readonly BetterInstruction pfpnacc = new (Mnemonic.Pfpnacc);

    public static readonly BetterInstruction pfrcp = new (Mnemonic.Pfrcp);

    public static readonly BetterInstruction pfrcpit1 = new (Mnemonic.Pfrcpit1);

    public static readonly BetterInstruction pfrcpit2 = new (Mnemonic.Pfrcpit2);

    public static readonly BetterInstruction pfrcpv = new (Mnemonic.Pfrcpv);

    public static readonly BetterInstruction pfrsqit1 = new (Mnemonic.Pfrsqit1);

    public static readonly BetterInstruction pfrsqrt = new (Mnemonic.Pfrsqrt);

    public static readonly BetterInstruction pfrsqrtv = new (Mnemonic.Pfrsqrtv);

    public static readonly BetterInstruction pfsub = new (Mnemonic.Pfsub);

    public static readonly BetterInstruction pfsubr = new (Mnemonic.Pfsubr);

    public static readonly BetterInstruction phaddd = new (Mnemonic.Phaddd);

    public static readonly BetterInstruction phaddsw = new (Mnemonic.Phaddsw);

    public static readonly BetterInstruction phaddw = new (Mnemonic.Phaddw);

    public static readonly BetterInstruction phminposuw = new (Mnemonic.Phminposuw);

    public static readonly BetterInstruction phsubd = new (Mnemonic.Phsubd);

    public static readonly BetterInstruction phsubsw = new (Mnemonic.Phsubsw);

    public static readonly BetterInstruction phsubw = new (Mnemonic.Phsubw);

    public static readonly BetterInstruction pi2fd = new (Mnemonic.Pi2fd);

    public static readonly BetterInstruction pi2fw = new (Mnemonic.Pi2fw);

    public static readonly BetterInstruction pinsrb = new (Mnemonic.Pinsrb);

    public static readonly BetterInstruction pinsrd = new (Mnemonic.Pinsrd);

    public static readonly BetterInstruction pinsrq = new (Mnemonic.Pinsrq);

    public static readonly BetterInstruction pinsrw = new (Mnemonic.Pinsrw);

    public static readonly BetterInstruction pmaddubsw = new (Mnemonic.Pmaddubsw);

    public static readonly BetterInstruction pmaddwd = new (Mnemonic.Pmaddwd);

    public static readonly BetterInstruction pmaxsb = new (Mnemonic.Pmaxsb);

    public static readonly BetterInstruction pmaxsd = new (Mnemonic.Pmaxsd);

    public static readonly BetterInstruction pmaxsw = new (Mnemonic.Pmaxsw);

    public static readonly BetterInstruction pmaxub = new (Mnemonic.Pmaxub);

    public static readonly BetterInstruction pmaxud = new (Mnemonic.Pmaxud);

    public static readonly BetterInstruction pmaxuw = new (Mnemonic.Pmaxuw);

    public static readonly BetterInstruction pminsb = new (Mnemonic.Pminsb);

    public static readonly BetterInstruction pminsd = new (Mnemonic.Pminsd);

    public static readonly BetterInstruction pminsw = new (Mnemonic.Pminsw);

    public static readonly BetterInstruction pminub = new (Mnemonic.Pminub);

    public static readonly BetterInstruction pminud = new (Mnemonic.Pminud);

    public static readonly BetterInstruction pminuw = new (Mnemonic.Pminuw);

    public static readonly BetterInstruction pmovmskb = new (Mnemonic.Pmovmskb);

    public static readonly BetterInstruction pmovsxbd = new (Mnemonic.Pmovsxbd);

    public static readonly BetterInstruction pmovsxbq = new (Mnemonic.Pmovsxbq);

    public static readonly BetterInstruction pmovsxbw = new (Mnemonic.Pmovsxbw);

    public static readonly BetterInstruction pmovsxdq = new (Mnemonic.Pmovsxdq);

    public static readonly BetterInstruction pmovsxwd = new (Mnemonic.Pmovsxwd);

    public static readonly BetterInstruction pmovsxwq = new (Mnemonic.Pmovsxwq);

    public static readonly BetterInstruction pmovzxbd = new (Mnemonic.Pmovzxbd);

    public static readonly BetterInstruction pmovzxbq = new (Mnemonic.Pmovzxbq);

    public static readonly BetterInstruction pmovzxbw = new (Mnemonic.Pmovzxbw);

    public static readonly BetterInstruction pmovzxdq = new (Mnemonic.Pmovzxdq);

    public static readonly BetterInstruction pmovzxwd = new (Mnemonic.Pmovzxwd);

    public static readonly BetterInstruction pmovzxwq = new (Mnemonic.Pmovzxwq);

    public static readonly BetterInstruction pmuldq = new (Mnemonic.Pmuldq);

    public static readonly BetterInstruction pmulhrsw = new (Mnemonic.Pmulhrsw);

    public static readonly BetterInstruction pmulhrw = new (Mnemonic.Pmulhrw);

    public static readonly BetterInstruction pmulhuw = new (Mnemonic.Pmulhuw);

    public static readonly BetterInstruction pmulhw = new (Mnemonic.Pmulhw);

    public static readonly BetterInstruction pmulld = new (Mnemonic.Pmulld);

    public static readonly BetterInstruction pmullw = new (Mnemonic.Pmullw);

    public static readonly BetterInstruction pmuludq = new (Mnemonic.Pmuludq);

    public static readonly BetterInstruction pop = new (Mnemonic.Pop);

    public static readonly BetterInstruction popa = new (Mnemonic.Popa);

    public static readonly BetterInstruction popcnt = new (Mnemonic.Popcnt);

    public static readonly BetterInstruction popf = new (Mnemonic.Popf);

    public static readonly BetterInstruction por = new (Mnemonic.Por);

    public static readonly BetterInstruction prefetch = new (Mnemonic.Prefetch);

    public static readonly BetterInstruction prefetchnta = new (Mnemonic.Prefetchnta);

    public static readonly BetterInstruction prefetcht0 = new (Mnemonic.Prefetcht0);

    public static readonly BetterInstruction prefetcht1 = new (Mnemonic.Prefetcht1);

    public static readonly BetterInstruction prefetcht2 = new (Mnemonic.Prefetcht2);

    public static readonly BetterInstruction prefetchw = new (Mnemonic.Prefetchw);

    public static readonly BetterInstruction prefetchwt1 = new (Mnemonic.Prefetchwt1);

    public static readonly BetterInstruction psadbw = new (Mnemonic.Psadbw);

    public static readonly BetterInstruction pshufb = new (Mnemonic.Pshufb);

    public static readonly BetterInstruction pshufd = new (Mnemonic.Pshufd);

    public static readonly BetterInstruction pshufhw = new (Mnemonic.Pshufhw);

    public static readonly BetterInstruction pshuflw = new (Mnemonic.Pshuflw);

    public static readonly BetterInstruction pshufw = new (Mnemonic.Pshufw);

    public static readonly BetterInstruction psignb = new (Mnemonic.Psignb);

    public static readonly BetterInstruction psignd = new (Mnemonic.Psignd);

    public static readonly BetterInstruction psignw = new (Mnemonic.Psignw);

    public static readonly BetterInstruction pslld = new (Mnemonic.Pslld);

    public static readonly BetterInstruction pslldq = new (Mnemonic.Pslldq);

    public static readonly BetterInstruction psllq = new (Mnemonic.Psllq);

    public static readonly BetterInstruction psllw = new (Mnemonic.Psllw);

    public static readonly BetterInstruction psrad = new (Mnemonic.Psrad);

    public static readonly BetterInstruction psraw = new (Mnemonic.Psraw);

    public static readonly BetterInstruction psrld = new (Mnemonic.Psrld);

    public static readonly BetterInstruction psrldq = new (Mnemonic.Psrldq);

    public static readonly BetterInstruction psrlq = new (Mnemonic.Psrlq);

    public static readonly BetterInstruction psrlw = new (Mnemonic.Psrlw);

    public static readonly BetterInstruction psubb = new (Mnemonic.Psubb);

    public static readonly BetterInstruction psubd = new (Mnemonic.Psubd);

    public static readonly BetterInstruction psubq = new (Mnemonic.Psubq);

    public static readonly BetterInstruction psubsb = new (Mnemonic.Psubsb);

    public static readonly BetterInstruction psubsw = new (Mnemonic.Psubsw);

    public static readonly BetterInstruction psubusb = new (Mnemonic.Psubusb);

    public static readonly BetterInstruction psubusw = new (Mnemonic.Psubusw);

    public static readonly BetterInstruction psubw = new (Mnemonic.Psubw);

    public static readonly BetterInstruction pswapd = new (Mnemonic.Pswapd);

    public static readonly BetterInstruction ptest = new (Mnemonic.Ptest);

    public static readonly BetterInstruction ptwrite = new (Mnemonic.Ptwrite);

    public static readonly BetterInstruction punpckhbw = new (Mnemonic.Punpckhbw);

    public static readonly BetterInstruction punpckhdq = new (Mnemonic.Punpckhdq);

    public static readonly BetterInstruction punpckhqdq = new (Mnemonic.Punpckhqdq);

    public static readonly BetterInstruction punpckhwd = new (Mnemonic.Punpckhwd);

    public static readonly BetterInstruction punpcklbw = new (Mnemonic.Punpcklbw);

    public static readonly BetterInstruction punpckldq = new (Mnemonic.Punpckldq);

    public static readonly BetterInstruction punpcklqdq = new (Mnemonic.Punpcklqdq);

    public static readonly BetterInstruction punpcklwd = new (Mnemonic.Punpcklwd);

    public static readonly BetterInstruction push = new (Mnemonic.Push);

    public static readonly BetterInstruction pusha = new (Mnemonic.Pusha);

    public static readonly BetterInstruction pushf = new (Mnemonic.Pushf);

    public static readonly BetterInstruction pxor = new (Mnemonic.Pxor);

    public static readonly BetterInstruction rcl = new (Mnemonic.Rcl);

    public static readonly BetterInstruction rcpps = new (Mnemonic.Rcpps);

    public static readonly BetterInstruction rcpss = new (Mnemonic.Rcpss);

    public static readonly BetterInstruction rcr = new (Mnemonic.Rcr);

    public static readonly BetterInstruction rdfsbase = new (Mnemonic.Rdfsbase);

    public static readonly BetterInstruction rdgsbase = new (Mnemonic.Rdgsbase);

    public static readonly BetterInstruction rdmsr = new (Mnemonic.Rdmsr);

    public static readonly BetterInstruction rdpid = new (Mnemonic.Rdpid);

    public static readonly BetterInstruction rdpkru = new (Mnemonic.Rdpkru);

    public static readonly BetterInstruction rdpmc = new (Mnemonic.Rdpmc);

    public static readonly BetterInstruction rdpru = new (Mnemonic.Rdpru);

    public static readonly BetterInstruction rdrand = new (Mnemonic.Rdrand);

    public static readonly BetterInstruction rdseed = new (Mnemonic.Rdseed);

    public static readonly BetterInstruction rdsspd = new (Mnemonic.Rdsspd);

    public static readonly BetterInstruction rdsspq = new (Mnemonic.Rdsspq);

    public static readonly BetterInstruction rdtsc = new (Mnemonic.Rdtsc);

    public static readonly BetterInstruction rdtscp = new (Mnemonic.Rdtscp);

    public static readonly BetterInstruction reservednop = new (Mnemonic.Reservednop);

    public static readonly BetterInstruction ret = new (Mnemonic.Ret);

    public static readonly BetterInstruction retf = new (Mnemonic.Retf);

    public static readonly BetterInstruction rol = new (Mnemonic.Rol);

    public static readonly BetterInstruction ror = new (Mnemonic.Ror);

    public static readonly BetterInstruction rorx = new (Mnemonic.Rorx);

    public static readonly BetterInstruction roundpd = new (Mnemonic.Roundpd);

    public static readonly BetterInstruction roundps = new (Mnemonic.Roundps);

    public static readonly BetterInstruction roundsd = new (Mnemonic.Roundsd);

    public static readonly BetterInstruction roundss = new (Mnemonic.Roundss);

    public static readonly BetterInstruction rsm = new (Mnemonic.Rsm);

    public static readonly BetterInstruction rsqrtps = new (Mnemonic.Rsqrtps);

    public static readonly BetterInstruction rsqrtss = new (Mnemonic.Rsqrtss);

    public static readonly BetterInstruction rstorssp = new (Mnemonic.Rstorssp);

    public static readonly BetterInstruction sahf = new (Mnemonic.Sahf);

    public static readonly BetterInstruction sal = new (Mnemonic.Sal);

    public static readonly BetterInstruction salc = new (Mnemonic.Salc);

    public static readonly BetterInstruction sar = new (Mnemonic.Sar);

    public static readonly BetterInstruction sarx = new (Mnemonic.Sarx);

    public static readonly BetterInstruction saveprevssp = new (Mnemonic.Saveprevssp);

    public static readonly BetterInstruction sbb = new (Mnemonic.Sbb);

    public static readonly BetterInstruction scasb = new (Mnemonic.Scasb);

    public static readonly BetterInstruction scasd = new (Mnemonic.Scasd);

    public static readonly BetterInstruction scasq = new (Mnemonic.Scasq);

    public static readonly BetterInstruction scasw = new (Mnemonic.Scasw);

    public static readonly BetterInstruction seta = new (Mnemonic.Seta);

    public static readonly BetterInstruction setae = new (Mnemonic.Setae);

    public static readonly BetterInstruction setb = new (Mnemonic.Setb);

    public static readonly BetterInstruction setbe = new (Mnemonic.Setbe);

    public static readonly BetterInstruction sete = new (Mnemonic.Sete);

    public static readonly BetterInstruction setg = new (Mnemonic.Setg);

    public static readonly BetterInstruction setge = new (Mnemonic.Setge);

    public static readonly BetterInstruction setl = new (Mnemonic.Setl);

    public static readonly BetterInstruction setle = new (Mnemonic.Setle);

    public static readonly BetterInstruction setne = new (Mnemonic.Setne);

    public static readonly BetterInstruction setno = new (Mnemonic.Setno);

    public static readonly BetterInstruction setnp = new (Mnemonic.Setnp);

    public static readonly BetterInstruction setns = new (Mnemonic.Setns);

    public static readonly BetterInstruction seto = new (Mnemonic.Seto);

    public static readonly BetterInstruction setp = new (Mnemonic.Setp);

    public static readonly BetterInstruction sets = new (Mnemonic.Sets);

    public static readonly BetterInstruction setssbsy = new (Mnemonic.Setssbsy);

    public static readonly BetterInstruction sfence = new (Mnemonic.Sfence);

    public static readonly BetterInstruction sgdt = new (Mnemonic.Sgdt);

    public static readonly BetterInstruction sha1msg1 = new (Mnemonic.Sha1msg1);

    public static readonly BetterInstruction sha1msg2 = new (Mnemonic.Sha1msg2);

    public static readonly BetterInstruction sha1nexte = new (Mnemonic.Sha1nexte);

    public static readonly BetterInstruction sha1rnds4 = new (Mnemonic.Sha1rnds4);

    public static readonly BetterInstruction sha256msg1 = new (Mnemonic.Sha256msg1);

    public static readonly BetterInstruction sha256msg2 = new (Mnemonic.Sha256msg2);

    public static readonly BetterInstruction sha256rnds2 = new (Mnemonic.Sha256rnds2);

    public static readonly BetterInstruction shl = new (Mnemonic.Shl);

    public static readonly BetterInstruction shld = new (Mnemonic.Shld);

    public static readonly BetterInstruction shlx = new (Mnemonic.Shlx);

    public static readonly BetterInstruction shr = new (Mnemonic.Shr);

    public static readonly BetterInstruction shrd = new (Mnemonic.Shrd);

    public static readonly BetterInstruction shrx = new (Mnemonic.Shrx);

    public static readonly BetterInstruction shufpd = new (Mnemonic.Shufpd);

    public static readonly BetterInstruction shufps = new (Mnemonic.Shufps);

    public static readonly BetterInstruction sidt = new (Mnemonic.Sidt);

    public static readonly BetterInstruction skinit = new (Mnemonic.Skinit);

    public static readonly BetterInstruction sldt = new (Mnemonic.Sldt);

    public static readonly BetterInstruction slwpcb = new (Mnemonic.Slwpcb);

    public static readonly BetterInstruction smsw = new (Mnemonic.Smsw);

    public static readonly BetterInstruction sqrtpd = new (Mnemonic.Sqrtpd);

    public static readonly BetterInstruction sqrtps = new (Mnemonic.Sqrtps);

    public static readonly BetterInstruction sqrtsd = new (Mnemonic.Sqrtsd);

    public static readonly BetterInstruction sqrtss = new (Mnemonic.Sqrtss);

    public static readonly BetterInstruction stac = new (Mnemonic.Stac);

    public static readonly BetterInstruction stc = new (Mnemonic.Stc);

    public static readonly BetterInstruction std = new (Mnemonic.Std);

    public static readonly BetterInstruction stgi = new (Mnemonic.Stgi);

    public static readonly BetterInstruction sti = new (Mnemonic.Sti);

    public static readonly BetterInstruction stmxcsr = new (Mnemonic.Stmxcsr);

    public static readonly BetterInstruction stosb = new (Mnemonic.Stosb);

    public static readonly BetterInstruction stosd = new (Mnemonic.Stosd);

    public static readonly BetterInstruction stosq = new (Mnemonic.Stosq);

    public static readonly BetterInstruction stosw = new (Mnemonic.Stosw);

    public static readonly BetterInstruction str = new (Mnemonic.Str);

    public static readonly BetterInstruction sub = new (Mnemonic.Sub);

    public static readonly BetterInstruction subpd = new (Mnemonic.Subpd);

    public static readonly BetterInstruction subps = new (Mnemonic.Subps);

    public static readonly BetterInstruction subsd = new (Mnemonic.Subsd);

    public static readonly BetterInstruction subss = new (Mnemonic.Subss);

    public static readonly BetterInstruction swapgs = new (Mnemonic.Swapgs);

    public static readonly BetterInstruction syscall = new (Mnemonic.Syscall);

    public static readonly BetterInstruction sysenter = new (Mnemonic.Sysenter);

    public static readonly BetterInstruction sysexit = new (Mnemonic.Sysexit);

    public static readonly BetterInstruction sysret = new (Mnemonic.Sysret);

    public static readonly BetterInstruction t1mskc = new (Mnemonic.T1mskc);

    public static readonly BetterInstruction test = new (Mnemonic.Test);

    public static readonly BetterInstruction tpause = new (Mnemonic.Tpause);

    public static readonly BetterInstruction tzcnt = new (Mnemonic.Tzcnt);

    public static readonly BetterInstruction tzmsk = new (Mnemonic.Tzmsk);

    public static readonly BetterInstruction ucomisd = new (Mnemonic.Ucomisd);

    public static readonly BetterInstruction ucomiss = new (Mnemonic.Ucomiss);

    public static readonly BetterInstruction ud0 = new (Mnemonic.Ud0);

    public static readonly BetterInstruction ud1 = new (Mnemonic.Ud1);

    public static readonly BetterInstruction ud2 = new (Mnemonic.Ud2);

    public static readonly BetterInstruction umonitor = new (Mnemonic.Umonitor);

    public static readonly BetterInstruction umov = new (Mnemonic.Umov);

    public static readonly BetterInstruction umwait = new (Mnemonic.Umwait);

    public static readonly BetterInstruction unpckhpd = new (Mnemonic.Unpckhpd);

    public static readonly BetterInstruction unpckhps = new (Mnemonic.Unpckhps);

    public static readonly BetterInstruction unpcklpd = new (Mnemonic.Unpcklpd);

    public static readonly BetterInstruction unpcklps = new (Mnemonic.Unpcklps);

    public static readonly BetterInstruction v4fmaddps = new (Mnemonic.V4fmaddps);

    public static readonly BetterInstruction v4fmaddss = new (Mnemonic.V4fmaddss);

    public static readonly BetterInstruction v4fnmaddps = new (Mnemonic.V4fnmaddps);

    public static readonly BetterInstruction v4fnmaddss = new (Mnemonic.V4fnmaddss);

    public static readonly BetterInstruction vaddpd = new (Mnemonic.Vaddpd);

    public static readonly BetterInstruction vaddps = new (Mnemonic.Vaddps);

    public static readonly BetterInstruction vaddsd = new (Mnemonic.Vaddsd);

    public static readonly BetterInstruction vaddss = new (Mnemonic.Vaddss);

    public static readonly BetterInstruction vaddsubpd = new (Mnemonic.Vaddsubpd);

    public static readonly BetterInstruction vaddsubps = new (Mnemonic.Vaddsubps);

    public static readonly BetterInstruction vaesdec = new (Mnemonic.Vaesdec);

    public static readonly BetterInstruction vaesdeclast = new (Mnemonic.Vaesdeclast);

    public static readonly BetterInstruction vaesenc = new (Mnemonic.Vaesenc);

    public static readonly BetterInstruction vaesenclast = new (Mnemonic.Vaesenclast);

    public static readonly BetterInstruction vaesimc = new (Mnemonic.Vaesimc);

    public static readonly BetterInstruction vaeskeygenassist = new (Mnemonic.Vaeskeygenassist);

    public static readonly BetterInstruction valignd = new (Mnemonic.Valignd);

    public static readonly BetterInstruction valignq = new (Mnemonic.Valignq);

    public static readonly BetterInstruction vandnpd = new (Mnemonic.Vandnpd);

    public static readonly BetterInstruction vandnps = new (Mnemonic.Vandnps);

    public static readonly BetterInstruction vandpd = new (Mnemonic.Vandpd);

    public static readonly BetterInstruction vandps = new (Mnemonic.Vandps);

    public static readonly BetterInstruction vblendmpd = new (Mnemonic.Vblendmpd);

    public static readonly BetterInstruction vblendmps = new (Mnemonic.Vblendmps);

    public static readonly BetterInstruction vblendpd = new (Mnemonic.Vblendpd);

    public static readonly BetterInstruction vblendps = new (Mnemonic.Vblendps);

    public static readonly BetterInstruction vblendvpd = new (Mnemonic.Vblendvpd);

    public static readonly BetterInstruction vblendvps = new (Mnemonic.Vblendvps);

    public static readonly BetterInstruction vbroadcastf128 = new (Mnemonic.Vbroadcastf128);

    public static readonly BetterInstruction vbroadcastf32x2 = new (Mnemonic.Vbroadcastf32x2);

    public static readonly BetterInstruction vbroadcastf32x4 = new (Mnemonic.Vbroadcastf32x4);

    public static readonly BetterInstruction vbroadcastf32x8 = new (Mnemonic.Vbroadcastf32x8);

    public static readonly BetterInstruction vbroadcastf64x2 = new (Mnemonic.Vbroadcastf64x2);

    public static readonly BetterInstruction vbroadcastf64x4 = new (Mnemonic.Vbroadcastf64x4);

    public static readonly BetterInstruction vbroadcasti128 = new (Mnemonic.Vbroadcasti128);

    public static readonly BetterInstruction vbroadcasti32x2 = new (Mnemonic.Vbroadcasti32x2);

    public static readonly BetterInstruction vbroadcasti32x4 = new (Mnemonic.Vbroadcasti32x4);

    public static readonly BetterInstruction vbroadcasti32x8 = new (Mnemonic.Vbroadcasti32x8);

    public static readonly BetterInstruction vbroadcasti64x2 = new (Mnemonic.Vbroadcasti64x2);

    public static readonly BetterInstruction vbroadcasti64x4 = new (Mnemonic.Vbroadcasti64x4);

    public static readonly BetterInstruction vbroadcastsd = new (Mnemonic.Vbroadcastsd);

    public static readonly BetterInstruction vbroadcastss = new (Mnemonic.Vbroadcastss);

    public static readonly BetterInstruction vcmppd = new (Mnemonic.Vcmppd);

    public static readonly BetterInstruction vcmpps = new (Mnemonic.Vcmpps);

    public static readonly BetterInstruction vcmpsd = new (Mnemonic.Vcmpsd);

    public static readonly BetterInstruction vcmpss = new (Mnemonic.Vcmpss);

    public static readonly BetterInstruction vcomisd = new (Mnemonic.Vcomisd);

    public static readonly BetterInstruction vcomiss = new (Mnemonic.Vcomiss);

    public static readonly BetterInstruction vcompresspd = new (Mnemonic.Vcompresspd);

    public static readonly BetterInstruction vcompressps = new (Mnemonic.Vcompressps);

    public static readonly BetterInstruction vcvtdq2pd = new (Mnemonic.Vcvtdq2pd);

    public static readonly BetterInstruction vcvtdq2ps = new (Mnemonic.Vcvtdq2ps);

    public static readonly BetterInstruction vcvtne2ps2bf16 = new (Mnemonic.Vcvtne2ps2bf16);

    public static readonly BetterInstruction vcvtneps2bf16 = new (Mnemonic.Vcvtneps2bf16);

    public static readonly BetterInstruction vcvtpd2dq = new (Mnemonic.Vcvtpd2dq);

    public static readonly BetterInstruction vcvtpd2ps = new (Mnemonic.Vcvtpd2ps);

    public static readonly BetterInstruction vcvtpd2qq = new (Mnemonic.Vcvtpd2qq);

    public static readonly BetterInstruction vcvtpd2udq = new (Mnemonic.Vcvtpd2udq);

    public static readonly BetterInstruction vcvtpd2uqq = new (Mnemonic.Vcvtpd2uqq);

    public static readonly BetterInstruction vcvtph2ps = new (Mnemonic.Vcvtph2ps);

    public static readonly BetterInstruction vcvtps2dq = new (Mnemonic.Vcvtps2dq);

    public static readonly BetterInstruction vcvtps2pd = new (Mnemonic.Vcvtps2pd);

    public static readonly BetterInstruction vcvtps2ph = new (Mnemonic.Vcvtps2ph);

    public static readonly BetterInstruction vcvtps2qq = new (Mnemonic.Vcvtps2qq);

    public static readonly BetterInstruction vcvtps2udq = new (Mnemonic.Vcvtps2udq);

    public static readonly BetterInstruction vcvtps2uqq = new (Mnemonic.Vcvtps2uqq);

    public static readonly BetterInstruction vcvtqq2pd = new (Mnemonic.Vcvtqq2pd);

    public static readonly BetterInstruction vcvtqq2ps = new (Mnemonic.Vcvtqq2ps);

    public static readonly BetterInstruction vcvtsd2si = new (Mnemonic.Vcvtsd2si);

    public static readonly BetterInstruction vcvtsd2ss = new (Mnemonic.Vcvtsd2ss);

    public static readonly BetterInstruction vcvtsd2usi = new (Mnemonic.Vcvtsd2usi);

    public static readonly BetterInstruction vcvtsi2sd = new (Mnemonic.Vcvtsi2sd);

    public static readonly BetterInstruction vcvtsi2ss = new (Mnemonic.Vcvtsi2ss);

    public static readonly BetterInstruction vcvtss2sd = new (Mnemonic.Vcvtss2sd);

    public static readonly BetterInstruction vcvtss2si = new (Mnemonic.Vcvtss2si);

    public static readonly BetterInstruction vcvtss2usi = new (Mnemonic.Vcvtss2usi);

    public static readonly BetterInstruction vcvttpd2dq = new (Mnemonic.Vcvttpd2dq);

    public static readonly BetterInstruction vcvttpd2qq = new (Mnemonic.Vcvttpd2qq);

    public static readonly BetterInstruction vcvttpd2udq = new (Mnemonic.Vcvttpd2udq);

    public static readonly BetterInstruction vcvttpd2uqq = new (Mnemonic.Vcvttpd2uqq);

    public static readonly BetterInstruction vcvttps2dq = new (Mnemonic.Vcvttps2dq);

    public static readonly BetterInstruction vcvttps2qq = new (Mnemonic.Vcvttps2qq);

    public static readonly BetterInstruction vcvttps2udq = new (Mnemonic.Vcvttps2udq);

    public static readonly BetterInstruction vcvttps2uqq = new (Mnemonic.Vcvttps2uqq);

    public static readonly BetterInstruction vcvttsd2si = new (Mnemonic.Vcvttsd2si);

    public static readonly BetterInstruction vcvttsd2usi = new (Mnemonic.Vcvttsd2usi);

    public static readonly BetterInstruction vcvttss2si = new (Mnemonic.Vcvttss2si);

    public static readonly BetterInstruction vcvttss2usi = new (Mnemonic.Vcvttss2usi);

    public static readonly BetterInstruction vcvtudq2pd = new (Mnemonic.Vcvtudq2pd);

    public static readonly BetterInstruction vcvtudq2ps = new (Mnemonic.Vcvtudq2ps);

    public static readonly BetterInstruction vcvtuqq2pd = new (Mnemonic.Vcvtuqq2pd);

    public static readonly BetterInstruction vcvtuqq2ps = new (Mnemonic.Vcvtuqq2ps);

    public static readonly BetterInstruction vcvtusi2sd = new (Mnemonic.Vcvtusi2sd);

    public static readonly BetterInstruction vcvtusi2ss = new (Mnemonic.Vcvtusi2ss);

    public static readonly BetterInstruction vdbpsadbw = new (Mnemonic.Vdbpsadbw);

    public static readonly BetterInstruction vdivpd = new (Mnemonic.Vdivpd);

    public static readonly BetterInstruction vdivps = new (Mnemonic.Vdivps);

    public static readonly BetterInstruction vdivsd = new (Mnemonic.Vdivsd);

    public static readonly BetterInstruction vdivss = new (Mnemonic.Vdivss);

    public static readonly BetterInstruction vdpbf16ps = new (Mnemonic.Vdpbf16ps);

    public static readonly BetterInstruction vdppd = new (Mnemonic.Vdppd);

    public static readonly BetterInstruction vdpps = new (Mnemonic.Vdpps);

    public static readonly BetterInstruction verr = new (Mnemonic.Verr);

    public static readonly BetterInstruction verw = new (Mnemonic.Verw);

    public static readonly BetterInstruction vexp2pd = new (Mnemonic.Vexp2pd);

    public static readonly BetterInstruction vexp2ps = new (Mnemonic.Vexp2ps);

    public static readonly BetterInstruction vexpandpd = new (Mnemonic.Vexpandpd);

    public static readonly BetterInstruction vexpandps = new (Mnemonic.Vexpandps);

    public static readonly BetterInstruction vextractf128 = new (Mnemonic.Vextractf128);

    public static readonly BetterInstruction vextractf32x4 = new (Mnemonic.Vextractf32x4);

    public static readonly BetterInstruction vextractf32x8 = new (Mnemonic.Vextractf32x8);

    public static readonly BetterInstruction vextractf64x2 = new (Mnemonic.Vextractf64x2);

    public static readonly BetterInstruction vextractf64x4 = new (Mnemonic.Vextractf64x4);

    public static readonly BetterInstruction vextracti128 = new (Mnemonic.Vextracti128);

    public static readonly BetterInstruction vextracti32x4 = new (Mnemonic.Vextracti32x4);

    public static readonly BetterInstruction vextracti32x8 = new (Mnemonic.Vextracti32x8);

    public static readonly BetterInstruction vextracti64x2 = new (Mnemonic.Vextracti64x2);

    public static readonly BetterInstruction vextracti64x4 = new (Mnemonic.Vextracti64x4);

    public static readonly BetterInstruction vextractps = new (Mnemonic.Vextractps);

    public static readonly BetterInstruction vfixupimmpd = new (Mnemonic.Vfixupimmpd);

    public static readonly BetterInstruction vfixupimmps = new (Mnemonic.Vfixupimmps);

    public static readonly BetterInstruction vfixupimmsd = new (Mnemonic.Vfixupimmsd);

    public static readonly BetterInstruction vfixupimmss = new (Mnemonic.Vfixupimmss);

    public static readonly BetterInstruction vfmadd132pd = new (Mnemonic.Vfmadd132pd);

    public static readonly BetterInstruction vfmadd132ps = new (Mnemonic.Vfmadd132ps);

    public static readonly BetterInstruction vfmadd132sd = new (Mnemonic.Vfmadd132sd);

    public static readonly BetterInstruction vfmadd132ss = new (Mnemonic.Vfmadd132ss);

    public static readonly BetterInstruction vfmadd213pd = new (Mnemonic.Vfmadd213pd);

    public static readonly BetterInstruction vfmadd213ps = new (Mnemonic.Vfmadd213ps);

    public static readonly BetterInstruction vfmadd213sd = new (Mnemonic.Vfmadd213sd);

    public static readonly BetterInstruction vfmadd213ss = new (Mnemonic.Vfmadd213ss);

    public static readonly BetterInstruction vfmadd231pd = new (Mnemonic.Vfmadd231pd);

    public static readonly BetterInstruction vfmadd231ps = new (Mnemonic.Vfmadd231ps);

    public static readonly BetterInstruction vfmadd231sd = new (Mnemonic.Vfmadd231sd);

    public static readonly BetterInstruction vfmadd231ss = new (Mnemonic.Vfmadd231ss);

    public static readonly BetterInstruction vfmaddpd = new (Mnemonic.Vfmaddpd);

    public static readonly BetterInstruction vfmaddps = new (Mnemonic.Vfmaddps);

    public static readonly BetterInstruction vfmaddsd = new (Mnemonic.Vfmaddsd);

    public static readonly BetterInstruction vfmaddss = new (Mnemonic.Vfmaddss);

    public static readonly BetterInstruction vfmaddsub132pd = new (Mnemonic.Vfmaddsub132pd);

    public static readonly BetterInstruction vfmaddsub132ps = new (Mnemonic.Vfmaddsub132ps);

    public static readonly BetterInstruction vfmaddsub213pd = new (Mnemonic.Vfmaddsub213pd);

    public static readonly BetterInstruction vfmaddsub213ps = new (Mnemonic.Vfmaddsub213ps);

    public static readonly BetterInstruction vfmaddsub231pd = new (Mnemonic.Vfmaddsub231pd);

    public static readonly BetterInstruction vfmaddsub231ps = new (Mnemonic.Vfmaddsub231ps);

    public static readonly BetterInstruction vfmaddsubpd = new (Mnemonic.Vfmaddsubpd);

    public static readonly BetterInstruction vfmaddsubps = new (Mnemonic.Vfmaddsubps);

    public static readonly BetterInstruction vfmsub132pd = new (Mnemonic.Vfmsub132pd);

    public static readonly BetterInstruction vfmsub132ps = new (Mnemonic.Vfmsub132ps);

    public static readonly BetterInstruction vfmsub132sd = new (Mnemonic.Vfmsub132sd);

    public static readonly BetterInstruction vfmsub132ss = new (Mnemonic.Vfmsub132ss);

    public static readonly BetterInstruction vfmsub213pd = new (Mnemonic.Vfmsub213pd);

    public static readonly BetterInstruction vfmsub213ps = new (Mnemonic.Vfmsub213ps);

    public static readonly BetterInstruction vfmsub213sd = new (Mnemonic.Vfmsub213sd);

    public static readonly BetterInstruction vfmsub213ss = new (Mnemonic.Vfmsub213ss);

    public static readonly BetterInstruction vfmsub231pd = new (Mnemonic.Vfmsub231pd);

    public static readonly BetterInstruction vfmsub231ps = new (Mnemonic.Vfmsub231ps);

    public static readonly BetterInstruction vfmsub231sd = new (Mnemonic.Vfmsub231sd);

    public static readonly BetterInstruction vfmsub231ss = new (Mnemonic.Vfmsub231ss);

    public static readonly BetterInstruction vfmsubadd132pd = new (Mnemonic.Vfmsubadd132pd);

    public static readonly BetterInstruction vfmsubadd132ps = new (Mnemonic.Vfmsubadd132ps);

    public static readonly BetterInstruction vfmsubadd213pd = new (Mnemonic.Vfmsubadd213pd);

    public static readonly BetterInstruction vfmsubadd213ps = new (Mnemonic.Vfmsubadd213ps);

    public static readonly BetterInstruction vfmsubadd231pd = new (Mnemonic.Vfmsubadd231pd);

    public static readonly BetterInstruction vfmsubadd231ps = new (Mnemonic.Vfmsubadd231ps);

    public static readonly BetterInstruction vfmsubaddpd = new (Mnemonic.Vfmsubaddpd);

    public static readonly BetterInstruction vfmsubaddps = new (Mnemonic.Vfmsubaddps);

    public static readonly BetterInstruction vfmsubpd = new (Mnemonic.Vfmsubpd);

    public static readonly BetterInstruction vfmsubps = new (Mnemonic.Vfmsubps);

    public static readonly BetterInstruction vfmsubsd = new (Mnemonic.Vfmsubsd);

    public static readonly BetterInstruction vfmsubss = new (Mnemonic.Vfmsubss);

    public static readonly BetterInstruction vfnmadd132pd = new (Mnemonic.Vfnmadd132pd);

    public static readonly BetterInstruction vfnmadd132ps = new (Mnemonic.Vfnmadd132ps);

    public static readonly BetterInstruction vfnmadd132sd = new (Mnemonic.Vfnmadd132sd);

    public static readonly BetterInstruction vfnmadd132ss = new (Mnemonic.Vfnmadd132ss);

    public static readonly BetterInstruction vfnmadd213pd = new (Mnemonic.Vfnmadd213pd);

    public static readonly BetterInstruction vfnmadd213ps = new (Mnemonic.Vfnmadd213ps);

    public static readonly BetterInstruction vfnmadd213sd = new (Mnemonic.Vfnmadd213sd);

    public static readonly BetterInstruction vfnmadd213ss = new (Mnemonic.Vfnmadd213ss);

    public static readonly BetterInstruction vfnmadd231pd = new (Mnemonic.Vfnmadd231pd);

    public static readonly BetterInstruction vfnmadd231ps = new (Mnemonic.Vfnmadd231ps);

    public static readonly BetterInstruction vfnmadd231sd = new (Mnemonic.Vfnmadd231sd);

    public static readonly BetterInstruction vfnmadd231ss = new (Mnemonic.Vfnmadd231ss);

    public static readonly BetterInstruction vfnmaddpd = new (Mnemonic.Vfnmaddpd);

    public static readonly BetterInstruction vfnmaddps = new (Mnemonic.Vfnmaddps);

    public static readonly BetterInstruction vfnmaddsd = new (Mnemonic.Vfnmaddsd);

    public static readonly BetterInstruction vfnmaddss = new (Mnemonic.Vfnmaddss);

    public static readonly BetterInstruction vfnmsub132pd = new (Mnemonic.Vfnmsub132pd);

    public static readonly BetterInstruction vfnmsub132ps = new (Mnemonic.Vfnmsub132ps);

    public static readonly BetterInstruction vfnmsub132sd = new (Mnemonic.Vfnmsub132sd);

    public static readonly BetterInstruction vfnmsub132ss = new (Mnemonic.Vfnmsub132ss);

    public static readonly BetterInstruction vfnmsub213pd = new (Mnemonic.Vfnmsub213pd);

    public static readonly BetterInstruction vfnmsub213ps = new (Mnemonic.Vfnmsub213ps);

    public static readonly BetterInstruction vfnmsub213sd = new (Mnemonic.Vfnmsub213sd);

    public static readonly BetterInstruction vfnmsub213ss = new (Mnemonic.Vfnmsub213ss);

    public static readonly BetterInstruction vfnmsub231pd = new (Mnemonic.Vfnmsub231pd);

    public static readonly BetterInstruction vfnmsub231ps = new (Mnemonic.Vfnmsub231ps);

    public static readonly BetterInstruction vfnmsub231sd = new (Mnemonic.Vfnmsub231sd);

    public static readonly BetterInstruction vfnmsub231ss = new (Mnemonic.Vfnmsub231ss);

    public static readonly BetterInstruction vfnmsubpd = new (Mnemonic.Vfnmsubpd);

    public static readonly BetterInstruction vfnmsubps = new (Mnemonic.Vfnmsubps);

    public static readonly BetterInstruction vfnmsubsd = new (Mnemonic.Vfnmsubsd);

    public static readonly BetterInstruction vfnmsubss = new (Mnemonic.Vfnmsubss);

    public static readonly BetterInstruction vfpclasspd = new (Mnemonic.Vfpclasspd);

    public static readonly BetterInstruction vfpclassps = new (Mnemonic.Vfpclassps);

    public static readonly BetterInstruction vfpclasssd = new (Mnemonic.Vfpclasssd);

    public static readonly BetterInstruction vfpclassss = new (Mnemonic.Vfpclassss);

    public static readonly BetterInstruction vfrczpd = new (Mnemonic.Vfrczpd);

    public static readonly BetterInstruction vfrczps = new (Mnemonic.Vfrczps);

    public static readonly BetterInstruction vfrczsd = new (Mnemonic.Vfrczsd);

    public static readonly BetterInstruction vfrczss = new (Mnemonic.Vfrczss);

    public static readonly BetterInstruction vgatherdpd = new (Mnemonic.Vgatherdpd);

    public static readonly BetterInstruction vgatherdps = new (Mnemonic.Vgatherdps);

    public static readonly BetterInstruction vgatherpf0dpd = new (Mnemonic.Vgatherpf0dpd);

    public static readonly BetterInstruction vgatherpf0dps = new (Mnemonic.Vgatherpf0dps);

    public static readonly BetterInstruction vgatherpf0qpd = new (Mnemonic.Vgatherpf0qpd);

    public static readonly BetterInstruction vgatherpf0qps = new (Mnemonic.Vgatherpf0qps);

    public static readonly BetterInstruction vgatherpf1dpd = new (Mnemonic.Vgatherpf1dpd);

    public static readonly BetterInstruction vgatherpf1dps = new (Mnemonic.Vgatherpf1dps);

    public static readonly BetterInstruction vgatherpf1qpd = new (Mnemonic.Vgatherpf1qpd);

    public static readonly BetterInstruction vgatherpf1qps = new (Mnemonic.Vgatherpf1qps);

    public static readonly BetterInstruction vgatherqpd = new (Mnemonic.Vgatherqpd);

    public static readonly BetterInstruction vgatherqps = new (Mnemonic.Vgatherqps);

    public static readonly BetterInstruction vgetexppd = new (Mnemonic.Vgetexppd);

    public static readonly BetterInstruction vgetexpps = new (Mnemonic.Vgetexpps);

    public static readonly BetterInstruction vgetexpsd = new (Mnemonic.Vgetexpsd);

    public static readonly BetterInstruction vgetexpss = new (Mnemonic.Vgetexpss);

    public static readonly BetterInstruction vgetmantpd = new (Mnemonic.Vgetmantpd);

    public static readonly BetterInstruction vgetmantps = new (Mnemonic.Vgetmantps);

    public static readonly BetterInstruction vgetmantsd = new (Mnemonic.Vgetmantsd);

    public static readonly BetterInstruction vgetmantss = new (Mnemonic.Vgetmantss);

    public static readonly BetterInstruction vgf2p8affineinvqb = new (Mnemonic.Vgf2p8affineinvqb);

    public static readonly BetterInstruction vgf2p8affineqb = new (Mnemonic.Vgf2p8affineqb);

    public static readonly BetterInstruction vgf2p8mulb = new (Mnemonic.Vgf2p8mulb);

    public static readonly BetterInstruction vhaddpd = new (Mnemonic.Vhaddpd);

    public static readonly BetterInstruction vhaddps = new (Mnemonic.Vhaddps);

    public static readonly BetterInstruction vhsubpd = new (Mnemonic.Vhsubpd);

    public static readonly BetterInstruction vhsubps = new (Mnemonic.Vhsubps);

    public static readonly BetterInstruction vinsertf128 = new (Mnemonic.Vinsertf128);

    public static readonly BetterInstruction vinsertf32x4 = new (Mnemonic.Vinsertf32x4);

    public static readonly BetterInstruction vinsertf32x8 = new (Mnemonic.Vinsertf32x8);

    public static readonly BetterInstruction vinsertf64x2 = new (Mnemonic.Vinsertf64x2);

    public static readonly BetterInstruction vinsertf64x4 = new (Mnemonic.Vinsertf64x4);

    public static readonly BetterInstruction vinserti128 = new (Mnemonic.Vinserti128);

    public static readonly BetterInstruction vinserti32x4 = new (Mnemonic.Vinserti32x4);

    public static readonly BetterInstruction vinserti32x8 = new (Mnemonic.Vinserti32x8);

    public static readonly BetterInstruction vinserti64x2 = new (Mnemonic.Vinserti64x2);

    public static readonly BetterInstruction vinserti64x4 = new (Mnemonic.Vinserti64x4);

    public static readonly BetterInstruction vinsertps = new (Mnemonic.Vinsertps);

    public static readonly BetterInstruction vlddqu = new (Mnemonic.Vlddqu);

    public static readonly BetterInstruction vldmxcsr = new (Mnemonic.Vldmxcsr);

    public static readonly BetterInstruction vmaskmovdqu = new (Mnemonic.Vmaskmovdqu);

    public static readonly BetterInstruction vmaskmovpd = new (Mnemonic.Vmaskmovpd);

    public static readonly BetterInstruction vmaskmovps = new (Mnemonic.Vmaskmovps);

    public static readonly BetterInstruction vmaxpd = new (Mnemonic.Vmaxpd);

    public static readonly BetterInstruction vmaxps = new (Mnemonic.Vmaxps);

    public static readonly BetterInstruction vmaxsd = new (Mnemonic.Vmaxsd);

    public static readonly BetterInstruction vmaxss = new (Mnemonic.Vmaxss);

    public static readonly BetterInstruction vmcall = new (Mnemonic.Vmcall);

    public static readonly BetterInstruction vmclear = new (Mnemonic.Vmclear);

    public static readonly BetterInstruction vmfunc = new (Mnemonic.Vmfunc);

    public static readonly BetterInstruction vminpd = new (Mnemonic.Vminpd);

    public static readonly BetterInstruction vminps = new (Mnemonic.Vminps);

    public static readonly BetterInstruction vminsd = new (Mnemonic.Vminsd);

    public static readonly BetterInstruction vminss = new (Mnemonic.Vminss);

    public static readonly BetterInstruction vmlaunch = new (Mnemonic.Vmlaunch);

    public static readonly BetterInstruction vmload = new (Mnemonic.Vmload);

    public static readonly BetterInstruction vmmcall = new (Mnemonic.Vmmcall);

    public static readonly BetterInstruction vmovapd = new (Mnemonic.Vmovapd);

    public static readonly BetterInstruction vmovaps = new (Mnemonic.Vmovaps);

    public static readonly BetterInstruction vmovd = new (Mnemonic.Vmovd);

    public static readonly BetterInstruction vmovddup = new (Mnemonic.Vmovddup);

    public static readonly BetterInstruction vmovdqa = new (Mnemonic.Vmovdqa);

    public static readonly BetterInstruction vmovdqa32 = new (Mnemonic.Vmovdqa32);

    public static readonly BetterInstruction vmovdqa64 = new (Mnemonic.Vmovdqa64);

    public static readonly BetterInstruction vmovdqu = new (Mnemonic.Vmovdqu);

    public static readonly BetterInstruction vmovdqu16 = new (Mnemonic.Vmovdqu16);

    public static readonly BetterInstruction vmovdqu32 = new (Mnemonic.Vmovdqu32);

    public static readonly BetterInstruction vmovdqu64 = new (Mnemonic.Vmovdqu64);

    public static readonly BetterInstruction vmovdqu8 = new (Mnemonic.Vmovdqu8);

    public static readonly BetterInstruction vmovhlps = new (Mnemonic.Vmovhlps);

    public static readonly BetterInstruction vmovhpd = new (Mnemonic.Vmovhpd);

    public static readonly BetterInstruction vmovhps = new (Mnemonic.Vmovhps);

    public static readonly BetterInstruction vmovlhps = new (Mnemonic.Vmovlhps);

    public static readonly BetterInstruction vmovlpd = new (Mnemonic.Vmovlpd);

    public static readonly BetterInstruction vmovlps = new (Mnemonic.Vmovlps);

    public static readonly BetterInstruction vmovmskpd = new (Mnemonic.Vmovmskpd);

    public static readonly BetterInstruction vmovmskps = new (Mnemonic.Vmovmskps);

    public static readonly BetterInstruction vmovntdq = new (Mnemonic.Vmovntdq);

    public static readonly BetterInstruction vmovntdqa = new (Mnemonic.Vmovntdqa);

    public static readonly BetterInstruction vmovntpd = new (Mnemonic.Vmovntpd);

    public static readonly BetterInstruction vmovntps = new (Mnemonic.Vmovntps);

    public static readonly BetterInstruction vmovq = new (Mnemonic.Vmovq);

    public static readonly BetterInstruction vmovsd = new (Mnemonic.Vmovsd);

    public static readonly BetterInstruction vmovshdup = new (Mnemonic.Vmovshdup);

    public static readonly BetterInstruction vmovsldup = new (Mnemonic.Vmovsldup);

    public static readonly BetterInstruction vmovss = new (Mnemonic.Vmovss);

    public static readonly BetterInstruction vmovupd = new (Mnemonic.Vmovupd);

    public static readonly BetterInstruction vmovups = new (Mnemonic.Vmovups);

    public static readonly BetterInstruction vmpsadbw = new (Mnemonic.Vmpsadbw);

    public static readonly BetterInstruction vmptrld = new (Mnemonic.Vmptrld);

    public static readonly BetterInstruction vmptrst = new (Mnemonic.Vmptrst);

    public static readonly BetterInstruction vmread = new (Mnemonic.Vmread);

    public static readonly BetterInstruction vmresume = new (Mnemonic.Vmresume);

    public static readonly BetterInstruction vmrun = new (Mnemonic.Vmrun);

    public static readonly BetterInstruction vmsave = new (Mnemonic.Vmsave);

    public static readonly BetterInstruction vmulpd = new (Mnemonic.Vmulpd);

    public static readonly BetterInstruction vmulps = new (Mnemonic.Vmulps);

    public static readonly BetterInstruction vmulsd = new (Mnemonic.Vmulsd);

    public static readonly BetterInstruction vmulss = new (Mnemonic.Vmulss);

    public static readonly BetterInstruction vmwrite = new (Mnemonic.Vmwrite);

    public static readonly BetterInstruction vmxoff = new (Mnemonic.Vmxoff);

    public static readonly BetterInstruction vmxon = new (Mnemonic.Vmxon);

    public static readonly BetterInstruction vorpd = new (Mnemonic.Vorpd);

    public static readonly BetterInstruction vorps = new (Mnemonic.Vorps);

    public static readonly BetterInstruction vp2intersectd = new (Mnemonic.Vp2intersectd);

    public static readonly BetterInstruction vp2intersectq = new (Mnemonic.Vp2intersectq);

    public static readonly BetterInstruction vp4dpwssd = new (Mnemonic.Vp4dpwssd);

    public static readonly BetterInstruction vp4dpwssds = new (Mnemonic.Vp4dpwssds);

    public static readonly BetterInstruction vpabsb = new (Mnemonic.Vpabsb);

    public static readonly BetterInstruction vpabsd = new (Mnemonic.Vpabsd);

    public static readonly BetterInstruction vpabsq = new (Mnemonic.Vpabsq);

    public static readonly BetterInstruction vpabsw = new (Mnemonic.Vpabsw);

    public static readonly BetterInstruction vpackssdw = new (Mnemonic.Vpackssdw);

    public static readonly BetterInstruction vpacksswb = new (Mnemonic.Vpacksswb);

    public static readonly BetterInstruction vpackusdw = new (Mnemonic.Vpackusdw);

    public static readonly BetterInstruction vpackuswb = new (Mnemonic.Vpackuswb);

    public static readonly BetterInstruction vpaddb = new (Mnemonic.Vpaddb);

    public static readonly BetterInstruction vpaddd = new (Mnemonic.Vpaddd);

    public static readonly BetterInstruction vpaddq = new (Mnemonic.Vpaddq);

    public static readonly BetterInstruction vpaddsb = new (Mnemonic.Vpaddsb);

    public static readonly BetterInstruction vpaddsw = new (Mnemonic.Vpaddsw);

    public static readonly BetterInstruction vpaddusb = new (Mnemonic.Vpaddusb);

    public static readonly BetterInstruction vpaddusw = new (Mnemonic.Vpaddusw);

    public static readonly BetterInstruction vpaddw = new (Mnemonic.Vpaddw);

    public static readonly BetterInstruction vpalignr = new (Mnemonic.Vpalignr);

    public static readonly BetterInstruction vpand = new (Mnemonic.Vpand);

    public static readonly BetterInstruction vpandd = new (Mnemonic.Vpandd);

    public static readonly BetterInstruction vpandn = new (Mnemonic.Vpandn);

    public static readonly BetterInstruction vpandnd = new (Mnemonic.Vpandnd);

    public static readonly BetterInstruction vpandnq = new (Mnemonic.Vpandnq);

    public static readonly BetterInstruction vpandq = new (Mnemonic.Vpandq);

    public static readonly BetterInstruction vpavgb = new (Mnemonic.Vpavgb);

    public static readonly BetterInstruction vpavgw = new (Mnemonic.Vpavgw);

    public static readonly BetterInstruction vpblendd = new (Mnemonic.Vpblendd);

    public static readonly BetterInstruction vpblendmb = new (Mnemonic.Vpblendmb);

    public static readonly BetterInstruction vpblendmd = new (Mnemonic.Vpblendmd);

    public static readonly BetterInstruction vpblendmq = new (Mnemonic.Vpblendmq);

    public static readonly BetterInstruction vpblendmw = new (Mnemonic.Vpblendmw);

    public static readonly BetterInstruction vpblendvb = new (Mnemonic.Vpblendvb);

    public static readonly BetterInstruction vpblendw = new (Mnemonic.Vpblendw);

    public static readonly BetterInstruction vpbroadcastb = new (Mnemonic.Vpbroadcastb);

    public static readonly BetterInstruction vpbroadcastd = new (Mnemonic.Vpbroadcastd);

    public static readonly BetterInstruction vpbroadcastmb2q = new (Mnemonic.Vpbroadcastmb2q);

    public static readonly BetterInstruction vpbroadcastmw2d = new (Mnemonic.Vpbroadcastmw2d);

    public static readonly BetterInstruction vpbroadcastq = new (Mnemonic.Vpbroadcastq);

    public static readonly BetterInstruction vpbroadcastw = new (Mnemonic.Vpbroadcastw);

    public static readonly BetterInstruction vpclmulqdq = new (Mnemonic.Vpclmulqdq);

    public static readonly BetterInstruction vpcmov = new (Mnemonic.Vpcmov);

    public static readonly BetterInstruction vpcmpb = new (Mnemonic.Vpcmpb);

    public static readonly BetterInstruction vpcmpd = new (Mnemonic.Vpcmpd);

    public static readonly BetterInstruction vpcmpeqb = new (Mnemonic.Vpcmpeqb);

    public static readonly BetterInstruction vpcmpeqd = new (Mnemonic.Vpcmpeqd);

    public static readonly BetterInstruction vpcmpeqq = new (Mnemonic.Vpcmpeqq);

    public static readonly BetterInstruction vpcmpeqw = new (Mnemonic.Vpcmpeqw);

    public static readonly BetterInstruction vpcmpestri = new (Mnemonic.Vpcmpestri);

    public static readonly BetterInstruction vpcmpestri64 = new (Mnemonic.Vpcmpestri64);

    public static readonly BetterInstruction vpcmpestrm = new (Mnemonic.Vpcmpestrm);

    public static readonly BetterInstruction vpcmpestrm64 = new (Mnemonic.Vpcmpestrm64);

    public static readonly BetterInstruction vpcmpgtb = new (Mnemonic.Vpcmpgtb);

    public static readonly BetterInstruction vpcmpgtd = new (Mnemonic.Vpcmpgtd);

    public static readonly BetterInstruction vpcmpgtq = new (Mnemonic.Vpcmpgtq);

    public static readonly BetterInstruction vpcmpgtw = new (Mnemonic.Vpcmpgtw);

    public static readonly BetterInstruction vpcmpistri = new (Mnemonic.Vpcmpistri);

    public static readonly BetterInstruction vpcmpistrm = new (Mnemonic.Vpcmpistrm);

    public static readonly BetterInstruction vpcmpq = new (Mnemonic.Vpcmpq);

    public static readonly BetterInstruction vpcmpub = new (Mnemonic.Vpcmpub);

    public static readonly BetterInstruction vpcmpud = new (Mnemonic.Vpcmpud);

    public static readonly BetterInstruction vpcmpuq = new (Mnemonic.Vpcmpuq);

    public static readonly BetterInstruction vpcmpuw = new (Mnemonic.Vpcmpuw);

    public static readonly BetterInstruction vpcmpw = new (Mnemonic.Vpcmpw);

    public static readonly BetterInstruction vpcomb = new (Mnemonic.Vpcomb);

    public static readonly BetterInstruction vpcomd = new (Mnemonic.Vpcomd);

    public static readonly BetterInstruction vpcompressb = new (Mnemonic.Vpcompressb);

    public static readonly BetterInstruction vpcompressd = new (Mnemonic.Vpcompressd);

    public static readonly BetterInstruction vpcompressq = new (Mnemonic.Vpcompressq);

    public static readonly BetterInstruction vpcompressw = new (Mnemonic.Vpcompressw);

    public static readonly BetterInstruction vpcomq = new (Mnemonic.Vpcomq);

    public static readonly BetterInstruction vpcomub = new (Mnemonic.Vpcomub);

    public static readonly BetterInstruction vpcomud = new (Mnemonic.Vpcomud);

    public static readonly BetterInstruction vpcomuq = new (Mnemonic.Vpcomuq);

    public static readonly BetterInstruction vpcomuw = new (Mnemonic.Vpcomuw);

    public static readonly BetterInstruction vpcomw = new (Mnemonic.Vpcomw);

    public static readonly BetterInstruction vpconflictd = new (Mnemonic.Vpconflictd);

    public static readonly BetterInstruction vpconflictq = new (Mnemonic.Vpconflictq);

    public static readonly BetterInstruction vpdpbusd = new (Mnemonic.Vpdpbusd);

    public static readonly BetterInstruction vpdpbusds = new (Mnemonic.Vpdpbusds);

    public static readonly BetterInstruction vpdpwssd = new (Mnemonic.Vpdpwssd);

    public static readonly BetterInstruction vpdpwssds = new (Mnemonic.Vpdpwssds);

    public static readonly BetterInstruction vperm2f128 = new (Mnemonic.Vperm2f128);

    public static readonly BetterInstruction vperm2i128 = new (Mnemonic.Vperm2i128);

    public static readonly BetterInstruction vpermb = new (Mnemonic.Vpermb);

    public static readonly BetterInstruction vpermd = new (Mnemonic.Vpermd);

    public static readonly BetterInstruction vpermi2b = new (Mnemonic.Vpermi2b);

    public static readonly BetterInstruction vpermi2d = new (Mnemonic.Vpermi2d);

    public static readonly BetterInstruction vpermi2pd = new (Mnemonic.Vpermi2pd);

    public static readonly BetterInstruction vpermi2ps = new (Mnemonic.Vpermi2ps);

    public static readonly BetterInstruction vpermi2q = new (Mnemonic.Vpermi2q);

    public static readonly BetterInstruction vpermi2w = new (Mnemonic.Vpermi2w);

    public static readonly BetterInstruction vpermil2pd = new (Mnemonic.Vpermil2pd);

    public static readonly BetterInstruction vpermil2ps = new (Mnemonic.Vpermil2ps);

    public static readonly BetterInstruction vpermilpd = new (Mnemonic.Vpermilpd);

    public static readonly BetterInstruction vpermilps = new (Mnemonic.Vpermilps);

    public static readonly BetterInstruction vpermpd = new (Mnemonic.Vpermpd);

    public static readonly BetterInstruction vpermps = new (Mnemonic.Vpermps);

    public static readonly BetterInstruction vpermq = new (Mnemonic.Vpermq);

    public static readonly BetterInstruction vpermt2b = new (Mnemonic.Vpermt2b);

    public static readonly BetterInstruction vpermt2d = new (Mnemonic.Vpermt2d);

    public static readonly BetterInstruction vpermt2pd = new (Mnemonic.Vpermt2pd);

    public static readonly BetterInstruction vpermt2ps = new (Mnemonic.Vpermt2ps);

    public static readonly BetterInstruction vpermt2q = new (Mnemonic.Vpermt2q);

    public static readonly BetterInstruction vpermt2w = new (Mnemonic.Vpermt2w);

    public static readonly BetterInstruction vpermw = new (Mnemonic.Vpermw);

    public static readonly BetterInstruction vpexpandb = new (Mnemonic.Vpexpandb);

    public static readonly BetterInstruction vpexpandd = new (Mnemonic.Vpexpandd);

    public static readonly BetterInstruction vpexpandq = new (Mnemonic.Vpexpandq);

    public static readonly BetterInstruction vpexpandw = new (Mnemonic.Vpexpandw);

    public static readonly BetterInstruction vpextrb = new (Mnemonic.Vpextrb);

    public static readonly BetterInstruction vpextrd = new (Mnemonic.Vpextrd);

    public static readonly BetterInstruction vpextrq = new (Mnemonic.Vpextrq);

    public static readonly BetterInstruction vpextrw = new (Mnemonic.Vpextrw);

    public static readonly BetterInstruction vpgatherdd = new (Mnemonic.Vpgatherdd);

    public static readonly BetterInstruction vpgatherdq = new (Mnemonic.Vpgatherdq);

    public static readonly BetterInstruction vpgatherqd = new (Mnemonic.Vpgatherqd);

    public static readonly BetterInstruction vpgatherqq = new (Mnemonic.Vpgatherqq);

    public static readonly BetterInstruction vphaddbd = new (Mnemonic.Vphaddbd);

    public static readonly BetterInstruction vphaddbq = new (Mnemonic.Vphaddbq);

    public static readonly BetterInstruction vphaddbw = new (Mnemonic.Vphaddbw);

    public static readonly BetterInstruction vphaddd = new (Mnemonic.Vphaddd);

    public static readonly BetterInstruction vphadddq = new (Mnemonic.Vphadddq);

    public static readonly BetterInstruction vphaddsw = new (Mnemonic.Vphaddsw);

    public static readonly BetterInstruction vphaddubd = new (Mnemonic.Vphaddubd);

    public static readonly BetterInstruction vphaddubq = new (Mnemonic.Vphaddubq);

    public static readonly BetterInstruction vphaddubw = new (Mnemonic.Vphaddubw);

    public static readonly BetterInstruction vphaddudq = new (Mnemonic.Vphaddudq);

    public static readonly BetterInstruction vphadduwd = new (Mnemonic.Vphadduwd);

    public static readonly BetterInstruction vphadduwq = new (Mnemonic.Vphadduwq);

    public static readonly BetterInstruction vphaddw = new (Mnemonic.Vphaddw);

    public static readonly BetterInstruction vphaddwd = new (Mnemonic.Vphaddwd);

    public static readonly BetterInstruction vphaddwq = new (Mnemonic.Vphaddwq);

    public static readonly BetterInstruction vphminposuw = new (Mnemonic.Vphminposuw);

    public static readonly BetterInstruction vphsubbw = new (Mnemonic.Vphsubbw);

    public static readonly BetterInstruction vphsubd = new (Mnemonic.Vphsubd);

    public static readonly BetterInstruction vphsubdq = new (Mnemonic.Vphsubdq);

    public static readonly BetterInstruction vphsubsw = new (Mnemonic.Vphsubsw);

    public static readonly BetterInstruction vphsubw = new (Mnemonic.Vphsubw);

    public static readonly BetterInstruction vphsubwd = new (Mnemonic.Vphsubwd);

    public static readonly BetterInstruction vpinsrb = new (Mnemonic.Vpinsrb);

    public static readonly BetterInstruction vpinsrd = new (Mnemonic.Vpinsrd);

    public static readonly BetterInstruction vpinsrq = new (Mnemonic.Vpinsrq);

    public static readonly BetterInstruction vpinsrw = new (Mnemonic.Vpinsrw);

    public static readonly BetterInstruction vplzcntd = new (Mnemonic.Vplzcntd);

    public static readonly BetterInstruction vplzcntq = new (Mnemonic.Vplzcntq);

    public static readonly BetterInstruction vpmacsdd = new (Mnemonic.Vpmacsdd);

    public static readonly BetterInstruction vpmacsdqh = new (Mnemonic.Vpmacsdqh);

    public static readonly BetterInstruction vpmacsdql = new (Mnemonic.Vpmacsdql);

    public static readonly BetterInstruction vpmacssdd = new (Mnemonic.Vpmacssdd);

    public static readonly BetterInstruction vpmacssdqh = new (Mnemonic.Vpmacssdqh);

    public static readonly BetterInstruction vpmacssdql = new (Mnemonic.Vpmacssdql);

    public static readonly BetterInstruction vpmacsswd = new (Mnemonic.Vpmacsswd);

    public static readonly BetterInstruction vpmacssww = new (Mnemonic.Vpmacssww);

    public static readonly BetterInstruction vpmacswd = new (Mnemonic.Vpmacswd);

    public static readonly BetterInstruction vpmacsww = new (Mnemonic.Vpmacsww);

    public static readonly BetterInstruction vpmadcsswd = new (Mnemonic.Vpmadcsswd);

    public static readonly BetterInstruction vpmadcswd = new (Mnemonic.Vpmadcswd);

    public static readonly BetterInstruction vpmadd52huq = new (Mnemonic.Vpmadd52huq);

    public static readonly BetterInstruction vpmadd52luq = new (Mnemonic.Vpmadd52luq);

    public static readonly BetterInstruction vpmaddubsw = new (Mnemonic.Vpmaddubsw);

    public static readonly BetterInstruction vpmaddwd = new (Mnemonic.Vpmaddwd);

    public static readonly BetterInstruction vpmaskmovd = new (Mnemonic.Vpmaskmovd);

    public static readonly BetterInstruction vpmaskmovq = new (Mnemonic.Vpmaskmovq);

    public static readonly BetterInstruction vpmaxsb = new (Mnemonic.Vpmaxsb);

    public static readonly BetterInstruction vpmaxsd = new (Mnemonic.Vpmaxsd);

    public static readonly BetterInstruction vpmaxsq = new (Mnemonic.Vpmaxsq);

    public static readonly BetterInstruction vpmaxsw = new (Mnemonic.Vpmaxsw);

    public static readonly BetterInstruction vpmaxub = new (Mnemonic.Vpmaxub);

    public static readonly BetterInstruction vpmaxud = new (Mnemonic.Vpmaxud);

    public static readonly BetterInstruction vpmaxuq = new (Mnemonic.Vpmaxuq);

    public static readonly BetterInstruction vpmaxuw = new (Mnemonic.Vpmaxuw);

    public static readonly BetterInstruction vpminsb = new (Mnemonic.Vpminsb);

    public static readonly BetterInstruction vpminsd = new (Mnemonic.Vpminsd);

    public static readonly BetterInstruction vpminsq = new (Mnemonic.Vpminsq);

    public static readonly BetterInstruction vpminsw = new (Mnemonic.Vpminsw);

    public static readonly BetterInstruction vpminub = new (Mnemonic.Vpminub);

    public static readonly BetterInstruction vpminud = new (Mnemonic.Vpminud);

    public static readonly BetterInstruction vpminuq = new (Mnemonic.Vpminuq);

    public static readonly BetterInstruction vpminuw = new (Mnemonic.Vpminuw);

    public static readonly BetterInstruction vpmovb2m = new (Mnemonic.Vpmovb2m);

    public static readonly BetterInstruction vpmovd2m = new (Mnemonic.Vpmovd2m);

    public static readonly BetterInstruction vpmovdb = new (Mnemonic.Vpmovdb);

    public static readonly BetterInstruction vpmovdw = new (Mnemonic.Vpmovdw);

    public static readonly BetterInstruction vpmovm2b = new (Mnemonic.Vpmovm2b);

    public static readonly BetterInstruction vpmovm2d = new (Mnemonic.Vpmovm2d);

    public static readonly BetterInstruction vpmovm2q = new (Mnemonic.Vpmovm2q);

    public static readonly BetterInstruction vpmovm2w = new (Mnemonic.Vpmovm2w);

    public static readonly BetterInstruction vpmovmskb = new (Mnemonic.Vpmovmskb);

    public static readonly BetterInstruction vpmovq2m = new (Mnemonic.Vpmovq2m);

    public static readonly BetterInstruction vpmovqb = new (Mnemonic.Vpmovqb);

    public static readonly BetterInstruction vpmovqd = new (Mnemonic.Vpmovqd);

    public static readonly BetterInstruction vpmovqw = new (Mnemonic.Vpmovqw);

    public static readonly BetterInstruction vpmovsdb = new (Mnemonic.Vpmovsdb);

    public static readonly BetterInstruction vpmovsdw = new (Mnemonic.Vpmovsdw);

    public static readonly BetterInstruction vpmovsqb = new (Mnemonic.Vpmovsqb);

    public static readonly BetterInstruction vpmovsqd = new (Mnemonic.Vpmovsqd);

    public static readonly BetterInstruction vpmovsqw = new (Mnemonic.Vpmovsqw);

    public static readonly BetterInstruction vpmovswb = new (Mnemonic.Vpmovswb);

    public static readonly BetterInstruction vpmovsxbd = new (Mnemonic.Vpmovsxbd);

    public static readonly BetterInstruction vpmovsxbq = new (Mnemonic.Vpmovsxbq);

    public static readonly BetterInstruction vpmovsxbw = new (Mnemonic.Vpmovsxbw);

    public static readonly BetterInstruction vpmovsxdq = new (Mnemonic.Vpmovsxdq);

    public static readonly BetterInstruction vpmovsxwd = new (Mnemonic.Vpmovsxwd);

    public static readonly BetterInstruction vpmovsxwq = new (Mnemonic.Vpmovsxwq);

    public static readonly BetterInstruction vpmovusdb = new (Mnemonic.Vpmovusdb);

    public static readonly BetterInstruction vpmovusdw = new (Mnemonic.Vpmovusdw);

    public static readonly BetterInstruction vpmovusqb = new (Mnemonic.Vpmovusqb);

    public static readonly BetterInstruction vpmovusqd = new (Mnemonic.Vpmovusqd);

    public static readonly BetterInstruction vpmovusqw = new (Mnemonic.Vpmovusqw);

    public static readonly BetterInstruction vpmovuswb = new (Mnemonic.Vpmovuswb);

    public static readonly BetterInstruction vpmovw2m = new (Mnemonic.Vpmovw2m);

    public static readonly BetterInstruction vpmovwb = new (Mnemonic.Vpmovwb);

    public static readonly BetterInstruction vpmovzxbd = new (Mnemonic.Vpmovzxbd);

    public static readonly BetterInstruction vpmovzxbq = new (Mnemonic.Vpmovzxbq);

    public static readonly BetterInstruction vpmovzxbw = new (Mnemonic.Vpmovzxbw);

    public static readonly BetterInstruction vpmovzxdq = new (Mnemonic.Vpmovzxdq);

    public static readonly BetterInstruction vpmovzxwd = new (Mnemonic.Vpmovzxwd);

    public static readonly BetterInstruction vpmovzxwq = new (Mnemonic.Vpmovzxwq);

    public static readonly BetterInstruction vpmuldq = new (Mnemonic.Vpmuldq);

    public static readonly BetterInstruction vpmulhrsw = new (Mnemonic.Vpmulhrsw);

    public static readonly BetterInstruction vpmulhuw = new (Mnemonic.Vpmulhuw);

    public static readonly BetterInstruction vpmulhw = new (Mnemonic.Vpmulhw);

    public static readonly BetterInstruction vpmulld = new (Mnemonic.Vpmulld);

    public static readonly BetterInstruction vpmullq = new (Mnemonic.Vpmullq);

    public static readonly BetterInstruction vpmullw = new (Mnemonic.Vpmullw);

    public static readonly BetterInstruction vpmultishiftqb = new (Mnemonic.Vpmultishiftqb);

    public static readonly BetterInstruction vpmuludq = new (Mnemonic.Vpmuludq);

    public static readonly BetterInstruction vpopcntb = new (Mnemonic.Vpopcntb);

    public static readonly BetterInstruction vpopcntd = new (Mnemonic.Vpopcntd);

    public static readonly BetterInstruction vpopcntq = new (Mnemonic.Vpopcntq);

    public static readonly BetterInstruction vpopcntw = new (Mnemonic.Vpopcntw);

    public static readonly BetterInstruction vpor = new (Mnemonic.Vpor);

    public static readonly BetterInstruction vpord = new (Mnemonic.Vpord);

    public static readonly BetterInstruction vporq = new (Mnemonic.Vporq);

    public static readonly BetterInstruction vpperm = new (Mnemonic.Vpperm);

    public static readonly BetterInstruction vprold = new (Mnemonic.Vprold);

    public static readonly BetterInstruction vprolq = new (Mnemonic.Vprolq);

    public static readonly BetterInstruction vprolvd = new (Mnemonic.Vprolvd);

    public static readonly BetterInstruction vprolvq = new (Mnemonic.Vprolvq);

    public static readonly BetterInstruction vprord = new (Mnemonic.Vprord);

    public static readonly BetterInstruction vprorq = new (Mnemonic.Vprorq);

    public static readonly BetterInstruction vprorvd = new (Mnemonic.Vprorvd);

    public static readonly BetterInstruction vprorvq = new (Mnemonic.Vprorvq);

    public static readonly BetterInstruction vprotb = new (Mnemonic.Vprotb);

    public static readonly BetterInstruction vprotd = new (Mnemonic.Vprotd);

    public static readonly BetterInstruction vprotq = new (Mnemonic.Vprotq);

    public static readonly BetterInstruction vprotw = new (Mnemonic.Vprotw);

    public static readonly BetterInstruction vpsadbw = new (Mnemonic.Vpsadbw);

    public static readonly BetterInstruction vpscatterdd = new (Mnemonic.Vpscatterdd);

    public static readonly BetterInstruction vpscatterdq = new (Mnemonic.Vpscatterdq);

    public static readonly BetterInstruction vpscatterqd = new (Mnemonic.Vpscatterqd);

    public static readonly BetterInstruction vpscatterqq = new (Mnemonic.Vpscatterqq);

    public static readonly BetterInstruction vpshab = new (Mnemonic.Vpshab);

    public static readonly BetterInstruction vpshad = new (Mnemonic.Vpshad);

    public static readonly BetterInstruction vpshaq = new (Mnemonic.Vpshaq);

    public static readonly BetterInstruction vpshaw = new (Mnemonic.Vpshaw);

    public static readonly BetterInstruction vpshlb = new (Mnemonic.Vpshlb);

    public static readonly BetterInstruction vpshld = new (Mnemonic.Vpshld);

    public static readonly BetterInstruction vpshldd = new (Mnemonic.Vpshldd);

    public static readonly BetterInstruction vpshldq = new (Mnemonic.Vpshldq);

    public static readonly BetterInstruction vpshldvd = new (Mnemonic.Vpshldvd);

    public static readonly BetterInstruction vpshldvq = new (Mnemonic.Vpshldvq);

    public static readonly BetterInstruction vpshldvw = new (Mnemonic.Vpshldvw);

    public static readonly BetterInstruction vpshldw = new (Mnemonic.Vpshldw);

    public static readonly BetterInstruction vpshlq = new (Mnemonic.Vpshlq);

    public static readonly BetterInstruction vpshlw = new (Mnemonic.Vpshlw);

    public static readonly BetterInstruction vpshrdd = new (Mnemonic.Vpshrdd);

    public static readonly BetterInstruction vpshrdq = new (Mnemonic.Vpshrdq);

    public static readonly BetterInstruction vpshrdvd = new (Mnemonic.Vpshrdvd);

    public static readonly BetterInstruction vpshrdvq = new (Mnemonic.Vpshrdvq);

    public static readonly BetterInstruction vpshrdvw = new (Mnemonic.Vpshrdvw);

    public static readonly BetterInstruction vpshrdw = new (Mnemonic.Vpshrdw);

    public static readonly BetterInstruction vpshufb = new (Mnemonic.Vpshufb);

    public static readonly BetterInstruction vpshufbitqmb = new (Mnemonic.Vpshufbitqmb);

    public static readonly BetterInstruction vpshufd = new (Mnemonic.Vpshufd);

    public static readonly BetterInstruction vpshufhw = new (Mnemonic.Vpshufhw);

    public static readonly BetterInstruction vpshuflw = new (Mnemonic.Vpshuflw);

    public static readonly BetterInstruction vpsignb = new (Mnemonic.Vpsignb);

    public static readonly BetterInstruction vpsignd = new (Mnemonic.Vpsignd);

    public static readonly BetterInstruction vpsignw = new (Mnemonic.Vpsignw);

    public static readonly BetterInstruction vpslld = new (Mnemonic.Vpslld);

    public static readonly BetterInstruction vpslldq = new (Mnemonic.Vpslldq);

    public static readonly BetterInstruction vpsllq = new (Mnemonic.Vpsllq);

    public static readonly BetterInstruction vpsllvd = new (Mnemonic.Vpsllvd);

    public static readonly BetterInstruction vpsllvq = new (Mnemonic.Vpsllvq);

    public static readonly BetterInstruction vpsllvw = new (Mnemonic.Vpsllvw);

    public static readonly BetterInstruction vpsllw = new (Mnemonic.Vpsllw);

    public static readonly BetterInstruction vpsrad = new (Mnemonic.Vpsrad);

    public static readonly BetterInstruction vpsraq = new (Mnemonic.Vpsraq);

    public static readonly BetterInstruction vpsravd = new (Mnemonic.Vpsravd);

    public static readonly BetterInstruction vpsravq = new (Mnemonic.Vpsravq);

    public static readonly BetterInstruction vpsravw = new (Mnemonic.Vpsravw);

    public static readonly BetterInstruction vpsraw = new (Mnemonic.Vpsraw);

    public static readonly BetterInstruction vpsrld = new (Mnemonic.Vpsrld);

    public static readonly BetterInstruction vpsrldq = new (Mnemonic.Vpsrldq);

    public static readonly BetterInstruction vpsrlq = new (Mnemonic.Vpsrlq);

    public static readonly BetterInstruction vpsrlvd = new (Mnemonic.Vpsrlvd);

    public static readonly BetterInstruction vpsrlvq = new (Mnemonic.Vpsrlvq);

    public static readonly BetterInstruction vpsrlvw = new (Mnemonic.Vpsrlvw);

    public static readonly BetterInstruction vpsrlw = new (Mnemonic.Vpsrlw);

    public static readonly BetterInstruction vpsubb = new (Mnemonic.Vpsubb);

    public static readonly BetterInstruction vpsubd = new (Mnemonic.Vpsubd);

    public static readonly BetterInstruction vpsubq = new (Mnemonic.Vpsubq);

    public static readonly BetterInstruction vpsubsb = new (Mnemonic.Vpsubsb);

    public static readonly BetterInstruction vpsubsw = new (Mnemonic.Vpsubsw);

    public static readonly BetterInstruction vpsubusb = new (Mnemonic.Vpsubusb);

    public static readonly BetterInstruction vpsubusw = new (Mnemonic.Vpsubusw);

    public static readonly BetterInstruction vpsubw = new (Mnemonic.Vpsubw);

    public static readonly BetterInstruction vpternlogd = new (Mnemonic.Vpternlogd);

    public static readonly BetterInstruction vpternlogq = new (Mnemonic.Vpternlogq);

    public static readonly BetterInstruction vptest = new (Mnemonic.Vptest);

    public static readonly BetterInstruction vptestmb = new (Mnemonic.Vptestmb);

    public static readonly BetterInstruction vptestmd = new (Mnemonic.Vptestmd);

    public static readonly BetterInstruction vptestmq = new (Mnemonic.Vptestmq);

    public static readonly BetterInstruction vptestmw = new (Mnemonic.Vptestmw);

    public static readonly BetterInstruction vptestnmb = new (Mnemonic.Vptestnmb);

    public static readonly BetterInstruction vptestnmd = new (Mnemonic.Vptestnmd);

    public static readonly BetterInstruction vptestnmq = new (Mnemonic.Vptestnmq);

    public static readonly BetterInstruction vptestnmw = new (Mnemonic.Vptestnmw);

    public static readonly BetterInstruction vpunpckhbw = new (Mnemonic.Vpunpckhbw);

    public static readonly BetterInstruction vpunpckhdq = new (Mnemonic.Vpunpckhdq);

    public static readonly BetterInstruction vpunpckhqdq = new (Mnemonic.Vpunpckhqdq);

    public static readonly BetterInstruction vpunpckhwd = new (Mnemonic.Vpunpckhwd);

    public static readonly BetterInstruction vpunpcklbw = new (Mnemonic.Vpunpcklbw);

    public static readonly BetterInstruction vpunpckldq = new (Mnemonic.Vpunpckldq);

    public static readonly BetterInstruction vpunpcklqdq = new (Mnemonic.Vpunpcklqdq);

    public static readonly BetterInstruction vpunpcklwd = new (Mnemonic.Vpunpcklwd);

    public static readonly BetterInstruction vpxor = new (Mnemonic.Vpxor);

    public static readonly BetterInstruction vpxord = new (Mnemonic.Vpxord);

    public static readonly BetterInstruction vpxorq = new (Mnemonic.Vpxorq);

    public static readonly BetterInstruction vrangepd = new (Mnemonic.Vrangepd);

    public static readonly BetterInstruction vrangeps = new (Mnemonic.Vrangeps);

    public static readonly BetterInstruction vrangesd = new (Mnemonic.Vrangesd);

    public static readonly BetterInstruction vrangess = new (Mnemonic.Vrangess);

    public static readonly BetterInstruction vrcp14pd = new (Mnemonic.Vrcp14pd);

    public static readonly BetterInstruction vrcp14ps = new (Mnemonic.Vrcp14ps);

    public static readonly BetterInstruction vrcp14sd = new (Mnemonic.Vrcp14sd);

    public static readonly BetterInstruction vrcp14ss = new (Mnemonic.Vrcp14ss);

    public static readonly BetterInstruction vrcp28pd = new (Mnemonic.Vrcp28pd);

    public static readonly BetterInstruction vrcp28ps = new (Mnemonic.Vrcp28ps);

    public static readonly BetterInstruction vrcp28sd = new (Mnemonic.Vrcp28sd);

    public static readonly BetterInstruction vrcp28ss = new (Mnemonic.Vrcp28ss);

    public static readonly BetterInstruction vrcpps = new (Mnemonic.Vrcpps);

    public static readonly BetterInstruction vrcpss = new (Mnemonic.Vrcpss);

    public static readonly BetterInstruction vreducepd = new (Mnemonic.Vreducepd);

    public static readonly BetterInstruction vreduceps = new (Mnemonic.Vreduceps);

    public static readonly BetterInstruction vreducesd = new (Mnemonic.Vreducesd);

    public static readonly BetterInstruction vreducess = new (Mnemonic.Vreducess);

    public static readonly BetterInstruction vrndscalepd = new (Mnemonic.Vrndscalepd);

    public static readonly BetterInstruction vrndscaleps = new (Mnemonic.Vrndscaleps);

    public static readonly BetterInstruction vrndscalesd = new (Mnemonic.Vrndscalesd);

    public static readonly BetterInstruction vrndscaless = new (Mnemonic.Vrndscaless);

    public static readonly BetterInstruction vroundpd = new (Mnemonic.Vroundpd);

    public static readonly BetterInstruction vroundps = new (Mnemonic.Vroundps);

    public static readonly BetterInstruction vroundsd = new (Mnemonic.Vroundsd);

    public static readonly BetterInstruction vroundss = new (Mnemonic.Vroundss);

    public static readonly BetterInstruction vrsqrt14pd = new (Mnemonic.Vrsqrt14pd);

    public static readonly BetterInstruction vrsqrt14ps = new (Mnemonic.Vrsqrt14ps);

    public static readonly BetterInstruction vrsqrt14sd = new (Mnemonic.Vrsqrt14sd);

    public static readonly BetterInstruction vrsqrt14ss = new (Mnemonic.Vrsqrt14ss);

    public static readonly BetterInstruction vrsqrt28pd = new (Mnemonic.Vrsqrt28pd);

    public static readonly BetterInstruction vrsqrt28ps = new (Mnemonic.Vrsqrt28ps);

    public static readonly BetterInstruction vrsqrt28sd = new (Mnemonic.Vrsqrt28sd);

    public static readonly BetterInstruction vrsqrt28ss = new (Mnemonic.Vrsqrt28ss);

    public static readonly BetterInstruction vrsqrtps = new (Mnemonic.Vrsqrtps);

    public static readonly BetterInstruction vrsqrtss = new (Mnemonic.Vrsqrtss);

    public static readonly BetterInstruction vscalefpd = new (Mnemonic.Vscalefpd);

    public static readonly BetterInstruction vscalefps = new (Mnemonic.Vscalefps);

    public static readonly BetterInstruction vscalefsd = new (Mnemonic.Vscalefsd);

    public static readonly BetterInstruction vscalefss = new (Mnemonic.Vscalefss);

    public static readonly BetterInstruction vscatterdpd = new (Mnemonic.Vscatterdpd);

    public static readonly BetterInstruction vscatterdps = new (Mnemonic.Vscatterdps);

    public static readonly BetterInstruction vscatterpf0dpd = new (Mnemonic.Vscatterpf0dpd);

    public static readonly BetterInstruction vscatterpf0dps = new (Mnemonic.Vscatterpf0dps);

    public static readonly BetterInstruction vscatterpf0qpd = new (Mnemonic.Vscatterpf0qpd);

    public static readonly BetterInstruction vscatterpf0qps = new (Mnemonic.Vscatterpf0qps);

    public static readonly BetterInstruction vscatterpf1dpd = new (Mnemonic.Vscatterpf1dpd);

    public static readonly BetterInstruction vscatterpf1dps = new (Mnemonic.Vscatterpf1dps);

    public static readonly BetterInstruction vscatterpf1qpd = new (Mnemonic.Vscatterpf1qpd);

    public static readonly BetterInstruction vscatterpf1qps = new (Mnemonic.Vscatterpf1qps);

    public static readonly BetterInstruction vscatterqpd = new (Mnemonic.Vscatterqpd);

    public static readonly BetterInstruction vscatterqps = new (Mnemonic.Vscatterqps);

    public static readonly BetterInstruction vshuff32x4 = new (Mnemonic.Vshuff32x4);

    public static readonly BetterInstruction vshuff64x2 = new (Mnemonic.Vshuff64x2);

    public static readonly BetterInstruction vshufi32x4 = new (Mnemonic.Vshufi32x4);

    public static readonly BetterInstruction vshufi64x2 = new (Mnemonic.Vshufi64x2);

    public static readonly BetterInstruction vshufpd = new (Mnemonic.Vshufpd);

    public static readonly BetterInstruction vshufps = new (Mnemonic.Vshufps);

    public static readonly BetterInstruction vsqrtpd = new (Mnemonic.Vsqrtpd);

    public static readonly BetterInstruction vsqrtps = new (Mnemonic.Vsqrtps);

    public static readonly BetterInstruction vsqrtsd = new (Mnemonic.Vsqrtsd);

    public static readonly BetterInstruction vsqrtss = new (Mnemonic.Vsqrtss);

    public static readonly BetterInstruction vstmxcsr = new (Mnemonic.Vstmxcsr);

    public static readonly BetterInstruction vsubpd = new (Mnemonic.Vsubpd);

    public static readonly BetterInstruction vsubps = new (Mnemonic.Vsubps);

    public static readonly BetterInstruction vsubsd = new (Mnemonic.Vsubsd);

    public static readonly BetterInstruction vsubss = new (Mnemonic.Vsubss);

    public static readonly BetterInstruction vtestpd = new (Mnemonic.Vtestpd);

    public static readonly BetterInstruction vtestps = new (Mnemonic.Vtestps);

    public static readonly BetterInstruction vucomisd = new (Mnemonic.Vucomisd);

    public static readonly BetterInstruction vucomiss = new (Mnemonic.Vucomiss);

    public static readonly BetterInstruction vunpckhpd = new (Mnemonic.Vunpckhpd);

    public static readonly BetterInstruction vunpckhps = new (Mnemonic.Vunpckhps);

    public static readonly BetterInstruction vunpcklpd = new (Mnemonic.Vunpcklpd);

    public static readonly BetterInstruction vunpcklps = new (Mnemonic.Vunpcklps);

    public static readonly BetterInstruction vxorpd = new (Mnemonic.Vxorpd);

    public static readonly BetterInstruction vxorps = new (Mnemonic.Vxorps);

    public static readonly BetterInstruction vzeroall = new (Mnemonic.Vzeroall);

    public static readonly BetterInstruction vzeroupper = new (Mnemonic.Vzeroupper);

    public static readonly BetterInstruction wait = new (Mnemonic.Wait);

    public static readonly BetterInstruction wbinvd = new (Mnemonic.Wbinvd);

    public static readonly BetterInstruction wbnoinvd = new (Mnemonic.Wbnoinvd);

    public static readonly BetterInstruction wrfsbase = new (Mnemonic.Wrfsbase);

    public static readonly BetterInstruction wrgsbase = new (Mnemonic.Wrgsbase);

    public static readonly BetterInstruction wrmsr = new (Mnemonic.Wrmsr);

    public static readonly BetterInstruction wrpkru = new (Mnemonic.Wrpkru);

    public static readonly BetterInstruction wrssd = new (Mnemonic.Wrssd);

    public static readonly BetterInstruction wrssq = new (Mnemonic.Wrssq);

    public static readonly BetterInstruction wrussd = new (Mnemonic.Wrussd);

    public static readonly BetterInstruction wrussq = new (Mnemonic.Wrussq);

    public static readonly BetterInstruction xabort = new (Mnemonic.Xabort);

    public static readonly BetterInstruction xadd = new (Mnemonic.Xadd);

    public static readonly BetterInstruction xbegin = new (Mnemonic.Xbegin);

    public static readonly BetterInstruction xbts = new (Mnemonic.Xbts);

    public static readonly BetterInstruction xchg = new (Mnemonic.Xchg);

    public static readonly BetterInstruction xcryptcbc = new (Mnemonic.Xcryptcbc);

    public static readonly BetterInstruction xcryptcfb = new (Mnemonic.Xcryptcfb);

    public static readonly BetterInstruction xcryptctr = new (Mnemonic.Xcryptctr);

    public static readonly BetterInstruction xcryptecb = new (Mnemonic.Xcryptecb);

    public static readonly BetterInstruction xcryptofb = new (Mnemonic.Xcryptofb);

    public static readonly BetterInstruction xend = new (Mnemonic.Xend);

    public static readonly BetterInstruction xgetbv = new (Mnemonic.Xgetbv);

    public static readonly BetterInstruction xlatb = new (Mnemonic.Xlatb);

    public static readonly BetterInstruction xor = new (Mnemonic.Xor);

    public static readonly BetterInstruction xorpd = new (Mnemonic.Xorpd);

    public static readonly BetterInstruction xorps = new (Mnemonic.Xorps);

    public static readonly BetterInstruction xrstor = new (Mnemonic.Xrstor);

    public static readonly BetterInstruction xrstor64 = new (Mnemonic.Xrstor64);

    public static readonly BetterInstruction xrstors = new (Mnemonic.Xrstors);

    public static readonly BetterInstruction xrstors64 = new (Mnemonic.Xrstors64);

    public static readonly BetterInstruction xsave = new (Mnemonic.Xsave);

    public static readonly BetterInstruction xsave64 = new (Mnemonic.Xsave64);

    public static readonly BetterInstruction xsavec = new (Mnemonic.Xsavec);

    public static readonly BetterInstruction xsavec64 = new (Mnemonic.Xsavec64);

    public static readonly BetterInstruction xsaveopt = new (Mnemonic.Xsaveopt);

    public static readonly BetterInstruction xsaveopt64 = new (Mnemonic.Xsaveopt64);

    public static readonly BetterInstruction xsaves = new (Mnemonic.Xsaves);

    public static readonly BetterInstruction xsaves64 = new (Mnemonic.Xsaves64);

    public static readonly BetterInstruction xsetbv = new (Mnemonic.Xsetbv);

    public static readonly BetterInstruction xsha1 = new (Mnemonic.Xsha1);

    public static readonly BetterInstruction xsha256 = new (Mnemonic.Xsha256);

    public static readonly BetterInstruction xstore = new (Mnemonic.Xstore);

    public static readonly BetterInstruction xtest = new (Mnemonic.Xtest);

    public static readonly BetterInstruction rmpadjust = new (Mnemonic.Rmpadjust);

    public static readonly BetterInstruction rmpupdate = new (Mnemonic.Rmpupdate);

    public static readonly BetterInstruction psmash = new (Mnemonic.Psmash);

    public static readonly BetterInstruction pvalidate = new (Mnemonic.Pvalidate);

    public static readonly BetterInstruction serialize = new (Mnemonic.Serialize);

    public static readonly BetterInstruction xsusldtrk = new (Mnemonic.Xsusldtrk);

    public static readonly BetterInstruction xresldtrk = new (Mnemonic.Xresldtrk);

    public static readonly BetterInstruction invlpgb = new (Mnemonic.Invlpgb);

    public static readonly BetterInstruction tlbsync = new (Mnemonic.Tlbsync);

    public static readonly BetterInstruction vmgexit = new (Mnemonic.Vmgexit);

    public static readonly BetterInstruction getsecq = new (Mnemonic.Getsecq);

    public static readonly BetterInstruction sysexitq = new (Mnemonic.Sysexitq);

    public static readonly BetterInstruction ldtilecfg = new (Mnemonic.Ldtilecfg);

    public static readonly BetterInstruction tilerelease = new (Mnemonic.Tilerelease);

    public static readonly BetterInstruction sttilecfg = new (Mnemonic.Sttilecfg);

    public static readonly BetterInstruction tilezero = new (Mnemonic.Tilezero);

    public static readonly BetterInstruction tileloaddt1 = new (Mnemonic.Tileloaddt1);

    public static readonly BetterInstruction tilestored = new (Mnemonic.Tilestored);

    public static readonly BetterInstruction tileloadd = new (Mnemonic.Tileloadd);

    public static readonly BetterInstruction tdpbf16ps = new (Mnemonic.Tdpbf16ps);

    public static readonly BetterInstruction tdpbuud = new (Mnemonic.Tdpbuud);

    public static readonly BetterInstruction tdpbusd = new (Mnemonic.Tdpbusd);

    public static readonly BetterInstruction tdpbsud = new (Mnemonic.Tdpbsud);

    public static readonly BetterInstruction tdpbssd = new (Mnemonic.Tdpbssd);

    public static readonly BetterInstruction sysretq = new (Mnemonic.Sysretq);

    public static readonly BetterInstruction fnstdw = new (Mnemonic.Fnstdw);

    public static readonly BetterInstruction fnstsg = new (Mnemonic.Fnstsg);

    public static readonly BetterInstruction rdshr = new (Mnemonic.Rdshr);

    public static readonly BetterInstruction wrshr = new (Mnemonic.Wrshr);

    public static readonly BetterInstruction smint = new (Mnemonic.Smint);

    public static readonly BetterInstruction dmint = new (Mnemonic.Dmint);

    public static readonly BetterInstruction rdm = new (Mnemonic.Rdm);

    public static readonly BetterInstruction svdc = new (Mnemonic.Svdc);

    public static readonly BetterInstruction rsdc = new (Mnemonic.Rsdc);

    public static readonly BetterInstruction svldt = new (Mnemonic.Svldt);

    public static readonly BetterInstruction rsldt = new (Mnemonic.Rsldt);

    public static readonly BetterInstruction svts = new (Mnemonic.Svts);

    public static readonly BetterInstruction rsts = new (Mnemonic.Rsts);

    public static readonly BetterInstruction bb0_reset = new (Mnemonic.Bb0_reset);

    public static readonly BetterInstruction bb1_reset = new (Mnemonic.Bb1_reset);

    public static readonly BetterInstruction cpu_write = new (Mnemonic.Cpu_write);

    public static readonly BetterInstruction cpu_read = new (Mnemonic.Cpu_read);

    public static readonly BetterInstruction altinst = new (Mnemonic.Altinst);

    public static readonly BetterInstruction paveb = new (Mnemonic.Paveb);

    public static readonly BetterInstruction paddsiw = new (Mnemonic.Paddsiw);

    public static readonly BetterInstruction pmagw = new (Mnemonic.Pmagw);

    public static readonly BetterInstruction pdistib = new (Mnemonic.Pdistib);

    public static readonly BetterInstruction psubsiw = new (Mnemonic.Psubsiw);

    public static readonly BetterInstruction pmvzb = new (Mnemonic.Pmvzb);

    public static readonly BetterInstruction pmvnzb = new (Mnemonic.Pmvnzb);

    public static readonly BetterInstruction pmvlzb = new (Mnemonic.Pmvlzb);

    public static readonly BetterInstruction pmvgezb = new (Mnemonic.Pmvgezb);

    public static readonly BetterInstruction pmulhriw = new (Mnemonic.Pmulhriw);

    public static readonly BetterInstruction pmachriw = new (Mnemonic.Pmachriw);

    public static readonly BetterInstruction ftstp = new (Mnemonic.Ftstp);

    public static readonly BetterInstruction frint2 = new (Mnemonic.Frint2);

    public static readonly BetterInstruction frichop = new (Mnemonic.Frichop);

    public static readonly BetterInstruction frinear = new (Mnemonic.Frinear);

    public static readonly BetterInstruction undoc = new (Mnemonic.Undoc);

    public static readonly BetterInstruction tdcall = new (Mnemonic.Tdcall);

    public static readonly BetterInstruction seamret = new (Mnemonic.Seamret);

    public static readonly BetterInstruction seamops = new (Mnemonic.Seamops);

    public static readonly BetterInstruction seamcall = new (Mnemonic.Seamcall);

    public static readonly BetterInstruction aesencwide128kl = new (Mnemonic.Aesencwide128kl);

    public static readonly BetterInstruction aesdecwide128kl = new (Mnemonic.Aesdecwide128kl);

    public static readonly BetterInstruction aesencwide256kl = new (Mnemonic.Aesencwide256kl);

    public static readonly BetterInstruction aesdecwide256kl = new (Mnemonic.Aesdecwide256kl);

    public static readonly BetterInstruction loadiwkey = new (Mnemonic.Loadiwkey);

    public static readonly BetterInstruction aesenc128kl = new (Mnemonic.Aesenc128kl);

    public static readonly BetterInstruction aesdec128kl = new (Mnemonic.Aesdec128kl);

    public static readonly BetterInstruction aesenc256kl = new (Mnemonic.Aesenc256kl);

    public static readonly BetterInstruction aesdec256kl = new (Mnemonic.Aesdec256kl);

    public static readonly BetterInstruction encodekey128 = new (Mnemonic.Encodekey128);

    public static readonly BetterInstruction encodekey256 = new (Mnemonic.Encodekey256);

    public static readonly BetterInstruction pushad = new (Mnemonic.Pushad);

    public static readonly BetterInstruction popad = new (Mnemonic.Popad);

    public static readonly BetterInstruction pushfd = new (Mnemonic.Pushfd);

    public static readonly BetterInstruction pushfq = new (Mnemonic.Pushfq);

    public static readonly BetterInstruction popfd = new (Mnemonic.Popfd);

    public static readonly BetterInstruction popfq = new (Mnemonic.Popfq);

    public static readonly BetterInstruction iretd = new (Mnemonic.Iretd);

    public static readonly BetterInstruction iretq = new (Mnemonic.Iretq);

    public static readonly BetterInstruction int3 = new (Mnemonic.Int3);

    public static readonly BetterInstruction uiret = new (Mnemonic.Uiret);

    public static readonly BetterInstruction testui = new (Mnemonic.Testui);

    public static readonly BetterInstruction clui = new (Mnemonic.Clui);

    public static readonly BetterInstruction stui = new (Mnemonic.Stui);

    public static readonly BetterInstruction senduipi = new (Mnemonic.Senduipi);

    public static readonly BetterInstruction hreset = new (Mnemonic.Hreset);

    public static readonly BetterInstruction ccs_hash = new (Mnemonic.Ccs_hash);

    public static readonly BetterInstruction ccs_encrypt = new (Mnemonic.Ccs_encrypt);

    public static readonly BetterInstruction lkgs = new (Mnemonic.Lkgs);

    public static readonly BetterInstruction eretu = new (Mnemonic.Eretu);

    public static readonly BetterInstruction erets = new (Mnemonic.Erets);

    public static readonly BetterInstruction storeall = new (Mnemonic.Storeall);

    public static readonly BetterInstruction vaddph = new (Mnemonic.Vaddph);

    public static readonly BetterInstruction vaddsh = new (Mnemonic.Vaddsh);

    public static readonly BetterInstruction vcmpph = new (Mnemonic.Vcmpph);

    public static readonly BetterInstruction vcmpsh = new (Mnemonic.Vcmpsh);

    public static readonly BetterInstruction vcomish = new (Mnemonic.Vcomish);

    public static readonly BetterInstruction vcvtdq2ph = new (Mnemonic.Vcvtdq2ph);

    public static readonly BetterInstruction vcvtpd2ph = new (Mnemonic.Vcvtpd2ph);

    public static readonly BetterInstruction vcvtph2dq = new (Mnemonic.Vcvtph2dq);

    public static readonly BetterInstruction vcvtph2pd = new (Mnemonic.Vcvtph2pd);

    public static readonly BetterInstruction vcvtph2psx = new (Mnemonic.Vcvtph2psx);

    public static readonly BetterInstruction vcvtph2qq = new (Mnemonic.Vcvtph2qq);

    public static readonly BetterInstruction vcvtph2udq = new (Mnemonic.Vcvtph2udq);

    public static readonly BetterInstruction vcvtph2uqq = new (Mnemonic.Vcvtph2uqq);

    public static readonly BetterInstruction vcvtph2uw = new (Mnemonic.Vcvtph2uw);

    public static readonly BetterInstruction vcvtph2w = new (Mnemonic.Vcvtph2w);

    public static readonly BetterInstruction vcvtps2phx = new (Mnemonic.Vcvtps2phx);

    public static readonly BetterInstruction vcvtqq2ph = new (Mnemonic.Vcvtqq2ph);

    public static readonly BetterInstruction vcvtsd2sh = new (Mnemonic.Vcvtsd2sh);

    public static readonly BetterInstruction vcvtsh2sd = new (Mnemonic.Vcvtsh2sd);

    public static readonly BetterInstruction vcvtsh2si = new (Mnemonic.Vcvtsh2si);

    public static readonly BetterInstruction vcvtsh2ss = new (Mnemonic.Vcvtsh2ss);

    public static readonly BetterInstruction vcvtsh2usi = new (Mnemonic.Vcvtsh2usi);

    public static readonly BetterInstruction vcvtsi2sh = new (Mnemonic.Vcvtsi2sh);

    public static readonly BetterInstruction vcvtss2sh = new (Mnemonic.Vcvtss2sh);

    public static readonly BetterInstruction vcvttph2dq = new (Mnemonic.Vcvttph2dq);

    public static readonly BetterInstruction vcvttph2qq = new (Mnemonic.Vcvttph2qq);

    public static readonly BetterInstruction vcvttph2udq = new (Mnemonic.Vcvttph2udq);

    public static readonly BetterInstruction vcvttph2uqq = new (Mnemonic.Vcvttph2uqq);

    public static readonly BetterInstruction vcvttph2uw = new (Mnemonic.Vcvttph2uw);

    public static readonly BetterInstruction vcvttph2w = new (Mnemonic.Vcvttph2w);

    public static readonly BetterInstruction vcvttsh2si = new (Mnemonic.Vcvttsh2si);

    public static readonly BetterInstruction vcvttsh2usi = new (Mnemonic.Vcvttsh2usi);

    public static readonly BetterInstruction vcvtudq2ph = new (Mnemonic.Vcvtudq2ph);

    public static readonly BetterInstruction vcvtuqq2ph = new (Mnemonic.Vcvtuqq2ph);

    public static readonly BetterInstruction vcvtusi2sh = new (Mnemonic.Vcvtusi2sh);

    public static readonly BetterInstruction vcvtuw2ph = new (Mnemonic.Vcvtuw2ph);

    public static readonly BetterInstruction vcvtw2ph = new (Mnemonic.Vcvtw2ph);

    public static readonly BetterInstruction vdivph = new (Mnemonic.Vdivph);

    public static readonly BetterInstruction vdivsh = new (Mnemonic.Vdivsh);

    public static readonly BetterInstruction vfcmaddcph = new (Mnemonic.Vfcmaddcph);

    public static readonly BetterInstruction vfmaddcph = new (Mnemonic.Vfmaddcph);

    public static readonly BetterInstruction vfcmaddcsh = new (Mnemonic.Vfcmaddcsh);

    public static readonly BetterInstruction vfmaddcsh = new (Mnemonic.Vfmaddcsh);

    public static readonly BetterInstruction vfcmulcph = new (Mnemonic.Vfcmulcph);

    public static readonly BetterInstruction vfmulcph = new (Mnemonic.Vfmulcph);

    public static readonly BetterInstruction vfcmulcsh = new (Mnemonic.Vfcmulcsh);

    public static readonly BetterInstruction vfmulcsh = new (Mnemonic.Vfmulcsh);

    public static readonly BetterInstruction vfmaddsub132ph = new (Mnemonic.Vfmaddsub132ph);

    public static readonly BetterInstruction vfmaddsub213ph = new (Mnemonic.Vfmaddsub213ph);

    public static readonly BetterInstruction vfmaddsub231ph = new (Mnemonic.Vfmaddsub231ph);

    public static readonly BetterInstruction vfmsubadd132ph = new (Mnemonic.Vfmsubadd132ph);

    public static readonly BetterInstruction vfmsubadd213ph = new (Mnemonic.Vfmsubadd213ph);

    public static readonly BetterInstruction vfmsubadd231ph = new (Mnemonic.Vfmsubadd231ph);

    public static readonly BetterInstruction vfmadd132ph = new (Mnemonic.Vfmadd132ph);

    public static readonly BetterInstruction vfmadd213ph = new (Mnemonic.Vfmadd213ph);

    public static readonly BetterInstruction vfmadd231ph = new (Mnemonic.Vfmadd231ph);

    public static readonly BetterInstruction vfnmadd132ph = new (Mnemonic.Vfnmadd132ph);

    public static readonly BetterInstruction vfnmadd213ph = new (Mnemonic.Vfnmadd213ph);

    public static readonly BetterInstruction vfnmadd231ph = new (Mnemonic.Vfnmadd231ph);

    public static readonly BetterInstruction vfmadd132sh = new (Mnemonic.Vfmadd132sh);

    public static readonly BetterInstruction vfmadd213sh = new (Mnemonic.Vfmadd213sh);

    public static readonly BetterInstruction vfmadd231sh = new (Mnemonic.Vfmadd231sh);

    public static readonly BetterInstruction vfnmadd132sh = new (Mnemonic.Vfnmadd132sh);

    public static readonly BetterInstruction vfnmadd213sh = new (Mnemonic.Vfnmadd213sh);

    public static readonly BetterInstruction vfnmadd231sh = new (Mnemonic.Vfnmadd231sh);

    public static readonly BetterInstruction vfmsub132ph = new (Mnemonic.Vfmsub132ph);

    public static readonly BetterInstruction vfmsub213ph = new (Mnemonic.Vfmsub213ph);

    public static readonly BetterInstruction vfmsub231ph = new (Mnemonic.Vfmsub231ph);

    public static readonly BetterInstruction vfnmsub132ph = new (Mnemonic.Vfnmsub132ph);

    public static readonly BetterInstruction vfnmsub213ph = new (Mnemonic.Vfnmsub213ph);

    public static readonly BetterInstruction vfnmsub231ph = new (Mnemonic.Vfnmsub231ph);

    public static readonly BetterInstruction vfmsub132sh = new (Mnemonic.Vfmsub132sh);

    public static readonly BetterInstruction vfmsub213sh = new (Mnemonic.Vfmsub213sh);

    public static readonly BetterInstruction vfmsub231sh = new (Mnemonic.Vfmsub231sh);

    public static readonly BetterInstruction vfnmsub132sh = new (Mnemonic.Vfnmsub132sh);

    public static readonly BetterInstruction vfnmsub213sh = new (Mnemonic.Vfnmsub213sh);

    public static readonly BetterInstruction vfnmsub231sh = new (Mnemonic.Vfnmsub231sh);

    public static readonly BetterInstruction vfpclassph = new (Mnemonic.Vfpclassph);

    public static readonly BetterInstruction vfpclasssh = new (Mnemonic.Vfpclasssh);

    public static readonly BetterInstruction vgetexpph = new (Mnemonic.Vgetexpph);

    public static readonly BetterInstruction vgetexpsh = new (Mnemonic.Vgetexpsh);

    public static readonly BetterInstruction vgetmantph = new (Mnemonic.Vgetmantph);

    public static readonly BetterInstruction vgetmantsh = new (Mnemonic.Vgetmantsh);

    public static readonly BetterInstruction vmaxph = new (Mnemonic.Vmaxph);

    public static readonly BetterInstruction vmaxsh = new (Mnemonic.Vmaxsh);

    public static readonly BetterInstruction vminph = new (Mnemonic.Vminph);

    public static readonly BetterInstruction vminsh = new (Mnemonic.Vminsh);

    public static readonly BetterInstruction vmovsh = new (Mnemonic.Vmovsh);

    public static readonly BetterInstruction vmovw = new (Mnemonic.Vmovw);

    public static readonly BetterInstruction vmulph = new (Mnemonic.Vmulph);

    public static readonly BetterInstruction vmulsh = new (Mnemonic.Vmulsh);

    public static readonly BetterInstruction vrcpph = new (Mnemonic.Vrcpph);

    public static readonly BetterInstruction vrcpsh = new (Mnemonic.Vrcpsh);

    public static readonly BetterInstruction vreduceph = new (Mnemonic.Vreduceph);

    public static readonly BetterInstruction vreducesh = new (Mnemonic.Vreducesh);

    public static readonly BetterInstruction vrndscaleph = new (Mnemonic.Vrndscaleph);

    public static readonly BetterInstruction vrndscalesh = new (Mnemonic.Vrndscalesh);

    public static readonly BetterInstruction vrsqrtph = new (Mnemonic.Vrsqrtph);

    public static readonly BetterInstruction vrsqrtsh = new (Mnemonic.Vrsqrtsh);

    public static readonly BetterInstruction vscalefph = new (Mnemonic.Vscalefph);

    public static readonly BetterInstruction vscalefsh = new (Mnemonic.Vscalefsh);

    public static readonly BetterInstruction vsqrtph = new (Mnemonic.Vsqrtph);

    public static readonly BetterInstruction vsqrtsh = new (Mnemonic.Vsqrtsh);

    public static readonly BetterInstruction vsubph = new (Mnemonic.Vsubph);

    public static readonly BetterInstruction vsubsh = new (Mnemonic.Vsubsh);

    public static readonly BetterInstruction vucomish = new (Mnemonic.Vucomish);

    public static readonly BetterInstruction rdudbg = new (Mnemonic.Rdudbg);

    public static readonly BetterInstruction wrudbg = new (Mnemonic.Wrudbg);

    public static readonly BetterInstruction clevict0 = new (Mnemonic.Clevict0);

    public static readonly BetterInstruction clevict1 = new (Mnemonic.Clevict1);

    public static readonly BetterInstruction delay = new (Mnemonic.Delay);

    public static readonly BetterInstruction jknzd = new (Mnemonic.Jknzd);

    public static readonly BetterInstruction jkzd = new (Mnemonic.Jkzd);

    public static readonly BetterInstruction kand = new (Mnemonic.Kand);

    public static readonly BetterInstruction kandn = new (Mnemonic.Kandn);

    public static readonly BetterInstruction kandnr = new (Mnemonic.Kandnr);

    public static readonly BetterInstruction kconcath = new (Mnemonic.Kconcath);

    public static readonly BetterInstruction kconcatl = new (Mnemonic.Kconcatl);

    public static readonly BetterInstruction kextract = new (Mnemonic.Kextract);

    public static readonly BetterInstruction kmerge2l1h = new (Mnemonic.Kmerge2l1h);

    public static readonly BetterInstruction kmerge2l1l = new (Mnemonic.Kmerge2l1l);

    public static readonly BetterInstruction kmov = new (Mnemonic.Kmov);

    public static readonly BetterInstruction knot = new (Mnemonic.Knot);

    public static readonly BetterInstruction kor = new (Mnemonic.Kor);

    public static readonly BetterInstruction kortest = new (Mnemonic.Kortest);

    public static readonly BetterInstruction kxnor = new (Mnemonic.Kxnor);

    public static readonly BetterInstruction kxor = new (Mnemonic.Kxor);

    public static readonly BetterInstruction spflt = new (Mnemonic.Spflt);

    public static readonly BetterInstruction tzcnti = new (Mnemonic.Tzcnti);

    public static readonly BetterInstruction vaddnpd = new (Mnemonic.Vaddnpd);

    public static readonly BetterInstruction vaddnps = new (Mnemonic.Vaddnps);

    public static readonly BetterInstruction vaddsetsps = new (Mnemonic.Vaddsetsps);

    public static readonly BetterInstruction vcvtfxpntdq2ps = new (Mnemonic.Vcvtfxpntdq2ps);

    public static readonly BetterInstruction vcvtfxpntpd2dq = new (Mnemonic.Vcvtfxpntpd2dq);

    public static readonly BetterInstruction vcvtfxpntpd2udq = new (Mnemonic.Vcvtfxpntpd2udq);

    public static readonly BetterInstruction vcvtfxpntps2dq = new (Mnemonic.Vcvtfxpntps2dq);

    public static readonly BetterInstruction vcvtfxpntps2udq = new (Mnemonic.Vcvtfxpntps2udq);

    public static readonly BetterInstruction vcvtfxpntudq2ps = new (Mnemonic.Vcvtfxpntudq2ps);

    public static readonly BetterInstruction vexp223ps = new (Mnemonic.Vexp223ps);

    public static readonly BetterInstruction vfixupnanpd = new (Mnemonic.Vfixupnanpd);

    public static readonly BetterInstruction vfixupnanps = new (Mnemonic.Vfixupnanps);

    public static readonly BetterInstruction vfmadd233ps = new (Mnemonic.Vfmadd233ps);

    public static readonly BetterInstruction vgatherpf0hintdpd = new (Mnemonic.Vgatherpf0hintdpd);

    public static readonly BetterInstruction vgatherpf0hintdps = new (Mnemonic.Vgatherpf0hintdps);

    public static readonly BetterInstruction vgmaxabsps = new (Mnemonic.Vgmaxabsps);

    public static readonly BetterInstruction vgmaxpd = new (Mnemonic.Vgmaxpd);

    public static readonly BetterInstruction vgmaxps = new (Mnemonic.Vgmaxps);

    public static readonly BetterInstruction vgminpd = new (Mnemonic.Vgminpd);

    public static readonly BetterInstruction vgminps = new (Mnemonic.Vgminps);

    public static readonly BetterInstruction vloadunpackhd = new (Mnemonic.Vloadunpackhd);

    public static readonly BetterInstruction vloadunpackhpd = new (Mnemonic.Vloadunpackhpd);

    public static readonly BetterInstruction vloadunpackhps = new (Mnemonic.Vloadunpackhps);

    public static readonly BetterInstruction vloadunpackhq = new (Mnemonic.Vloadunpackhq);

    public static readonly BetterInstruction vloadunpackld = new (Mnemonic.Vloadunpackld);

    public static readonly BetterInstruction vloadunpacklpd = new (Mnemonic.Vloadunpacklpd);

    public static readonly BetterInstruction vloadunpacklps = new (Mnemonic.Vloadunpacklps);

    public static readonly BetterInstruction vloadunpacklq = new (Mnemonic.Vloadunpacklq);

    public static readonly BetterInstruction vlog2ps = new (Mnemonic.Vlog2ps);

    public static readonly BetterInstruction vmovnrapd = new (Mnemonic.Vmovnrapd);

    public static readonly BetterInstruction vmovnraps = new (Mnemonic.Vmovnraps);

    public static readonly BetterInstruction vmovnrngoapd = new (Mnemonic.Vmovnrngoapd);

    public static readonly BetterInstruction vmovnrngoaps = new (Mnemonic.Vmovnrngoaps);

    public static readonly BetterInstruction vpackstorehd = new (Mnemonic.Vpackstorehd);

    public static readonly BetterInstruction vpackstorehpd = new (Mnemonic.Vpackstorehpd);

    public static readonly BetterInstruction vpackstorehps = new (Mnemonic.Vpackstorehps);

    public static readonly BetterInstruction vpackstorehq = new (Mnemonic.Vpackstorehq);

    public static readonly BetterInstruction vpackstoreld = new (Mnemonic.Vpackstoreld);

    public static readonly BetterInstruction vpackstorelpd = new (Mnemonic.Vpackstorelpd);

    public static readonly BetterInstruction vpackstorelps = new (Mnemonic.Vpackstorelps);

    public static readonly BetterInstruction vpackstorelq = new (Mnemonic.Vpackstorelq);

    public static readonly BetterInstruction vpadcd = new (Mnemonic.Vpadcd);

    public static readonly BetterInstruction vpaddsetcd = new (Mnemonic.Vpaddsetcd);

    public static readonly BetterInstruction vpaddsetsd = new (Mnemonic.Vpaddsetsd);

    public static readonly BetterInstruction vpcmpltd = new (Mnemonic.Vpcmpltd);

    public static readonly BetterInstruction vpermf32x4 = new (Mnemonic.Vpermf32x4);

    public static readonly BetterInstruction vpmadd231d = new (Mnemonic.Vpmadd231d);

    public static readonly BetterInstruction vpmadd233d = new (Mnemonic.Vpmadd233d);

    public static readonly BetterInstruction vpmulhd = new (Mnemonic.Vpmulhd);

    public static readonly BetterInstruction vpmulhud = new (Mnemonic.Vpmulhud);

    public static readonly BetterInstruction vprefetch0 = new (Mnemonic.Vprefetch0);

    public static readonly BetterInstruction vprefetch1 = new (Mnemonic.Vprefetch1);

    public static readonly BetterInstruction vprefetch2 = new (Mnemonic.Vprefetch2);

    public static readonly BetterInstruction vprefetche0 = new (Mnemonic.Vprefetche0);

    public static readonly BetterInstruction vprefetche1 = new (Mnemonic.Vprefetche1);

    public static readonly BetterInstruction vprefetche2 = new (Mnemonic.Vprefetche2);

    public static readonly BetterInstruction vprefetchenta = new (Mnemonic.Vprefetchenta);

    public static readonly BetterInstruction vprefetchnta = new (Mnemonic.Vprefetchnta);

    public static readonly BetterInstruction vpsbbd = new (Mnemonic.Vpsbbd);

    public static readonly BetterInstruction vpsbbrd = new (Mnemonic.Vpsbbrd);

    public static readonly BetterInstruction vpsubrd = new (Mnemonic.Vpsubrd);

    public static readonly BetterInstruction vpsubrsetbd = new (Mnemonic.Vpsubrsetbd);

    public static readonly BetterInstruction vpsubsetbd = new (Mnemonic.Vpsubsetbd);

    public static readonly BetterInstruction vrcp23ps = new (Mnemonic.Vrcp23ps);

    public static readonly BetterInstruction vrndfxpntpd = new (Mnemonic.Vrndfxpntpd);

    public static readonly BetterInstruction vrndfxpntps = new (Mnemonic.Vrndfxpntps);

    public static readonly BetterInstruction vrsqrt23ps = new (Mnemonic.Vrsqrt23ps);

    public static readonly BetterInstruction vscaleps = new (Mnemonic.Vscaleps);

    public static readonly BetterInstruction vscatterpf0hintdpd = new (Mnemonic.Vscatterpf0hintdpd);

    public static readonly BetterInstruction vscatterpf0hintdps = new (Mnemonic.Vscatterpf0hintdps);

    public static readonly BetterInstruction vsubrpd = new (Mnemonic.Vsubrpd);

    public static readonly BetterInstruction vsubrps = new (Mnemonic.Vsubrps);

    }