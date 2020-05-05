using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_1137
{
    public static void Func()
    {
        /*
         *  在一个「平衡字符串」中，'L' 和 'R' 字符的数量是相同的。
            给出一个平衡字符串 s，请你将它分割成尽可能多的平衡字符串。
            返回可以通过分割得到的平衡字符串的最大数量。

            来源：力扣（LeetCode）
            链接：https://leetcode-cn.com/problems/split-a-string-in-balanced-strings
            著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
         */
    }
    public static int Tribonacci(int n)
    {
        int first = 0;
        if (n <= 0) { return first; }
        int second = 1;
        if (n <= 1) { return second; }
        int third = 1;
        if (n <= 2) { return third; }
        for (int i = 3; i <= n; ++i)
        {
            int sum = first + second + third;

            first = second;
            second = third;
            third = sum;
        }
        return third;
    }
}