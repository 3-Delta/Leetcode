using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class _15
{
    public static void Func()
    {
        SingleList<int> left = new SingleList<int>(new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 });
        left?.PrintXunhuanPre();

        Console.WriteLine(left?.BackN(0)?.value);
        Console.WriteLine(left?.BackN(1)?.value);
        Console.WriteLine(left?.BackN(4)?.value);
        Console.WriteLine(left?.BackN(8)?.value);
        Console.WriteLine(left?.BackN(20)?.value);
        Console.WriteLine(left?.IsCircle());

        SingleList<int> right = new SingleList<int>(new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 }, true);
        Console.WriteLine(right?.IsCircle());
    }
}