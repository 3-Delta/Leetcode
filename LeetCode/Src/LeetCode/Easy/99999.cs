using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

/*
    https://mp.weixin.qq.com/s/LccoG6IB3ZewNv9qzv_6KQ
    s = "abc", t = "ahbgdc", return true.
    s = "axc", t = "ahbgdc", return false.
 */
public static class LC_99999
{
    public static void Func()
    {
        
    }
    public static bool IsSubSequence(string[] ss, string t)
    {
        foreach (string s in ss)
        {
            if (!IsSubSequence(s, t))
            {
                return false;
            }
        }
        return true;
    }
    public static bool IsSubSequence(string s, string t)
    {
        int i = 0, j = 0;
        while (i < s.Length && j < t.Length)
        {
            if (s[i] == t[j])
            {
                i++;
            }
            j++;
        }
        return i == s.Length;
    }
}