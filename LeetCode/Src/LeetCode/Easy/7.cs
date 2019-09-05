using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_7
{
    public static void Func()
    {
        Console.WriteLine(Reverse(123));
    }
    public static int Reverse(int x)
    {
        int ret = 0;
        int sign = x > 0 ? 1 : -1;
        x = Math.Abs(x);
        try
        {
            while (x > 0)
            {
                ret = ret * 10 + x % 10;
                x /= 10;
            }
        }
        // 移除使用异常接收
        catch (Exception)
        {
            ret = 0;
        }
        return ret * sign;
    }
}