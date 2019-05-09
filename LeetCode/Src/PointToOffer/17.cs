using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class _17
{
    public static void Func()
    {
        SingleList<int> left = new SingleList<int>(new List<int>() { 1, 3, 5, 7, 9 });
        left?.PrintXunhuanPre();
        SingleList<int> right = new SingleList<int>(new List<int>() { 0, 2, 4, 6, 8 });
        right?.PrintXunhuanPre();

        SingleList<int> three = SingleList<int>.Merge(left, right);
        three?.PrintXunhuanPre();
        SingleList<int> fout = SingleList<int>.MergeDG(left, right);
        fout?.PrintXunhuanPre();

        // 测试环形链表的clone
        SingleList<int> circle = new SingleList<int>(new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8}, true);
        circle?.PrintXunhuanPre();
        SingleList<int> aim = new SingleList<int>(circle);
        aim?.PrintXunhuanPre();
        SingleList<int> aimxx = new SingleList<int>(circle.head);
        aimxx?.PrintXunhuanPre();
    }
}