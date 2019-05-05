using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class _5
{
    public static void Func()
    {
        SingleList<int> left = new SingleList<int>(new List<int>() { 1, 2, 3, 4 });
        left.PrintDGPost(left.head);
    }
}