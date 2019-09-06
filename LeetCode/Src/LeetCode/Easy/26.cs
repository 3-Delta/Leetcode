using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_26
{
    public static void Func()
    {
        
    }
    public static int RemoveDuplicates(int[] nums)
    {
        // 有序数组的Unique,相同的元素在一堆
        // 关键点：
        // 1: 逆序
        // 2: 后面向前复制
        // 3: 时刻修改guardIndex
        int length = nums.Length;
        int guardIndex = length - 1;
        for (int i = nums.Length - 2; i >= 0; --i)
        {
            if (nums[i] == nums[guardIndex])
            {
                for (int j = i + 1; j < length; ++j)
                {
                    nums[j - 1] = nums[j];
                }
                --length;
            }
            guardIndex = i;
        }
        return length;
    }
}