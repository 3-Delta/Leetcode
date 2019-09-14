using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_557
{
    public static void Func()
    {
    }
    public static string ReverseWords(string s)
    {
        s = s.Trim();
        if (s == "") { return s; }
        if (s.Length < 2) { return s; }

        char[] chars = s.ToArray<char>();
        int left = 0;
        int i;
        for (i = 0; i < s.Length; ++i)
        {
            if (chars[i] == ' ')
            {
                Swap(left, i - 1, chars);
                left = i + 1;
            }
        }

        Swap(left, i - 1, chars);
        return new string(chars);
    }

    public static void Swap(int front, int tail, char[] str)
    {
        while (front < tail)
        {
            str[front] ^= str[tail];
            str[tail] ^= str[front];
            str[front++] ^= str[tail--];
        }
    }
}