using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class Sort
{
    public static int[] array = new int[] { 0, 9, 6, 7, 2, 4, 3, 1, 5, 100};

    public static void Func()
    {
        //SimpleSort();

        // BubbleSort();

        InsertSort();

        IntArray.Print(array);
        Console.WriteLine("-----------------");
    }
    public static void SimpleSort()
    {
        // 不是两两逐次比较
        int count = array.Length;
        for (int i = 0; i < count - 1; ++i)
        {
            for (int j = i + 1; j < count; ++j)
            {
                if (array[i] < array[j])
                {
                    int t = array[i];
                    array[i] = array[j];
                    array[j] = t;
                }
            }
        }
    }
    public static void BubbleSort()
    {
        // 不是两两逐次比较
        int count = array.Length;
        // 比较次数
        for (int i = 0; i < count - 1; ++i)
        {
            bool sortFlag = false;
            for (int j = 0; j < count - i - 1; ++j)
            {
                if (array[j] < array[j + 1])
                {
                    int t = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = t;

                    sortFlag = true;
                }
            }

            // 相邻两者一直没有交换顺序，说明有序
            if (!sortFlag)
            {
                break;
            }
        }
    }
    public static void InsertSort()
    {
        int count = array.Length;
        for (int i = 1; i < count; ++i)
        {
            int guard = array[i];
            int j = i - 1;
            for (; j >= 0; --j)
            {
                if (guard > array[j])
                {
                    array[j + 1] = array[j];
                }
                else
                {
                    // 一定要在else中break,否则j会一直到0，我们需要在合适的地方打断循环。
                    break;
                }
            }
            array[j + 1] = guard;
        }
    }
}