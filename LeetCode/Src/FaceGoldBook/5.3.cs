using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

// 给定一个32位整数 num，你可以将一个数位从0变为1。请编写一个程序，找出你能够获得的最长的一串1的长度。
public static class LC_GoldBook_5_3
{
    public static int Func()
    {
        return Gun(1775);
    }

    public static int Gun(int num)
    {
        int max = 0;
        // 1 << index逐渐循环，与 num 异或操作，得到比特1的个数
        for (int i = 0; i < 32; ++i)
        {
            int t = 1 << i;
            int yihuo = t ^ num;
            int bit1 = GetBit1Count(yihuo);
            if (max < bit1)
            {
                max = bit1;
            }
        }
        return max;
    }

    // 获取连续bit1的最大个数
    public static int GetBit1Count(int t)
    {
        int i = 0;
        int max = 0;
        int count = 0;
        while (i < 32)
        {
            int shift = t >> i;
            if ((shift & 1) == 1)
            {
                ++count;
            }
            else
            {
                count = 0;
            }

            if (count > max)
            {
                max = count;
            }

            ++i;
        }

        return max;
    }
}