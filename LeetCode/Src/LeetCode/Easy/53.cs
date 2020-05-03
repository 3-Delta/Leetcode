using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_53
{
    // 53. 最大子序和
    public static void Func()
    {
        MaxSubArray(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 });
    }

    public static int MaxSubArray(int[] nums)
    {
        // 摩尔排序法
        int sum = nums[0];
        int max = nums[0];
        for (int i = 1; i < nums.Length; ++i)
        {
            /* 错误做法
            sum += nums[i];
            if (sum <= 0)
            {
                sum = nums[i];
            }
            */
            if (sum <= 0)
            {
                sum = nums[i];
            }
            else
            {
                sum += nums[i];
            }

            if (sum > max)
            {
                max = sum;
            }
        }
        return max;
    }
}