using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_633
{
    public static void Func()
    {
        
    }

    public static bool JudgeSquareSum(int c) {
        /*
        for (long a = 0; a * a <= c; ++a) {
            double b = Math.Sqrt(c - a * a);
            // 精华在这里：b == (int) b
            if (b == (int) b) {
                return true;
            }
        }
        return false;
        */

        long left = 0;
        long right = (long)Math.Sqrt(c);
        while (left <= right) {
            long sum = left * left + right * right;
            if (sum == c) {
                return true;
            }
            else if (sum > c) {
                right--;
            }
            else {
                left++;
            }
        }
        return false;
    }
}