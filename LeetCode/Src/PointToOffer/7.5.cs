using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class _7_5
{
    // 假设最大岁数200
    public static int maxAge = 200;

    public static void Func()
    {
        int[] argsOfMember = new int[] { 45, 45, 67, 78, 23, 45, 34, 23};
        Funcc(argsOfMember);
    }

    private static void Funcc(int[] argsOfMember)
    {
        int[] array = new int[maxAge];
        for(int i = 0, count = argsOfMember.Length; i < count; ++ i)
        {
            array[argsOfMember[i]]++;
        }
        for (int i = 0; i < maxAge; ++i)
        {
            for (int j = 0; j < array[i]; ++j)
            {
                Console.WriteLine(i);
            }
        }
    }
}