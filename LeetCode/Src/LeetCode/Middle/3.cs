using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_3
{
    public static void Func()
    {
        
    }

    public static int LengthOfLongestSubstring(string s)
    {
        HashSet<char> hash = new HashSet<char>();
        int max = 0;
        for (int i = 0; i < s.Length; ++i)
        {
            int count = 0;
            hash.Clear();
            for (int j = i; j < s.Length; ++j)
            {
                if (!hash.Contains(s[j]))
                {
                    hash.Add(s[j]);
                    ++count;
                }
                else
                {
                    break;
                }
            }

            if (count > max)
            {
                max = count;
            }
        }
        return max;
    }
}