using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_67
{
    public static void Func()
    {
        string a = "11";
        string b = "1";

        Console.WriteLine(AddBinary(a, b));
    }
    private static string AddBinary(string a, string b)
    {
        List<int> ls = new List<int>();
        int i = a.Length - 1;
        int j = b.Length - 1;
        int jin = 0;
        int t;
        while (i >= 0 && j >= 0)
        {
            t = AtoI(a[i]) + AtoI(b[j]) + jin;
            jin = t / 2;
            ls.Add(t % 2);
            --i;
            --j;
        }
        while (i >= 0)
        {
            t = AtoI(a[i]) + jin;
            jin = t / 2;
            ls.Add(t % 2);
            --i;
        }
        while (j >= 0)
        {
            t = AtoI(b[j]) + jin;
            jin = t / 2;
            ls.Add(t % 2);
            --j;
        }
        if (jin != 0)
        {
            ls.Add(jin);
        }
        ls.Reverse();
        string s = "";
        foreach (int ii in ls)
        {
            s += ii;
        }
        return s;
    }

    private static int AtoI(char c)
    {
        return c - '0';
    }
}