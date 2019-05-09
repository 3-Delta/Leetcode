using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class _28
{
    public static void Func()
    {
        char[] orig = new char[] { 'a','b','c' };
        AllPermutation(orig);
    }

    public static void AllPermutation(char[] orig, int index = 0)
    {
        if (index >= orig.Length)
        {
            foreach (char c in orig)
            {
                Console.Write(c);
            }
            Console.WriteLine();
        }
        else
        {
            // 因为当前index位置，只能和后面的进行交换，所以循环变量从当前index开始
            for (int i = index; i < orig.Length; ++i)
            {
                // 固定index位置，然后逐渐和后面的每个元素替换,所以这里使用循环去交换
                Swap(orig, index, i);

                // 固定index位置，然后递归index+1
                AllPermutation(orig, index + 1);

                // 还原
                Swap(orig, i, index);
            }
        }
    }
    public static void Swap<T>(IList<T> array, int left, int right)
    {
        T c = array[left];
        array[left] = array[right];
        array[right] = c;
    }
    // 所有组合的情况
    public static void AllCombination(char[] orig, int index = 0)
    {

    }
}