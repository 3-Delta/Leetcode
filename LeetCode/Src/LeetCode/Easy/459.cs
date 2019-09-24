using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_459
{
    public static void Func()
    {
        RepeatedSubstringPattern("abab");
    }
    public static bool RepeatedSubstringPattern(string s)
    {
        string ss = s + s;
        return ss.Substring(1, s.Length * 2 - 2).Contains(s);
    }
}