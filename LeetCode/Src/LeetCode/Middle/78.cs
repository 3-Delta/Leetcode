using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_78
{
    public static void Func()
    {
        Subsets(new List<int>() { 1, 2, 3});

        List<List<int>> res = new List<List<int>>();
        res.Add(new List<int>());
        Generate(0, new List<int>() { 1, 2, 3 }, new List<int>(), res);

        res = new List<List<int>>();
        Generate2(0, new List<int>() { 1, 2, 3 }, new List<int>(), res);
    }

    public static List<List<int>> Subsets(List<int> nums)
    {
        // 思路就是用二进制bit位去逐个比较
        int length = nums.Count;
        int maxNum = 1 << length;
        List<List<int>> res = new List<List<int>>();
        for (int i = 0; i < maxNum; ++i)
        {
            List<int> ls = new List<int>();
            for (int j = 0; j < length; ++j)
            {
                if ((i & (1 << j)) != 0)
                {
                    ls.Add(nums[j]);
                }
            }
            res.Add(ls);
        }
        return res;
    }
    private static void Generate(int start, List<int> nums, List<int> list, List<List<int>> res)
    {
        //终止条件
        if (start >= nums.Count) { return; }
        //选择放入次数
        list.Add(nums[start]);
        // 必须new
        res.Add(new List<int>(list));
        Generate(start + 1, nums, list, res);
        list.RemoveAt(list.Count - 1);
        Generate(start + 1, nums, list, res);
    }
    // 迭代最佳理解方式
    private static void Generate2(int start, List<int> nums, List<int> list, List<List<int>> res)
    {
        // 必须new
        res.Add(new List<int>(list));
        for (int i = start; i < nums.Count; ++i)
        {
            list.Add(nums[i]);
            Generate2(i + 1, nums, list, res);
            list.RemoveAt(list.Count - 1);
        }
    }
}