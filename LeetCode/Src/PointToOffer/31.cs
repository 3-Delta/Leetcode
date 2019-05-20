using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class _31
{
    public class Tiple3
    {
        public int max;
        public int startIndex;
        public int endIndex;

        public Tiple3() { }
        public Tiple3(int max, int startIndex, int endIndex)
        {
            this.max = max;
            this.startIndex = startIndex;
            this.endIndex = endIndex;
        }
        public override string ToString()
        {
            return string.Format("max:{0} start:{1} end:{2}", max, startIndex, endIndex);
        }
    }
    public static int[] array = new int[] { 1, -2, 3, 10, -4, 7, 2, -5};

    public static void Func()
    {
        Func1();
        Func2();
    }

    public static void Func1() // 查找法
    {
        Tiple3 ret = new Tiple3();
        int[,] map = new int[array.Length, array.Length];

        for (int i = 0; i < array.Length; ++i)
        {
            int sum = 0;
            for (int j = i; j < array.Length; ++j)
            {
                sum += array[j];
                map[i, j] = sum;
            }
        }

        for (int i = 0; i < array.Length; ++i)
        {
            for (int j = i; j < array.Length; ++j)
            {
                if (map[i, j] > ret.max)
                {
                    ret.max = map[i, j];
                    ret.startIndex = i;
                    ret.endIndex = j;
                }
            }
        }

        Console.WriteLine(ret.ToString());
    }

    public static void Func2()
    {
        Tiple3 ret = new Tiple3();
        int sum = 0;

        //ret.startIndex = 0;
        //ret.max = -int.MaxValue; 
        //for (int i = 0; i < array.Length; ++i)
        //{
        //    if (sum <= 0)
        //    {
        //        sum = array[i];
        //    }
        //    else
        //    {
        //        sum += array[i];
        //        ret.endIndex = i;
        //    }

        //    if (sum > ret.max)
        //    {
        //        ret.max = sum;
        //    }
        //}

        Console.WriteLine(ret.ToString());
    }
}