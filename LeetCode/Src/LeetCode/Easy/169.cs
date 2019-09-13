using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_169
{
    public static void Func()
    {
        List<int> ls = new List<int>() { 2, 2, 1, 1, 1, 2, 2 };
        int zhong = GetZhong(ls);
        Console.WriteLine(zhong);
        zhong = GetZhongByHash(ls);
        Console.WriteLine(zhong);
    }

    private static int GetZhong(List<int> nums)
    {
        // 摩尔投票法
        int target = nums[0];
        int count = 1;
        for (int i = 1; i < nums.Count; i++)
        {
            if (nums[i] != target)
            {
                count--;
                if (count == 0)
                {
                    target = nums[i];
                    count = 1;
                }
            }
            else { count++; }
        }
        return target;
    }
    private static int GetZhongByHash(List<int> nums)
    {
        int ret = -1;
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Count; i++)
        {
            if (!dict.ContainsKey(nums[i]))
            {
                dict.Add(nums[i], 0);
            }
            dict[nums[i]]++;
        }
        int max = -1;
        foreach (var kvp in dict)
        {
            if (kvp.Value > max)
            {
                max = kvp.Value;
                ret = kvp.Key;
            }
        }
        return ret;
    }
}