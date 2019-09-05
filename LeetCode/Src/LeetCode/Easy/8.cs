using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_8
{
    public static void Func()
    {
        Console.WriteLine(Atoi("  -123"));
    }
    private static int Atoi(string str)
    {
        return int.Parse(str);
    }
}