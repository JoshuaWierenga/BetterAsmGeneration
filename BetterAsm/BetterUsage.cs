using BetterAsm;
using Iced.Intel;

public static class BetterAsmInstructions
{
    public static readonly BetterInstruction INVALID = new (Mnemonic.INVALID);
  
    
    public static readonly BetterInstruction Aaa = new (Mnemonic.Aaa);
  
    
    public static readonly BetterInstruction Aad = new (Mnemonic.Aad);
  
    
    public static readonly BetterInstruction Aam = new (Mnemonic.Aam);
  
    
    public static readonly BetterInstruction Aas = new (Mnemonic.Aas);
  
    
    public static readonly BetterInstruction Adc = new (Mnemonic.Adc);
  
    
    public static readonly BetterInstruction Adcx = new (Mnemonic.Adcx);
  
    
    public static readonly BetterInstruction Add = new (Mnemonic.Add);
  
    
    public static readonly BetterInstruction Addpd = new (Mnemonic.Addpd);
  
    
    public static readonly BetterInstruction Addps = new (Mnemonic.Addps);
  
    
    public static readonly BetterInstruction Addsd = new (Mnemonic.Addsd);
  
    
    public static readonly BetterInstruction Addss = new (Mnemonic.Addss);
  
    
    public static readonly BetterInstruction Addsubpd = new (Mnemonic.Addsubpd);
  
    
    public static readonly BetterInstruction Addsubps = new (Mnemonic.Addsubps);
  
    
    public static readonly BetterInstruction Adox = new (Mnemonic.Adox);
  
    
    public static readonly BetterInstruction Aesdec = new (Mnemonic.Aesdec);
  
    
    public static readonly BetterInstruction Aesdeclast = new (Mnemonic.Aesdeclast);
  
    
    public static readonly BetterInstruction Aesenc = new (Mnemonic.Aesenc);
  
    
    public static readonly BetterInstruction Aesenclast = new (Mnemonic.Aesenclast);
  
    
    public static readonly BetterInstruction Aesimc = new (Mnemonic.Aesimc);
  
    
    public static readonly BetterInstruction Aeskeygenassist = new (Mnemonic.Aeskeygenassist);
  
    
    public static readonly BetterInstruction And = new (Mnemonic.And);
  
    
    public static readonly BetterInstruction Andn = new (Mnemonic.Andn);
  
    
    public static readonly BetterInstruction Andnpd = new (Mnemonic.Andnpd);
  
    
    public static readonly BetterInstruction Andnps = new (Mnemonic.Andnps);
  
    
    public static readonly BetterInstruction Andpd = new (Mnemonic.Andpd);
  
    
    public static readonly BetterInstruction Andps = new (Mnemonic.Andps);
  
    
    public static readonly BetterInstruction Arpl = new (Mnemonic.Arpl);
  
    
    public static readonly BetterInstruction Bextr = new (Mnemonic.Bextr);
  
    
    public static readonly BetterInstruction Blcfill = new (Mnemonic.Blcfill);
  
    
    public static readonly BetterInstruction Blci = new (Mnemonic.Blci);
  
    
    public static readonly BetterInstruction Blcic = new (Mnemonic.Blcic);
  
    
    public static readonly BetterInstruction Blcmsk = new (Mnemonic.Blcmsk);
  
    
    public static readonly BetterInstruction Blcs = new (Mnemonic.Blcs);
  
    
    public static readonly BetterInstruction Blendpd = new (Mnemonic.Blendpd);
  
    
    public static readonly BetterInstruction Blendps = new (Mnemonic.Blendps);
  
    
    public static readonly BetterInstruction Blendvpd = new (Mnemonic.Blendvpd);
  
    
    public static readonly BetterInstruction Blendvps = new (Mnemonic.Blendvps);
  
    
    public static readonly BetterInstruction Blsfill = new (Mnemonic.Blsfill);
  
    
    public static readonly BetterInstruction Blsi = new (Mnemonic.Blsi);
  
    
    public static readonly BetterInstruction Blsic = new (Mnemonic.Blsic);
  
    
    public static readonly BetterInstruction Blsmsk = new (Mnemonic.Blsmsk);
  
    
    public static readonly BetterInstruction Blsr = new (Mnemonic.Blsr);
  
    
    public static readonly BetterInstruction Bndcl = new (Mnemonic.Bndcl);
  
    
    public static readonly BetterInstruction Bndcn = new (Mnemonic.Bndcn);
  
    
    public static readonly BetterInstruction Bndcu = new (Mnemonic.Bndcu);
  
    
    public static readonly BetterInstruction Bndldx = new (Mnemonic.Bndldx);
  
    
    public static readonly BetterInstruction Bndmk = new (Mnemonic.Bndmk);
  
    
    public static readonly BetterInstruction Bndmov = new (Mnemonic.Bndmov);
  
    
    public static readonly BetterInstruction Bndstx = new (Mnemonic.Bndstx);
  
    
    public static readonly BetterInstruction Bound = new (Mnemonic.Bound);
  
    
    public static readonly BetterInstruction Bsf = new (Mnemonic.Bsf);
  
    
    public static readonly BetterInstruction Bsr = new (Mnemonic.Bsr);
  
    
    public static readonly BetterInstruction Bswap = new (Mnemonic.Bswap);
  
    
    public static readonly BetterInstruction Bt = new (Mnemonic.Bt);
  
    
    public static readonly BetterInstruction Btc = new (Mnemonic.Btc);
  
    
    public static readonly BetterInstruction Btr = new (Mnemonic.Btr);
  
    
    public static readonly BetterInstruction Bts = new (Mnemonic.Bts);
  
    
    public static readonly BetterInstruction Bzhi = new (Mnemonic.Bzhi);
  
    
    public static readonly BetterInstruction Call = new (Mnemonic.Call);
  
    
    public static readonly BetterInstruction Cbw = new (Mnemonic.Cbw);
  
    
    public static readonly BetterInstruction Cdq = new (Mnemonic.Cdq);
  
    
    public static readonly BetterInstruction Cdqe = new (Mnemonic.Cdqe);
  
    
    public static readonly BetterInstruction Cl1invmb = new (Mnemonic.Cl1invmb);
  
    
    public static readonly BetterInstruction Clac = new (Mnemonic.Clac);
  
    
    public static readonly BetterInstruction Clc = new (Mnemonic.Clc);
  
    
    public static readonly BetterInstruction Cld = new (Mnemonic.Cld);
  
    
    public static readonly BetterInstruction Cldemote = new (Mnemonic.Cldemote);
  
    
    public static readonly BetterInstruction Clflush = new (Mnemonic.Clflush);
  
    
    public static readonly BetterInstruction Clflushopt = new (Mnemonic.Clflushopt);
  
    
    public static readonly BetterInstruction Clgi = new (Mnemonic.Clgi);
  
    
    public static readonly BetterInstruction Cli = new (Mnemonic.Cli);
  
    
    public static readonly BetterInstruction Clrssbsy = new (Mnemonic.Clrssbsy);
  
    
    public static readonly BetterInstruction Clts = new (Mnemonic.Clts);
  
    
    public static readonly BetterInstruction Clwb = new (Mnemonic.Clwb);
  
    
    public static readonly BetterInstruction Clzero = new (Mnemonic.Clzero);
  
    
    public static readonly BetterInstruction Cmc = new (Mnemonic.Cmc);
  
    
    public static readonly BetterInstruction Cmova = new (Mnemonic.Cmova);
  
    
    public static readonly BetterInstruction Cmovae = new (Mnemonic.Cmovae);
  
    
    public static readonly BetterInstruction Cmovb = new (Mnemonic.Cmovb);
  
    
    public static readonly BetterInstruction Cmovbe = new (Mnemonic.Cmovbe);
  
    
    public static readonly BetterInstruction Cmove = new (Mnemonic.Cmove);
  
    
    public static readonly BetterInstruction Cmovg = new (Mnemonic.Cmovg);
  
    
    public static readonly BetterInstruction Cmovge = new (Mnemonic.Cmovge);
  
    
    public static readonly BetterInstruction Cmovl = new (Mnemonic.Cmovl);
  
    
    public static readonly BetterInstruction Cmovle = new (Mnemonic.Cmovle);
  
    
    public static readonly BetterInstruction Cmovne = new (Mnemonic.Cmovne);
  
    
    public static readonly BetterInstruction Cmovno = new (Mnemonic.Cmovno);
  
    
    public static readonly BetterInstruction Cmovnp = new (Mnemonic.Cmovnp);
  
    
    public static readonly BetterInstruction Cmovns = new (Mnemonic.Cmovns);
  
    
    public static readonly BetterInstruction Cmovo = new (Mnemonic.Cmovo);
  
    
    public static readonly BetterInstruction Cmovp = new (Mnemonic.Cmovp);
  
    
    public static readonly BetterInstruction Cmovs = new (Mnemonic.Cmovs);
  
    
    public static readonly BetterInstruction Cmp = new (Mnemonic.Cmp);
  
    
    public static readonly BetterInstruction Cmppd = new (Mnemonic.Cmppd);
  
    
    public static readonly BetterInstruction Cmpps = new (Mnemonic.Cmpps);
  
    
    public static readonly BetterInstruction Cmpsb = new (Mnemonic.Cmpsb);
  
    
    public static readonly BetterInstruction Cmpsd = new (Mnemonic.Cmpsd);
  
    
    public static readonly BetterInstruction Cmpsq = new (Mnemonic.Cmpsq);
  
    
    public static readonly BetterInstruction Cmpss = new (Mnemonic.Cmpss);
  
    
    public static readonly BetterInstruction Cmpsw = new (Mnemonic.Cmpsw);
  
    
    public static readonly BetterInstruction Cmpxchg = new (Mnemonic.Cmpxchg);
  
    
    public static readonly BetterInstruction Cmpxchg16b = new (Mnemonic.Cmpxchg16b);
  
    
    public static readonly BetterInstruction Cmpxchg8b = new (Mnemonic.Cmpxchg8b);
  
    
    public static readonly BetterInstruction Comisd = new (Mnemonic.Comisd);
  
    
    public static readonly BetterInstruction Comiss = new (Mnemonic.Comiss);
  
    
    public static readonly BetterInstruction Cpuid = new (Mnemonic.Cpuid);
  
    
    public static readonly BetterInstruction Cqo = new (Mnemonic.Cqo);
  
    
    public static readonly BetterInstruction Crc32 = new (Mnemonic.Crc32);
  
    
    public static readonly BetterInstruction Cvtdq2pd = new (Mnemonic.Cvtdq2pd);
  
    
    public static readonly BetterInstruction Cvtdq2ps = new (Mnemonic.Cvtdq2ps);
  
    
    public static readonly BetterInstruction Cvtpd2dq = new (Mnemonic.Cvtpd2dq);
  
    
    public static readonly BetterInstruction Cvtpd2pi = new (Mnemonic.Cvtpd2pi);
  
    
    public static readonly BetterInstruction Cvtpd2ps = new (Mnemonic.Cvtpd2ps);
  
    
    public static readonly BetterInstruction Cvtpi2pd = new (Mnemonic.Cvtpi2pd);
  
    
    public static readonly BetterInstruction Cvtpi2ps = new (Mnemonic.Cvtpi2ps);
  
    
    public static readonly BetterInstruction Cvtps2dq = new (Mnemonic.Cvtps2dq);
  
    
    public static readonly BetterInstruction Cvtps2pd = new (Mnemonic.Cvtps2pd);
  
    
    public static readonly BetterInstruction Cvtps2pi = new (Mnemonic.Cvtps2pi);
  
    
    public static readonly BetterInstruction Cvtsd2si = new (Mnemonic.Cvtsd2si);
  
    
    public static readonly BetterInstruction Cvtsd2ss = new (Mnemonic.Cvtsd2ss);
  
    
    public static readonly BetterInstruction Cvtsi2sd = new (Mnemonic.Cvtsi2sd);
  
    
    public static readonly BetterInstruction Cvtsi2ss = new (Mnemonic.Cvtsi2ss);
  
    
    public static readonly BetterInstruction Cvtss2sd = new (Mnemonic.Cvtss2sd);
  
    
    public static readonly BetterInstruction Cvtss2si = new (Mnemonic.Cvtss2si);
  
    
    public static readonly BetterInstruction Cvttpd2dq = new (Mnemonic.Cvttpd2dq);
  
    
    public static readonly BetterInstruction Cvttpd2pi = new (Mnemonic.Cvttpd2pi);
  
    
    public static readonly BetterInstruction Cvttps2dq = new (Mnemonic.Cvttps2dq);
  
    
    public static readonly BetterInstruction Cvttps2pi = new (Mnemonic.Cvttps2pi);
  
    
    public static readonly BetterInstruction Cvttsd2si = new (Mnemonic.Cvttsd2si);
  
    
    public static readonly BetterInstruction Cvttss2si = new (Mnemonic.Cvttss2si);
  
    
    public static readonly BetterInstruction Cwd = new (Mnemonic.Cwd);
  
    
    public static readonly BetterInstruction Cwde = new (Mnemonic.Cwde);
  
    
    public static readonly BetterInstruction Daa = new (Mnemonic.Daa);
  
    
    public static readonly BetterInstruction Das = new (Mnemonic.Das);
  
    
    public static readonly BetterInstruction Db = new (Mnemonic.Db);
  
    
    public static readonly BetterInstruction Dd = new (Mnemonic.Dd);
  
    
    public static readonly BetterInstruction Dec = new (Mnemonic.Dec);
  
    
    public static readonly BetterInstruction Div = new (Mnemonic.Div);
  
    
    public static readonly BetterInstruction Divpd = new (Mnemonic.Divpd);
  
    
    public static readonly BetterInstruction Divps = new (Mnemonic.Divps);
  
    
    public static readonly BetterInstruction Divsd = new (Mnemonic.Divsd);
  
    
    public static readonly BetterInstruction Divss = new (Mnemonic.Divss);
  
    
    public static readonly BetterInstruction Dppd = new (Mnemonic.Dppd);
  
    
    public static readonly BetterInstruction Dpps = new (Mnemonic.Dpps);
  
    
    public static readonly BetterInstruction Dq = new (Mnemonic.Dq);
  
    
    public static readonly BetterInstruction Dw = new (Mnemonic.Dw);
  
    
    public static readonly BetterInstruction Emms = new (Mnemonic.Emms);
  
    
    public static readonly BetterInstruction Encls = new (Mnemonic.Encls);
  
    
    public static readonly BetterInstruction Enclu = new (Mnemonic.Enclu);
  
    
    public static readonly BetterInstruction Enclv = new (Mnemonic.Enclv);
  
    
    public static readonly BetterInstruction Endbr32 = new (Mnemonic.Endbr32);
  
    
    public static readonly BetterInstruction Endbr64 = new (Mnemonic.Endbr64);
  
    
    public static readonly BetterInstruction Enqcmd = new (Mnemonic.Enqcmd);
  
    
    public static readonly BetterInstruction Enqcmds = new (Mnemonic.Enqcmds);
  
    
    public static readonly BetterInstruction Enter = new (Mnemonic.Enter);
  
    
    public static readonly BetterInstruction Extractps = new (Mnemonic.Extractps);
  
    
    public static readonly BetterInstruction Extrq = new (Mnemonic.Extrq);
  
    
    public static readonly BetterInstruction F2xm1 = new (Mnemonic.F2xm1);
  
    
    public static readonly BetterInstruction Fabs = new (Mnemonic.Fabs);
  
    
    public static readonly BetterInstruction Fadd = new (Mnemonic.Fadd);
  
    
    public static readonly BetterInstruction Faddp = new (Mnemonic.Faddp);
  
    
    public static readonly BetterInstruction Fbld = new (Mnemonic.Fbld);
  
    
    public static readonly BetterInstruction Fbstp = new (Mnemonic.Fbstp);
  
    
    public static readonly BetterInstruction Fchs = new (Mnemonic.Fchs);
  
    
    public static readonly BetterInstruction Fclex = new (Mnemonic.Fclex);
  
    
    public static readonly BetterInstruction Fcmovb = new (Mnemonic.Fcmovb);
  
    
    public static readonly BetterInstruction Fcmovbe = new (Mnemonic.Fcmovbe);
  
    
    public static readonly BetterInstruction Fcmove = new (Mnemonic.Fcmove);
  
    
    public static readonly BetterInstruction Fcmovnb = new (Mnemonic.Fcmovnb);
  
    
    public static readonly BetterInstruction Fcmovnbe = new (Mnemonic.Fcmovnbe);
  
    
    public static readonly BetterInstruction Fcmovne = new (Mnemonic.Fcmovne);
  
    
    public static readonly BetterInstruction Fcmovnu = new (Mnemonic.Fcmovnu);
  
    
    public static readonly BetterInstruction Fcmovu = new (Mnemonic.Fcmovu);
  
    
    public static readonly BetterInstruction Fcom = new (Mnemonic.Fcom);
  
    
    public static readonly BetterInstruction Fcomi = new (Mnemonic.Fcomi);
  
    
    public static readonly BetterInstruction Fcomip = new (Mnemonic.Fcomip);
  
    
    public static readonly BetterInstruction Fcomp = new (Mnemonic.Fcomp);
  
    
    public static readonly BetterInstruction Fcompp = new (Mnemonic.Fcompp);
  
    
    public static readonly BetterInstruction Fcos = new (Mnemonic.Fcos);
  
    
    public static readonly BetterInstruction Fdecstp = new (Mnemonic.Fdecstp);
  
    
    public static readonly BetterInstruction Fdisi = new (Mnemonic.Fdisi);
  
    
    public static readonly BetterInstruction Fdiv = new (Mnemonic.Fdiv);
  
    
    public static readonly BetterInstruction Fdivp = new (Mnemonic.Fdivp);
  
    
    public static readonly BetterInstruction Fdivr = new (Mnemonic.Fdivr);
  
    
    public static readonly BetterInstruction Fdivrp = new (Mnemonic.Fdivrp);
  
    
    public static readonly BetterInstruction Femms = new (Mnemonic.Femms);
  
    
    public static readonly BetterInstruction Feni = new (Mnemonic.Feni);
  
    
    public static readonly BetterInstruction Ffree = new (Mnemonic.Ffree);
  
    
    public static readonly BetterInstruction Ffreep = new (Mnemonic.Ffreep);
  
    
    public static readonly BetterInstruction Fiadd = new (Mnemonic.Fiadd);
  
    
    public static readonly BetterInstruction Ficom = new (Mnemonic.Ficom);
  
    
    public static readonly BetterInstruction Ficomp = new (Mnemonic.Ficomp);
  
    
    public static readonly BetterInstruction Fidiv = new (Mnemonic.Fidiv);
  
    
    public static readonly BetterInstruction Fidivr = new (Mnemonic.Fidivr);
  
    
    public static readonly BetterInstruction Fild = new (Mnemonic.Fild);
  
    
    public static readonly BetterInstruction Fimul = new (Mnemonic.Fimul);
  
    
    public static readonly BetterInstruction Fincstp = new (Mnemonic.Fincstp);
  
    
    public static readonly BetterInstruction Finit = new (Mnemonic.Finit);
  
    
    public static readonly BetterInstruction Fist = new (Mnemonic.Fist);
  
    
    public static readonly BetterInstruction Fistp = new (Mnemonic.Fistp);
  
    
    public static readonly BetterInstruction Fisttp = new (Mnemonic.Fisttp);
  
    
    public static readonly BetterInstruction Fisub = new (Mnemonic.Fisub);
  
    
    public static readonly BetterInstruction Fisubr = new (Mnemonic.Fisubr);
  
    
    public static readonly BetterInstruction Fld = new (Mnemonic.Fld);
  
    
    public static readonly BetterInstruction Fld1 = new (Mnemonic.Fld1);
  
    
    public static readonly BetterInstruction Fldcw = new (Mnemonic.Fldcw);
  
    
    public static readonly BetterInstruction Fldenv = new (Mnemonic.Fldenv);
  
    
    public static readonly BetterInstruction Fldl2e = new (Mnemonic.Fldl2e);
  
    
    public static readonly BetterInstruction Fldl2t = new (Mnemonic.Fldl2t);
  
    
    public static readonly BetterInstruction Fldlg2 = new (Mnemonic.Fldlg2);
  
    
    public static readonly BetterInstruction Fldln2 = new (Mnemonic.Fldln2);
  
    
    public static readonly BetterInstruction Fldpi = new (Mnemonic.Fldpi);
  
    
    public static readonly BetterInstruction Fldz = new (Mnemonic.Fldz);
  
    
    public static readonly BetterInstruction Fmul = new (Mnemonic.Fmul);
  
    
    public static readonly BetterInstruction Fmulp = new (Mnemonic.Fmulp);
  
    
    public static readonly BetterInstruction Fnclex = new (Mnemonic.Fnclex);
  
    
    public static readonly BetterInstruction Fndisi = new (Mnemonic.Fndisi);
  
    
    public static readonly BetterInstruction Fneni = new (Mnemonic.Fneni);
  
    
    public static readonly BetterInstruction Fninit = new (Mnemonic.Fninit);
  
    
    public static readonly BetterInstruction Fnop = new (Mnemonic.Fnop);
  
    
    public static readonly BetterInstruction Fnsave = new (Mnemonic.Fnsave);
  
    
    public static readonly BetterInstruction Fnsetpm = new (Mnemonic.Fnsetpm);
  
    
    public static readonly BetterInstruction Fnstcw = new (Mnemonic.Fnstcw);
  
    
    public static readonly BetterInstruction Fnstenv = new (Mnemonic.Fnstenv);
  
    
    public static readonly BetterInstruction Fnstsw = new (Mnemonic.Fnstsw);
  
    
    public static readonly BetterInstruction Fpatan = new (Mnemonic.Fpatan);
  
    
    public static readonly BetterInstruction Fprem = new (Mnemonic.Fprem);
  
    
    public static readonly BetterInstruction Fprem1 = new (Mnemonic.Fprem1);
  
    
    public static readonly BetterInstruction Fptan = new (Mnemonic.Fptan);
  
    
    public static readonly BetterInstruction Frndint = new (Mnemonic.Frndint);
  
    
    public static readonly BetterInstruction Frstor = new (Mnemonic.Frstor);
  
    
    public static readonly BetterInstruction Frstpm = new (Mnemonic.Frstpm);
  
    
    public static readonly BetterInstruction Fsave = new (Mnemonic.Fsave);
  
    
    public static readonly BetterInstruction Fscale = new (Mnemonic.Fscale);
  
    
    public static readonly BetterInstruction Fsetpm = new (Mnemonic.Fsetpm);
  
    
    public static readonly BetterInstruction Fsin = new (Mnemonic.Fsin);
  
    
    public static readonly BetterInstruction Fsincos = new (Mnemonic.Fsincos);
  
    
    public static readonly BetterInstruction Fsqrt = new (Mnemonic.Fsqrt);
  
    
    public static readonly BetterInstruction Fst = new (Mnemonic.Fst);
  
    
    public static readonly BetterInstruction Fstcw = new (Mnemonic.Fstcw);
  
    
    public static readonly BetterInstruction Fstdw = new (Mnemonic.Fstdw);
  
    
    public static readonly BetterInstruction Fstenv = new (Mnemonic.Fstenv);
  
    
    public static readonly BetterInstruction Fstp = new (Mnemonic.Fstp);
  
    
    public static readonly BetterInstruction Fstpnce = new (Mnemonic.Fstpnce);
  
    
    public static readonly BetterInstruction Fstsg = new (Mnemonic.Fstsg);
  
    
    public static readonly BetterInstruction Fstsw = new (Mnemonic.Fstsw);
  
    
    public static readonly BetterInstruction Fsub = new (Mnemonic.Fsub);
  
    
    public static readonly BetterInstruction Fsubp = new (Mnemonic.Fsubp);
  
    
    public static readonly BetterInstruction Fsubr = new (Mnemonic.Fsubr);
  
    
    public static readonly BetterInstruction Fsubrp = new (Mnemonic.Fsubrp);
  
    
    public static readonly BetterInstruction Ftst = new (Mnemonic.Ftst);
  
    
    public static readonly BetterInstruction Fucom = new (Mnemonic.Fucom);
  
    
    public static readonly BetterInstruction Fucomi = new (Mnemonic.Fucomi);
  
    
    public static readonly BetterInstruction Fucomip = new (Mnemonic.Fucomip);
  
    
    public static readonly BetterInstruction Fucomp = new (Mnemonic.Fucomp);
  
    
    public static readonly BetterInstruction Fucompp = new (Mnemonic.Fucompp);
  
    
    public static readonly BetterInstruction Fxam = new (Mnemonic.Fxam);
  
    
    public static readonly BetterInstruction Fxch = new (Mnemonic.Fxch);
  
    
    public static readonly BetterInstruction Fxrstor = new (Mnemonic.Fxrstor);
  
    
    public static readonly BetterInstruction Fxrstor64 = new (Mnemonic.Fxrstor64);
  
    
    public static readonly BetterInstruction Fxsave = new (Mnemonic.Fxsave);
  
    
    public static readonly BetterInstruction Fxsave64 = new (Mnemonic.Fxsave64);
  
    
    public static readonly BetterInstruction Fxtract = new (Mnemonic.Fxtract);
  
    
    public static readonly BetterInstruction Fyl2x = new (Mnemonic.Fyl2x);
  
    
    public static readonly BetterInstruction Fyl2xp1 = new (Mnemonic.Fyl2xp1);
  
    
    public static readonly BetterInstruction Getsec = new (Mnemonic.Getsec);
  
    
    public static readonly BetterInstruction Gf2p8affineinvqb = new (Mnemonic.Gf2p8affineinvqb);
  
    
    public static readonly BetterInstruction Gf2p8affineqb = new (Mnemonic.Gf2p8affineqb);
  
    
    public static readonly BetterInstruction Gf2p8mulb = new (Mnemonic.Gf2p8mulb);
  
    
    public static readonly BetterInstruction Haddpd = new (Mnemonic.Haddpd);
  
    
    public static readonly BetterInstruction Haddps = new (Mnemonic.Haddps);
  
    
    public static readonly BetterInstruction Hlt = new (Mnemonic.Hlt);
  
    
    public static readonly BetterInstruction Hsubpd = new (Mnemonic.Hsubpd);
  
    
    public static readonly BetterInstruction Hsubps = new (Mnemonic.Hsubps);
  
    
    public static readonly BetterInstruction Ibts = new (Mnemonic.Ibts);
  
    
    public static readonly BetterInstruction Idiv = new (Mnemonic.Idiv);
  
    
    public static readonly BetterInstruction Imul = new (Mnemonic.Imul);
  
    
    public static readonly BetterInstruction In = new (Mnemonic.In);
  
    
    public static readonly BetterInstruction Inc = new (Mnemonic.Inc);
  
    
    public static readonly BetterInstruction Incsspd = new (Mnemonic.Incsspd);
  
    
    public static readonly BetterInstruction Incsspq = new (Mnemonic.Incsspq);
  
    
    public static readonly BetterInstruction Insb = new (Mnemonic.Insb);
  
    
    public static readonly BetterInstruction Insd = new (Mnemonic.Insd);
  
    
    public static readonly BetterInstruction Insertps = new (Mnemonic.Insertps);
  
    
    public static readonly BetterInstruction Insertq = new (Mnemonic.Insertq);
  
    
    public static readonly BetterInstruction Insw = new (Mnemonic.Insw);
  
    
    public static readonly BetterInstruction Int = new (Mnemonic.Int);
  
    
    public static readonly BetterInstruction Int1 = new (Mnemonic.Int1);
  
    
    public static readonly BetterInstruction Into = new (Mnemonic.Into);
  
    
    public static readonly BetterInstruction Invd = new (Mnemonic.Invd);
  
    
    public static readonly BetterInstruction Invept = new (Mnemonic.Invept);
  
    
    public static readonly BetterInstruction Invlpg = new (Mnemonic.Invlpg);
  
    
    public static readonly BetterInstruction Invlpga = new (Mnemonic.Invlpga);
  
    
    public static readonly BetterInstruction Invpcid = new (Mnemonic.Invpcid);
  
    
    public static readonly BetterInstruction Invvpid = new (Mnemonic.Invvpid);
  
    
    public static readonly BetterInstruction Iret = new (Mnemonic.Iret);
  
    
    public static readonly BetterInstruction Ja = new (Mnemonic.Ja);
  
    
    public static readonly BetterInstruction Jae = new (Mnemonic.Jae);
  
    
    public static readonly BetterInstruction Jb = new (Mnemonic.Jb);
  
    
    public static readonly BetterInstruction Jbe = new (Mnemonic.Jbe);
  
    
    public static readonly BetterInstruction Jcxz = new (Mnemonic.Jcxz);
  
    
    public static readonly BetterInstruction Je = new (Mnemonic.Je);
  
    
    public static readonly BetterInstruction Jecxz = new (Mnemonic.Jecxz);
  
    
    public static readonly BetterInstruction Jg = new (Mnemonic.Jg);
  
    
    public static readonly BetterInstruction Jge = new (Mnemonic.Jge);
  
    
    public static readonly BetterInstruction Jl = new (Mnemonic.Jl);
  
    
    public static readonly BetterInstruction Jle = new (Mnemonic.Jle);
  
    
    public static readonly BetterInstruction Jmp = new (Mnemonic.Jmp);
  
    
    public static readonly BetterInstruction Jmpe = new (Mnemonic.Jmpe);
  
    
    public static readonly BetterInstruction Jne = new (Mnemonic.Jne);
  
    
    public static readonly BetterInstruction Jno = new (Mnemonic.Jno);
  
    
    public static readonly BetterInstruction Jnp = new (Mnemonic.Jnp);
  
    
    public static readonly BetterInstruction Jns = new (Mnemonic.Jns);
  
    
    public static readonly BetterInstruction Jo = new (Mnemonic.Jo);
  
    
    public static readonly BetterInstruction Jp = new (Mnemonic.Jp);
  
    
    public static readonly BetterInstruction Jrcxz = new (Mnemonic.Jrcxz);
  
    
    public static readonly BetterInstruction Js = new (Mnemonic.Js);
  
    
    public static readonly BetterInstruction Kaddb = new (Mnemonic.Kaddb);
  
    
    public static readonly BetterInstruction Kaddd = new (Mnemonic.Kaddd);
  
    
    public static readonly BetterInstruction Kaddq = new (Mnemonic.Kaddq);
  
    
    public static readonly BetterInstruction Kaddw = new (Mnemonic.Kaddw);
  
    
    public static readonly BetterInstruction Kandb = new (Mnemonic.Kandb);
  
    
    public static readonly BetterInstruction Kandd = new (Mnemonic.Kandd);
  
    
    public static readonly BetterInstruction Kandnb = new (Mnemonic.Kandnb);
  
    
    public static readonly BetterInstruction Kandnd = new (Mnemonic.Kandnd);
  
    
    public static readonly BetterInstruction Kandnq = new (Mnemonic.Kandnq);
  
    
    public static readonly BetterInstruction Kandnw = new (Mnemonic.Kandnw);
  
    
    public static readonly BetterInstruction Kandq = new (Mnemonic.Kandq);
  
    
    public static readonly BetterInstruction Kandw = new (Mnemonic.Kandw);
  
    
    public static readonly BetterInstruction Kmovb = new (Mnemonic.Kmovb);
  
    
    public static readonly BetterInstruction Kmovd = new (Mnemonic.Kmovd);
  
    
    public static readonly BetterInstruction Kmovq = new (Mnemonic.Kmovq);
  
    
    public static readonly BetterInstruction Kmovw = new (Mnemonic.Kmovw);
  
    
    public static readonly BetterInstruction Knotb = new (Mnemonic.Knotb);
  
    
    public static readonly BetterInstruction Knotd = new (Mnemonic.Knotd);
  
    
    public static readonly BetterInstruction Knotq = new (Mnemonic.Knotq);
  
    
    public static readonly BetterInstruction Knotw = new (Mnemonic.Knotw);
  
    
    public static readonly BetterInstruction Korb = new (Mnemonic.Korb);
  
    
    public static readonly BetterInstruction Kord = new (Mnemonic.Kord);
  
    
    public static readonly BetterInstruction Korq = new (Mnemonic.Korq);
  
    
    public static readonly BetterInstruction Kortestb = new (Mnemonic.Kortestb);
  
    
    public static readonly BetterInstruction Kortestd = new (Mnemonic.Kortestd);
  
    
    public static readonly BetterInstruction Kortestq = new (Mnemonic.Kortestq);
  
    
    public static readonly BetterInstruction Kortestw = new (Mnemonic.Kortestw);
  
    
    public static readonly BetterInstruction Korw = new (Mnemonic.Korw);
  
    
    public static readonly BetterInstruction Kshiftlb = new (Mnemonic.Kshiftlb);
  
    
    public static readonly BetterInstruction Kshiftld = new (Mnemonic.Kshiftld);
  
    
    public static readonly BetterInstruction Kshiftlq = new (Mnemonic.Kshiftlq);
  
    
    public static readonly BetterInstruction Kshiftlw = new (Mnemonic.Kshiftlw);
  
    
    public static readonly BetterInstruction Kshiftrb = new (Mnemonic.Kshiftrb);
  
    
    public static readonly BetterInstruction Kshiftrd = new (Mnemonic.Kshiftrd);
  
    
    public static readonly BetterInstruction Kshiftrq = new (Mnemonic.Kshiftrq);
  
    
    public static readonly BetterInstruction Kshiftrw = new (Mnemonic.Kshiftrw);
  
    
    public static readonly BetterInstruction Ktestb = new (Mnemonic.Ktestb);
  
    
    public static readonly BetterInstruction Ktestd = new (Mnemonic.Ktestd);
  
    
    public static readonly BetterInstruction Ktestq = new (Mnemonic.Ktestq);
  
    
    public static readonly BetterInstruction Ktestw = new (Mnemonic.Ktestw);
  
    
    public static readonly BetterInstruction Kunpckbw = new (Mnemonic.Kunpckbw);
  
    
    public static readonly BetterInstruction Kunpckdq = new (Mnemonic.Kunpckdq);
  
    
    public static readonly BetterInstruction Kunpckwd = new (Mnemonic.Kunpckwd);
  
    
    public static readonly BetterInstruction Kxnorb = new (Mnemonic.Kxnorb);
  
    
    public static readonly BetterInstruction Kxnord = new (Mnemonic.Kxnord);
  
    
    public static readonly BetterInstruction Kxnorq = new (Mnemonic.Kxnorq);
  
    
    public static readonly BetterInstruction Kxnorw = new (Mnemonic.Kxnorw);
  
    
    public static readonly BetterInstruction Kxorb = new (Mnemonic.Kxorb);
  
    
    public static readonly BetterInstruction Kxord = new (Mnemonic.Kxord);
  
    
    public static readonly BetterInstruction Kxorq = new (Mnemonic.Kxorq);
  
    
    public static readonly BetterInstruction Kxorw = new (Mnemonic.Kxorw);
  
    
    public static readonly BetterInstruction Lahf = new (Mnemonic.Lahf);
  
    
    public static readonly BetterInstruction Lar = new (Mnemonic.Lar);
  
    
    public static readonly BetterInstruction Lddqu = new (Mnemonic.Lddqu);
  
    
    public static readonly BetterInstruction Ldmxcsr = new (Mnemonic.Ldmxcsr);
  
    
    public static readonly BetterInstruction Lds = new (Mnemonic.Lds);
  
    
    public static readonly BetterInstruction Lea = new (Mnemonic.Lea);
  
    
    public static readonly BetterInstruction Leave = new (Mnemonic.Leave);
  
    
    public static readonly BetterInstruction Les = new (Mnemonic.Les);
  
    
    public static readonly BetterInstruction Lfence = new (Mnemonic.Lfence);
  
    
    public static readonly BetterInstruction Lfs = new (Mnemonic.Lfs);
  
    
    public static readonly BetterInstruction Lgdt = new (Mnemonic.Lgdt);
  
    
    public static readonly BetterInstruction Lgs = new (Mnemonic.Lgs);
  
    
    public static readonly BetterInstruction Lidt = new (Mnemonic.Lidt);
  
    
    public static readonly BetterInstruction Lldt = new (Mnemonic.Lldt);
  
    
    public static readonly BetterInstruction Llwpcb = new (Mnemonic.Llwpcb);
  
    
    public static readonly BetterInstruction Lmsw = new (Mnemonic.Lmsw);
  
    
    public static readonly BetterInstruction Loadall = new (Mnemonic.Loadall);
  
    
    public static readonly BetterInstruction Lodsb = new (Mnemonic.Lodsb);
  
    
    public static readonly BetterInstruction Lodsd = new (Mnemonic.Lodsd);
  
    
    public static readonly BetterInstruction Lodsq = new (Mnemonic.Lodsq);
  
    
    public static readonly BetterInstruction Lodsw = new (Mnemonic.Lodsw);
  
    
    public static readonly BetterInstruction Loop = new (Mnemonic.Loop);
  
    
    public static readonly BetterInstruction Loope = new (Mnemonic.Loope);
  
    
    public static readonly BetterInstruction Loopne = new (Mnemonic.Loopne);
  
    
    public static readonly BetterInstruction Lsl = new (Mnemonic.Lsl);
  
    
    public static readonly BetterInstruction Lss = new (Mnemonic.Lss);
  
    
    public static readonly BetterInstruction Ltr = new (Mnemonic.Ltr);
  
    
    public static readonly BetterInstruction Lwpins = new (Mnemonic.Lwpins);
  
    
    public static readonly BetterInstruction Lwpval = new (Mnemonic.Lwpval);
  
    
    public static readonly BetterInstruction Lzcnt = new (Mnemonic.Lzcnt);
  
    
    public static readonly BetterInstruction Maskmovdqu = new (Mnemonic.Maskmovdqu);
  
    
    public static readonly BetterInstruction Maskmovq = new (Mnemonic.Maskmovq);
  
    
    public static readonly BetterInstruction Maxpd = new (Mnemonic.Maxpd);
  
    
    public static readonly BetterInstruction Maxps = new (Mnemonic.Maxps);
  
    
    public static readonly BetterInstruction Maxsd = new (Mnemonic.Maxsd);
  
    
    public static readonly BetterInstruction Maxss = new (Mnemonic.Maxss);
  
    
    public static readonly BetterInstruction Mcommit = new (Mnemonic.Mcommit);
  
    
    public static readonly BetterInstruction Mfence = new (Mnemonic.Mfence);
  
    
    public static readonly BetterInstruction Minpd = new (Mnemonic.Minpd);
  
    
    public static readonly BetterInstruction Minps = new (Mnemonic.Minps);
  
    
    public static readonly BetterInstruction Minsd = new (Mnemonic.Minsd);
  
    
    public static readonly BetterInstruction Minss = new (Mnemonic.Minss);
  
    
    public static readonly BetterInstruction Monitor = new (Mnemonic.Monitor);
  
    
    public static readonly BetterInstruction Monitorx = new (Mnemonic.Monitorx);
  
    
    public static readonly BetterInstruction Montmul = new (Mnemonic.Montmul);
  
    
    public static readonly BetterInstruction Mov = new (Mnemonic.Mov);
  
    
    public static readonly BetterInstruction Movapd = new (Mnemonic.Movapd);
  
    
    public static readonly BetterInstruction Movaps = new (Mnemonic.Movaps);
  
    
    public static readonly BetterInstruction Movbe = new (Mnemonic.Movbe);
  
    
    public static readonly BetterInstruction Movd = new (Mnemonic.Movd);
  
    
    public static readonly BetterInstruction Movddup = new (Mnemonic.Movddup);
  
    
    public static readonly BetterInstruction Movdir64b = new (Mnemonic.Movdir64b);
  
    
    public static readonly BetterInstruction Movdiri = new (Mnemonic.Movdiri);
  
    
    public static readonly BetterInstruction Movdq2q = new (Mnemonic.Movdq2q);
  
    
    public static readonly BetterInstruction Movdqa = new (Mnemonic.Movdqa);
  
    
    public static readonly BetterInstruction Movdqu = new (Mnemonic.Movdqu);
  
    
    public static readonly BetterInstruction Movhlps = new (Mnemonic.Movhlps);
  
    
    public static readonly BetterInstruction Movhpd = new (Mnemonic.Movhpd);
  
    
    public static readonly BetterInstruction Movhps = new (Mnemonic.Movhps);
  
    
    public static readonly BetterInstruction Movlhps = new (Mnemonic.Movlhps);
  
    
    public static readonly BetterInstruction Movlpd = new (Mnemonic.Movlpd);
  
    
    public static readonly BetterInstruction Movlps = new (Mnemonic.Movlps);
  
    
    public static readonly BetterInstruction Movmskpd = new (Mnemonic.Movmskpd);
  
    
    public static readonly BetterInstruction Movmskps = new (Mnemonic.Movmskps);
  
    
    public static readonly BetterInstruction Movntdq = new (Mnemonic.Movntdq);
  
    
    public static readonly BetterInstruction Movntdqa = new (Mnemonic.Movntdqa);
  
    
    public static readonly BetterInstruction Movnti = new (Mnemonic.Movnti);
  
    
    public static readonly BetterInstruction Movntpd = new (Mnemonic.Movntpd);
  
    
    public static readonly BetterInstruction Movntps = new (Mnemonic.Movntps);
  
    
    public static readonly BetterInstruction Movntq = new (Mnemonic.Movntq);
  
    
    public static readonly BetterInstruction Movntsd = new (Mnemonic.Movntsd);
  
    
    public static readonly BetterInstruction Movntss = new (Mnemonic.Movntss);
  
    
    public static readonly BetterInstruction Movq = new (Mnemonic.Movq);
  
    
    public static readonly BetterInstruction Movq2dq = new (Mnemonic.Movq2dq);
  
    
    public static readonly BetterInstruction Movsb = new (Mnemonic.Movsb);
  
    
    public static readonly BetterInstruction Movsd = new (Mnemonic.Movsd);
  
    
    public static readonly BetterInstruction Movshdup = new (Mnemonic.Movshdup);
  
    
    public static readonly BetterInstruction Movsldup = new (Mnemonic.Movsldup);
  
    
    public static readonly BetterInstruction Movsq = new (Mnemonic.Movsq);
  
    
    public static readonly BetterInstruction Movss = new (Mnemonic.Movss);
  
    
    public static readonly BetterInstruction Movsw = new (Mnemonic.Movsw);
  
    
    public static readonly BetterInstruction Movsx = new (Mnemonic.Movsx);
  
    
    public static readonly BetterInstruction Movsxd = new (Mnemonic.Movsxd);
  
    
    public static readonly BetterInstruction Movupd = new (Mnemonic.Movupd);
  
    
    public static readonly BetterInstruction Movups = new (Mnemonic.Movups);
  
    
    public static readonly BetterInstruction Movzx = new (Mnemonic.Movzx);
  
    
    public static readonly BetterInstruction Mpsadbw = new (Mnemonic.Mpsadbw);
  
    
    public static readonly BetterInstruction Mul = new (Mnemonic.Mul);
  
    
    public static readonly BetterInstruction Mulpd = new (Mnemonic.Mulpd);
  
    
    public static readonly BetterInstruction Mulps = new (Mnemonic.Mulps);
  
    
    public static readonly BetterInstruction Mulsd = new (Mnemonic.Mulsd);
  
    
    public static readonly BetterInstruction Mulss = new (Mnemonic.Mulss);
  
    
    public static readonly BetterInstruction Mulx = new (Mnemonic.Mulx);
  
    
    public static readonly BetterInstruction Mwait = new (Mnemonic.Mwait);
  
    
    public static readonly BetterInstruction Mwaitx = new (Mnemonic.Mwaitx);
  
    
    public static readonly BetterInstruction Neg = new (Mnemonic.Neg);
  
    
    public static readonly BetterInstruction Nop = new (Mnemonic.Nop);
  
    
    public static readonly BetterInstruction Not = new (Mnemonic.Not);
  
    
    public static readonly BetterInstruction Or = new (Mnemonic.Or);
  
    
    public static readonly BetterInstruction Orpd = new (Mnemonic.Orpd);
  
    
    public static readonly BetterInstruction Orps = new (Mnemonic.Orps);
  
    
    public static readonly BetterInstruction Out = new (Mnemonic.Out);
  
    
    public static readonly BetterInstruction Outsb = new (Mnemonic.Outsb);
  
    
    public static readonly BetterInstruction Outsd = new (Mnemonic.Outsd);
  
    
    public static readonly BetterInstruction Outsw = new (Mnemonic.Outsw);
  
    
    public static readonly BetterInstruction Pabsb = new (Mnemonic.Pabsb);
  
    
    public static readonly BetterInstruction Pabsd = new (Mnemonic.Pabsd);
  
    
    public static readonly BetterInstruction Pabsw = new (Mnemonic.Pabsw);
  
    
    public static readonly BetterInstruction Packssdw = new (Mnemonic.Packssdw);
  
    
    public static readonly BetterInstruction Packsswb = new (Mnemonic.Packsswb);
  
    
    public static readonly BetterInstruction Packusdw = new (Mnemonic.Packusdw);
  
    
    public static readonly BetterInstruction Packuswb = new (Mnemonic.Packuswb);
  
    
    public static readonly BetterInstruction Paddb = new (Mnemonic.Paddb);
  
    
    public static readonly BetterInstruction Paddd = new (Mnemonic.Paddd);
  
    
    public static readonly BetterInstruction Paddq = new (Mnemonic.Paddq);
  
    
    public static readonly BetterInstruction Paddsb = new (Mnemonic.Paddsb);
  
    
    public static readonly BetterInstruction Paddsw = new (Mnemonic.Paddsw);
  
    
    public static readonly BetterInstruction Paddusb = new (Mnemonic.Paddusb);
  
    
    public static readonly BetterInstruction Paddusw = new (Mnemonic.Paddusw);
  
    
    public static readonly BetterInstruction Paddw = new (Mnemonic.Paddw);
  
    
    public static readonly BetterInstruction Palignr = new (Mnemonic.Palignr);
  
    
    public static readonly BetterInstruction Pand = new (Mnemonic.Pand);
  
    
    public static readonly BetterInstruction Pandn = new (Mnemonic.Pandn);
  
    
    public static readonly BetterInstruction Pause = new (Mnemonic.Pause);
  
    
    public static readonly BetterInstruction Pavgb = new (Mnemonic.Pavgb);
  
    
    public static readonly BetterInstruction Pavgusb = new (Mnemonic.Pavgusb);
  
    
    public static readonly BetterInstruction Pavgw = new (Mnemonic.Pavgw);
  
    
    public static readonly BetterInstruction Pblendvb = new (Mnemonic.Pblendvb);
  
    
    public static readonly BetterInstruction Pblendw = new (Mnemonic.Pblendw);
  
    
    public static readonly BetterInstruction Pclmulqdq = new (Mnemonic.Pclmulqdq);
  
    
    public static readonly BetterInstruction Pcmpeqb = new (Mnemonic.Pcmpeqb);
  
    
    public static readonly BetterInstruction Pcmpeqd = new (Mnemonic.Pcmpeqd);
  
    
    public static readonly BetterInstruction Pcmpeqq = new (Mnemonic.Pcmpeqq);
  
    
    public static readonly BetterInstruction Pcmpeqw = new (Mnemonic.Pcmpeqw);
  
    
    public static readonly BetterInstruction Pcmpestri = new (Mnemonic.Pcmpestri);
  
    
    public static readonly BetterInstruction Pcmpestri64 = new (Mnemonic.Pcmpestri64);
  
    
    public static readonly BetterInstruction Pcmpestrm = new (Mnemonic.Pcmpestrm);
  
    
    public static readonly BetterInstruction Pcmpestrm64 = new (Mnemonic.Pcmpestrm64);
  
    
    public static readonly BetterInstruction Pcmpgtb = new (Mnemonic.Pcmpgtb);
  
    
    public static readonly BetterInstruction Pcmpgtd = new (Mnemonic.Pcmpgtd);
  
    
    public static readonly BetterInstruction Pcmpgtq = new (Mnemonic.Pcmpgtq);
  
    
    public static readonly BetterInstruction Pcmpgtw = new (Mnemonic.Pcmpgtw);
  
    
    public static readonly BetterInstruction Pcmpistri = new (Mnemonic.Pcmpistri);
  
    
    public static readonly BetterInstruction Pcmpistrm = new (Mnemonic.Pcmpistrm);
  
    
    public static readonly BetterInstruction Pcommit = new (Mnemonic.Pcommit);
  
    
    public static readonly BetterInstruction Pconfig = new (Mnemonic.Pconfig);
  
    
    public static readonly BetterInstruction Pdep = new (Mnemonic.Pdep);
  
    
    public static readonly BetterInstruction Pext = new (Mnemonic.Pext);
  
    
    public static readonly BetterInstruction Pextrb = new (Mnemonic.Pextrb);
  
    
    public static readonly BetterInstruction Pextrd = new (Mnemonic.Pextrd);
  
    
    public static readonly BetterInstruction Pextrq = new (Mnemonic.Pextrq);
  
    
    public static readonly BetterInstruction Pextrw = new (Mnemonic.Pextrw);
  
    
    public static readonly BetterInstruction Pf2id = new (Mnemonic.Pf2id);
  
    
    public static readonly BetterInstruction Pf2iw = new (Mnemonic.Pf2iw);
  
    
    public static readonly BetterInstruction Pfacc = new (Mnemonic.Pfacc);
  
    
    public static readonly BetterInstruction Pfadd = new (Mnemonic.Pfadd);
  
    
    public static readonly BetterInstruction Pfcmpeq = new (Mnemonic.Pfcmpeq);
  
    
    public static readonly BetterInstruction Pfcmpge = new (Mnemonic.Pfcmpge);
  
    
    public static readonly BetterInstruction Pfcmpgt = new (Mnemonic.Pfcmpgt);
  
    
    public static readonly BetterInstruction Pfmax = new (Mnemonic.Pfmax);
  
    
    public static readonly BetterInstruction Pfmin = new (Mnemonic.Pfmin);
  
    
    public static readonly BetterInstruction Pfmul = new (Mnemonic.Pfmul);
  
    
    public static readonly BetterInstruction Pfnacc = new (Mnemonic.Pfnacc);
  
    
    public static readonly BetterInstruction Pfpnacc = new (Mnemonic.Pfpnacc);
  
    
    public static readonly BetterInstruction Pfrcp = new (Mnemonic.Pfrcp);
  
    
    public static readonly BetterInstruction Pfrcpit1 = new (Mnemonic.Pfrcpit1);
  
    
    public static readonly BetterInstruction Pfrcpit2 = new (Mnemonic.Pfrcpit2);
  
    
    public static readonly BetterInstruction Pfrcpv = new (Mnemonic.Pfrcpv);
  
    
    public static readonly BetterInstruction Pfrsqit1 = new (Mnemonic.Pfrsqit1);
  
    
    public static readonly BetterInstruction Pfrsqrt = new (Mnemonic.Pfrsqrt);
  
    
    public static readonly BetterInstruction Pfrsqrtv = new (Mnemonic.Pfrsqrtv);
  
    
    public static readonly BetterInstruction Pfsub = new (Mnemonic.Pfsub);
  
    
    public static readonly BetterInstruction Pfsubr = new (Mnemonic.Pfsubr);
  
    
    public static readonly BetterInstruction Phaddd = new (Mnemonic.Phaddd);
  
    
    public static readonly BetterInstruction Phaddsw = new (Mnemonic.Phaddsw);
  
    
    public static readonly BetterInstruction Phaddw = new (Mnemonic.Phaddw);
  
    
    public static readonly BetterInstruction Phminposuw = new (Mnemonic.Phminposuw);
  
    
    public static readonly BetterInstruction Phsubd = new (Mnemonic.Phsubd);
  
    
    public static readonly BetterInstruction Phsubsw = new (Mnemonic.Phsubsw);
  
    
    public static readonly BetterInstruction Phsubw = new (Mnemonic.Phsubw);
  
    
    public static readonly BetterInstruction Pi2fd = new (Mnemonic.Pi2fd);
  
    
    public static readonly BetterInstruction Pi2fw = new (Mnemonic.Pi2fw);
  
    
    public static readonly BetterInstruction Pinsrb = new (Mnemonic.Pinsrb);
  
    
    public static readonly BetterInstruction Pinsrd = new (Mnemonic.Pinsrd);
  
    
    public static readonly BetterInstruction Pinsrq = new (Mnemonic.Pinsrq);
  
    
    public static readonly BetterInstruction Pinsrw = new (Mnemonic.Pinsrw);
  
    
    public static readonly BetterInstruction Pmaddubsw = new (Mnemonic.Pmaddubsw);
  
    
    public static readonly BetterInstruction Pmaddwd = new (Mnemonic.Pmaddwd);
  
    
    public static readonly BetterInstruction Pmaxsb = new (Mnemonic.Pmaxsb);
  
    
    public static readonly BetterInstruction Pmaxsd = new (Mnemonic.Pmaxsd);
  
    
    public static readonly BetterInstruction Pmaxsw = new (Mnemonic.Pmaxsw);
  
    
    public static readonly BetterInstruction Pmaxub = new (Mnemonic.Pmaxub);
  
    
    public static readonly BetterInstruction Pmaxud = new (Mnemonic.Pmaxud);
  
    
    public static readonly BetterInstruction Pmaxuw = new (Mnemonic.Pmaxuw);
  
    
    public static readonly BetterInstruction Pminsb = new (Mnemonic.Pminsb);
  
    
    public static readonly BetterInstruction Pminsd = new (Mnemonic.Pminsd);
  
    
    public static readonly BetterInstruction Pminsw = new (Mnemonic.Pminsw);
  
    
    public static readonly BetterInstruction Pminub = new (Mnemonic.Pminub);
  
    
    public static readonly BetterInstruction Pminud = new (Mnemonic.Pminud);
  
    
    public static readonly BetterInstruction Pminuw = new (Mnemonic.Pminuw);
  
    
    public static readonly BetterInstruction Pmovmskb = new (Mnemonic.Pmovmskb);
  
    
    public static readonly BetterInstruction Pmovsxbd = new (Mnemonic.Pmovsxbd);
  
    
    public static readonly BetterInstruction Pmovsxbq = new (Mnemonic.Pmovsxbq);
  
    
    public static readonly BetterInstruction Pmovsxbw = new (Mnemonic.Pmovsxbw);
  
    
    public static readonly BetterInstruction Pmovsxdq = new (Mnemonic.Pmovsxdq);
  
    
    public static readonly BetterInstruction Pmovsxwd = new (Mnemonic.Pmovsxwd);
  
    
    public static readonly BetterInstruction Pmovsxwq = new (Mnemonic.Pmovsxwq);
  
    
    public static readonly BetterInstruction Pmovzxbd = new (Mnemonic.Pmovzxbd);
  
    
    public static readonly BetterInstruction Pmovzxbq = new (Mnemonic.Pmovzxbq);
  
    
    public static readonly BetterInstruction Pmovzxbw = new (Mnemonic.Pmovzxbw);
  
    
    public static readonly BetterInstruction Pmovzxdq = new (Mnemonic.Pmovzxdq);
  
    
    public static readonly BetterInstruction Pmovzxwd = new (Mnemonic.Pmovzxwd);
  
    
    public static readonly BetterInstruction Pmovzxwq = new (Mnemonic.Pmovzxwq);
  
    
    public static readonly BetterInstruction Pmuldq = new (Mnemonic.Pmuldq);
  
    
    public static readonly BetterInstruction Pmulhrsw = new (Mnemonic.Pmulhrsw);
  
    
    public static readonly BetterInstruction Pmulhrw = new (Mnemonic.Pmulhrw);
  
    
    public static readonly BetterInstruction Pmulhuw = new (Mnemonic.Pmulhuw);
  
    
    public static readonly BetterInstruction Pmulhw = new (Mnemonic.Pmulhw);
  
    
    public static readonly BetterInstruction Pmulld = new (Mnemonic.Pmulld);
  
    
    public static readonly BetterInstruction Pmullw = new (Mnemonic.Pmullw);
  
    
    public static readonly BetterInstruction Pmuludq = new (Mnemonic.Pmuludq);
  
    
    public static readonly BetterInstruction Pop = new (Mnemonic.Pop);
  
    
    public static readonly BetterInstruction Popa = new (Mnemonic.Popa);
  
    
    public static readonly BetterInstruction Popcnt = new (Mnemonic.Popcnt);
  
    
    public static readonly BetterInstruction Popf = new (Mnemonic.Popf);
  
    
    public static readonly BetterInstruction Por = new (Mnemonic.Por);
  
    
    public static readonly BetterInstruction Prefetch = new (Mnemonic.Prefetch);
  
    
    public static readonly BetterInstruction Prefetchnta = new (Mnemonic.Prefetchnta);
  
    
    public static readonly BetterInstruction Prefetcht0 = new (Mnemonic.Prefetcht0);
  
    
    public static readonly BetterInstruction Prefetcht1 = new (Mnemonic.Prefetcht1);
  
    
    public static readonly BetterInstruction Prefetcht2 = new (Mnemonic.Prefetcht2);
  
    
    public static readonly BetterInstruction Prefetchw = new (Mnemonic.Prefetchw);
  
    
    public static readonly BetterInstruction Prefetchwt1 = new (Mnemonic.Prefetchwt1);
  
    
    public static readonly BetterInstruction Psadbw = new (Mnemonic.Psadbw);
  
    
    public static readonly BetterInstruction Pshufb = new (Mnemonic.Pshufb);
  
    
    public static readonly BetterInstruction Pshufd = new (Mnemonic.Pshufd);
  
    
    public static readonly BetterInstruction Pshufhw = new (Mnemonic.Pshufhw);
  
    
    public static readonly BetterInstruction Pshuflw = new (Mnemonic.Pshuflw);
  
    
    public static readonly BetterInstruction Pshufw = new (Mnemonic.Pshufw);
  
    
    public static readonly BetterInstruction Psignb = new (Mnemonic.Psignb);
  
    
    public static readonly BetterInstruction Psignd = new (Mnemonic.Psignd);
  
    
    public static readonly BetterInstruction Psignw = new (Mnemonic.Psignw);
  
    
    public static readonly BetterInstruction Pslld = new (Mnemonic.Pslld);
  
    
    public static readonly BetterInstruction Pslldq = new (Mnemonic.Pslldq);
  
    
    public static readonly BetterInstruction Psllq = new (Mnemonic.Psllq);
  
    
    public static readonly BetterInstruction Psllw = new (Mnemonic.Psllw);
  
    
    public static readonly BetterInstruction Psrad = new (Mnemonic.Psrad);
  
    
    public static readonly BetterInstruction Psraw = new (Mnemonic.Psraw);
  
    
    public static readonly BetterInstruction Psrld = new (Mnemonic.Psrld);
  
    
    public static readonly BetterInstruction Psrldq = new (Mnemonic.Psrldq);
  
    
    public static readonly BetterInstruction Psrlq = new (Mnemonic.Psrlq);
  
    
    public static readonly BetterInstruction Psrlw = new (Mnemonic.Psrlw);
  
    
    public static readonly BetterInstruction Psubb = new (Mnemonic.Psubb);
  
    
    public static readonly BetterInstruction Psubd = new (Mnemonic.Psubd);
  
    
    public static readonly BetterInstruction Psubq = new (Mnemonic.Psubq);
  
    
    public static readonly BetterInstruction Psubsb = new (Mnemonic.Psubsb);
  
    
    public static readonly BetterInstruction Psubsw = new (Mnemonic.Psubsw);
  
    
    public static readonly BetterInstruction Psubusb = new (Mnemonic.Psubusb);
  
    
    public static readonly BetterInstruction Psubusw = new (Mnemonic.Psubusw);
  
    
    public static readonly BetterInstruction Psubw = new (Mnemonic.Psubw);
  
    
    public static readonly BetterInstruction Pswapd = new (Mnemonic.Pswapd);
  
    
    public static readonly BetterInstruction Ptest = new (Mnemonic.Ptest);
  
    
    public static readonly BetterInstruction Ptwrite = new (Mnemonic.Ptwrite);
  
    
    public static readonly BetterInstruction Punpckhbw = new (Mnemonic.Punpckhbw);
  
    
    public static readonly BetterInstruction Punpckhdq = new (Mnemonic.Punpckhdq);
  
    
    public static readonly BetterInstruction Punpckhqdq = new (Mnemonic.Punpckhqdq);
  
    
    public static readonly BetterInstruction Punpckhwd = new (Mnemonic.Punpckhwd);
  
    
    public static readonly BetterInstruction Punpcklbw = new (Mnemonic.Punpcklbw);
  
    
    public static readonly BetterInstruction Punpckldq = new (Mnemonic.Punpckldq);
  
    
    public static readonly BetterInstruction Punpcklqdq = new (Mnemonic.Punpcklqdq);
  
    
    public static readonly BetterInstruction Punpcklwd = new (Mnemonic.Punpcklwd);
  
    
    public static readonly BetterInstruction Push = new (Mnemonic.Push);
  
    
    public static readonly BetterInstruction Pusha = new (Mnemonic.Pusha);
  
    
    public static readonly BetterInstruction Pushf = new (Mnemonic.Pushf);
  
    
    public static readonly BetterInstruction Pxor = new (Mnemonic.Pxor);
  
    
    public static readonly BetterInstruction Rcl = new (Mnemonic.Rcl);
  
    
    public static readonly BetterInstruction Rcpps = new (Mnemonic.Rcpps);
  
    
    public static readonly BetterInstruction Rcpss = new (Mnemonic.Rcpss);
  
    
    public static readonly BetterInstruction Rcr = new (Mnemonic.Rcr);
  
    
    public static readonly BetterInstruction Rdfsbase = new (Mnemonic.Rdfsbase);
  
    
    public static readonly BetterInstruction Rdgsbase = new (Mnemonic.Rdgsbase);
  
    
    public static readonly BetterInstruction Rdmsr = new (Mnemonic.Rdmsr);
  
    
    public static readonly BetterInstruction Rdpid = new (Mnemonic.Rdpid);
  
    
    public static readonly BetterInstruction Rdpkru = new (Mnemonic.Rdpkru);
  
    
    public static readonly BetterInstruction Rdpmc = new (Mnemonic.Rdpmc);
  
    
    public static readonly BetterInstruction Rdpru = new (Mnemonic.Rdpru);
  
    
    public static readonly BetterInstruction Rdrand = new (Mnemonic.Rdrand);
  
    
    public static readonly BetterInstruction Rdseed = new (Mnemonic.Rdseed);
  
    
    public static readonly BetterInstruction Rdsspd = new (Mnemonic.Rdsspd);
  
    
    public static readonly BetterInstruction Rdsspq = new (Mnemonic.Rdsspq);
  
    
    public static readonly BetterInstruction Rdtsc = new (Mnemonic.Rdtsc);
  
    
    public static readonly BetterInstruction Rdtscp = new (Mnemonic.Rdtscp);
  
    
    public static readonly BetterInstruction Reservednop = new (Mnemonic.Reservednop);
  
    
    public static readonly BetterInstruction Ret = new (Mnemonic.Ret);
  
    
    public static readonly BetterInstruction Retf = new (Mnemonic.Retf);
  
    
    public static readonly BetterInstruction Rol = new (Mnemonic.Rol);
  
    
    public static readonly BetterInstruction Ror = new (Mnemonic.Ror);
  
    
    public static readonly BetterInstruction Rorx = new (Mnemonic.Rorx);
  
    
    public static readonly BetterInstruction Roundpd = new (Mnemonic.Roundpd);
  
    
    public static readonly BetterInstruction Roundps = new (Mnemonic.Roundps);
  
    
    public static readonly BetterInstruction Roundsd = new (Mnemonic.Roundsd);
  
    
    public static readonly BetterInstruction Roundss = new (Mnemonic.Roundss);
  
    
    public static readonly BetterInstruction Rsm = new (Mnemonic.Rsm);
  
    
    public static readonly BetterInstruction Rsqrtps = new (Mnemonic.Rsqrtps);
  
    
    public static readonly BetterInstruction Rsqrtss = new (Mnemonic.Rsqrtss);
  
    
    public static readonly BetterInstruction Rstorssp = new (Mnemonic.Rstorssp);
  
    
    public static readonly BetterInstruction Sahf = new (Mnemonic.Sahf);
  
    
    public static readonly BetterInstruction Sal = new (Mnemonic.Sal);
  
    
    public static readonly BetterInstruction Salc = new (Mnemonic.Salc);
  
    
    public static readonly BetterInstruction Sar = new (Mnemonic.Sar);
  
    
    public static readonly BetterInstruction Sarx = new (Mnemonic.Sarx);
  
    
    public static readonly BetterInstruction Saveprevssp = new (Mnemonic.Saveprevssp);
  
    
    public static readonly BetterInstruction Sbb = new (Mnemonic.Sbb);
  
    
    public static readonly BetterInstruction Scasb = new (Mnemonic.Scasb);
  
    
    public static readonly BetterInstruction Scasd = new (Mnemonic.Scasd);
  
    
    public static readonly BetterInstruction Scasq = new (Mnemonic.Scasq);
  
    
    public static readonly BetterInstruction Scasw = new (Mnemonic.Scasw);
  
    
    public static readonly BetterInstruction Seta = new (Mnemonic.Seta);
  
    
    public static readonly BetterInstruction Setae = new (Mnemonic.Setae);
  
    
    public static readonly BetterInstruction Setb = new (Mnemonic.Setb);
  
    
    public static readonly BetterInstruction Setbe = new (Mnemonic.Setbe);
  
    
    public static readonly BetterInstruction Sete = new (Mnemonic.Sete);
  
    
    public static readonly BetterInstruction Setg = new (Mnemonic.Setg);
  
    
    public static readonly BetterInstruction Setge = new (Mnemonic.Setge);
  
    
    public static readonly BetterInstruction Setl = new (Mnemonic.Setl);
  
    
    public static readonly BetterInstruction Setle = new (Mnemonic.Setle);
  
    
    public static readonly BetterInstruction Setne = new (Mnemonic.Setne);
  
    
    public static readonly BetterInstruction Setno = new (Mnemonic.Setno);
  
    
    public static readonly BetterInstruction Setnp = new (Mnemonic.Setnp);
  
    
    public static readonly BetterInstruction Setns = new (Mnemonic.Setns);
  
    
    public static readonly BetterInstruction Seto = new (Mnemonic.Seto);
  
    
    public static readonly BetterInstruction Setp = new (Mnemonic.Setp);
  
    
    public static readonly BetterInstruction Sets = new (Mnemonic.Sets);
  
    
    public static readonly BetterInstruction Setssbsy = new (Mnemonic.Setssbsy);
  
    
    public static readonly BetterInstruction Sfence = new (Mnemonic.Sfence);
  
    
    public static readonly BetterInstruction Sgdt = new (Mnemonic.Sgdt);
  
    
    public static readonly BetterInstruction Sha1msg1 = new (Mnemonic.Sha1msg1);
  
    
    public static readonly BetterInstruction Sha1msg2 = new (Mnemonic.Sha1msg2);
  
    
    public static readonly BetterInstruction Sha1nexte = new (Mnemonic.Sha1nexte);
  
    
    public static readonly BetterInstruction Sha1rnds4 = new (Mnemonic.Sha1rnds4);
  
    
    public static readonly BetterInstruction Sha256msg1 = new (Mnemonic.Sha256msg1);
  
    
    public static readonly BetterInstruction Sha256msg2 = new (Mnemonic.Sha256msg2);
  
    
    public static readonly BetterInstruction Sha256rnds2 = new (Mnemonic.Sha256rnds2);
  
    
    public static readonly BetterInstruction Shl = new (Mnemonic.Shl);
  
    
    public static readonly BetterInstruction Shld = new (Mnemonic.Shld);
  
    
    public static readonly BetterInstruction Shlx = new (Mnemonic.Shlx);
  
    
    public static readonly BetterInstruction Shr = new (Mnemonic.Shr);
  
    
    public static readonly BetterInstruction Shrd = new (Mnemonic.Shrd);
  
    
    public static readonly BetterInstruction Shrx = new (Mnemonic.Shrx);
  
    
    public static readonly BetterInstruction Shufpd = new (Mnemonic.Shufpd);
  
    
    public static readonly BetterInstruction Shufps = new (Mnemonic.Shufps);
  
    
    public static readonly BetterInstruction Sidt = new (Mnemonic.Sidt);
  
    
    public static readonly BetterInstruction Skinit = new (Mnemonic.Skinit);
  
    
    public static readonly BetterInstruction Sldt = new (Mnemonic.Sldt);
  
    
    public static readonly BetterInstruction Slwpcb = new (Mnemonic.Slwpcb);
  
    
    public static readonly BetterInstruction Smsw = new (Mnemonic.Smsw);
  
    
    public static readonly BetterInstruction Sqrtpd = new (Mnemonic.Sqrtpd);
  
    
    public static readonly BetterInstruction Sqrtps = new (Mnemonic.Sqrtps);
  
    
    public static readonly BetterInstruction Sqrtsd = new (Mnemonic.Sqrtsd);
  
    
    public static readonly BetterInstruction Sqrtss = new (Mnemonic.Sqrtss);
  
    
    public static readonly BetterInstruction Stac = new (Mnemonic.Stac);
  
    
    public static readonly BetterInstruction Stc = new (Mnemonic.Stc);
  
    
    public static readonly BetterInstruction Std = new (Mnemonic.Std);
  
    
    public static readonly BetterInstruction Stgi = new (Mnemonic.Stgi);
  
    
    public static readonly BetterInstruction Sti = new (Mnemonic.Sti);
  
    
    public static readonly BetterInstruction Stmxcsr = new (Mnemonic.Stmxcsr);
  
    
    public static readonly BetterInstruction Stosb = new (Mnemonic.Stosb);
  
    
    public static readonly BetterInstruction Stosd = new (Mnemonic.Stosd);
  
    
    public static readonly BetterInstruction Stosq = new (Mnemonic.Stosq);
  
    
    public static readonly BetterInstruction Stosw = new (Mnemonic.Stosw);
  
    
    public static readonly BetterInstruction Str = new (Mnemonic.Str);
  
    
    public static readonly BetterInstruction Sub = new (Mnemonic.Sub);
  
    
    public static readonly BetterInstruction Subpd = new (Mnemonic.Subpd);
  
    
    public static readonly BetterInstruction Subps = new (Mnemonic.Subps);
  
    
    public static readonly BetterInstruction Subsd = new (Mnemonic.Subsd);
  
    
    public static readonly BetterInstruction Subss = new (Mnemonic.Subss);
  
    
    public static readonly BetterInstruction Swapgs = new (Mnemonic.Swapgs);
  
    
    public static readonly BetterInstruction Syscall = new (Mnemonic.Syscall);
  
    
    public static readonly BetterInstruction Sysenter = new (Mnemonic.Sysenter);
  
    
    public static readonly BetterInstruction Sysexit = new (Mnemonic.Sysexit);
  
    
    public static readonly BetterInstruction Sysret = new (Mnemonic.Sysret);
  
    
    public static readonly BetterInstruction T1mskc = new (Mnemonic.T1mskc);
  
    
    public static readonly BetterInstruction Test = new (Mnemonic.Test);
  
    
    public static readonly BetterInstruction Tpause = new (Mnemonic.Tpause);
  
    
    public static readonly BetterInstruction Tzcnt = new (Mnemonic.Tzcnt);
  
    
    public static readonly BetterInstruction Tzmsk = new (Mnemonic.Tzmsk);
  
    
    public static readonly BetterInstruction Ucomisd = new (Mnemonic.Ucomisd);
  
    
    public static readonly BetterInstruction Ucomiss = new (Mnemonic.Ucomiss);
  
    
    public static readonly BetterInstruction Ud0 = new (Mnemonic.Ud0);
  
    
    public static readonly BetterInstruction Ud1 = new (Mnemonic.Ud1);
  
    
    public static readonly BetterInstruction Ud2 = new (Mnemonic.Ud2);
  
    
    public static readonly BetterInstruction Umonitor = new (Mnemonic.Umonitor);
  
    
    public static readonly BetterInstruction Umov = new (Mnemonic.Umov);
  
    
    public static readonly BetterInstruction Umwait = new (Mnemonic.Umwait);
  
    
    public static readonly BetterInstruction Unpckhpd = new (Mnemonic.Unpckhpd);
  
    
    public static readonly BetterInstruction Unpckhps = new (Mnemonic.Unpckhps);
  
    
    public static readonly BetterInstruction Unpcklpd = new (Mnemonic.Unpcklpd);
  
    
    public static readonly BetterInstruction Unpcklps = new (Mnemonic.Unpcklps);
  
    
    public static readonly BetterInstruction V4fmaddps = new (Mnemonic.V4fmaddps);
  
    
    public static readonly BetterInstruction V4fmaddss = new (Mnemonic.V4fmaddss);
  
    
    public static readonly BetterInstruction V4fnmaddps = new (Mnemonic.V4fnmaddps);
  
    
    public static readonly BetterInstruction V4fnmaddss = new (Mnemonic.V4fnmaddss);
  
    
    public static readonly BetterInstruction Vaddpd = new (Mnemonic.Vaddpd);
  
    
    public static readonly BetterInstruction Vaddps = new (Mnemonic.Vaddps);
  
    
    public static readonly BetterInstruction Vaddsd = new (Mnemonic.Vaddsd);
  
    
    public static readonly BetterInstruction Vaddss = new (Mnemonic.Vaddss);
  
    
    public static readonly BetterInstruction Vaddsubpd = new (Mnemonic.Vaddsubpd);
  
    
    public static readonly BetterInstruction Vaddsubps = new (Mnemonic.Vaddsubps);
  
    
    public static readonly BetterInstruction Vaesdec = new (Mnemonic.Vaesdec);
  
    
    public static readonly BetterInstruction Vaesdeclast = new (Mnemonic.Vaesdeclast);
  
    
    public static readonly BetterInstruction Vaesenc = new (Mnemonic.Vaesenc);
  
    
    public static readonly BetterInstruction Vaesenclast = new (Mnemonic.Vaesenclast);
  
    
    public static readonly BetterInstruction Vaesimc = new (Mnemonic.Vaesimc);
  
    
    public static readonly BetterInstruction Vaeskeygenassist = new (Mnemonic.Vaeskeygenassist);
  
    
    public static readonly BetterInstruction Valignd = new (Mnemonic.Valignd);
  
    
    public static readonly BetterInstruction Valignq = new (Mnemonic.Valignq);
  
    
    public static readonly BetterInstruction Vandnpd = new (Mnemonic.Vandnpd);
  
    
    public static readonly BetterInstruction Vandnps = new (Mnemonic.Vandnps);
  
    
    public static readonly BetterInstruction Vandpd = new (Mnemonic.Vandpd);
  
    
    public static readonly BetterInstruction Vandps = new (Mnemonic.Vandps);
  
    
    public static readonly BetterInstruction Vblendmpd = new (Mnemonic.Vblendmpd);
  
    
    public static readonly BetterInstruction Vblendmps = new (Mnemonic.Vblendmps);
  
    
    public static readonly BetterInstruction Vblendpd = new (Mnemonic.Vblendpd);
  
    
    public static readonly BetterInstruction Vblendps = new (Mnemonic.Vblendps);
  
    
    public static readonly BetterInstruction Vblendvpd = new (Mnemonic.Vblendvpd);
  
    
    public static readonly BetterInstruction Vblendvps = new (Mnemonic.Vblendvps);
  
    
    public static readonly BetterInstruction Vbroadcastf128 = new (Mnemonic.Vbroadcastf128);
  
    
    public static readonly BetterInstruction Vbroadcastf32x2 = new (Mnemonic.Vbroadcastf32x2);
  
    
    public static readonly BetterInstruction Vbroadcastf32x4 = new (Mnemonic.Vbroadcastf32x4);
  
    
    public static readonly BetterInstruction Vbroadcastf32x8 = new (Mnemonic.Vbroadcastf32x8);
  
    
    public static readonly BetterInstruction Vbroadcastf64x2 = new (Mnemonic.Vbroadcastf64x2);
  
    
    public static readonly BetterInstruction Vbroadcastf64x4 = new (Mnemonic.Vbroadcastf64x4);
  
    
    public static readonly BetterInstruction Vbroadcasti128 = new (Mnemonic.Vbroadcasti128);
  
    
    public static readonly BetterInstruction Vbroadcasti32x2 = new (Mnemonic.Vbroadcasti32x2);
  
    
    public static readonly BetterInstruction Vbroadcasti32x4 = new (Mnemonic.Vbroadcasti32x4);
  
    
    public static readonly BetterInstruction Vbroadcasti32x8 = new (Mnemonic.Vbroadcasti32x8);
  
    
    public static readonly BetterInstruction Vbroadcasti64x2 = new (Mnemonic.Vbroadcasti64x2);
  
    
    public static readonly BetterInstruction Vbroadcasti64x4 = new (Mnemonic.Vbroadcasti64x4);
  
    
    public static readonly BetterInstruction Vbroadcastsd = new (Mnemonic.Vbroadcastsd);
  
    
    public static readonly BetterInstruction Vbroadcastss = new (Mnemonic.Vbroadcastss);
  
    
    public static readonly BetterInstruction Vcmppd = new (Mnemonic.Vcmppd);
  
    
    public static readonly BetterInstruction Vcmpps = new (Mnemonic.Vcmpps);
  
    
    public static readonly BetterInstruction Vcmpsd = new (Mnemonic.Vcmpsd);
  
    
    public static readonly BetterInstruction Vcmpss = new (Mnemonic.Vcmpss);
  
    
    public static readonly BetterInstruction Vcomisd = new (Mnemonic.Vcomisd);
  
    
    public static readonly BetterInstruction Vcomiss = new (Mnemonic.Vcomiss);
  
    
    public static readonly BetterInstruction Vcompresspd = new (Mnemonic.Vcompresspd);
  
    
    public static readonly BetterInstruction Vcompressps = new (Mnemonic.Vcompressps);
  
    
    public static readonly BetterInstruction Vcvtdq2pd = new (Mnemonic.Vcvtdq2pd);
  
    
    public static readonly BetterInstruction Vcvtdq2ps = new (Mnemonic.Vcvtdq2ps);
  
    
    public static readonly BetterInstruction Vcvtne2ps2bf16 = new (Mnemonic.Vcvtne2ps2bf16);
  
    
    public static readonly BetterInstruction Vcvtneps2bf16 = new (Mnemonic.Vcvtneps2bf16);
  
    
    public static readonly BetterInstruction Vcvtpd2dq = new (Mnemonic.Vcvtpd2dq);
  
    
    public static readonly BetterInstruction Vcvtpd2ps = new (Mnemonic.Vcvtpd2ps);
  
    
    public static readonly BetterInstruction Vcvtpd2qq = new (Mnemonic.Vcvtpd2qq);
  
    
    public static readonly BetterInstruction Vcvtpd2udq = new (Mnemonic.Vcvtpd2udq);
  
    
    public static readonly BetterInstruction Vcvtpd2uqq = new (Mnemonic.Vcvtpd2uqq);
  
    
    public static readonly BetterInstruction Vcvtph2ps = new (Mnemonic.Vcvtph2ps);
  
    
    public static readonly BetterInstruction Vcvtps2dq = new (Mnemonic.Vcvtps2dq);
  
    
    public static readonly BetterInstruction Vcvtps2pd = new (Mnemonic.Vcvtps2pd);
  
    
    public static readonly BetterInstruction Vcvtps2ph = new (Mnemonic.Vcvtps2ph);
  
    
    public static readonly BetterInstruction Vcvtps2qq = new (Mnemonic.Vcvtps2qq);
  
    
    public static readonly BetterInstruction Vcvtps2udq = new (Mnemonic.Vcvtps2udq);
  
    
    public static readonly BetterInstruction Vcvtps2uqq = new (Mnemonic.Vcvtps2uqq);
  
    
    public static readonly BetterInstruction Vcvtqq2pd = new (Mnemonic.Vcvtqq2pd);
  
    
    public static readonly BetterInstruction Vcvtqq2ps = new (Mnemonic.Vcvtqq2ps);
  
    
    public static readonly BetterInstruction Vcvtsd2si = new (Mnemonic.Vcvtsd2si);
  
    
    public static readonly BetterInstruction Vcvtsd2ss = new (Mnemonic.Vcvtsd2ss);
  
    
    public static readonly BetterInstruction Vcvtsd2usi = new (Mnemonic.Vcvtsd2usi);
  
    
    public static readonly BetterInstruction Vcvtsi2sd = new (Mnemonic.Vcvtsi2sd);
  
    
    public static readonly BetterInstruction Vcvtsi2ss = new (Mnemonic.Vcvtsi2ss);
  
    
    public static readonly BetterInstruction Vcvtss2sd = new (Mnemonic.Vcvtss2sd);
  
    
    public static readonly BetterInstruction Vcvtss2si = new (Mnemonic.Vcvtss2si);
  
    
    public static readonly BetterInstruction Vcvtss2usi = new (Mnemonic.Vcvtss2usi);
  
    
    public static readonly BetterInstruction Vcvttpd2dq = new (Mnemonic.Vcvttpd2dq);
  
    
    public static readonly BetterInstruction Vcvttpd2qq = new (Mnemonic.Vcvttpd2qq);
  
    
    public static readonly BetterInstruction Vcvttpd2udq = new (Mnemonic.Vcvttpd2udq);
  
    
    public static readonly BetterInstruction Vcvttpd2uqq = new (Mnemonic.Vcvttpd2uqq);
  
    
    public static readonly BetterInstruction Vcvttps2dq = new (Mnemonic.Vcvttps2dq);
  
    
    public static readonly BetterInstruction Vcvttps2qq = new (Mnemonic.Vcvttps2qq);
  
    
    public static readonly BetterInstruction Vcvttps2udq = new (Mnemonic.Vcvttps2udq);
  
    
    public static readonly BetterInstruction Vcvttps2uqq = new (Mnemonic.Vcvttps2uqq);
  
    
    public static readonly BetterInstruction Vcvttsd2si = new (Mnemonic.Vcvttsd2si);
  
    
    public static readonly BetterInstruction Vcvttsd2usi = new (Mnemonic.Vcvttsd2usi);
  
    
    public static readonly BetterInstruction Vcvttss2si = new (Mnemonic.Vcvttss2si);
  
    
    public static readonly BetterInstruction Vcvttss2usi = new (Mnemonic.Vcvttss2usi);
  
    
    public static readonly BetterInstruction Vcvtudq2pd = new (Mnemonic.Vcvtudq2pd);
  
    
    public static readonly BetterInstruction Vcvtudq2ps = new (Mnemonic.Vcvtudq2ps);
  
    
    public static readonly BetterInstruction Vcvtuqq2pd = new (Mnemonic.Vcvtuqq2pd);
  
    
    public static readonly BetterInstruction Vcvtuqq2ps = new (Mnemonic.Vcvtuqq2ps);
  
    
    public static readonly BetterInstruction Vcvtusi2sd = new (Mnemonic.Vcvtusi2sd);
  
    
    public static readonly BetterInstruction Vcvtusi2ss = new (Mnemonic.Vcvtusi2ss);
  
    
    public static readonly BetterInstruction Vdbpsadbw = new (Mnemonic.Vdbpsadbw);
  
    
    public static readonly BetterInstruction Vdivpd = new (Mnemonic.Vdivpd);
  
    
    public static readonly BetterInstruction Vdivps = new (Mnemonic.Vdivps);
  
    
    public static readonly BetterInstruction Vdivsd = new (Mnemonic.Vdivsd);
  
    
    public static readonly BetterInstruction Vdivss = new (Mnemonic.Vdivss);
  
    
    public static readonly BetterInstruction Vdpbf16ps = new (Mnemonic.Vdpbf16ps);
  
    
    public static readonly BetterInstruction Vdppd = new (Mnemonic.Vdppd);
  
    
    public static readonly BetterInstruction Vdpps = new (Mnemonic.Vdpps);
  
    
    public static readonly BetterInstruction Verr = new (Mnemonic.Verr);
  
    
    public static readonly BetterInstruction Verw = new (Mnemonic.Verw);
  
    
    public static readonly BetterInstruction Vexp2pd = new (Mnemonic.Vexp2pd);
  
    
    public static readonly BetterInstruction Vexp2ps = new (Mnemonic.Vexp2ps);
  
    
    public static readonly BetterInstruction Vexpandpd = new (Mnemonic.Vexpandpd);
  
    
    public static readonly BetterInstruction Vexpandps = new (Mnemonic.Vexpandps);
  
    
    public static readonly BetterInstruction Vextractf128 = new (Mnemonic.Vextractf128);
  
    
    public static readonly BetterInstruction Vextractf32x4 = new (Mnemonic.Vextractf32x4);
  
    
    public static readonly BetterInstruction Vextractf32x8 = new (Mnemonic.Vextractf32x8);
  
    
    public static readonly BetterInstruction Vextractf64x2 = new (Mnemonic.Vextractf64x2);
  
    
    public static readonly BetterInstruction Vextractf64x4 = new (Mnemonic.Vextractf64x4);
  
    
    public static readonly BetterInstruction Vextracti128 = new (Mnemonic.Vextracti128);
  
    
    public static readonly BetterInstruction Vextracti32x4 = new (Mnemonic.Vextracti32x4);
  
    
    public static readonly BetterInstruction Vextracti32x8 = new (Mnemonic.Vextracti32x8);
  
    
    public static readonly BetterInstruction Vextracti64x2 = new (Mnemonic.Vextracti64x2);
  
    
    public static readonly BetterInstruction Vextracti64x4 = new (Mnemonic.Vextracti64x4);
  
    
    public static readonly BetterInstruction Vextractps = new (Mnemonic.Vextractps);
  
    
    public static readonly BetterInstruction Vfixupimmpd = new (Mnemonic.Vfixupimmpd);
  
    
    public static readonly BetterInstruction Vfixupimmps = new (Mnemonic.Vfixupimmps);
  
    
    public static readonly BetterInstruction Vfixupimmsd = new (Mnemonic.Vfixupimmsd);
  
    
    public static readonly BetterInstruction Vfixupimmss = new (Mnemonic.Vfixupimmss);
  
    
    public static readonly BetterInstruction Vfmadd132pd = new (Mnemonic.Vfmadd132pd);
  
    
    public static readonly BetterInstruction Vfmadd132ps = new (Mnemonic.Vfmadd132ps);
  
    
    public static readonly BetterInstruction Vfmadd132sd = new (Mnemonic.Vfmadd132sd);
  
    
    public static readonly BetterInstruction Vfmadd132ss = new (Mnemonic.Vfmadd132ss);
  
    
    public static readonly BetterInstruction Vfmadd213pd = new (Mnemonic.Vfmadd213pd);
  
    
    public static readonly BetterInstruction Vfmadd213ps = new (Mnemonic.Vfmadd213ps);
  
    
    public static readonly BetterInstruction Vfmadd213sd = new (Mnemonic.Vfmadd213sd);
  
    
    public static readonly BetterInstruction Vfmadd213ss = new (Mnemonic.Vfmadd213ss);
  
    
    public static readonly BetterInstruction Vfmadd231pd = new (Mnemonic.Vfmadd231pd);
  
    
    public static readonly BetterInstruction Vfmadd231ps = new (Mnemonic.Vfmadd231ps);
  
    
    public static readonly BetterInstruction Vfmadd231sd = new (Mnemonic.Vfmadd231sd);
  
    
    public static readonly BetterInstruction Vfmadd231ss = new (Mnemonic.Vfmadd231ss);
  
    
    public static readonly BetterInstruction Vfmaddpd = new (Mnemonic.Vfmaddpd);
  
    
    public static readonly BetterInstruction Vfmaddps = new (Mnemonic.Vfmaddps);
  
    
    public static readonly BetterInstruction Vfmaddsd = new (Mnemonic.Vfmaddsd);
  
    
    public static readonly BetterInstruction Vfmaddss = new (Mnemonic.Vfmaddss);
  
    
    public static readonly BetterInstruction Vfmaddsub132pd = new (Mnemonic.Vfmaddsub132pd);
  
    
    public static readonly BetterInstruction Vfmaddsub132ps = new (Mnemonic.Vfmaddsub132ps);
  
    
    public static readonly BetterInstruction Vfmaddsub213pd = new (Mnemonic.Vfmaddsub213pd);
  
    
    public static readonly BetterInstruction Vfmaddsub213ps = new (Mnemonic.Vfmaddsub213ps);
  
    
    public static readonly BetterInstruction Vfmaddsub231pd = new (Mnemonic.Vfmaddsub231pd);
  
    
    public static readonly BetterInstruction Vfmaddsub231ps = new (Mnemonic.Vfmaddsub231ps);
  
    
    public static readonly BetterInstruction Vfmaddsubpd = new (Mnemonic.Vfmaddsubpd);
  
    
    public static readonly BetterInstruction Vfmaddsubps = new (Mnemonic.Vfmaddsubps);
  
    
    public static readonly BetterInstruction Vfmsub132pd = new (Mnemonic.Vfmsub132pd);
  
    
    public static readonly BetterInstruction Vfmsub132ps = new (Mnemonic.Vfmsub132ps);
  
    
    public static readonly BetterInstruction Vfmsub132sd = new (Mnemonic.Vfmsub132sd);
  
    
    public static readonly BetterInstruction Vfmsub132ss = new (Mnemonic.Vfmsub132ss);
  
    
    public static readonly BetterInstruction Vfmsub213pd = new (Mnemonic.Vfmsub213pd);
  
    
    public static readonly BetterInstruction Vfmsub213ps = new (Mnemonic.Vfmsub213ps);
  
    
    public static readonly BetterInstruction Vfmsub213sd = new (Mnemonic.Vfmsub213sd);
  
    
    public static readonly BetterInstruction Vfmsub213ss = new (Mnemonic.Vfmsub213ss);
  
    
    public static readonly BetterInstruction Vfmsub231pd = new (Mnemonic.Vfmsub231pd);
  
    
    public static readonly BetterInstruction Vfmsub231ps = new (Mnemonic.Vfmsub231ps);
  
    
    public static readonly BetterInstruction Vfmsub231sd = new (Mnemonic.Vfmsub231sd);
  
    
    public static readonly BetterInstruction Vfmsub231ss = new (Mnemonic.Vfmsub231ss);
  
    
    public static readonly BetterInstruction Vfmsubadd132pd = new (Mnemonic.Vfmsubadd132pd);
  
    
    public static readonly BetterInstruction Vfmsubadd132ps = new (Mnemonic.Vfmsubadd132ps);
  
    
    public static readonly BetterInstruction Vfmsubadd213pd = new (Mnemonic.Vfmsubadd213pd);
  
    
    public static readonly BetterInstruction Vfmsubadd213ps = new (Mnemonic.Vfmsubadd213ps);
  
    
    public static readonly BetterInstruction Vfmsubadd231pd = new (Mnemonic.Vfmsubadd231pd);
  
    
    public static readonly BetterInstruction Vfmsubadd231ps = new (Mnemonic.Vfmsubadd231ps);
  
    
    public static readonly BetterInstruction Vfmsubaddpd = new (Mnemonic.Vfmsubaddpd);
  
    
    public static readonly BetterInstruction Vfmsubaddps = new (Mnemonic.Vfmsubaddps);
  
    
    public static readonly BetterInstruction Vfmsubpd = new (Mnemonic.Vfmsubpd);
  
    
    public static readonly BetterInstruction Vfmsubps = new (Mnemonic.Vfmsubps);
  
    
    public static readonly BetterInstruction Vfmsubsd = new (Mnemonic.Vfmsubsd);
  
    
    public static readonly BetterInstruction Vfmsubss = new (Mnemonic.Vfmsubss);
  
    
    public static readonly BetterInstruction Vfnmadd132pd = new (Mnemonic.Vfnmadd132pd);
  
    
    public static readonly BetterInstruction Vfnmadd132ps = new (Mnemonic.Vfnmadd132ps);
  
    
    public static readonly BetterInstruction Vfnmadd132sd = new (Mnemonic.Vfnmadd132sd);
  
    
    public static readonly BetterInstruction Vfnmadd132ss = new (Mnemonic.Vfnmadd132ss);
  
    
    public static readonly BetterInstruction Vfnmadd213pd = new (Mnemonic.Vfnmadd213pd);
  
    
    public static readonly BetterInstruction Vfnmadd213ps = new (Mnemonic.Vfnmadd213ps);
  
    
    public static readonly BetterInstruction Vfnmadd213sd = new (Mnemonic.Vfnmadd213sd);
  
    
    public static readonly BetterInstruction Vfnmadd213ss = new (Mnemonic.Vfnmadd213ss);
  
    
    public static readonly BetterInstruction Vfnmadd231pd = new (Mnemonic.Vfnmadd231pd);
  
    
    public static readonly BetterInstruction Vfnmadd231ps = new (Mnemonic.Vfnmadd231ps);
  
    
    public static readonly BetterInstruction Vfnmadd231sd = new (Mnemonic.Vfnmadd231sd);
  
    
    public static readonly BetterInstruction Vfnmadd231ss = new (Mnemonic.Vfnmadd231ss);
  
    
    public static readonly BetterInstruction Vfnmaddpd = new (Mnemonic.Vfnmaddpd);
  
    
    public static readonly BetterInstruction Vfnmaddps = new (Mnemonic.Vfnmaddps);
  
    
    public static readonly BetterInstruction Vfnmaddsd = new (Mnemonic.Vfnmaddsd);
  
    
    public static readonly BetterInstruction Vfnmaddss = new (Mnemonic.Vfnmaddss);
  
    
    public static readonly BetterInstruction Vfnmsub132pd = new (Mnemonic.Vfnmsub132pd);
  
    
    public static readonly BetterInstruction Vfnmsub132ps = new (Mnemonic.Vfnmsub132ps);
  
    
    public static readonly BetterInstruction Vfnmsub132sd = new (Mnemonic.Vfnmsub132sd);
  
    
    public static readonly BetterInstruction Vfnmsub132ss = new (Mnemonic.Vfnmsub132ss);
  
    
    public static readonly BetterInstruction Vfnmsub213pd = new (Mnemonic.Vfnmsub213pd);
  
    
    public static readonly BetterInstruction Vfnmsub213ps = new (Mnemonic.Vfnmsub213ps);
  
    
    public static readonly BetterInstruction Vfnmsub213sd = new (Mnemonic.Vfnmsub213sd);
  
    
    public static readonly BetterInstruction Vfnmsub213ss = new (Mnemonic.Vfnmsub213ss);
  
    
    public static readonly BetterInstruction Vfnmsub231pd = new (Mnemonic.Vfnmsub231pd);
  
    
    public static readonly BetterInstruction Vfnmsub231ps = new (Mnemonic.Vfnmsub231ps);
  
    
    public static readonly BetterInstruction Vfnmsub231sd = new (Mnemonic.Vfnmsub231sd);
  
    
    public static readonly BetterInstruction Vfnmsub231ss = new (Mnemonic.Vfnmsub231ss);
  
    
    public static readonly BetterInstruction Vfnmsubpd = new (Mnemonic.Vfnmsubpd);
  
    
    public static readonly BetterInstruction Vfnmsubps = new (Mnemonic.Vfnmsubps);
  
    
    public static readonly BetterInstruction Vfnmsubsd = new (Mnemonic.Vfnmsubsd);
  
    
    public static readonly BetterInstruction Vfnmsubss = new (Mnemonic.Vfnmsubss);
  
    
    public static readonly BetterInstruction Vfpclasspd = new (Mnemonic.Vfpclasspd);
  
    
    public static readonly BetterInstruction Vfpclassps = new (Mnemonic.Vfpclassps);
  
    
    public static readonly BetterInstruction Vfpclasssd = new (Mnemonic.Vfpclasssd);
  
    
    public static readonly BetterInstruction Vfpclassss = new (Mnemonic.Vfpclassss);
  
    
    public static readonly BetterInstruction Vfrczpd = new (Mnemonic.Vfrczpd);
  
    
    public static readonly BetterInstruction Vfrczps = new (Mnemonic.Vfrczps);
  
    
    public static readonly BetterInstruction Vfrczsd = new (Mnemonic.Vfrczsd);
  
    
    public static readonly BetterInstruction Vfrczss = new (Mnemonic.Vfrczss);
  
    
    public static readonly BetterInstruction Vgatherdpd = new (Mnemonic.Vgatherdpd);
  
    
    public static readonly BetterInstruction Vgatherdps = new (Mnemonic.Vgatherdps);
  
    
    public static readonly BetterInstruction Vgatherpf0dpd = new (Mnemonic.Vgatherpf0dpd);
  
    
    public static readonly BetterInstruction Vgatherpf0dps = new (Mnemonic.Vgatherpf0dps);
  
    
    public static readonly BetterInstruction Vgatherpf0qpd = new (Mnemonic.Vgatherpf0qpd);
  
    
    public static readonly BetterInstruction Vgatherpf0qps = new (Mnemonic.Vgatherpf0qps);
  
    
    public static readonly BetterInstruction Vgatherpf1dpd = new (Mnemonic.Vgatherpf1dpd);
  
    
    public static readonly BetterInstruction Vgatherpf1dps = new (Mnemonic.Vgatherpf1dps);
  
    
    public static readonly BetterInstruction Vgatherpf1qpd = new (Mnemonic.Vgatherpf1qpd);
  
    
    public static readonly BetterInstruction Vgatherpf1qps = new (Mnemonic.Vgatherpf1qps);
  
    
    public static readonly BetterInstruction Vgatherqpd = new (Mnemonic.Vgatherqpd);
  
    
    public static readonly BetterInstruction Vgatherqps = new (Mnemonic.Vgatherqps);
  
    
    public static readonly BetterInstruction Vgetexppd = new (Mnemonic.Vgetexppd);
  
    
    public static readonly BetterInstruction Vgetexpps = new (Mnemonic.Vgetexpps);
  
    
    public static readonly BetterInstruction Vgetexpsd = new (Mnemonic.Vgetexpsd);
  
    
    public static readonly BetterInstruction Vgetexpss = new (Mnemonic.Vgetexpss);
  
    
    public static readonly BetterInstruction Vgetmantpd = new (Mnemonic.Vgetmantpd);
  
    
    public static readonly BetterInstruction Vgetmantps = new (Mnemonic.Vgetmantps);
  
    
    public static readonly BetterInstruction Vgetmantsd = new (Mnemonic.Vgetmantsd);
  
    
    public static readonly BetterInstruction Vgetmantss = new (Mnemonic.Vgetmantss);
  
    
    public static readonly BetterInstruction Vgf2p8affineinvqb = new (Mnemonic.Vgf2p8affineinvqb);
  
    
    public static readonly BetterInstruction Vgf2p8affineqb = new (Mnemonic.Vgf2p8affineqb);
  
    
    public static readonly BetterInstruction Vgf2p8mulb = new (Mnemonic.Vgf2p8mulb);
  
    
    public static readonly BetterInstruction Vhaddpd = new (Mnemonic.Vhaddpd);
  
    
    public static readonly BetterInstruction Vhaddps = new (Mnemonic.Vhaddps);
  
    
    public static readonly BetterInstruction Vhsubpd = new (Mnemonic.Vhsubpd);
  
    
    public static readonly BetterInstruction Vhsubps = new (Mnemonic.Vhsubps);
  
    
    public static readonly BetterInstruction Vinsertf128 = new (Mnemonic.Vinsertf128);
  
    
    public static readonly BetterInstruction Vinsertf32x4 = new (Mnemonic.Vinsertf32x4);
  
    
    public static readonly BetterInstruction Vinsertf32x8 = new (Mnemonic.Vinsertf32x8);
  
    
    public static readonly BetterInstruction Vinsertf64x2 = new (Mnemonic.Vinsertf64x2);
  
    
    public static readonly BetterInstruction Vinsertf64x4 = new (Mnemonic.Vinsertf64x4);
  
    
    public static readonly BetterInstruction Vinserti128 = new (Mnemonic.Vinserti128);
  
    
    public static readonly BetterInstruction Vinserti32x4 = new (Mnemonic.Vinserti32x4);
  
    
    public static readonly BetterInstruction Vinserti32x8 = new (Mnemonic.Vinserti32x8);
  
    
    public static readonly BetterInstruction Vinserti64x2 = new (Mnemonic.Vinserti64x2);
  
    
    public static readonly BetterInstruction Vinserti64x4 = new (Mnemonic.Vinserti64x4);
  
    
    public static readonly BetterInstruction Vinsertps = new (Mnemonic.Vinsertps);
  
    
    public static readonly BetterInstruction Vlddqu = new (Mnemonic.Vlddqu);
  
    
    public static readonly BetterInstruction Vldmxcsr = new (Mnemonic.Vldmxcsr);
  
    
    public static readonly BetterInstruction Vmaskmovdqu = new (Mnemonic.Vmaskmovdqu);
  
    
    public static readonly BetterInstruction Vmaskmovpd = new (Mnemonic.Vmaskmovpd);
  
    
    public static readonly BetterInstruction Vmaskmovps = new (Mnemonic.Vmaskmovps);
  
    
    public static readonly BetterInstruction Vmaxpd = new (Mnemonic.Vmaxpd);
  
    
    public static readonly BetterInstruction Vmaxps = new (Mnemonic.Vmaxps);
  
    
    public static readonly BetterInstruction Vmaxsd = new (Mnemonic.Vmaxsd);
  
    
    public static readonly BetterInstruction Vmaxss = new (Mnemonic.Vmaxss);
  
    
    public static readonly BetterInstruction Vmcall = new (Mnemonic.Vmcall);
  
    
    public static readonly BetterInstruction Vmclear = new (Mnemonic.Vmclear);
  
    
    public static readonly BetterInstruction Vmfunc = new (Mnemonic.Vmfunc);
  
    
    public static readonly BetterInstruction Vminpd = new (Mnemonic.Vminpd);
  
    
    public static readonly BetterInstruction Vminps = new (Mnemonic.Vminps);
  
    
    public static readonly BetterInstruction Vminsd = new (Mnemonic.Vminsd);
  
    
    public static readonly BetterInstruction Vminss = new (Mnemonic.Vminss);
  
    
    public static readonly BetterInstruction Vmlaunch = new (Mnemonic.Vmlaunch);
  
    
    public static readonly BetterInstruction Vmload = new (Mnemonic.Vmload);
  
    
    public static readonly BetterInstruction Vmmcall = new (Mnemonic.Vmmcall);
  
    
    public static readonly BetterInstruction Vmovapd = new (Mnemonic.Vmovapd);
  
    
    public static readonly BetterInstruction Vmovaps = new (Mnemonic.Vmovaps);
  
    
    public static readonly BetterInstruction Vmovd = new (Mnemonic.Vmovd);
  
    
    public static readonly BetterInstruction Vmovddup = new (Mnemonic.Vmovddup);
  
    
    public static readonly BetterInstruction Vmovdqa = new (Mnemonic.Vmovdqa);
  
    
    public static readonly BetterInstruction Vmovdqa32 = new (Mnemonic.Vmovdqa32);
  
    
    public static readonly BetterInstruction Vmovdqa64 = new (Mnemonic.Vmovdqa64);
  
    
    public static readonly BetterInstruction Vmovdqu = new (Mnemonic.Vmovdqu);
  
    
    public static readonly BetterInstruction Vmovdqu16 = new (Mnemonic.Vmovdqu16);
  
    
    public static readonly BetterInstruction Vmovdqu32 = new (Mnemonic.Vmovdqu32);
  
    
    public static readonly BetterInstruction Vmovdqu64 = new (Mnemonic.Vmovdqu64);
  
    
    public static readonly BetterInstruction Vmovdqu8 = new (Mnemonic.Vmovdqu8);
  
    
    public static readonly BetterInstruction Vmovhlps = new (Mnemonic.Vmovhlps);
  
    
    public static readonly BetterInstruction Vmovhpd = new (Mnemonic.Vmovhpd);
  
    
    public static readonly BetterInstruction Vmovhps = new (Mnemonic.Vmovhps);
  
    
    public static readonly BetterInstruction Vmovlhps = new (Mnemonic.Vmovlhps);
  
    
    public static readonly BetterInstruction Vmovlpd = new (Mnemonic.Vmovlpd);
  
    
    public static readonly BetterInstruction Vmovlps = new (Mnemonic.Vmovlps);
  
    
    public static readonly BetterInstruction Vmovmskpd = new (Mnemonic.Vmovmskpd);
  
    
    public static readonly BetterInstruction Vmovmskps = new (Mnemonic.Vmovmskps);
  
    
    public static readonly BetterInstruction Vmovntdq = new (Mnemonic.Vmovntdq);
  
    
    public static readonly BetterInstruction Vmovntdqa = new (Mnemonic.Vmovntdqa);
  
    
    public static readonly BetterInstruction Vmovntpd = new (Mnemonic.Vmovntpd);
  
    
    public static readonly BetterInstruction Vmovntps = new (Mnemonic.Vmovntps);
  
    
    public static readonly BetterInstruction Vmovq = new (Mnemonic.Vmovq);
  
    
    public static readonly BetterInstruction Vmovsd = new (Mnemonic.Vmovsd);
  
    
    public static readonly BetterInstruction Vmovshdup = new (Mnemonic.Vmovshdup);
  
    
    public static readonly BetterInstruction Vmovsldup = new (Mnemonic.Vmovsldup);
  
    
    public static readonly BetterInstruction Vmovss = new (Mnemonic.Vmovss);
  
    
    public static readonly BetterInstruction Vmovupd = new (Mnemonic.Vmovupd);
  
    
    public static readonly BetterInstruction Vmovups = new (Mnemonic.Vmovups);
  
    
    public static readonly BetterInstruction Vmpsadbw = new (Mnemonic.Vmpsadbw);
  
    
    public static readonly BetterInstruction Vmptrld = new (Mnemonic.Vmptrld);
  
    
    public static readonly BetterInstruction Vmptrst = new (Mnemonic.Vmptrst);
  
    
    public static readonly BetterInstruction Vmread = new (Mnemonic.Vmread);
  
    
    public static readonly BetterInstruction Vmresume = new (Mnemonic.Vmresume);
  
    
    public static readonly BetterInstruction Vmrun = new (Mnemonic.Vmrun);
  
    
    public static readonly BetterInstruction Vmsave = new (Mnemonic.Vmsave);
  
    
    public static readonly BetterInstruction Vmulpd = new (Mnemonic.Vmulpd);
  
    
    public static readonly BetterInstruction Vmulps = new (Mnemonic.Vmulps);
  
    
    public static readonly BetterInstruction Vmulsd = new (Mnemonic.Vmulsd);
  
    
    public static readonly BetterInstruction Vmulss = new (Mnemonic.Vmulss);
  
    
    public static readonly BetterInstruction Vmwrite = new (Mnemonic.Vmwrite);
  
    
    public static readonly BetterInstruction Vmxoff = new (Mnemonic.Vmxoff);
  
    
    public static readonly BetterInstruction Vmxon = new (Mnemonic.Vmxon);
  
    
    public static readonly BetterInstruction Vorpd = new (Mnemonic.Vorpd);
  
    
    public static readonly BetterInstruction Vorps = new (Mnemonic.Vorps);
  
    
    public static readonly BetterInstruction Vp2intersectd = new (Mnemonic.Vp2intersectd);
  
    
    public static readonly BetterInstruction Vp2intersectq = new (Mnemonic.Vp2intersectq);
  
    
    public static readonly BetterInstruction Vp4dpwssd = new (Mnemonic.Vp4dpwssd);
  
    
    public static readonly BetterInstruction Vp4dpwssds = new (Mnemonic.Vp4dpwssds);
  
    
    public static readonly BetterInstruction Vpabsb = new (Mnemonic.Vpabsb);
  
    
    public static readonly BetterInstruction Vpabsd = new (Mnemonic.Vpabsd);
  
    
    public static readonly BetterInstruction Vpabsq = new (Mnemonic.Vpabsq);
  
    
    public static readonly BetterInstruction Vpabsw = new (Mnemonic.Vpabsw);
  
    
    public static readonly BetterInstruction Vpackssdw = new (Mnemonic.Vpackssdw);
  
    
    public static readonly BetterInstruction Vpacksswb = new (Mnemonic.Vpacksswb);
  
    
    public static readonly BetterInstruction Vpackusdw = new (Mnemonic.Vpackusdw);
  
    
    public static readonly BetterInstruction Vpackuswb = new (Mnemonic.Vpackuswb);
  
    
    public static readonly BetterInstruction Vpaddb = new (Mnemonic.Vpaddb);
  
    
    public static readonly BetterInstruction Vpaddd = new (Mnemonic.Vpaddd);
  
    
    public static readonly BetterInstruction Vpaddq = new (Mnemonic.Vpaddq);
  
    
    public static readonly BetterInstruction Vpaddsb = new (Mnemonic.Vpaddsb);
  
    
    public static readonly BetterInstruction Vpaddsw = new (Mnemonic.Vpaddsw);
  
    
    public static readonly BetterInstruction Vpaddusb = new (Mnemonic.Vpaddusb);
  
    
    public static readonly BetterInstruction Vpaddusw = new (Mnemonic.Vpaddusw);
  
    
    public static readonly BetterInstruction Vpaddw = new (Mnemonic.Vpaddw);
  
    
    public static readonly BetterInstruction Vpalignr = new (Mnemonic.Vpalignr);
  
    
    public static readonly BetterInstruction Vpand = new (Mnemonic.Vpand);
  
    
    public static readonly BetterInstruction Vpandd = new (Mnemonic.Vpandd);
  
    
    public static readonly BetterInstruction Vpandn = new (Mnemonic.Vpandn);
  
    
    public static readonly BetterInstruction Vpandnd = new (Mnemonic.Vpandnd);
  
    
    public static readonly BetterInstruction Vpandnq = new (Mnemonic.Vpandnq);
  
    
    public static readonly BetterInstruction Vpandq = new (Mnemonic.Vpandq);
  
    
    public static readonly BetterInstruction Vpavgb = new (Mnemonic.Vpavgb);
  
    
    public static readonly BetterInstruction Vpavgw = new (Mnemonic.Vpavgw);
  
    
    public static readonly BetterInstruction Vpblendd = new (Mnemonic.Vpblendd);
  
    
    public static readonly BetterInstruction Vpblendmb = new (Mnemonic.Vpblendmb);
  
    
    public static readonly BetterInstruction Vpblendmd = new (Mnemonic.Vpblendmd);
  
    
    public static readonly BetterInstruction Vpblendmq = new (Mnemonic.Vpblendmq);
  
    
    public static readonly BetterInstruction Vpblendmw = new (Mnemonic.Vpblendmw);
  
    
    public static readonly BetterInstruction Vpblendvb = new (Mnemonic.Vpblendvb);
  
    
    public static readonly BetterInstruction Vpblendw = new (Mnemonic.Vpblendw);
  
    
    public static readonly BetterInstruction Vpbroadcastb = new (Mnemonic.Vpbroadcastb);
  
    
    public static readonly BetterInstruction Vpbroadcastd = new (Mnemonic.Vpbroadcastd);
  
    
    public static readonly BetterInstruction Vpbroadcastmb2q = new (Mnemonic.Vpbroadcastmb2q);
  
    
    public static readonly BetterInstruction Vpbroadcastmw2d = new (Mnemonic.Vpbroadcastmw2d);
  
    
    public static readonly BetterInstruction Vpbroadcastq = new (Mnemonic.Vpbroadcastq);
  
    
    public static readonly BetterInstruction Vpbroadcastw = new (Mnemonic.Vpbroadcastw);
  
    
    public static readonly BetterInstruction Vpclmulqdq = new (Mnemonic.Vpclmulqdq);
  
    
    public static readonly BetterInstruction Vpcmov = new (Mnemonic.Vpcmov);
  
    
    public static readonly BetterInstruction Vpcmpb = new (Mnemonic.Vpcmpb);
  
    
    public static readonly BetterInstruction Vpcmpd = new (Mnemonic.Vpcmpd);
  
    
    public static readonly BetterInstruction Vpcmpeqb = new (Mnemonic.Vpcmpeqb);
  
    
    public static readonly BetterInstruction Vpcmpeqd = new (Mnemonic.Vpcmpeqd);
  
    
    public static readonly BetterInstruction Vpcmpeqq = new (Mnemonic.Vpcmpeqq);
  
    
    public static readonly BetterInstruction Vpcmpeqw = new (Mnemonic.Vpcmpeqw);
  
    
    public static readonly BetterInstruction Vpcmpestri = new (Mnemonic.Vpcmpestri);
  
    
    public static readonly BetterInstruction Vpcmpestri64 = new (Mnemonic.Vpcmpestri64);
  
    
    public static readonly BetterInstruction Vpcmpestrm = new (Mnemonic.Vpcmpestrm);
  
    
    public static readonly BetterInstruction Vpcmpestrm64 = new (Mnemonic.Vpcmpestrm64);
  
    
    public static readonly BetterInstruction Vpcmpgtb = new (Mnemonic.Vpcmpgtb);
  
    
    public static readonly BetterInstruction Vpcmpgtd = new (Mnemonic.Vpcmpgtd);
  
    
    public static readonly BetterInstruction Vpcmpgtq = new (Mnemonic.Vpcmpgtq);
  
    
    public static readonly BetterInstruction Vpcmpgtw = new (Mnemonic.Vpcmpgtw);
  
    
    public static readonly BetterInstruction Vpcmpistri = new (Mnemonic.Vpcmpistri);
  
    
    public static readonly BetterInstruction Vpcmpistrm = new (Mnemonic.Vpcmpistrm);
  
    
    public static readonly BetterInstruction Vpcmpq = new (Mnemonic.Vpcmpq);
  
    
    public static readonly BetterInstruction Vpcmpub = new (Mnemonic.Vpcmpub);
  
    
    public static readonly BetterInstruction Vpcmpud = new (Mnemonic.Vpcmpud);
  
    
    public static readonly BetterInstruction Vpcmpuq = new (Mnemonic.Vpcmpuq);
  
    
    public static readonly BetterInstruction Vpcmpuw = new (Mnemonic.Vpcmpuw);
  
    
    public static readonly BetterInstruction Vpcmpw = new (Mnemonic.Vpcmpw);
  
    
    public static readonly BetterInstruction Vpcomb = new (Mnemonic.Vpcomb);
  
    
    public static readonly BetterInstruction Vpcomd = new (Mnemonic.Vpcomd);
  
    
    public static readonly BetterInstruction Vpcompressb = new (Mnemonic.Vpcompressb);
  
    
    public static readonly BetterInstruction Vpcompressd = new (Mnemonic.Vpcompressd);
  
    
    public static readonly BetterInstruction Vpcompressq = new (Mnemonic.Vpcompressq);
  
    
    public static readonly BetterInstruction Vpcompressw = new (Mnemonic.Vpcompressw);
  
    
    public static readonly BetterInstruction Vpcomq = new (Mnemonic.Vpcomq);
  
    
    public static readonly BetterInstruction Vpcomub = new (Mnemonic.Vpcomub);
  
    
    public static readonly BetterInstruction Vpcomud = new (Mnemonic.Vpcomud);
  
    
    public static readonly BetterInstruction Vpcomuq = new (Mnemonic.Vpcomuq);
  
    
    public static readonly BetterInstruction Vpcomuw = new (Mnemonic.Vpcomuw);
  
    
    public static readonly BetterInstruction Vpcomw = new (Mnemonic.Vpcomw);
  
    
    public static readonly BetterInstruction Vpconflictd = new (Mnemonic.Vpconflictd);
  
    
    public static readonly BetterInstruction Vpconflictq = new (Mnemonic.Vpconflictq);
  
    
    public static readonly BetterInstruction Vpdpbusd = new (Mnemonic.Vpdpbusd);
  
    
    public static readonly BetterInstruction Vpdpbusds = new (Mnemonic.Vpdpbusds);
  
    
    public static readonly BetterInstruction Vpdpwssd = new (Mnemonic.Vpdpwssd);
  
    
    public static readonly BetterInstruction Vpdpwssds = new (Mnemonic.Vpdpwssds);
  
    
    public static readonly BetterInstruction Vperm2f128 = new (Mnemonic.Vperm2f128);
  
    
    public static readonly BetterInstruction Vperm2i128 = new (Mnemonic.Vperm2i128);
  
    
    public static readonly BetterInstruction Vpermb = new (Mnemonic.Vpermb);
  
    
    public static readonly BetterInstruction Vpermd = new (Mnemonic.Vpermd);
  
    
    public static readonly BetterInstruction Vpermi2b = new (Mnemonic.Vpermi2b);
  
    
    public static readonly BetterInstruction Vpermi2d = new (Mnemonic.Vpermi2d);
  
    
    public static readonly BetterInstruction Vpermi2pd = new (Mnemonic.Vpermi2pd);
  
    
    public static readonly BetterInstruction Vpermi2ps = new (Mnemonic.Vpermi2ps);
  
    
    public static readonly BetterInstruction Vpermi2q = new (Mnemonic.Vpermi2q);
  
    
    public static readonly BetterInstruction Vpermi2w = new (Mnemonic.Vpermi2w);
  
    
    public static readonly BetterInstruction Vpermil2pd = new (Mnemonic.Vpermil2pd);
  
    
    public static readonly BetterInstruction Vpermil2ps = new (Mnemonic.Vpermil2ps);
  
    
    public static readonly BetterInstruction Vpermilpd = new (Mnemonic.Vpermilpd);
  
    
    public static readonly BetterInstruction Vpermilps = new (Mnemonic.Vpermilps);
  
    
    public static readonly BetterInstruction Vpermpd = new (Mnemonic.Vpermpd);
  
    
    public static readonly BetterInstruction Vpermps = new (Mnemonic.Vpermps);
  
    
    public static readonly BetterInstruction Vpermq = new (Mnemonic.Vpermq);
  
    
    public static readonly BetterInstruction Vpermt2b = new (Mnemonic.Vpermt2b);
  
    
    public static readonly BetterInstruction Vpermt2d = new (Mnemonic.Vpermt2d);
  
    
    public static readonly BetterInstruction Vpermt2pd = new (Mnemonic.Vpermt2pd);
  
    
    public static readonly BetterInstruction Vpermt2ps = new (Mnemonic.Vpermt2ps);
  
    
    public static readonly BetterInstruction Vpermt2q = new (Mnemonic.Vpermt2q);
  
    
    public static readonly BetterInstruction Vpermt2w = new (Mnemonic.Vpermt2w);
  
    
    public static readonly BetterInstruction Vpermw = new (Mnemonic.Vpermw);
  
    
    public static readonly BetterInstruction Vpexpandb = new (Mnemonic.Vpexpandb);
  
    
    public static readonly BetterInstruction Vpexpandd = new (Mnemonic.Vpexpandd);
  
    
    public static readonly BetterInstruction Vpexpandq = new (Mnemonic.Vpexpandq);
  
    
    public static readonly BetterInstruction Vpexpandw = new (Mnemonic.Vpexpandw);
  
    
    public static readonly BetterInstruction Vpextrb = new (Mnemonic.Vpextrb);
  
    
    public static readonly BetterInstruction Vpextrd = new (Mnemonic.Vpextrd);
  
    
    public static readonly BetterInstruction Vpextrq = new (Mnemonic.Vpextrq);
  
    
    public static readonly BetterInstruction Vpextrw = new (Mnemonic.Vpextrw);
  
    
    public static readonly BetterInstruction Vpgatherdd = new (Mnemonic.Vpgatherdd);
  
    
    public static readonly BetterInstruction Vpgatherdq = new (Mnemonic.Vpgatherdq);
  
    
    public static readonly BetterInstruction Vpgatherqd = new (Mnemonic.Vpgatherqd);
  
    
    public static readonly BetterInstruction Vpgatherqq = new (Mnemonic.Vpgatherqq);
  
    
    public static readonly BetterInstruction Vphaddbd = new (Mnemonic.Vphaddbd);
  
    
    public static readonly BetterInstruction Vphaddbq = new (Mnemonic.Vphaddbq);
  
    
    public static readonly BetterInstruction Vphaddbw = new (Mnemonic.Vphaddbw);
  
    
    public static readonly BetterInstruction Vphaddd = new (Mnemonic.Vphaddd);
  
    
    public static readonly BetterInstruction Vphadddq = new (Mnemonic.Vphadddq);
  
    
    public static readonly BetterInstruction Vphaddsw = new (Mnemonic.Vphaddsw);
  
    
    public static readonly BetterInstruction Vphaddubd = new (Mnemonic.Vphaddubd);
  
    
    public static readonly BetterInstruction Vphaddubq = new (Mnemonic.Vphaddubq);
  
    
    public static readonly BetterInstruction Vphaddubw = new (Mnemonic.Vphaddubw);
  
    
    public static readonly BetterInstruction Vphaddudq = new (Mnemonic.Vphaddudq);
  
    
    public static readonly BetterInstruction Vphadduwd = new (Mnemonic.Vphadduwd);
  
    
    public static readonly BetterInstruction Vphadduwq = new (Mnemonic.Vphadduwq);
  
    
    public static readonly BetterInstruction Vphaddw = new (Mnemonic.Vphaddw);
  
    
    public static readonly BetterInstruction Vphaddwd = new (Mnemonic.Vphaddwd);
  
    
    public static readonly BetterInstruction Vphaddwq = new (Mnemonic.Vphaddwq);
  
    
    public static readonly BetterInstruction Vphminposuw = new (Mnemonic.Vphminposuw);
  
    
    public static readonly BetterInstruction Vphsubbw = new (Mnemonic.Vphsubbw);
  
    
    public static readonly BetterInstruction Vphsubd = new (Mnemonic.Vphsubd);
  
    
    public static readonly BetterInstruction Vphsubdq = new (Mnemonic.Vphsubdq);
  
    
    public static readonly BetterInstruction Vphsubsw = new (Mnemonic.Vphsubsw);
  
    
    public static readonly BetterInstruction Vphsubw = new (Mnemonic.Vphsubw);
  
    
    public static readonly BetterInstruction Vphsubwd = new (Mnemonic.Vphsubwd);
  
    
    public static readonly BetterInstruction Vpinsrb = new (Mnemonic.Vpinsrb);
  
    
    public static readonly BetterInstruction Vpinsrd = new (Mnemonic.Vpinsrd);
  
    
    public static readonly BetterInstruction Vpinsrq = new (Mnemonic.Vpinsrq);
  
    
    public static readonly BetterInstruction Vpinsrw = new (Mnemonic.Vpinsrw);
  
    
    public static readonly BetterInstruction Vplzcntd = new (Mnemonic.Vplzcntd);
  
    
    public static readonly BetterInstruction Vplzcntq = new (Mnemonic.Vplzcntq);
  
    
    public static readonly BetterInstruction Vpmacsdd = new (Mnemonic.Vpmacsdd);
  
    
    public static readonly BetterInstruction Vpmacsdqh = new (Mnemonic.Vpmacsdqh);
  
    
    public static readonly BetterInstruction Vpmacsdql = new (Mnemonic.Vpmacsdql);
  
    
    public static readonly BetterInstruction Vpmacssdd = new (Mnemonic.Vpmacssdd);
  
    
    public static readonly BetterInstruction Vpmacssdqh = new (Mnemonic.Vpmacssdqh);
  
    
    public static readonly BetterInstruction Vpmacssdql = new (Mnemonic.Vpmacssdql);
  
    
    public static readonly BetterInstruction Vpmacsswd = new (Mnemonic.Vpmacsswd);
  
    
    public static readonly BetterInstruction Vpmacssww = new (Mnemonic.Vpmacssww);
  
    
    public static readonly BetterInstruction Vpmacswd = new (Mnemonic.Vpmacswd);
  
    
    public static readonly BetterInstruction Vpmacsww = new (Mnemonic.Vpmacsww);
  
    
    public static readonly BetterInstruction Vpmadcsswd = new (Mnemonic.Vpmadcsswd);
  
    
    public static readonly BetterInstruction Vpmadcswd = new (Mnemonic.Vpmadcswd);
  
    
    public static readonly BetterInstruction Vpmadd52huq = new (Mnemonic.Vpmadd52huq);
  
    
    public static readonly BetterInstruction Vpmadd52luq = new (Mnemonic.Vpmadd52luq);
  
    
    public static readonly BetterInstruction Vpmaddubsw = new (Mnemonic.Vpmaddubsw);
  
    
    public static readonly BetterInstruction Vpmaddwd = new (Mnemonic.Vpmaddwd);
  
    
    public static readonly BetterInstruction Vpmaskmovd = new (Mnemonic.Vpmaskmovd);
  
    
    public static readonly BetterInstruction Vpmaskmovq = new (Mnemonic.Vpmaskmovq);
  
    
    public static readonly BetterInstruction Vpmaxsb = new (Mnemonic.Vpmaxsb);
  
    
    public static readonly BetterInstruction Vpmaxsd = new (Mnemonic.Vpmaxsd);
  
    
    public static readonly BetterInstruction Vpmaxsq = new (Mnemonic.Vpmaxsq);
  
    
    public static readonly BetterInstruction Vpmaxsw = new (Mnemonic.Vpmaxsw);
  
    
    public static readonly BetterInstruction Vpmaxub = new (Mnemonic.Vpmaxub);
  
    
    public static readonly BetterInstruction Vpmaxud = new (Mnemonic.Vpmaxud);
  
    
    public static readonly BetterInstruction Vpmaxuq = new (Mnemonic.Vpmaxuq);
  
    
    public static readonly BetterInstruction Vpmaxuw = new (Mnemonic.Vpmaxuw);
  
    
    public static readonly BetterInstruction Vpminsb = new (Mnemonic.Vpminsb);
  
    
    public static readonly BetterInstruction Vpminsd = new (Mnemonic.Vpminsd);
  
    
    public static readonly BetterInstruction Vpminsq = new (Mnemonic.Vpminsq);
  
    
    public static readonly BetterInstruction Vpminsw = new (Mnemonic.Vpminsw);
  
    
    public static readonly BetterInstruction Vpminub = new (Mnemonic.Vpminub);
  
    
    public static readonly BetterInstruction Vpminud = new (Mnemonic.Vpminud);
  
    
    public static readonly BetterInstruction Vpminuq = new (Mnemonic.Vpminuq);
  
    
    public static readonly BetterInstruction Vpminuw = new (Mnemonic.Vpminuw);
  
    
    public static readonly BetterInstruction Vpmovb2m = new (Mnemonic.Vpmovb2m);
  
    
    public static readonly BetterInstruction Vpmovd2m = new (Mnemonic.Vpmovd2m);
  
    
    public static readonly BetterInstruction Vpmovdb = new (Mnemonic.Vpmovdb);
  
    
    public static readonly BetterInstruction Vpmovdw = new (Mnemonic.Vpmovdw);
  
    
    public static readonly BetterInstruction Vpmovm2b = new (Mnemonic.Vpmovm2b);
  
    
    public static readonly BetterInstruction Vpmovm2d = new (Mnemonic.Vpmovm2d);
  
    
    public static readonly BetterInstruction Vpmovm2q = new (Mnemonic.Vpmovm2q);
  
    
    public static readonly BetterInstruction Vpmovm2w = new (Mnemonic.Vpmovm2w);
  
    
    public static readonly BetterInstruction Vpmovmskb = new (Mnemonic.Vpmovmskb);
  
    
    public static readonly BetterInstruction Vpmovq2m = new (Mnemonic.Vpmovq2m);
  
    
    public static readonly BetterInstruction Vpmovqb = new (Mnemonic.Vpmovqb);
  
    
    public static readonly BetterInstruction Vpmovqd = new (Mnemonic.Vpmovqd);
  
    
    public static readonly BetterInstruction Vpmovqw = new (Mnemonic.Vpmovqw);
  
    
    public static readonly BetterInstruction Vpmovsdb = new (Mnemonic.Vpmovsdb);
  
    
    public static readonly BetterInstruction Vpmovsdw = new (Mnemonic.Vpmovsdw);
  
    
    public static readonly BetterInstruction Vpmovsqb = new (Mnemonic.Vpmovsqb);
  
    
    public static readonly BetterInstruction Vpmovsqd = new (Mnemonic.Vpmovsqd);
  
    
    public static readonly BetterInstruction Vpmovsqw = new (Mnemonic.Vpmovsqw);
  
    
    public static readonly BetterInstruction Vpmovswb = new (Mnemonic.Vpmovswb);
  
    
    public static readonly BetterInstruction Vpmovsxbd = new (Mnemonic.Vpmovsxbd);
  
    
    public static readonly BetterInstruction Vpmovsxbq = new (Mnemonic.Vpmovsxbq);
  
    
    public static readonly BetterInstruction Vpmovsxbw = new (Mnemonic.Vpmovsxbw);
  
    
    public static readonly BetterInstruction Vpmovsxdq = new (Mnemonic.Vpmovsxdq);
  
    
    public static readonly BetterInstruction Vpmovsxwd = new (Mnemonic.Vpmovsxwd);
  
    
    public static readonly BetterInstruction Vpmovsxwq = new (Mnemonic.Vpmovsxwq);
  
    
    public static readonly BetterInstruction Vpmovusdb = new (Mnemonic.Vpmovusdb);
  
    
    public static readonly BetterInstruction Vpmovusdw = new (Mnemonic.Vpmovusdw);
  
    
    public static readonly BetterInstruction Vpmovusqb = new (Mnemonic.Vpmovusqb);
  
    
    public static readonly BetterInstruction Vpmovusqd = new (Mnemonic.Vpmovusqd);
  
    
    public static readonly BetterInstruction Vpmovusqw = new (Mnemonic.Vpmovusqw);
  
    
    public static readonly BetterInstruction Vpmovuswb = new (Mnemonic.Vpmovuswb);
  
    
    public static readonly BetterInstruction Vpmovw2m = new (Mnemonic.Vpmovw2m);
  
    
    public static readonly BetterInstruction Vpmovwb = new (Mnemonic.Vpmovwb);
  
    
    public static readonly BetterInstruction Vpmovzxbd = new (Mnemonic.Vpmovzxbd);
  
    
    public static readonly BetterInstruction Vpmovzxbq = new (Mnemonic.Vpmovzxbq);
  
    
    public static readonly BetterInstruction Vpmovzxbw = new (Mnemonic.Vpmovzxbw);
  
    
    public static readonly BetterInstruction Vpmovzxdq = new (Mnemonic.Vpmovzxdq);
  
    
    public static readonly BetterInstruction Vpmovzxwd = new (Mnemonic.Vpmovzxwd);
  
    
    public static readonly BetterInstruction Vpmovzxwq = new (Mnemonic.Vpmovzxwq);
  
    
    public static readonly BetterInstruction Vpmuldq = new (Mnemonic.Vpmuldq);
  
    
    public static readonly BetterInstruction Vpmulhrsw = new (Mnemonic.Vpmulhrsw);
  
    
    public static readonly BetterInstruction Vpmulhuw = new (Mnemonic.Vpmulhuw);
  
    
    public static readonly BetterInstruction Vpmulhw = new (Mnemonic.Vpmulhw);
  
    
    public static readonly BetterInstruction Vpmulld = new (Mnemonic.Vpmulld);
  
    
    public static readonly BetterInstruction Vpmullq = new (Mnemonic.Vpmullq);
  
    
    public static readonly BetterInstruction Vpmullw = new (Mnemonic.Vpmullw);
  
    
    public static readonly BetterInstruction Vpmultishiftqb = new (Mnemonic.Vpmultishiftqb);
  
    
    public static readonly BetterInstruction Vpmuludq = new (Mnemonic.Vpmuludq);
  
    
    public static readonly BetterInstruction Vpopcntb = new (Mnemonic.Vpopcntb);
  
    
    public static readonly BetterInstruction Vpopcntd = new (Mnemonic.Vpopcntd);
  
    
    public static readonly BetterInstruction Vpopcntq = new (Mnemonic.Vpopcntq);
  
    
    public static readonly BetterInstruction Vpopcntw = new (Mnemonic.Vpopcntw);
  
    
    public static readonly BetterInstruction Vpor = new (Mnemonic.Vpor);
  
    
    public static readonly BetterInstruction Vpord = new (Mnemonic.Vpord);
  
    
    public static readonly BetterInstruction Vporq = new (Mnemonic.Vporq);
  
    
    public static readonly BetterInstruction Vpperm = new (Mnemonic.Vpperm);
  
    
    public static readonly BetterInstruction Vprold = new (Mnemonic.Vprold);
  
    
    public static readonly BetterInstruction Vprolq = new (Mnemonic.Vprolq);
  
    
    public static readonly BetterInstruction Vprolvd = new (Mnemonic.Vprolvd);
  
    
    public static readonly BetterInstruction Vprolvq = new (Mnemonic.Vprolvq);
  
    
    public static readonly BetterInstruction Vprord = new (Mnemonic.Vprord);
  
    
    public static readonly BetterInstruction Vprorq = new (Mnemonic.Vprorq);
  
    
    public static readonly BetterInstruction Vprorvd = new (Mnemonic.Vprorvd);
  
    
    public static readonly BetterInstruction Vprorvq = new (Mnemonic.Vprorvq);
  
    
    public static readonly BetterInstruction Vprotb = new (Mnemonic.Vprotb);
  
    
    public static readonly BetterInstruction Vprotd = new (Mnemonic.Vprotd);
  
    
    public static readonly BetterInstruction Vprotq = new (Mnemonic.Vprotq);
  
    
    public static readonly BetterInstruction Vprotw = new (Mnemonic.Vprotw);
  
    
    public static readonly BetterInstruction Vpsadbw = new (Mnemonic.Vpsadbw);
  
    
    public static readonly BetterInstruction Vpscatterdd = new (Mnemonic.Vpscatterdd);
  
    
    public static readonly BetterInstruction Vpscatterdq = new (Mnemonic.Vpscatterdq);
  
    
    public static readonly BetterInstruction Vpscatterqd = new (Mnemonic.Vpscatterqd);
  
    
    public static readonly BetterInstruction Vpscatterqq = new (Mnemonic.Vpscatterqq);
  
    
    public static readonly BetterInstruction Vpshab = new (Mnemonic.Vpshab);
  
    
    public static readonly BetterInstruction Vpshad = new (Mnemonic.Vpshad);
  
    
    public static readonly BetterInstruction Vpshaq = new (Mnemonic.Vpshaq);
  
    
    public static readonly BetterInstruction Vpshaw = new (Mnemonic.Vpshaw);
  
    
    public static readonly BetterInstruction Vpshlb = new (Mnemonic.Vpshlb);
  
    
    public static readonly BetterInstruction Vpshld = new (Mnemonic.Vpshld);
  
    
    public static readonly BetterInstruction Vpshldd = new (Mnemonic.Vpshldd);
  
    
    public static readonly BetterInstruction Vpshldq = new (Mnemonic.Vpshldq);
  
    
    public static readonly BetterInstruction Vpshldvd = new (Mnemonic.Vpshldvd);
  
    
    public static readonly BetterInstruction Vpshldvq = new (Mnemonic.Vpshldvq);
  
    
    public static readonly BetterInstruction Vpshldvw = new (Mnemonic.Vpshldvw);
  
    
    public static readonly BetterInstruction Vpshldw = new (Mnemonic.Vpshldw);
  
    
    public static readonly BetterInstruction Vpshlq = new (Mnemonic.Vpshlq);
  
    
    public static readonly BetterInstruction Vpshlw = new (Mnemonic.Vpshlw);
  
    
    public static readonly BetterInstruction Vpshrdd = new (Mnemonic.Vpshrdd);
  
    
    public static readonly BetterInstruction Vpshrdq = new (Mnemonic.Vpshrdq);
  
    
    public static readonly BetterInstruction Vpshrdvd = new (Mnemonic.Vpshrdvd);
  
    
    public static readonly BetterInstruction Vpshrdvq = new (Mnemonic.Vpshrdvq);
  
    
    public static readonly BetterInstruction Vpshrdvw = new (Mnemonic.Vpshrdvw);
  
    
    public static readonly BetterInstruction Vpshrdw = new (Mnemonic.Vpshrdw);
  
    
    public static readonly BetterInstruction Vpshufb = new (Mnemonic.Vpshufb);
  
    
    public static readonly BetterInstruction Vpshufbitqmb = new (Mnemonic.Vpshufbitqmb);
  
    
    public static readonly BetterInstruction Vpshufd = new (Mnemonic.Vpshufd);
  
    
    public static readonly BetterInstruction Vpshufhw = new (Mnemonic.Vpshufhw);
  
    
    public static readonly BetterInstruction Vpshuflw = new (Mnemonic.Vpshuflw);
  
    
    public static readonly BetterInstruction Vpsignb = new (Mnemonic.Vpsignb);
  
    
    public static readonly BetterInstruction Vpsignd = new (Mnemonic.Vpsignd);
  
    
    public static readonly BetterInstruction Vpsignw = new (Mnemonic.Vpsignw);
  
    
    public static readonly BetterInstruction Vpslld = new (Mnemonic.Vpslld);
  
    
    public static readonly BetterInstruction Vpslldq = new (Mnemonic.Vpslldq);
  
    
    public static readonly BetterInstruction Vpsllq = new (Mnemonic.Vpsllq);
  
    
    public static readonly BetterInstruction Vpsllvd = new (Mnemonic.Vpsllvd);
  
    
    public static readonly BetterInstruction Vpsllvq = new (Mnemonic.Vpsllvq);
  
    
    public static readonly BetterInstruction Vpsllvw = new (Mnemonic.Vpsllvw);
  
    
    public static readonly BetterInstruction Vpsllw = new (Mnemonic.Vpsllw);
  
    
    public static readonly BetterInstruction Vpsrad = new (Mnemonic.Vpsrad);
  
    
    public static readonly BetterInstruction Vpsraq = new (Mnemonic.Vpsraq);
  
    
    public static readonly BetterInstruction Vpsravd = new (Mnemonic.Vpsravd);
  
    
    public static readonly BetterInstruction Vpsravq = new (Mnemonic.Vpsravq);
  
    
    public static readonly BetterInstruction Vpsravw = new (Mnemonic.Vpsravw);
  
    
    public static readonly BetterInstruction Vpsraw = new (Mnemonic.Vpsraw);
  
    
    public static readonly BetterInstruction Vpsrld = new (Mnemonic.Vpsrld);
  
    
    public static readonly BetterInstruction Vpsrldq = new (Mnemonic.Vpsrldq);
  
    
    public static readonly BetterInstruction Vpsrlq = new (Mnemonic.Vpsrlq);
  
    
    public static readonly BetterInstruction Vpsrlvd = new (Mnemonic.Vpsrlvd);
  
    
    public static readonly BetterInstruction Vpsrlvq = new (Mnemonic.Vpsrlvq);
  
    
    public static readonly BetterInstruction Vpsrlvw = new (Mnemonic.Vpsrlvw);
  
    
    public static readonly BetterInstruction Vpsrlw = new (Mnemonic.Vpsrlw);
  
    
    public static readonly BetterInstruction Vpsubb = new (Mnemonic.Vpsubb);
  
    
    public static readonly BetterInstruction Vpsubd = new (Mnemonic.Vpsubd);
  
    
    public static readonly BetterInstruction Vpsubq = new (Mnemonic.Vpsubq);
  
    
    public static readonly BetterInstruction Vpsubsb = new (Mnemonic.Vpsubsb);
  
    
    public static readonly BetterInstruction Vpsubsw = new (Mnemonic.Vpsubsw);
  
    
    public static readonly BetterInstruction Vpsubusb = new (Mnemonic.Vpsubusb);
  
    
    public static readonly BetterInstruction Vpsubusw = new (Mnemonic.Vpsubusw);
  
    
    public static readonly BetterInstruction Vpsubw = new (Mnemonic.Vpsubw);
  
    
    public static readonly BetterInstruction Vpternlogd = new (Mnemonic.Vpternlogd);
  
    
    public static readonly BetterInstruction Vpternlogq = new (Mnemonic.Vpternlogq);
  
    
    public static readonly BetterInstruction Vptest = new (Mnemonic.Vptest);
  
    
    public static readonly BetterInstruction Vptestmb = new (Mnemonic.Vptestmb);
  
    
    public static readonly BetterInstruction Vptestmd = new (Mnemonic.Vptestmd);
  
    
    public static readonly BetterInstruction Vptestmq = new (Mnemonic.Vptestmq);
  
    
    public static readonly BetterInstruction Vptestmw = new (Mnemonic.Vptestmw);
  
    
    public static readonly BetterInstruction Vptestnmb = new (Mnemonic.Vptestnmb);
  
    
    public static readonly BetterInstruction Vptestnmd = new (Mnemonic.Vptestnmd);
  
    
    public static readonly BetterInstruction Vptestnmq = new (Mnemonic.Vptestnmq);
  
    
    public static readonly BetterInstruction Vptestnmw = new (Mnemonic.Vptestnmw);
  
    
    public static readonly BetterInstruction Vpunpckhbw = new (Mnemonic.Vpunpckhbw);
  
    
    public static readonly BetterInstruction Vpunpckhdq = new (Mnemonic.Vpunpckhdq);
  
    
    public static readonly BetterInstruction Vpunpckhqdq = new (Mnemonic.Vpunpckhqdq);
  
    
    public static readonly BetterInstruction Vpunpckhwd = new (Mnemonic.Vpunpckhwd);
  
    
    public static readonly BetterInstruction Vpunpcklbw = new (Mnemonic.Vpunpcklbw);
  
    
    public static readonly BetterInstruction Vpunpckldq = new (Mnemonic.Vpunpckldq);
  
    
    public static readonly BetterInstruction Vpunpcklqdq = new (Mnemonic.Vpunpcklqdq);
  
    
    public static readonly BetterInstruction Vpunpcklwd = new (Mnemonic.Vpunpcklwd);
  
    
    public static readonly BetterInstruction Vpxor = new (Mnemonic.Vpxor);
  
    
    public static readonly BetterInstruction Vpxord = new (Mnemonic.Vpxord);
  
    
    public static readonly BetterInstruction Vpxorq = new (Mnemonic.Vpxorq);
  
    
    public static readonly BetterInstruction Vrangepd = new (Mnemonic.Vrangepd);
  
    
    public static readonly BetterInstruction Vrangeps = new (Mnemonic.Vrangeps);
  
    
    public static readonly BetterInstruction Vrangesd = new (Mnemonic.Vrangesd);
  
    
    public static readonly BetterInstruction Vrangess = new (Mnemonic.Vrangess);
  
    
    public static readonly BetterInstruction Vrcp14pd = new (Mnemonic.Vrcp14pd);
  
    
    public static readonly BetterInstruction Vrcp14ps = new (Mnemonic.Vrcp14ps);
  
    
    public static readonly BetterInstruction Vrcp14sd = new (Mnemonic.Vrcp14sd);
  
    
    public static readonly BetterInstruction Vrcp14ss = new (Mnemonic.Vrcp14ss);
  
    
    public static readonly BetterInstruction Vrcp28pd = new (Mnemonic.Vrcp28pd);
  
    
    public static readonly BetterInstruction Vrcp28ps = new (Mnemonic.Vrcp28ps);
  
    
    public static readonly BetterInstruction Vrcp28sd = new (Mnemonic.Vrcp28sd);
  
    
    public static readonly BetterInstruction Vrcp28ss = new (Mnemonic.Vrcp28ss);
  
    
    public static readonly BetterInstruction Vrcpps = new (Mnemonic.Vrcpps);
  
    
    public static readonly BetterInstruction Vrcpss = new (Mnemonic.Vrcpss);
  
    
    public static readonly BetterInstruction Vreducepd = new (Mnemonic.Vreducepd);
  
    
    public static readonly BetterInstruction Vreduceps = new (Mnemonic.Vreduceps);
  
    
    public static readonly BetterInstruction Vreducesd = new (Mnemonic.Vreducesd);
  
    
    public static readonly BetterInstruction Vreducess = new (Mnemonic.Vreducess);
  
    
    public static readonly BetterInstruction Vrndscalepd = new (Mnemonic.Vrndscalepd);
  
    
    public static readonly BetterInstruction Vrndscaleps = new (Mnemonic.Vrndscaleps);
  
    
    public static readonly BetterInstruction Vrndscalesd = new (Mnemonic.Vrndscalesd);
  
    
    public static readonly BetterInstruction Vrndscaless = new (Mnemonic.Vrndscaless);
  
    
    public static readonly BetterInstruction Vroundpd = new (Mnemonic.Vroundpd);
  
    
    public static readonly BetterInstruction Vroundps = new (Mnemonic.Vroundps);
  
    
    public static readonly BetterInstruction Vroundsd = new (Mnemonic.Vroundsd);
  
    
    public static readonly BetterInstruction Vroundss = new (Mnemonic.Vroundss);
  
    
    public static readonly BetterInstruction Vrsqrt14pd = new (Mnemonic.Vrsqrt14pd);
  
    
    public static readonly BetterInstruction Vrsqrt14ps = new (Mnemonic.Vrsqrt14ps);
  
    
    public static readonly BetterInstruction Vrsqrt14sd = new (Mnemonic.Vrsqrt14sd);
  
    
    public static readonly BetterInstruction Vrsqrt14ss = new (Mnemonic.Vrsqrt14ss);
  
    
    public static readonly BetterInstruction Vrsqrt28pd = new (Mnemonic.Vrsqrt28pd);
  
    
    public static readonly BetterInstruction Vrsqrt28ps = new (Mnemonic.Vrsqrt28ps);
  
    
    public static readonly BetterInstruction Vrsqrt28sd = new (Mnemonic.Vrsqrt28sd);
  
    
    public static readonly BetterInstruction Vrsqrt28ss = new (Mnemonic.Vrsqrt28ss);
  
    
    public static readonly BetterInstruction Vrsqrtps = new (Mnemonic.Vrsqrtps);
  
    
    public static readonly BetterInstruction Vrsqrtss = new (Mnemonic.Vrsqrtss);
  
    
    public static readonly BetterInstruction Vscalefpd = new (Mnemonic.Vscalefpd);
  
    
    public static readonly BetterInstruction Vscalefps = new (Mnemonic.Vscalefps);
  
    
    public static readonly BetterInstruction Vscalefsd = new (Mnemonic.Vscalefsd);
  
    
    public static readonly BetterInstruction Vscalefss = new (Mnemonic.Vscalefss);
  
    
    public static readonly BetterInstruction Vscatterdpd = new (Mnemonic.Vscatterdpd);
  
    
    public static readonly BetterInstruction Vscatterdps = new (Mnemonic.Vscatterdps);
  
    
    public static readonly BetterInstruction Vscatterpf0dpd = new (Mnemonic.Vscatterpf0dpd);
  
    
    public static readonly BetterInstruction Vscatterpf0dps = new (Mnemonic.Vscatterpf0dps);
  
    
    public static readonly BetterInstruction Vscatterpf0qpd = new (Mnemonic.Vscatterpf0qpd);
  
    
    public static readonly BetterInstruction Vscatterpf0qps = new (Mnemonic.Vscatterpf0qps);
  
    
    public static readonly BetterInstruction Vscatterpf1dpd = new (Mnemonic.Vscatterpf1dpd);
  
    
    public static readonly BetterInstruction Vscatterpf1dps = new (Mnemonic.Vscatterpf1dps);
  
    
    public static readonly BetterInstruction Vscatterpf1qpd = new (Mnemonic.Vscatterpf1qpd);
  
    
    public static readonly BetterInstruction Vscatterpf1qps = new (Mnemonic.Vscatterpf1qps);
  
    
    public static readonly BetterInstruction Vscatterqpd = new (Mnemonic.Vscatterqpd);
  
    
    public static readonly BetterInstruction Vscatterqps = new (Mnemonic.Vscatterqps);
  
    
    public static readonly BetterInstruction Vshuff32x4 = new (Mnemonic.Vshuff32x4);
  
    
    public static readonly BetterInstruction Vshuff64x2 = new (Mnemonic.Vshuff64x2);
  
    
    public static readonly BetterInstruction Vshufi32x4 = new (Mnemonic.Vshufi32x4);
  
    
    public static readonly BetterInstruction Vshufi64x2 = new (Mnemonic.Vshufi64x2);
  
    
    public static readonly BetterInstruction Vshufpd = new (Mnemonic.Vshufpd);
  
    
    public static readonly BetterInstruction Vshufps = new (Mnemonic.Vshufps);
  
    
    public static readonly BetterInstruction Vsqrtpd = new (Mnemonic.Vsqrtpd);
  
    
    public static readonly BetterInstruction Vsqrtps = new (Mnemonic.Vsqrtps);
  
    
    public static readonly BetterInstruction Vsqrtsd = new (Mnemonic.Vsqrtsd);
  
    
    public static readonly BetterInstruction Vsqrtss = new (Mnemonic.Vsqrtss);
  
    
    public static readonly BetterInstruction Vstmxcsr = new (Mnemonic.Vstmxcsr);
  
    
    public static readonly BetterInstruction Vsubpd = new (Mnemonic.Vsubpd);
  
    
    public static readonly BetterInstruction Vsubps = new (Mnemonic.Vsubps);
  
    
    public static readonly BetterInstruction Vsubsd = new (Mnemonic.Vsubsd);
  
    
    public static readonly BetterInstruction Vsubss = new (Mnemonic.Vsubss);
  
    
    public static readonly BetterInstruction Vtestpd = new (Mnemonic.Vtestpd);
  
    
    public static readonly BetterInstruction Vtestps = new (Mnemonic.Vtestps);
  
    
    public static readonly BetterInstruction Vucomisd = new (Mnemonic.Vucomisd);
  
    
    public static readonly BetterInstruction Vucomiss = new (Mnemonic.Vucomiss);
  
    
    public static readonly BetterInstruction Vunpckhpd = new (Mnemonic.Vunpckhpd);
  
    
    public static readonly BetterInstruction Vunpckhps = new (Mnemonic.Vunpckhps);
  
    
    public static readonly BetterInstruction Vunpcklpd = new (Mnemonic.Vunpcklpd);
  
    
    public static readonly BetterInstruction Vunpcklps = new (Mnemonic.Vunpcklps);
  
    
    public static readonly BetterInstruction Vxorpd = new (Mnemonic.Vxorpd);
  
    
    public static readonly BetterInstruction Vxorps = new (Mnemonic.Vxorps);
  
    
    public static readonly BetterInstruction Vzeroall = new (Mnemonic.Vzeroall);
  
    
    public static readonly BetterInstruction Vzeroupper = new (Mnemonic.Vzeroupper);
  
    
    public static readonly BetterInstruction Wait = new (Mnemonic.Wait);
  
    
    public static readonly BetterInstruction Wbinvd = new (Mnemonic.Wbinvd);
  
    
    public static readonly BetterInstruction Wbnoinvd = new (Mnemonic.Wbnoinvd);
  
    
    public static readonly BetterInstruction Wrfsbase = new (Mnemonic.Wrfsbase);
  
    
    public static readonly BetterInstruction Wrgsbase = new (Mnemonic.Wrgsbase);
  
    
    public static readonly BetterInstruction Wrmsr = new (Mnemonic.Wrmsr);
  
    
    public static readonly BetterInstruction Wrpkru = new (Mnemonic.Wrpkru);
  
    
    public static readonly BetterInstruction Wrssd = new (Mnemonic.Wrssd);
  
    
    public static readonly BetterInstruction Wrssq = new (Mnemonic.Wrssq);
  
    
    public static readonly BetterInstruction Wrussd = new (Mnemonic.Wrussd);
  
    
    public static readonly BetterInstruction Wrussq = new (Mnemonic.Wrussq);
  
    
    public static readonly BetterInstruction Xabort = new (Mnemonic.Xabort);
  
    
    public static readonly BetterInstruction Xadd = new (Mnemonic.Xadd);
  
    
    public static readonly BetterInstruction Xbegin = new (Mnemonic.Xbegin);
  
    
    public static readonly BetterInstruction Xbts = new (Mnemonic.Xbts);
  
    
    public static readonly BetterInstruction Xchg = new (Mnemonic.Xchg);
  
    
    public static readonly BetterInstruction Xcryptcbc = new (Mnemonic.Xcryptcbc);
  
    
    public static readonly BetterInstruction Xcryptcfb = new (Mnemonic.Xcryptcfb);
  
    
    public static readonly BetterInstruction Xcryptctr = new (Mnemonic.Xcryptctr);
  
    
    public static readonly BetterInstruction Xcryptecb = new (Mnemonic.Xcryptecb);
  
    
    public static readonly BetterInstruction Xcryptofb = new (Mnemonic.Xcryptofb);
  
    
    public static readonly BetterInstruction Xend = new (Mnemonic.Xend);
  
    
    public static readonly BetterInstruction Xgetbv = new (Mnemonic.Xgetbv);
  
    
    public static readonly BetterInstruction Xlatb = new (Mnemonic.Xlatb);
  
    
    public static readonly BetterInstruction Xor = new (Mnemonic.Xor);
  
    
    public static readonly BetterInstruction Xorpd = new (Mnemonic.Xorpd);
  
    
    public static readonly BetterInstruction Xorps = new (Mnemonic.Xorps);
  
    
    public static readonly BetterInstruction Xrstor = new (Mnemonic.Xrstor);
  
    
    public static readonly BetterInstruction Xrstor64 = new (Mnemonic.Xrstor64);
  
    
    public static readonly BetterInstruction Xrstors = new (Mnemonic.Xrstors);
  
    
    public static readonly BetterInstruction Xrstors64 = new (Mnemonic.Xrstors64);
  
    
    public static readonly BetterInstruction Xsave = new (Mnemonic.Xsave);
  
    
    public static readonly BetterInstruction Xsave64 = new (Mnemonic.Xsave64);
  
    
    public static readonly BetterInstruction Xsavec = new (Mnemonic.Xsavec);
  
    
    public static readonly BetterInstruction Xsavec64 = new (Mnemonic.Xsavec64);
  
    
    public static readonly BetterInstruction Xsaveopt = new (Mnemonic.Xsaveopt);
  
    
    public static readonly BetterInstruction Xsaveopt64 = new (Mnemonic.Xsaveopt64);
  
    
    public static readonly BetterInstruction Xsaves = new (Mnemonic.Xsaves);
  
    
    public static readonly BetterInstruction Xsaves64 = new (Mnemonic.Xsaves64);
  
    
    public static readonly BetterInstruction Xsetbv = new (Mnemonic.Xsetbv);
  
    
    public static readonly BetterInstruction Xsha1 = new (Mnemonic.Xsha1);
  
    
    public static readonly BetterInstruction Xsha256 = new (Mnemonic.Xsha256);
  
    
    public static readonly BetterInstruction Xstore = new (Mnemonic.Xstore);
  
    
    public static readonly BetterInstruction Xtest = new (Mnemonic.Xtest);
  
    
    public static readonly BetterInstruction Rmpadjust = new (Mnemonic.Rmpadjust);
  
    
    public static readonly BetterInstruction Rmpupdate = new (Mnemonic.Rmpupdate);
  
    
    public static readonly BetterInstruction Psmash = new (Mnemonic.Psmash);
  
    
    public static readonly BetterInstruction Pvalidate = new (Mnemonic.Pvalidate);
  
    
    public static readonly BetterInstruction Serialize = new (Mnemonic.Serialize);
  
    
    public static readonly BetterInstruction Xsusldtrk = new (Mnemonic.Xsusldtrk);
  
    
    public static readonly BetterInstruction Xresldtrk = new (Mnemonic.Xresldtrk);
  
    
    public static readonly BetterInstruction Invlpgb = new (Mnemonic.Invlpgb);
  
    
    public static readonly BetterInstruction Tlbsync = new (Mnemonic.Tlbsync);
  
    
    public static readonly BetterInstruction Vmgexit = new (Mnemonic.Vmgexit);
  
    
    public static readonly BetterInstruction Getsecq = new (Mnemonic.Getsecq);
  
    
    public static readonly BetterInstruction Sysexitq = new (Mnemonic.Sysexitq);
  
    
    public static readonly BetterInstruction Ldtilecfg = new (Mnemonic.Ldtilecfg);
  
    
    public static readonly BetterInstruction Tilerelease = new (Mnemonic.Tilerelease);
  
    
    public static readonly BetterInstruction Sttilecfg = new (Mnemonic.Sttilecfg);
  
    
    public static readonly BetterInstruction Tilezero = new (Mnemonic.Tilezero);
  
    
    public static readonly BetterInstruction Tileloaddt1 = new (Mnemonic.Tileloaddt1);
  
    
    public static readonly BetterInstruction Tilestored = new (Mnemonic.Tilestored);
  
    
    public static readonly BetterInstruction Tileloadd = new (Mnemonic.Tileloadd);
  
    
    public static readonly BetterInstruction Tdpbf16ps = new (Mnemonic.Tdpbf16ps);
  
    
    public static readonly BetterInstruction Tdpbuud = new (Mnemonic.Tdpbuud);
  
    
    public static readonly BetterInstruction Tdpbusd = new (Mnemonic.Tdpbusd);
  
    
    public static readonly BetterInstruction Tdpbsud = new (Mnemonic.Tdpbsud);
  
    
    public static readonly BetterInstruction Tdpbssd = new (Mnemonic.Tdpbssd);
  
    
    public static readonly BetterInstruction Sysretq = new (Mnemonic.Sysretq);
  
    
    public static readonly BetterInstruction Fnstdw = new (Mnemonic.Fnstdw);
  
    
    public static readonly BetterInstruction Fnstsg = new (Mnemonic.Fnstsg);
  
    
    public static readonly BetterInstruction Rdshr = new (Mnemonic.Rdshr);
  
    
    public static readonly BetterInstruction Wrshr = new (Mnemonic.Wrshr);
  
    
    public static readonly BetterInstruction Smint = new (Mnemonic.Smint);
  
    
    public static readonly BetterInstruction Dmint = new (Mnemonic.Dmint);
  
    
    public static readonly BetterInstruction Rdm = new (Mnemonic.Rdm);
  
    
    public static readonly BetterInstruction Svdc = new (Mnemonic.Svdc);
  
    
    public static readonly BetterInstruction Rsdc = new (Mnemonic.Rsdc);
  
    
    public static readonly BetterInstruction Svldt = new (Mnemonic.Svldt);
  
    
    public static readonly BetterInstruction Rsldt = new (Mnemonic.Rsldt);
  
    
    public static readonly BetterInstruction Svts = new (Mnemonic.Svts);
  
    
    public static readonly BetterInstruction Rsts = new (Mnemonic.Rsts);
  
    
    public static readonly BetterInstruction Bb0_reset = new (Mnemonic.Bb0_reset);
  
    
    public static readonly BetterInstruction Bb1_reset = new (Mnemonic.Bb1_reset);
  
    
    public static readonly BetterInstruction Cpu_write = new (Mnemonic.Cpu_write);
  
    
    public static readonly BetterInstruction Cpu_read = new (Mnemonic.Cpu_read);
  
    
    public static readonly BetterInstruction Altinst = new (Mnemonic.Altinst);
  
    
    public static readonly BetterInstruction Paveb = new (Mnemonic.Paveb);
  
    
    public static readonly BetterInstruction Paddsiw = new (Mnemonic.Paddsiw);
  
    
    public static readonly BetterInstruction Pmagw = new (Mnemonic.Pmagw);
  
    
    public static readonly BetterInstruction Pdistib = new (Mnemonic.Pdistib);
  
    
    public static readonly BetterInstruction Psubsiw = new (Mnemonic.Psubsiw);
  
    
    public static readonly BetterInstruction Pmvzb = new (Mnemonic.Pmvzb);
  
    
    public static readonly BetterInstruction Pmvnzb = new (Mnemonic.Pmvnzb);
  
    
    public static readonly BetterInstruction Pmvlzb = new (Mnemonic.Pmvlzb);
  
    
    public static readonly BetterInstruction Pmvgezb = new (Mnemonic.Pmvgezb);
  
    
    public static readonly BetterInstruction Pmulhriw = new (Mnemonic.Pmulhriw);
  
    
    public static readonly BetterInstruction Pmachriw = new (Mnemonic.Pmachriw);
  
    
    public static readonly BetterInstruction Ftstp = new (Mnemonic.Ftstp);
  
    
    public static readonly BetterInstruction Frint2 = new (Mnemonic.Frint2);
  
    
    public static readonly BetterInstruction Frichop = new (Mnemonic.Frichop);
  
    
    public static readonly BetterInstruction Frinear = new (Mnemonic.Frinear);
  
    
    public static readonly BetterInstruction Undoc = new (Mnemonic.Undoc);
  
    
    public static readonly BetterInstruction Tdcall = new (Mnemonic.Tdcall);
  
    
    public static readonly BetterInstruction Seamret = new (Mnemonic.Seamret);
  
    
    public static readonly BetterInstruction Seamops = new (Mnemonic.Seamops);
  
    
    public static readonly BetterInstruction Seamcall = new (Mnemonic.Seamcall);
  
    
    public static readonly BetterInstruction Aesencwide128kl = new (Mnemonic.Aesencwide128kl);
  
    
    public static readonly BetterInstruction Aesdecwide128kl = new (Mnemonic.Aesdecwide128kl);
  
    
    public static readonly BetterInstruction Aesencwide256kl = new (Mnemonic.Aesencwide256kl);
  
    
    public static readonly BetterInstruction Aesdecwide256kl = new (Mnemonic.Aesdecwide256kl);
  
    
    public static readonly BetterInstruction Loadiwkey = new (Mnemonic.Loadiwkey);
  
    
    public static readonly BetterInstruction Aesenc128kl = new (Mnemonic.Aesenc128kl);
  
    
    public static readonly BetterInstruction Aesdec128kl = new (Mnemonic.Aesdec128kl);
  
    
    public static readonly BetterInstruction Aesenc256kl = new (Mnemonic.Aesenc256kl);
  
    
    public static readonly BetterInstruction Aesdec256kl = new (Mnemonic.Aesdec256kl);
  
    
    public static readonly BetterInstruction Encodekey128 = new (Mnemonic.Encodekey128);
  
    
    public static readonly BetterInstruction Encodekey256 = new (Mnemonic.Encodekey256);
  
    
    public static readonly BetterInstruction Pushad = new (Mnemonic.Pushad);
  
    
    public static readonly BetterInstruction Popad = new (Mnemonic.Popad);
  
    
    public static readonly BetterInstruction Pushfd = new (Mnemonic.Pushfd);
  
    
    public static readonly BetterInstruction Pushfq = new (Mnemonic.Pushfq);
  
    
    public static readonly BetterInstruction Popfd = new (Mnemonic.Popfd);
  
    
    public static readonly BetterInstruction Popfq = new (Mnemonic.Popfq);
  
    
    public static readonly BetterInstruction Iretd = new (Mnemonic.Iretd);
  
    
    public static readonly BetterInstruction Iretq = new (Mnemonic.Iretq);
  
    
    public static readonly BetterInstruction Int3 = new (Mnemonic.Int3);
  
    
    public static readonly BetterInstruction Uiret = new (Mnemonic.Uiret);
  
    
    public static readonly BetterInstruction Testui = new (Mnemonic.Testui);
  
    
    public static readonly BetterInstruction Clui = new (Mnemonic.Clui);
  
    
    public static readonly BetterInstruction Stui = new (Mnemonic.Stui);
  
    
    public static readonly BetterInstruction Senduipi = new (Mnemonic.Senduipi);
  
    
    public static readonly BetterInstruction Hreset = new (Mnemonic.Hreset);
  
    
    public static readonly BetterInstruction Ccs_hash = new (Mnemonic.Ccs_hash);
  
    
    public static readonly BetterInstruction Ccs_encrypt = new (Mnemonic.Ccs_encrypt);
  
    
    public static readonly BetterInstruction Lkgs = new (Mnemonic.Lkgs);
  
    
    public static readonly BetterInstruction Eretu = new (Mnemonic.Eretu);
  
    
    public static readonly BetterInstruction Erets = new (Mnemonic.Erets);
  
    
    public static readonly BetterInstruction Storeall = new (Mnemonic.Storeall);
  
    
    public static readonly BetterInstruction Vaddph = new (Mnemonic.Vaddph);
  
    
    public static readonly BetterInstruction Vaddsh = new (Mnemonic.Vaddsh);
  
    
    public static readonly BetterInstruction Vcmpph = new (Mnemonic.Vcmpph);
  
    
    public static readonly BetterInstruction Vcmpsh = new (Mnemonic.Vcmpsh);
  
    
    public static readonly BetterInstruction Vcomish = new (Mnemonic.Vcomish);
  
    
    public static readonly BetterInstruction Vcvtdq2ph = new (Mnemonic.Vcvtdq2ph);
  
    
    public static readonly BetterInstruction Vcvtpd2ph = new (Mnemonic.Vcvtpd2ph);
  
    
    public static readonly BetterInstruction Vcvtph2dq = new (Mnemonic.Vcvtph2dq);
  
    
    public static readonly BetterInstruction Vcvtph2pd = new (Mnemonic.Vcvtph2pd);
  
    
    public static readonly BetterInstruction Vcvtph2psx = new (Mnemonic.Vcvtph2psx);
  
    
    public static readonly BetterInstruction Vcvtph2qq = new (Mnemonic.Vcvtph2qq);
  
    
    public static readonly BetterInstruction Vcvtph2udq = new (Mnemonic.Vcvtph2udq);
  
    
    public static readonly BetterInstruction Vcvtph2uqq = new (Mnemonic.Vcvtph2uqq);
  
    
    public static readonly BetterInstruction Vcvtph2uw = new (Mnemonic.Vcvtph2uw);
  
    
    public static readonly BetterInstruction Vcvtph2w = new (Mnemonic.Vcvtph2w);
  
    
    public static readonly BetterInstruction Vcvtps2phx = new (Mnemonic.Vcvtps2phx);
  
    
    public static readonly BetterInstruction Vcvtqq2ph = new (Mnemonic.Vcvtqq2ph);
  
    
    public static readonly BetterInstruction Vcvtsd2sh = new (Mnemonic.Vcvtsd2sh);
  
    
    public static readonly BetterInstruction Vcvtsh2sd = new (Mnemonic.Vcvtsh2sd);
  
    
    public static readonly BetterInstruction Vcvtsh2si = new (Mnemonic.Vcvtsh2si);
  
    
    public static readonly BetterInstruction Vcvtsh2ss = new (Mnemonic.Vcvtsh2ss);
  
    
    public static readonly BetterInstruction Vcvtsh2usi = new (Mnemonic.Vcvtsh2usi);
  
    
    public static readonly BetterInstruction Vcvtsi2sh = new (Mnemonic.Vcvtsi2sh);
  
    
    public static readonly BetterInstruction Vcvtss2sh = new (Mnemonic.Vcvtss2sh);
  
    
    public static readonly BetterInstruction Vcvttph2dq = new (Mnemonic.Vcvttph2dq);
  
    
    public static readonly BetterInstruction Vcvttph2qq = new (Mnemonic.Vcvttph2qq);
  
    
    public static readonly BetterInstruction Vcvttph2udq = new (Mnemonic.Vcvttph2udq);
  
    
    public static readonly BetterInstruction Vcvttph2uqq = new (Mnemonic.Vcvttph2uqq);
  
    
    public static readonly BetterInstruction Vcvttph2uw = new (Mnemonic.Vcvttph2uw);
  
    
    public static readonly BetterInstruction Vcvttph2w = new (Mnemonic.Vcvttph2w);
  
    
    public static readonly BetterInstruction Vcvttsh2si = new (Mnemonic.Vcvttsh2si);
  
    
    public static readonly BetterInstruction Vcvttsh2usi = new (Mnemonic.Vcvttsh2usi);
  
    
    public static readonly BetterInstruction Vcvtudq2ph = new (Mnemonic.Vcvtudq2ph);
  
    
    public static readonly BetterInstruction Vcvtuqq2ph = new (Mnemonic.Vcvtuqq2ph);
  
    
    public static readonly BetterInstruction Vcvtusi2sh = new (Mnemonic.Vcvtusi2sh);
  
    
    public static readonly BetterInstruction Vcvtuw2ph = new (Mnemonic.Vcvtuw2ph);
  
    
    public static readonly BetterInstruction Vcvtw2ph = new (Mnemonic.Vcvtw2ph);
  
    
    public static readonly BetterInstruction Vdivph = new (Mnemonic.Vdivph);
  
    
    public static readonly BetterInstruction Vdivsh = new (Mnemonic.Vdivsh);
  
    
    public static readonly BetterInstruction Vfcmaddcph = new (Mnemonic.Vfcmaddcph);
  
    
    public static readonly BetterInstruction Vfmaddcph = new (Mnemonic.Vfmaddcph);
  
    
    public static readonly BetterInstruction Vfcmaddcsh = new (Mnemonic.Vfcmaddcsh);
  
    
    public static readonly BetterInstruction Vfmaddcsh = new (Mnemonic.Vfmaddcsh);
  
    
    public static readonly BetterInstruction Vfcmulcph = new (Mnemonic.Vfcmulcph);
  
    
    public static readonly BetterInstruction Vfmulcph = new (Mnemonic.Vfmulcph);
  
    
    public static readonly BetterInstruction Vfcmulcsh = new (Mnemonic.Vfcmulcsh);
  
    
    public static readonly BetterInstruction Vfmulcsh = new (Mnemonic.Vfmulcsh);
  
    
    public static readonly BetterInstruction Vfmaddsub132ph = new (Mnemonic.Vfmaddsub132ph);
  
    
    public static readonly BetterInstruction Vfmaddsub213ph = new (Mnemonic.Vfmaddsub213ph);
  
    
    public static readonly BetterInstruction Vfmaddsub231ph = new (Mnemonic.Vfmaddsub231ph);
  
    
    public static readonly BetterInstruction Vfmsubadd132ph = new (Mnemonic.Vfmsubadd132ph);
  
    
    public static readonly BetterInstruction Vfmsubadd213ph = new (Mnemonic.Vfmsubadd213ph);
  
    
    public static readonly BetterInstruction Vfmsubadd231ph = new (Mnemonic.Vfmsubadd231ph);
  
    
    public static readonly BetterInstruction Vfmadd132ph = new (Mnemonic.Vfmadd132ph);
  
    
    public static readonly BetterInstruction Vfmadd213ph = new (Mnemonic.Vfmadd213ph);
  
    
    public static readonly BetterInstruction Vfmadd231ph = new (Mnemonic.Vfmadd231ph);
  
    
    public static readonly BetterInstruction Vfnmadd132ph = new (Mnemonic.Vfnmadd132ph);
  
    
    public static readonly BetterInstruction Vfnmadd213ph = new (Mnemonic.Vfnmadd213ph);
  
    
    public static readonly BetterInstruction Vfnmadd231ph = new (Mnemonic.Vfnmadd231ph);
  
    
    public static readonly BetterInstruction Vfmadd132sh = new (Mnemonic.Vfmadd132sh);
  
    
    public static readonly BetterInstruction Vfmadd213sh = new (Mnemonic.Vfmadd213sh);
  
    
    public static readonly BetterInstruction Vfmadd231sh = new (Mnemonic.Vfmadd231sh);
  
    
    public static readonly BetterInstruction Vfnmadd132sh = new (Mnemonic.Vfnmadd132sh);
  
    
    public static readonly BetterInstruction Vfnmadd213sh = new (Mnemonic.Vfnmadd213sh);
  
    
    public static readonly BetterInstruction Vfnmadd231sh = new (Mnemonic.Vfnmadd231sh);
  
    
    public static readonly BetterInstruction Vfmsub132ph = new (Mnemonic.Vfmsub132ph);
  
    
    public static readonly BetterInstruction Vfmsub213ph = new (Mnemonic.Vfmsub213ph);
  
    
    public static readonly BetterInstruction Vfmsub231ph = new (Mnemonic.Vfmsub231ph);
  
    
    public static readonly BetterInstruction Vfnmsub132ph = new (Mnemonic.Vfnmsub132ph);
  
    
    public static readonly BetterInstruction Vfnmsub213ph = new (Mnemonic.Vfnmsub213ph);
  
    
    public static readonly BetterInstruction Vfnmsub231ph = new (Mnemonic.Vfnmsub231ph);
  
    
    public static readonly BetterInstruction Vfmsub132sh = new (Mnemonic.Vfmsub132sh);
  
    
    public static readonly BetterInstruction Vfmsub213sh = new (Mnemonic.Vfmsub213sh);
  
    
    public static readonly BetterInstruction Vfmsub231sh = new (Mnemonic.Vfmsub231sh);
  
    
    public static readonly BetterInstruction Vfnmsub132sh = new (Mnemonic.Vfnmsub132sh);
  
    
    public static readonly BetterInstruction Vfnmsub213sh = new (Mnemonic.Vfnmsub213sh);
  
    
    public static readonly BetterInstruction Vfnmsub231sh = new (Mnemonic.Vfnmsub231sh);
  
    
    public static readonly BetterInstruction Vfpclassph = new (Mnemonic.Vfpclassph);
  
    
    public static readonly BetterInstruction Vfpclasssh = new (Mnemonic.Vfpclasssh);
  
    
    public static readonly BetterInstruction Vgetexpph = new (Mnemonic.Vgetexpph);
  
    
    public static readonly BetterInstruction Vgetexpsh = new (Mnemonic.Vgetexpsh);
  
    
    public static readonly BetterInstruction Vgetmantph = new (Mnemonic.Vgetmantph);
  
    
    public static readonly BetterInstruction Vgetmantsh = new (Mnemonic.Vgetmantsh);
  
    
    public static readonly BetterInstruction Vmaxph = new (Mnemonic.Vmaxph);
  
    
    public static readonly BetterInstruction Vmaxsh = new (Mnemonic.Vmaxsh);
  
    
    public static readonly BetterInstruction Vminph = new (Mnemonic.Vminph);
  
    
    public static readonly BetterInstruction Vminsh = new (Mnemonic.Vminsh);
  
    
    public static readonly BetterInstruction Vmovsh = new (Mnemonic.Vmovsh);
  
    
    public static readonly BetterInstruction Vmovw = new (Mnemonic.Vmovw);
  
    
    public static readonly BetterInstruction Vmulph = new (Mnemonic.Vmulph);
  
    
    public static readonly BetterInstruction Vmulsh = new (Mnemonic.Vmulsh);
  
    
    public static readonly BetterInstruction Vrcpph = new (Mnemonic.Vrcpph);
  
    
    public static readonly BetterInstruction Vrcpsh = new (Mnemonic.Vrcpsh);
  
    
    public static readonly BetterInstruction Vreduceph = new (Mnemonic.Vreduceph);
  
    
    public static readonly BetterInstruction Vreducesh = new (Mnemonic.Vreducesh);
  
    
    public static readonly BetterInstruction Vrndscaleph = new (Mnemonic.Vrndscaleph);
  
    
    public static readonly BetterInstruction Vrndscalesh = new (Mnemonic.Vrndscalesh);
  
    
    public static readonly BetterInstruction Vrsqrtph = new (Mnemonic.Vrsqrtph);
  
    
    public static readonly BetterInstruction Vrsqrtsh = new (Mnemonic.Vrsqrtsh);
  
    
    public static readonly BetterInstruction Vscalefph = new (Mnemonic.Vscalefph);
  
    
    public static readonly BetterInstruction Vscalefsh = new (Mnemonic.Vscalefsh);
  
    
    public static readonly BetterInstruction Vsqrtph = new (Mnemonic.Vsqrtph);
  
    
    public static readonly BetterInstruction Vsqrtsh = new (Mnemonic.Vsqrtsh);
  
    
    public static readonly BetterInstruction Vsubph = new (Mnemonic.Vsubph);
  
    
    public static readonly BetterInstruction Vsubsh = new (Mnemonic.Vsubsh);
  
    
    public static readonly BetterInstruction Vucomish = new (Mnemonic.Vucomish);
  
    
    public static readonly BetterInstruction Rdudbg = new (Mnemonic.Rdudbg);
  
    
    public static readonly BetterInstruction Wrudbg = new (Mnemonic.Wrudbg);
  
    
    public static readonly BetterInstruction Clevict0 = new (Mnemonic.Clevict0);
  
    
    public static readonly BetterInstruction Clevict1 = new (Mnemonic.Clevict1);
  
    
    public static readonly BetterInstruction Delay = new (Mnemonic.Delay);
  
    
    public static readonly BetterInstruction Jknzd = new (Mnemonic.Jknzd);
  
    
    public static readonly BetterInstruction Jkzd = new (Mnemonic.Jkzd);
  
    
    public static readonly BetterInstruction Kand = new (Mnemonic.Kand);
  
    
    public static readonly BetterInstruction Kandn = new (Mnemonic.Kandn);
  
    
    public static readonly BetterInstruction Kandnr = new (Mnemonic.Kandnr);
  
    
    public static readonly BetterInstruction Kconcath = new (Mnemonic.Kconcath);
  
    
    public static readonly BetterInstruction Kconcatl = new (Mnemonic.Kconcatl);
  
    
    public static readonly BetterInstruction Kextract = new (Mnemonic.Kextract);
  
    
    public static readonly BetterInstruction Kmerge2l1h = new (Mnemonic.Kmerge2l1h);
  
    
    public static readonly BetterInstruction Kmerge2l1l = new (Mnemonic.Kmerge2l1l);
  
    
    public static readonly BetterInstruction Kmov = new (Mnemonic.Kmov);
  
    
    public static readonly BetterInstruction Knot = new (Mnemonic.Knot);
  
    
    public static readonly BetterInstruction Kor = new (Mnemonic.Kor);
  
    
    public static readonly BetterInstruction Kortest = new (Mnemonic.Kortest);
  
    
    public static readonly BetterInstruction Kxnor = new (Mnemonic.Kxnor);
  
    
    public static readonly BetterInstruction Kxor = new (Mnemonic.Kxor);
  
    
    public static readonly BetterInstruction Spflt = new (Mnemonic.Spflt);
  
    
    public static readonly BetterInstruction Tzcnti = new (Mnemonic.Tzcnti);
  
    
    public static readonly BetterInstruction Vaddnpd = new (Mnemonic.Vaddnpd);
  
    
    public static readonly BetterInstruction Vaddnps = new (Mnemonic.Vaddnps);
  
    
    public static readonly BetterInstruction Vaddsetsps = new (Mnemonic.Vaddsetsps);
  
    
    public static readonly BetterInstruction Vcvtfxpntdq2ps = new (Mnemonic.Vcvtfxpntdq2ps);
  
    
    public static readonly BetterInstruction Vcvtfxpntpd2dq = new (Mnemonic.Vcvtfxpntpd2dq);
  
    
    public static readonly BetterInstruction Vcvtfxpntpd2udq = new (Mnemonic.Vcvtfxpntpd2udq);
  
    
    public static readonly BetterInstruction Vcvtfxpntps2dq = new (Mnemonic.Vcvtfxpntps2dq);
  
    
    public static readonly BetterInstruction Vcvtfxpntps2udq = new (Mnemonic.Vcvtfxpntps2udq);
  
    
    public static readonly BetterInstruction Vcvtfxpntudq2ps = new (Mnemonic.Vcvtfxpntudq2ps);
  
    
    public static readonly BetterInstruction Vexp223ps = new (Mnemonic.Vexp223ps);
  
    
    public static readonly BetterInstruction Vfixupnanpd = new (Mnemonic.Vfixupnanpd);
  
    
    public static readonly BetterInstruction Vfixupnanps = new (Mnemonic.Vfixupnanps);
  
    
    public static readonly BetterInstruction Vfmadd233ps = new (Mnemonic.Vfmadd233ps);
  
    
    public static readonly BetterInstruction Vgatherpf0hintdpd = new (Mnemonic.Vgatherpf0hintdpd);
  
    
    public static readonly BetterInstruction Vgatherpf0hintdps = new (Mnemonic.Vgatherpf0hintdps);
  
    
    public static readonly BetterInstruction Vgmaxabsps = new (Mnemonic.Vgmaxabsps);
  
    
    public static readonly BetterInstruction Vgmaxpd = new (Mnemonic.Vgmaxpd);
  
    
    public static readonly BetterInstruction Vgmaxps = new (Mnemonic.Vgmaxps);
  
    
    public static readonly BetterInstruction Vgminpd = new (Mnemonic.Vgminpd);
  
    
    public static readonly BetterInstruction Vgminps = new (Mnemonic.Vgminps);
  
    
    public static readonly BetterInstruction Vloadunpackhd = new (Mnemonic.Vloadunpackhd);
  
    
    public static readonly BetterInstruction Vloadunpackhpd = new (Mnemonic.Vloadunpackhpd);
  
    
    public static readonly BetterInstruction Vloadunpackhps = new (Mnemonic.Vloadunpackhps);
  
    
    public static readonly BetterInstruction Vloadunpackhq = new (Mnemonic.Vloadunpackhq);
  
    
    public static readonly BetterInstruction Vloadunpackld = new (Mnemonic.Vloadunpackld);
  
    
    public static readonly BetterInstruction Vloadunpacklpd = new (Mnemonic.Vloadunpacklpd);
  
    
    public static readonly BetterInstruction Vloadunpacklps = new (Mnemonic.Vloadunpacklps);
  
    
    public static readonly BetterInstruction Vloadunpacklq = new (Mnemonic.Vloadunpacklq);
  
    
    public static readonly BetterInstruction Vlog2ps = new (Mnemonic.Vlog2ps);
  
    
    public static readonly BetterInstruction Vmovnrapd = new (Mnemonic.Vmovnrapd);
  
    
    public static readonly BetterInstruction Vmovnraps = new (Mnemonic.Vmovnraps);
  
    
    public static readonly BetterInstruction Vmovnrngoapd = new (Mnemonic.Vmovnrngoapd);
  
    
    public static readonly BetterInstruction Vmovnrngoaps = new (Mnemonic.Vmovnrngoaps);
  
    
    public static readonly BetterInstruction Vpackstorehd = new (Mnemonic.Vpackstorehd);
  
    
    public static readonly BetterInstruction Vpackstorehpd = new (Mnemonic.Vpackstorehpd);
  
    
    public static readonly BetterInstruction Vpackstorehps = new (Mnemonic.Vpackstorehps);
  
    
    public static readonly BetterInstruction Vpackstorehq = new (Mnemonic.Vpackstorehq);
  
    
    public static readonly BetterInstruction Vpackstoreld = new (Mnemonic.Vpackstoreld);
  
    
    public static readonly BetterInstruction Vpackstorelpd = new (Mnemonic.Vpackstorelpd);
  
    
    public static readonly BetterInstruction Vpackstorelps = new (Mnemonic.Vpackstorelps);
  
    
    public static readonly BetterInstruction Vpackstorelq = new (Mnemonic.Vpackstorelq);
  
    
    public static readonly BetterInstruction Vpadcd = new (Mnemonic.Vpadcd);
  
    
    public static readonly BetterInstruction Vpaddsetcd = new (Mnemonic.Vpaddsetcd);
  
    
    public static readonly BetterInstruction Vpaddsetsd = new (Mnemonic.Vpaddsetsd);
  
    
    public static readonly BetterInstruction Vpcmpltd = new (Mnemonic.Vpcmpltd);
  
    
    public static readonly BetterInstruction Vpermf32x4 = new (Mnemonic.Vpermf32x4);
  
    
    public static readonly BetterInstruction Vpmadd231d = new (Mnemonic.Vpmadd231d);
  
    
    public static readonly BetterInstruction Vpmadd233d = new (Mnemonic.Vpmadd233d);
  
    
    public static readonly BetterInstruction Vpmulhd = new (Mnemonic.Vpmulhd);
  
    
    public static readonly BetterInstruction Vpmulhud = new (Mnemonic.Vpmulhud);
  
    
    public static readonly BetterInstruction Vprefetch0 = new (Mnemonic.Vprefetch0);
  
    
    public static readonly BetterInstruction Vprefetch1 = new (Mnemonic.Vprefetch1);
  
    
    public static readonly BetterInstruction Vprefetch2 = new (Mnemonic.Vprefetch2);
  
    
    public static readonly BetterInstruction Vprefetche0 = new (Mnemonic.Vprefetche0);
  
    
    public static readonly BetterInstruction Vprefetche1 = new (Mnemonic.Vprefetche1);
  
    
    public static readonly BetterInstruction Vprefetche2 = new (Mnemonic.Vprefetche2);
  
    
    public static readonly BetterInstruction Vprefetchenta = new (Mnemonic.Vprefetchenta);
  
    
    public static readonly BetterInstruction Vprefetchnta = new (Mnemonic.Vprefetchnta);
  
    
    public static readonly BetterInstruction Vpsbbd = new (Mnemonic.Vpsbbd);
  
    
    public static readonly BetterInstruction Vpsbbrd = new (Mnemonic.Vpsbbrd);
  
    
    public static readonly BetterInstruction Vpsubrd = new (Mnemonic.Vpsubrd);
  
    
    public static readonly BetterInstruction Vpsubrsetbd = new (Mnemonic.Vpsubrsetbd);
  
    
    public static readonly BetterInstruction Vpsubsetbd = new (Mnemonic.Vpsubsetbd);
  
    
    public static readonly BetterInstruction Vrcp23ps = new (Mnemonic.Vrcp23ps);
  
    
    public static readonly BetterInstruction Vrndfxpntpd = new (Mnemonic.Vrndfxpntpd);
  
    
    public static readonly BetterInstruction Vrndfxpntps = new (Mnemonic.Vrndfxpntps);
  
    
    public static readonly BetterInstruction Vrsqrt23ps = new (Mnemonic.Vrsqrt23ps);
  
    
    public static readonly BetterInstruction Vscaleps = new (Mnemonic.Vscaleps);
  
    
    public static readonly BetterInstruction Vscatterpf0hintdpd = new (Mnemonic.Vscatterpf0hintdpd);
  
    
    public static readonly BetterInstruction Vscatterpf0hintdps = new (Mnemonic.Vscatterpf0hintdps);
  
    
    public static readonly BetterInstruction Vsubrpd = new (Mnemonic.Vsubrpd);
  
    
    public static readonly BetterInstruction Vsubrps = new (Mnemonic.Vsubrps);
  
    
    }