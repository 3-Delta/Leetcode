using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_290
{
    public static void Func()
    {
        Console.WriteLine(WordPattern("abba", "dog cat cat dog"));
    }

    public static bool WordPattern(string pattern, string str)
    {
        bool ret = true;
        string[] segments = str.Split(' ');
        if (segments.Length != pattern.Length)
        {
            ret = false;
        }
        else
        {
            Dictionary<char, string> map = new Dictionary<char, string>();
            for (int i = 0; i < pattern.Length; ++i)
            {
                if (!map.ContainsKey(pattern[i]))
                {
                    // 没有隐射的时候value已经被使用了
                    if (map.ContainsValue(segments[i]))
                    {
                        ret = false;
                        break;
                    }
                    map.Add(pattern[i], segments[i]);
                }
                else
                {
                    if (!map[pattern[i]].Equals(segments[i]))
                    {
                        ret = false;
                        break;
                    }
                }
            }
        }
        return ret;
    }
}