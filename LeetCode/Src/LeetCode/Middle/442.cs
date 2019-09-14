using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_442
{
    public static void Func()
    {
        
    }

    public static IList<int> FindDuplicates(int[] nums)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for (int i = 0, count = nums.Length; i < count; ++i)
        {
            if (!dict.ContainsKey(nums[i]))
            {
                dict.Add(nums[i], 0);
            }
            ++dict[nums[i]];
        }
        List<int> ret = new List<int>();
        foreach (var kvp in dict)
        {
            if (kvp.Value >= 2)
            {
                ret.Add(kvp.Key);
            }
        }
        return ret;
    }

    /*
     这个题目开头暗示了n的范围，所以可以加以利用，将元素转换成数组的索引并对应的将该处的元素乘以-1；
     若数组索引对应元素的位置本身就是负数，则表示已经对应过一次；在结果列表里增加该索引的正数就行；
     */
    public static IList<int> FindDuplicates2(int[] nums)
    {
        List<int> ret = new List<int>();
        return ret;
    }
}