using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_438
{
    public static void Func()
    {
        IList<int> ls = FindAnagrams("cbaebabacd", "abs");
    }

    public static IList<int> FindAnagrams(string s, string p)
    {
        List<int> ls = new List<int>();
        char[] hash = new char[26];
        if (p != null && s != null && p.Length <= s.Length)
        {
            char[] arr = s.ToArray<char>();
            char[] brr = p.ToArray<char>();

            // hash匹配计算
        }
        return ls;
    }
}