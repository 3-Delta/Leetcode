using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_46
{
    public static void Func()
    {
        List<int> array = new List<int>() { 1, 2, 3};
        AllSort(array, 0);
    }
    public static void AllSort(List<int> array, int index)
    {
        if (index >= array.Count)
        {
            IntArray.Print(array);
        }
        else
        {
            for (int i = index; i < array.Count; ++i)
            {
                Swap(array, index, i);
                AllSort(array, index + 1);
                Swap(array, index, i);
            }
        }
    }
    public static void Swap(List<int> array, int aIndex, int bIndex)
    {
        int t = array[aIndex];
        array[aIndex] = array[bIndex];
        array[bIndex] = t;
    }
}