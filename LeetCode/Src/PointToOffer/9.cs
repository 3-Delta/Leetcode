using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class _9
{
    public static void Func()
    {
        int index = 11;
        FibXunhuan(index);

        Console.WriteLine(FibDG(index));
        Console.WriteLine("Over");

        Console.WriteLine(FibDG1(index, 1, 1));
        Console.WriteLine("Over");
    }

    private static int FibXunhuan(int n)
    {
        int ret = 0;
        if (n < 3)
        {
            ret = 1;
        }
        else
        {
            int left = 1;
            int right = 1;
            for (int i = 3; i <= n; ++i)
            {
                int sum = left + right;
                left = right;
                right = sum;
            }
            ret = right;
        }

        Console.WriteLine(ret);
        Console.WriteLine("Over");
        return ret;
    }
    private static int FibDG(int n)
    {
        int ret = 1;
        if (n < 3)
        {
            ret = 1;
        }
        else
        {
            ret = FibDG(n - 1) + FibDG(n - 2);
        }
        return ret;
    }
    private static int FibDG1(int n, int left = 1, int right = 1)
    {
        int ret = 1;
        if (n >= 3)
        {
            ret = FibDG1(n - 1, right, left + right);
        }
        else
        {
            ret = right;
        }

        return ret;
    }
}