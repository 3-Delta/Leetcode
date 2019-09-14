using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_387
{
    public static void Func()
    {
    }

    public static int FirstUniqChar(string s)
    {
        int index = -1;
        Dictionary<char, int> dict = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; ++i)
        {
            if (!dict.ContainsKey(s[i]))
            {
                dict.Add(s[i], 0);
            }
            ++dict[s[i]];
        }
        for (int i = 0; i < s.Length; ++i)
        {
            if (dict[s[i]] <= 1)
            {
                index = i;
                break;
            }
        }
        return index;
    }
}