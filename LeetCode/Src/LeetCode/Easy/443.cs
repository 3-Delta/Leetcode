using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_443
{
    public static void Func()
    {
        Console.WriteLine(Compress("abbbcccdd".ToArray<char>()));
    }

    public static int Compress(char[] chars)
    {
        char guard = chars[0];
        int count = 1;
        int realLength = 1;
        for (int i = 1; i < chars.Length; ++i)
        {
            if (chars[i] == guard)
            {
                ++count;
            }
            else
            {
                guard = chars[i];
                if (count == 1)
                {
                    chars[realLength++] = guard;
                }
                else if (count > 1)
                {
                    string str = count.ToString();
                    for (int j = 0; j < str.Length; ++j)
                    {
                        chars[realLength++] = str[j];
                    }
                    chars[realLength++] = guard;
                }

                count = 1;
            }
        }

        if (count > 1)
        {
            string str = count.ToString();
            for (int j = 0; j < str.Length; ++j)
            {
                chars[realLength++] = str[j];
            }
        }

        return realLength;
    }
}