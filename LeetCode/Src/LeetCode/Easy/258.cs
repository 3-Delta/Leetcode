using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_258
{
    public static void Func()
    {
    }

    public static int AddDigits(int num)
    {
        if (num <= 9) { return num; }
        else
        {
            int sum = 0;
            while (num > 0) // 注意这里条件
            {
                sum += num % 10;
                num /= 10;
            }

            return AddDigits(sum);
        }
    }
}