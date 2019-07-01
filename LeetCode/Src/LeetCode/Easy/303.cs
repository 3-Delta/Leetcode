using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://leetcode-cn.com/problems/range-sum-query-immutable/
// 使用查表方式解决问题
public static class LC_303
{
    private static List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6, 8 };
    private static List<int> sum = new List<int>();

    private static void BuildSumList()
    {
        sum.Clear();
        int tSum = 0;
        for (int i = 0; i < nums.Count; ++i)
        {
            tSum += nums[i];
            sum.Add(tSum);
        }
    }
    public static bool SumRange(int i, int j, out int retValue)
    {
        retValue = 0;
        bool ret = (0 <= i && i <= j && j < nums.Count);
        if (ret)
        {
            retValue = sum[j] - sum[i];
        }
        return ret;
    }
    public static void Func()
    {
        // 构建一次
        BuildSumList();

        int result;
        SumRange(3, 5, out result);
        Console.WriteLine(result);
    }
}