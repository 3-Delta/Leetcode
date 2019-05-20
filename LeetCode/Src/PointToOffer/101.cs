using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 1到1000的质数
public static class _101
{
    public static void Func()
    {
       // PrimeNumber();
        PrimeNumber1();
    }

    public static void PrimeNumber()
    {
        for (int i = 2; i < 1000; ++i)
        {
            bool flag = false;
            for (int j = 2; j <= i / 2; ++j)
            {
                if (i % j == 0)
                {
                    flag = true;
                    break;
                }
            }
            if (!flag)
            {
                Console.WriteLine(i);
            }
        }

        Console.WriteLine("================");
    }

    public static void PrimeNumber1() // 优化版本
    {
        for (int i = 2; i < 1000; ++i)
        {
            int k = (int)Math.Sqrt(i); // 平方根进行优化
            bool flag = false;
            for (int j = 2; j <= k; ++j)
            {
                if (i % j == 0)
                {
                    flag = true;
                    break;
                }
            }

            if (!flag)
            {
                Console.WriteLine(i);
            }
        }

        Console.WriteLine("================");
    }
}