using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_405
{
    public static void Func()
    {
        char[] chars = new char[]{ '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f'};

        Console.WriteLine(ToHex(26, chars));
    }
    public static string ToHex(int num, char[] chars)
    {
        //string ret = "";
        //while (num != 0)
        //{
        //    ret += chars[num % 16];
        //    num = num / 16;
        //}
        //return ret.Reverse();
        return null;
    }
}