using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_9
{
    public static void Func()
    {
        Console.WriteLine(IsHui(123));
    }
    private static bool IsHui(int x)
    {
        bool ret = false;
        if (x < 0) { ret = false; }
        else if (x == 0) { ret = true; }
        else
        {
            ret = Reverse(x) == x;
        }
        return ret;
    }
    public static int Reverse(int x)
    {
        return LC_7.Reverse(x);
    }
}