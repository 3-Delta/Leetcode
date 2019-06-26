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

// 九宫格
public class NineGrid
{
    public int countPerLine;
    // 获取九宫格的周边8个位置的index,下标从0开始
    public void GetNeighbours(int currentIndex, ref List<int> ret, int arrayCount)
    {
        // 左下角开始，右上原则
        ret = ret ?? new List<int>();
        int index0 = currentIndex - countPerLine - 1;
        int index1 = currentIndex - countPerLine;
        int index2 = currentIndex - countPerLine + 1;
        int index3 = currentIndex - 1;
        int index5 = currentIndex + 1;
        int index6 = currentIndex + countPerLine - 1;
        int index7 = currentIndex + countPerLine;
        int index8 = currentIndex + countPerLine + 1;

        int line = currentIndex % countPerLine;
        if (IsIndexValid(index0, arrayCount) && index0 % countPerLine == line - 1)
        {
            ret.Add(index0);
        }
        if (IsIndexValid(index1, arrayCount) && index1 % countPerLine == line - 1)
        {
            ret.Add(index1);
        }
        if (IsIndexValid(index2, arrayCount) && index2 % countPerLine == line - 1)
        {
            ret.Add(index2);
        }
        if (IsIndexValid(index3, arrayCount) && index3 % countPerLine == line)
        {
            ret.Add(index3);
        }
        if (IsIndexValid(index5, arrayCount) && index5 % countPerLine == line)
        {
            ret.Add(index5);
        }
        if (IsIndexValid(index6, arrayCount) && index6 % countPerLine == line + 1)
        {
            ret.Add(index6);
        }
        if (IsIndexValid(index7, arrayCount) && index7 % countPerLine == line + 1)
        {
            ret.Add(index7);
        }
        if (IsIndexValid(index8, arrayCount) && index8 % countPerLine == line + 1)
        {
            ret.Add(index8);
        }
    }

    public bool IsIndexValid(int index, int arrayCount)
    {
        return (0 <= index && index < arrayCount);
    }
}