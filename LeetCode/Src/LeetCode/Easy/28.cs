using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class Le_28
{
    public static void Func()
    {
        GetString("hello", "ll");
    }
    private static void GetString(string left, string right)
    {
        if (left != null && right != null && left.Length >= right.Length)
        {
            //left = left.Replace(right, "");

            for (int i = 0; i < left.Length; ++i)
            {
                int j = 0;
                while (right[j] == left[i])
                {

                }
                if (j >= right.Length)
                {
                    Change(left, right, i);
                    return;
                }
            }
        }
    }
}