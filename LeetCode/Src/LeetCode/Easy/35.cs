using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_35
{
    public static void Func()
    {
    }
    public static int SearchInsert(int[] nums, int target)
    {
        int pos = 0;
        int left = 0, right = nums.Length - 1;
        while (left <= right) // <=
        {
            int mid = (left + right) / 2;
            if (nums[mid] == target)
            {
                pos = mid;
                break;
            }
            else if (nums[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        if (left > right)
        {
            // right + 1
            pos = right + 1;
        }
        return pos;
    }
}