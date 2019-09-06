using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_29
{
    public static void Func()
    {
        List<int> ls = new List<int>();
        ls.Reverse();
        ls.ToArray();
    }
    public static int Divide(int dividend, int divisor)
    {
        int shang = 0;
        int signX = Math.Sign(dividend);
        int signY = Math.Sign(divisor);
        int absX = Math.Abs(dividend);
        int absY = Math.Abs(divisor);
        if (absX == absY) { shang = 1; }
        else if (absY == 1) { shang = absX; }
        else
        {
            while (absX - absY >= 0)
            {
                absX -= absY;
                ++shang;
            }
        }

        return shang * signX * signY;
    }
}