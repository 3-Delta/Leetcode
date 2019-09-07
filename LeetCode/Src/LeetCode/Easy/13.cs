using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_13
{
    public static void Func()
    {
        //Console.WriteLine(RomanToInt("IV"));
        Console.WriteLine(RomanToInt("MCMXCIV"));
    }

    /*
        首先将所有的组合可能性列出并添加到哈希表中
        然后对字符串进行遍历，由于组合只有两种，一种是 1 个字符，一种是 2 个字符，其中 2 个字符优先于 1 个字符
        先判断两个字符的组合在哈希表中是否存在，存在则将值取出加到结果 ans 中，并向后移2个字符。不存在则将判断当前 1 个字符是否存在，存在则将值取出加到结果 ans 中，并向后移 1 个字符
        遍历结束返回结果 ans
     */
    public static int RomanToInt(string s)
    {
        Dictionary<string, int> map = new Dictionary<string, int>();
        map.Add("I", 1);
        map.Add("IV", 4);
        map.Add("V", 5);
        map.Add("IX", 9);
        map.Add("X", 10);
        map.Add("XL", 40);
        map.Add("L", 50);
        map.Add("XC", 90);
        map.Add("C", 100);
        map.Add("CD", 400);
        map.Add("D", 500);
        map.Add("CM", 900);
        map.Add("M", 1000);

        int i = 0;
        int sum = 0;
        while (i < s.Length)
        {
            // 需要考虑到：连续两个不匹配【n,n+1】，那么还可能[n+1,n+2]是匹配的。而不能直接[n+2, n+3]
            if (i + 1 < s.Length && map.ContainsKey(s.Substring(i, 2)))
            {
                sum += map[s.Substring(i, 2)];
                i += 2;
            }
            else
            {
                sum += map[s[i].ToString()];
                ++i;
            }
        }

        return sum;
    }
}