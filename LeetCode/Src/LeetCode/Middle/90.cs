using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_90
{
    public static void Func()
    {
        Subsets(new List<int>() { 1, 2, 2});
    }

    // 确保nums是排序的
    public static List<List<int>> Subsets(List<int> nums)
    {
        List<List<int>> res = new List<List<int>>();
        GetAns(nums, 0, new List<int>(), res);
        return res;
    }

    // 重复元素求子集
    private static void GetAns(List<int> nums, int start, List<int> temp, List<List<int>> res)
    {
        // 必须new
        res.Add(new List<int>(temp));
        for (int i = start; i < nums.Count; ++i)
        {
            //和上个数字相等就跳过
            if (i > start && nums[i] == nums[i - 1])
            {
                continue;
            }
            temp.Add(nums[i]);
            GetAns(nums, i + 1, temp, res);
            temp.Remove(temp.Count - 1);
        }
    }
}