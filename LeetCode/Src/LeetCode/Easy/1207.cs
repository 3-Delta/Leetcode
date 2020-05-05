using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_1207
{
    public static void Func()
    {
    }
    public static bool UniqueOccurrences(int[] arr)
    {
        int[] hash = new int[2001];
        foreach (var i in arr)
        {
            ++hash[i + 1000];
        }

        // 定义域【0， 2001】，值域【0， 1001】
        bool[] set = new bool[1001];
        foreach (var i in hash)
        {
            // has existed
            if (i > 0 && set[i])
            {
                return false;
            }
            else
            {
                set[i] = true;
            }
        }
        return true;
    }
}