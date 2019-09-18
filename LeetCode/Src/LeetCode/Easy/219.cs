using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_219
{
    public static void Func()
    {
        Console.WriteLine(ContainsNearbyDuplicate(new int[] {1, 2, 3, 1 }, 3));
    }
    public static bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        bool ret = false;
        HashSet<int> set = new HashSet<int>();
        for (int i = 0; i < nums.Length; ++i)
        {
            if (set.Contains(nums[i]))
            {
                ret = true;
                break;
            }
            else
            {
                set.Add(nums[i]);
                if (set.Count > k)
                {
                    // 始终维持一个maxLength为k的set,如果超出，则从头部开始删除。
                    set.Remove(nums[i - k]);
                }
            }
        }
        return ret;
    }
}