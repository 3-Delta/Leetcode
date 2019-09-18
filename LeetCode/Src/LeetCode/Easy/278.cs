using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_278
{
    public static void Func()
    {
    }

    public static int FirstBadVersion(int n)
    {
        int left = 1;
        int right = n;
        while (left <= right)
        {
            // 注意这里越界条件
            int mid = left + (right - left) / 2;
            if (IsBadVersion(mid))
            {
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }

        return left;
    }
    public static bool IsBadVersion(int version) { return false; }
}