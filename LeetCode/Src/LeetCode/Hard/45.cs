using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://leetcode-cn.com/problems/jump-game-ii/solution/45-by-ikaruga/
public static class LC_45
{
    public static void Func()
    {
        Jump(new int[] { 2, 3, 1, 1, 4});
    }

    public static int Jump1(int[] nums)
    {
        int count = 0;
        int start = 0;
        int end = 1;
        while (end < nums.Length)
        {
            int maxPos = 0;
            for (int i = start; i < end; i++)
            {
                // 能跳到最远的距离
                int nextIndex = nums[i] + i;
                maxPos = Math.Max(maxPos, nextIndex);
            }
            start = end;      // 下一次起跳点范围开始的格子
            end = maxPos + 1; // 下一次起跳点范围结束的格子
            count++;            // 跳跃次数
        }
        return count;
    }
    public static int Jump(int[] nums)
    {
        int count = 0;
        int endPos = 0;
        int maxPos = 0;
        for (int i = 0, length = nums.Length - 1; i < length; ++i)
        {
            int nextIndex = nums[i] + i;
            // 逐步模拟计算得到maxPos
            maxPos = Math.Max(nextIndex, maxPos);
            if (maxPos >= length)
            {
                ++count;
                break;
            }
            else if (i == endPos)
            {
                endPos = maxPos;
                count++;
            }
        }
        return count;
    }
}
