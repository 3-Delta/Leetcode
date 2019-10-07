using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_541
{
    public static void Func()
    {
        Console.WriteLine(ReverseStr("hyzqyljrnigxvdtneasepfahmtyhlohwxmkqcdfehybknvdmfrfvtbsovjbdhevlfxpdaovjgunjqlimjkfnqcqnajmebeddqsgl", 39));
    }

    public static string ReverseStr(string s, int k)
    {
        char[] chars = s.ToCharArray();
        int left = 0;
        int mid = left + k - 1;
        int right = mid + k;
        if (k >= s.Length)
        {
            Reverser(chars, left, s.Length - 1);
        }
        else
        {
            while (true)
            {
                if (mid < s.Length)
                {
                    Reverser(chars, left, mid);

                    left = right + 1;
                    mid = left + k - 1;
                    right = mid + k;
                }
                else if (s.Length < mid)
                {
                    Reverser(chars, left, s.Length - 1);
                    break;
                }
                else if (right >= s.Length)
                {
                    break;
                }
            }
        }
        return new String(chars);
    }
    public static void Reverser(char[] chars, int left, int right)
    {
        while (left < right)
        {
            char c = chars[left];
            chars[left] = chars[right];
            chars[right] = c;

            ++left;
            --right;
        }
    }
}