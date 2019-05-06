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
    }
}