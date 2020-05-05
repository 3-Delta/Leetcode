using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_300
{
    public static void Func()
    {
        //LengthOfLIS(new int[] {-2, -1});
        LengthOfLIS(new int[] { 10, 9, 2, 5, 3, 4 });
    }

    // 最长连续递增子序列
    public static int LengthOfLIS_1(int[] nums)
    {
        int max = 1;
        int count = 1;
        for (int i = 1, length = nums.Length; i < length; ++i)
        {
            // 摩尔投票法
            if (nums[i] - nums[i - 1] >= 0)
            {
                ++count;
            }
            else
            {
                count = 1;
            }
            max = Math.Max(count, max);
        }
        return max;
    }

    public static int LengthOfLIS(int[] nums)
    {
        /*
         * // 错误做法
            int length = nums.Length;
            if (length <= 0) { return 0; }

            int max = 0;
            for (int i = 0; i < length; ++i)
            {
                int lastMax = nums[i];
                int count = 1;
                for (int j = i + 1; j < length; ++j)
                {
                    if (nums[j] >= lastMax)
                    {
                        ++count;
                        lastMax = nums[j];
                    }
                }

                max = Math.Max(max, count);
            }
            return max;
         */

        int max = 0;
        return max;
    }
}