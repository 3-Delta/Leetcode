using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class _11
{
    public static void Func()
    {
        double baseNum = 3;
        int exp = 2;
        Console.WriteLine("power:" + (Power(baseNum, exp)));
    }

    public static double Power(double baseNum, int exp)
    {
        double ret = 0;

        if (baseNum == 0) // 特殊情况
        {
            ret = 0;
        }
        else
        {
            if (exp == 0) // 特殊情况
            {
                ret = 1;
            }
            else if (exp > 0)
            {
                ret = baseNum * (Power(baseNum, exp - 1));
            }
            else // 特殊情况
            {
                ret = (1 / baseNum) * (1 / (Power(baseNum, exp + 1)));
            }
        }
        
        return ret;
    }
}