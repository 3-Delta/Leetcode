using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class _34
{
    public static void Func()
    {
        Ugly2(1500);
    }

    public static bool IsUgly(int n)
    {
        while (n % 3 == 0)
        {
            n /= 3;
        }
        while (n % 5 == 0)
        {
            n /= 5;
        }
        while (n % 7 == 0)
        {
            n /= 7;
        }
        return n == 1;
    }

    public static void Ugly2(int n)
    {
        List<int> ugs = new List<int>() { 1};
        int index3 = 0;
        int index5 = 0;
        int index7 = 0;

        int nextUglyIndex = 1;
        while (n > nextUglyIndex)
        {
            nextUglyIndex++;
            int index = 0;
            int max = Min(ref index, index3 * 3, index5 * 5, index7 * 7);
            ugs.Add(max);

            // 错误做法
            //if (index == 0) { ++index3; }
            //if (index == 1) { ++index5; }
            //if (index == 2) { ++index7; }

            // 正确做法
            while (ugs[nextUglyIndex - 1] >= index3 * 3)
            {
                ++index3;
            }
            while (ugs[nextUglyIndex - 1] >= index5 * 5)
            {
                ++index5;
            }
            while (ugs[nextUglyIndex - 1] >= index7 * 5)
            {
                ++index7;
            }
        }

        Console.WriteLine(ugs[n - 1]);
    }

    public static int Min(ref int index, params int[] nums)
    {
        int ret = nums[0];
        for (int i = 1; i < nums.Length; ++i)
        {
            if (nums[i] < ret)
            {
                ret = nums[i];
                index = i;
            }
        }
        return ret;
    }
}