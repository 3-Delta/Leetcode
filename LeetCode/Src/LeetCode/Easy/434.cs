using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_434
{
    public static void Func()
    {
    }
    public static int CountSegments(string s)
    {
        s = s.Trim();
        // 必须特判
        if (s == "") { return 0; }

        int count = 0;
        bool isWord = true;
        for (int i = 0; i < s.Length; ++i)
        {
            if (isWord)
            {
                if (s[i] == ' ')
                {
                    isWord = false;
                    ++count;
                }
            }
            else
            {
                if (s[i] != ' ')
                {
                    isWord = true;
                }
            }
        }

        if (isWord) { count++; }
        return count;
    }
}