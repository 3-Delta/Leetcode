using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_448
{
    public static void Func()
    {
        FindDisappearedNumbers(new int[] { 4, 3, 2, 7, 8, 2, 3, 1 });
    }

    public static IList<int> FindDisappearedNumbers(int[] nums)
    {
        // 注意+1
        List<int> ls = new List<int>(nums.Length + 1);
        List<int> ret = new List<int>();
        for (int i = 0; i <= nums.Length; ++i)
        {
            ls.Add(0);
        }
        for (int i = 0; i < nums.Length; ++i)
        {
            ls[nums[i]]++;
        }
        // 注意不是>=0
        for (int i = ls.Count - 1; i > 0; --i)
        {
            if (ls[i] <= 0)
            {
                ret.Add(i);
            }
        }
        return ret;
    }
}