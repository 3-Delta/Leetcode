using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

/*
 * blic boolean CheckPermutation(String s1, String s2) {
        if (s1 == null || s2 == null) {
            return false;
        }
        int length = s1.length();
        if (length != s2.length()) {
            return false;
        }
        int result = 0;
        char[] s1Char = s1.toCharArray();
        char[] s2Char = s2.toCharArray();
        int s1Sum = 0;
        int s2Sum = 0;
        for (int i = 0; i < s1Char.length; i++) {
            result = result ^ s1Char[i] ^ s2Char[i];
            s1Sum += s1Char[i];
            s2Sum += s2Char[i];
        }

作者：peng-187
链接：https://leetcode-cn.com/problems/check-permutation-lcci/solution/yi-huo-yun-suan-shi-jian-fu-za-du-onkong-jian-fu-z/
来源：力扣（LeetCode）
著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。
 */
public static class LC_GoldBook_1_2
{
    // 异或 （实现不了）
    public static bool Func()
    {
        return CheckPermutation("leetcode", "sdf");
    }

    public static bool CheckPermutation(string s1, string s2)
    {
        if (s1.Length != s2.Length) { return false; }
        Dictionary<char, int> hash = new Dictionary<char, int>();

        foreach (char c in s1)
        {
            if (!hash.ContainsKey(c))
            {
                hash.Add(c, 1);
            }
            else
            {
                ++hash[c];
            }
        }
        foreach (char c in s2)
        {
            if (!hash.ContainsKey(c))
            {
                return false;
            }
            else
            {
                --hash[c];
                if (hash[c] <= 0)
                {
                    hash.Remove(c);
                }
            }
        }

        return true;
    }
}