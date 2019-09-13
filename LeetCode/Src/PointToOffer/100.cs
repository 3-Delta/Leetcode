using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// num的10进制尾巴0的个数
// num的阶乘10进制尾巴0的个数

public static class _100
{
    public static void Func()
    {
        int num = 25;
        Console.WriteLine(Func1(num));
        Console.WriteLine("Over");

        Func2(num);

        Console.WriteLine(Func3(num));
        Console.WriteLine("Over");

        ZeroCountTailBinary(num);
    }

    // 一个数字10进制后面有多少0
    private static int Func1(int target)
    {
        int ret = 0;
        while (target % 5 == 0)
        {
            ++ret;
            target /= 5;
        }
        return ret;
    }
    // 阶乘10进制的0个数
    private static void Func2(int target)
    {
        int ret = 0;
        for (int i = 5; i <= target; ++i)
        {
            ret += Func1(i);
        }
        Console.WriteLine(ret);
        Console.WriteLine("Over");
    }
    private static int Func3(int target)
    {
        int ret = 0;
        if (target < 5)
        {
            ret = 0;
        }
        else
        {
            ret = Func1(target) + Func3(target - 1);
        }
        return ret;
    }
    // 是2的几次幂
    private static int numberOf2InPurePowerOf2(int num)
    {
        int ret = 0;
        while (num %2 == 0)
        {
            ++ret;
            num /= 2;
        }
        return ret;
    }
    // 二进制中尾巴0的个数
    // 二进制表示中，尾巴0的个数
    // -num的二进制表示为：num的取反+1
    // 取反之后，尾巴的几个0变为1，然后+1之后，就会出现之前尾巴的0还是0，同时最接近尾巴的原来数字会变为1，那么此时进行&操作，因为高位&都是0【之前是取反操作出来的】
    private static int ZeroCountTailBinary(int num)
    {
        int ret = num & (-num);
        ret = numberOf2InPurePowerOf2(ret);

        Console.WriteLine(ret);
        Console.WriteLine("Over");
        return ret;
    }
    // 二进制中只有一个1，并且1后面跟了n个0；
    public static bool isPowerOf2(int num)
    {
        return (num & (num - 1)) == 0;
    }
    public static bool isPowerOf2Digui(int num)
    {
        bool ret = false;
        if (num < 1) { ret = false; }
        else if (num == 1) { ret = true; }
        else
        {
            int yushu = num % 2;
            if (yushu == 0)
            {
                ret = isPowerOf2Digui(num >> 1);
            }
            else
            {
                ret = false;
            }
        }
        return ret;

        /*
        bool ret = false;
        if (n < 1) { ret = false; }
        else if (n == 1) { ret = true; }
        else
        {
            int yushu = n % 3;
            n /= 3;
            while (yushu == 0)
            {
                if (n == 1)
                {
                    ret = true;
                    break;
                }
                else
                {
                    yushu = n % 3;
                    n /= 3;
                }
            }
        }
        return ret;
        */
    }
}