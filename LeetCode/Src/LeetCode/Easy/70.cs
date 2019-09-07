using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_70
{
    public static void Func()
    {
    }
    public static int climbStairs(int n)
    {
        if (n == 1)
        {
            return 1;
        }
        int t;
        int left = 1;
        int right = 2;
        for (int i = 3; i <= n; i++)
        {
            t = left + right;
            left = right;
            right = t;
        }
        return right;
    }
}