using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class _10
{
    public static void Func()
    {
        int num = 9;
        Func1(num);
        Func2(num);
    }
    private static void Func1(int target)
    {
        int ret = 0;
        int i = 0;

        while (i < sizeof(int)) // 或者i != 0
        {
            int num = 1 << i;
            // 不能(target & num) == 1
            if ((target & num) != 0) { ++ret; }
            ++i;
        }

        Console.WriteLine(ret);
        Console.WriteLine("Over");
    }
    private static void Func2(int target)
    {
        int ret = 0;
        while (target != 0)
        {
            target &= (target - 1); // 消除bit中的最后一个1。
            ret++;
        }

        Console.WriteLine(ret);
        Console.WriteLine("Over");
    }
    // 是否为2的整数次方 【比特中只有一个1可以表明此为2的次幂】
    private static bool IsPower2(int num)
    {
        return (num & (num - 1)) == 0;
    }
}