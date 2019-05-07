using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class _12
{
    public static void Func()
    {
        int n = 3;
        int[] array = new int[n];
        Funcc(array);
    }

    public static void Funcc(int[] array, int n = 0)
    {
        if (n >= array.Length)
        {
            IntArray.Print(array);
        }
        else
        {
            for (int i = 0; i <= 9; ++i)
            {
                array[n] = i;
                Funcc(array, n + 1);
            }
        }
    }
}