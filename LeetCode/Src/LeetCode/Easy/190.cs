using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_190
{
    public static void Func()
    {
        Console.WriteLine(ReverseBits(123));
    }

    /*
     * 思路：此题只需要采用位运算，每次将原来的数字向左移动1位，就需要把该末尾加到我们的数字中去即可，
     * 此题需要注意的是一点要循环32次，不仅是有32位，最重要的不能判断到原来的数字为0就结束循环，
     * 这样就有可能的导致没有补足0所以要循环32次。同时对于左移而言，末尾全部补上的是0，
     * 而对于右移而言左边补的是原本最高位的数字，比如一个32位的数字最高位为1就全部补上1，
     * 如果为0 就全部补上0.这个知识点也是面试常考的。

    作者：vailing
    链接：https://leetcode-cn.com/problems/reverse-bits/solution/zuo-you-yi-dong-by-vailing/
    来源：力扣（LeetCode）
    著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。
     */
    public static uint ReverseBits(uint n)
    {
        uint res = 0;
        for (int i = 0; i < 32; i++)
        {
            res <<= 1;
            // 关键在于始终去n最右，同时取完之后立即n右移
            res += n & 1;
            n >>= 1;
        }
        return res;
    }
}