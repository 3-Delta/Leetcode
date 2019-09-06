using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_27
{
    public static void Func()
    {
        
    }
    public static int RemoveElement(int[] nums, int val)
    {
        int i = 0;
        int j = nums.Length - 1;
        while (i <= j)
        {
            if (nums[i] == val)
            {
                int t = nums[i];
                nums[i] = nums[j];
                nums[j] = t;
                --j;
            }
            else
            {
                ++i;
            }
        }
        return j + 1;
    }
}