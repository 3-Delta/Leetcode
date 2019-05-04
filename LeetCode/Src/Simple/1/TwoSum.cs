using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class TwoSum
{
    // 穷举法
    // 时间 O(n^2)
    // 空间 O(1)
    public static bool Exec1(List<int> nums, int target, out Tuple<int, int> tuple)
    {
        bool ret = false;
        tuple = new Tuple<int, int>(0, 0);
        for (int i = 0, count = nums.Count; i < count - 1; ++i)
        {
            for (int j = i + 1; j < count; ++j)
            {
                int sum = nums[i] + nums[j];
                if (sum == target)
                {
                    tuple = new Tuple<int, int>(i, j);
                    ret = true;
                    return ret;
                }
            }
        }
        return ret;
    }

    // bitmap
    // 时间 O(n)
    // 空间 O(n)
    public static bool Exec2(List<int> nums, int target, out Tuple<int, int> tuple)
    {
        bool ret = false;
        tuple = new Tuple<int, int>(0, 0);
        // value:index
        Dictionary<int, int> hash = new Dictionary<int, int>();
        for (int i = 0, count = nums.Count; i < count; ++i)
        {
            int diff = target - nums[i];
            if (hash.ContainsKey(diff))
            {
                // 预防措施，防止出现{1， 2， 3} -》 4，结果是2 + 2
                //if (hash[diff] != i)
                {
                    ret = true;
                    tuple = new Tuple<int, int>(i, hash[diff]);
                    break;
                }
            }
            else
            {
                hash.Add(nums[i], i);
            }
        }
        return ret;
    }

    // 输入是一个排序数组
    // bitmap
    // 时间 O(n) 而不是O(lg n)
    // 空间 O(1)
    public static bool Exec3(List<int> nums, int target, out Tuple<int, int> tuple)
    {
        bool ret = false;
        tuple = new Tuple<int, int>(0, 0);
        int i = 0, j = nums.Count - 1;
        while (i < j)
        {
            int sum = nums[i] + nums[j];
            if (sum == target)
            {
                ret = true;
                tuple = new Tuple<int, int>(i, j);
                break;
            }
            else if (sum > target)
            {
                --j;
            }
            else
            {
                ++i;
            }
        }
        return ret;
    }

    public static void Func()
    {
        List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6, 8};
        Tuple<int, int> tuple;
        if (Exec1(nums, 7, out tuple))
        {
            Console.WriteLine(tuple.Item1 + "  " + tuple.Item2);
        }
        Console.WriteLine("Over");
    }
}