using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 升序数列旋转之后存在一个新的数列， 求取最小值
// 时间复杂度需要O(lg n)

/// 旋转之后是两个递增数列组合起来的，分界点就是最小元素所在位置，利用近似二分法查找
public static class _8
{
    public static int[] array = new int[] { 4, 5, 1, 2, 3};
    // public static int[] array = new int[] { 1, 2, 3, 4, 5};

    public static void Func()
    {
        //int left = 0;
        //int right = array.Length - 1;
        //while (left <= right)
        //{
        //    int middle = (left + right) / 2;
        //    if (array[left] > array[middle])
        //    {
        //        right = middle - 1;
        //    }
        //    else if (array[middle] > array[right])
        //    {
        //        left = middle + 1;
        //    }
        //    else
        //    {
        //        // 如果进入这里：说明整体有序
        //        break;
        //    }
        //}
        // 存在很多bug

        

        Console.WriteLine(array[middle]);
    }
}