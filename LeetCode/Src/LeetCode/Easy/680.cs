using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_680
{
    public static void Func()
    {
        
    }
    public static bool ValidPalindrome(string s)
    {
        for (int i = 0, j = s.Length - 1; i < j; ++i, --j)
        {
            if (s[i] != s[j])
            {
                return (Judge(s, i + 1, j) || Judge(s, i, j - 1));
            }
        }
        return true;
    }
    private static bool Judge(string str, int i, int j)
    {
        while (i < j)
        {
            if (str[i++] != str[j--])
            {
                return false;
            }
        }
        return true;
    }
}