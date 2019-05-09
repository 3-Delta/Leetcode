using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class IntArray
{
    public static void Print(int[] array)
    {
        foreach (var i in array)
        {
            Console.Write(i + "   ");
        }
        Console.WriteLine("================");
    }

    // 是否升序
    public static bool IsSorted(int[] array, bool increase = true, int index = 0)
    {
        bool ret = true;
        if (index < array.Length - 1)
        {
            if ((increase && array[index + 1] < array[index]) || (!increase) && array[index + 1] > array[index])
            {
                ret = false;
            }
            else
            {
                ret = IsSorted(array, increase, index + 1);
            }
        }
        return ret;
    }
    public static int[] MergeXunhuan(int[] left, int[] right)
    {
        int[] ret = new int[left.Length + right.Length];

        int l = 0;
        int r = 0;

        int index = 0;
        while (l < left.Length && r < right.Length)
        {
            if (left[l] < right[r])
            {
                ret[index++] = left[l++];
            }
            else
            {
                ret[index++] = right[r++];
            }
        }

        while (l < left.Length)
        {
            ret[index++] = left[l++];
        }
        while (r < right.Length)
        {
            ret[index++] = right[r++];
        }
        return ret;
    }
    public static void MergeDG(int[] left, int[] right)
    {
        int[] ret = new int[left.Length + right.Length];
        MergeDG(left, 0, right, 0, ret, 0);

        IntArray.Print(ret);
    }
    public static void MergeDG(int[] left, int l, int[] right, int r, int[] target, int index)
    {
        if (left != null && right != null && target != null && 0 <= index && index < target.Length)
        {
            if (l < left.Length && r < right.Length)
            {
                if (left[l] < right[r])
                {
                    target[index++] = left[l];
                    MergeDG(left, l + 1, right, r, target, index);
                }
                else
                {
                    target[index++] = right[r];
                    MergeDG(left, l, right, r + 1, target, index);
                }
            }
            else
            {
                while (l < left.Length) { target[index++] = left[l++]; }
                while (r < right.Length) { target[index++] = right[r++]; }
            }
        }
        
    }
}