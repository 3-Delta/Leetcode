using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_92
{
    public static void Func()
    {
        SingleList<int> sl = new SingleList<int>(new List<int> { 1, 2, 3, 4, 5 });
        sl.PrintXunhuanPre();
        sl.head = ReverseBetween(sl.head, 2, 4);
        sl.PrintXunhuanPre();
    }

    public static SingleListNode<int> ReverseBetween(SingleListNode<int> head, int m, int n)
    {
        if (head == null) { return null; }
        SingleListNode<int> cur = head, prev = null;
        while (m > 1)
        {
            prev = cur;
            cur = cur.next;
            m--;
            n--;
        }
        SingleListNode<int> left = prev, right = cur;
        while (n > 0)
        {
            SingleListNode<int> next = cur.next;
            cur.next = prev;
            prev = cur;
            cur = next;
            n--;
        }

        if (left != null) { left.next = prev; }
        else { head = prev; }

        right.next = cur;
        return head;
    }
}