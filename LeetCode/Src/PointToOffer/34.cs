using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class _34
{
    public static void Func()
    {
    }

    public static bool IsUgly(int n)
    {
        while (n % 3 == 0)
        {
            n /= 3;
        }
        while (n % 5 == 0)
        {
            n /= 5;
        }
        while (n % 7 == 0)
        {
            n /= 7;
        }
        return n == 1;
    }
}