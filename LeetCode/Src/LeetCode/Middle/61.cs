using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_61
{
    public static void Func()
    {
        SingleList<int> list = new SingleList<int>(new List<int> { 1});
        list.PrintXunhuanPre();
        list.head = list.RotateRight(list.head, 1);
        list.PrintXunhuanPre();
    }
}