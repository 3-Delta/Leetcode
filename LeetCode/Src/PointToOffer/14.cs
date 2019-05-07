using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 奇数在偶数前面
public static class _14
{
    public static int[] array = new int[] { 1, 5, 3, 6, 4, 8, 7, 2, -1};

    public static void Func()
    {
        IntArray.Print(array);

        int left = 0;
        int right = array.Length - 1;

        // 不是 <=,因为假设数列完全符合奇数在左，偶数在右{1， 3， 2， 4}，那么如果条件是left <= right,就会死循环
        while (left < right)
        {
            while (left < right && (array[left] & 1) == 1) { ++left; }
            while (left < right && (array[right] & 1) == 0) { --right; }

            // left < right表明是因为左边遇到偶数，右边遇到奇数造成的。
            // 需要考虑1， 3， 2， 4 这种完全符合条件的情况是否会遇到问题
            if (left < right)
            {
                int t = array[left];
                array[left] = array[right];
                array[right] = t;
            }
        }

        IntArray.Print(array);
    }
}