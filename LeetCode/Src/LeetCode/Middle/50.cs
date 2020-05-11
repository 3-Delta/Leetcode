using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

// https://leetcode-cn.com/problems/powx-n/solution/powx-n-by-leetcode-solution/
public static class LC_50
{
    public static void Func()
    {
    }

    public static double MyPow(double x, int n)
    {
        // 注意n可能超出int的最大值
        long abs = n;
        return abs >= 0 ? Quick(x, abs) : 1.0 / Quick(x, -abs);
    }
    // 按照循环的实现方式容易计算超时
    public static double Quick(double x, long n)
    {
        double ret = 1;
        double t = x;
        while (n > 0)
        {
            // 奇数
            if ((n & 1) == 1)
            {
                ret *= t;
            }

            t *= t;
            n >>= 1;
        }
        return ret;
    }
}