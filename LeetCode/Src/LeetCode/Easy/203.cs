using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_203
{
    public static void Func()
    {
        SingleList<int> list = new SingleList<int>(new List<int>() { 1, 2, 3, 4, 5, 6});
        list.PrintXunhuanPre();
        list.DeleteValue(3);
        list.PrintXunhuanPre();
    }

}