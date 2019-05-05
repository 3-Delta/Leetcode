using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class _3
{
    private static List<List<int>> array = new List<List<int>>()
    {
        new List<int>(){ 1, 2, 8, 9 },
        new List<int>(){ 2, 4, 9, 12 },
        new List<int>(){ 4, 7, 10, 13 },
        new List<int>(){ 6, 8, 11, 15 },
    };

    public static void Func()
    {
        //HasTarget(3);

        HasTargetDG(7);
    }
    public static bool HasTarget(int value)
    {
        bool ret = false;

        int i;
        Find.BinaryFindXunhuan(array[0], value, out i);
        // 判断i的合法性，因为可能查找失败的话，会给一个right,但是right的合法性不检验
        if(0 <= i && i < array[0].Count)
        {
            List<int> col = new List<int>();
            foreach (List<int> ls in array)
            {
                col.Add(ls[i]);
            }

            int j;
            if (Find.BinaryFindXunhuan(col, value, out j))
            {
                Console.WriteLine(i + "  " + j + "  Over!");
                ret = true;
            }
        }
        
        return ret;
    }
    public static bool HasTargetDG(int value)
    {
        bool ret = false;

        int i;
        Find.BinaryFindDG(array[0], 0, array[0].Count - 1, value, out i);
        // 判断i的合法性，因为可能查找失败的话，会给一个right,但是right的合法性不检验
        if (0 <= i && i < array[0].Count)
        {
            List<int> col = new List<int>();
            foreach (List<int> ls in array)
            {
                col.Add(ls[i]);
            }

            int j;
            if (Find.BinaryFindDG(col, 0, col.Count - 1, value, out j))
            //if (Find.BinaryFindXunhuan(col, value, out j))
            {
                Console.WriteLine(i + "  " + j + "  Over!");
                ret = true;
            }
        }

        return ret;
    }
}