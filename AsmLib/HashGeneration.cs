using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System;

namespace AsmLib;

public static class HashGeneration
{
    private static readonly MD5 Md5 = MD5.Create();
    private static readonly Encoding Encoding = Encoding.UTF8;

#if ASMLIB
    public static string ToHash(IEnumerable<AssemblyData> data)
    {
        string asmString = string.Concat(data).ToLower();
        byte[] asmBytes = Encoding.GetBytes(asmString);
        byte[] asmHashedBytes = Md5.ComputeHash(asmBytes);
        
        StringBuilder asmSb = new();
        foreach (byte t in asmHashedBytes)
        {
            asmSb.Append(t.ToString("X2"));
        }
        return asmSb.ToString();
    }
#endif

    public static string ToHash(string data)
    {
#if ASMLIB
        string[] asmTokens = data.Split(new[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        string asmString = string.Concat(asmTokens).ToLower();
        byte[] asmBytes = Encoding.GetBytes(asmString);
#elif ASMGENERATOR
        byte[] asmBytes = Encoding.GetBytes(data);
#endif
        byte[] asmHashedBytes = Md5.ComputeHash(asmBytes);

        StringBuilder asmSb = new();
        foreach (byte t in asmHashedBytes)
        {
            asmSb.Append(t.ToString("X2"));
        }
        return asmSb.ToString();
    }
}