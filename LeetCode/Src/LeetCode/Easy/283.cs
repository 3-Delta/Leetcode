using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_283
{
    public static void Func()
    {
    }

    public static void MoveZeroes(int[] nums)
    {
        int k = 0;
        for (int i = 0; i < nums.Length; ++i)
        {
            if (nums[i] != 0)
            {
                nums[k++] = nums[i];
            }
        }
        for (; k < nums.Length; ++k)
        {
            nums[k] = 0;
        }
    }
}