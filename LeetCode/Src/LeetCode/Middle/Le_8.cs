using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Le_8
{
    public static void Func()
    {
        SingleList<int> left = new SingleList<int>(new List<int>() { 9, 9, 9});
        SingleList<int> right = new SingleList<int>(new List<int>() { 9, 9, 9, 9 });
        SingleList<int> target = SingleList<int>.Add(left, right);
        target?.PrintXunhuanPre();
    }
}