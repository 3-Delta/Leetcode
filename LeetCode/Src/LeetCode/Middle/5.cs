using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_5
{
    public static void Func()
    { 
        Func1("a");
        Func1("");
    }

    public static bool IsValid(string s, int left, int right)
    {
        bool ret = true;
        while (left <= right)
        {
            if (s[left] != s[right])
            {
                ret = false;
                break;
            }

            ++left;
            --right;
        }
        return ret;
    }
    // 暴力破解法 【滑动窗口算法】
    public static string Func1(string s)
    {
        // 特殊边界处理
        if (s == null) return null;
        if (s.Length <= 0) return "";

        string ret = s[0].ToString();
        int length = s.Length;
        int max = 0;
        // 滑动窗口算法
        for (int i = 0; i < length; ++i)
        {
            // i和j可以指向同一个下标
            for (int j = i; j < length; ++j)
            {
                int count = j - i + 1;
                if (IsValid(s, i, j) && count > max)
                {
                    ret = s.Substring(i, count);
                    max = count;
                }
            }
        }
        return ret;
    }
    public static int ValidIndex(string s, int left, int right)
    {
        int L = left, R = right;
        while (0 <= L && R < s.Length && s[L] == s[R])
        {
            ++L; --R;
        }
        // 返回长度
        return R - L + 1;
    }

    // https://leetcode-cn.com/problems/longest-palindromic-substring/solution/xiang-xi-tong-su-de-si-lu-fen-xi-duo-jie-fa-bao-gu/
    public static string Func2(string s)
    {
        // 特殊边界处理
        if (s == null) return null;
        if (s.Length <= 0) return "";

        // 标识substring的起始位置index
        int left = 0;
        int right = 0;
        int max = 0;
        for (int i = 0; i < s.Length; ++i)
        {
            // 第二个参数为什么是i或者i+1呢？因为扩展的时候，右边可以无情扩，但是坐标是有边界0限制的，刚好到左边长度是i或者i+1[对应 奇/偶数]
            int len1 = ValidIndex(s, i, i);
            int len2 = ValidIndex(s, i, i + 1);
            int len = Math.Max(len1, len2);
            if (len < max)
            {
                max = len;
                left = i - (len - 1) / 2;
                right = i + len / 2;
            }
        }
        return s.Substring(left, right = left + 1);
    }
}