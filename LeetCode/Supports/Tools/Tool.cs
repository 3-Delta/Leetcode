using System;
using System.Collections.Generic;

public static class Tool
{
    public static void Swap<T>(ref T left, ref T right)
    {
        T t = left;
        left = right;
        right = t;
    }
    public static bool IsIndexValid<T>(this IList<T> array, int index)
    {
        return 0 <= index && index < array.Count;
    }
}