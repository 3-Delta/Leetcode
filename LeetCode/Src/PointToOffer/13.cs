using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class _13
{
    public static void Func()
    {
        SingleList<int> left = new SingleList<int>(new List<int>() { 1, 2, 3, 4, 5, 6 });
        left?.PrintXunhuanPre();
        left.Delete(3);
        left?.PrintXunhuanPre();
        left.Delete(1);
        left?.PrintXunhuanPre();
        left.Delete(6);
        left?.PrintXunhuanPre();
    }
}