using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_25
{
    public static void Func()
    {
        SingleList<int> sl = new SingleList<int>(new List<int>{1, 2, 3, 4, 5});
        sl.PrintXunhuanPre();
        SingleListNode<int> t = new SingleListNode<int>(-1, sl.head);
        ReverseKGroup(t, sl.head, sl.head.next.next.next.next);
        sl.head = t.next;
        sl.PrintXunhuanPre();
    }
    public static SingleListNode<int> ReverseKGroup(SingleListNode<int> head, int k) 
    {
        SingleListNode<int> ret = head;
        if(k <= 1) { ret = head; }
        else
        {
        }
        return ret.next;
    }
    // 前闭后开
    public static SingleListNode<int> ReverseKGroup(SingleListNode<int> prew, SingleListNode<int> left, SingleListNode<int> right)
    {
        SingleListNode<int> head = prew;
        SingleListNode<int> leftPrew = left;
        while (left != right)
        {
            SingleListNode<int> prewNext = prew.next;
            SingleListNode<int> leftNext = left.next;
            if (prewNext == left)
            {
                left = leftNext;
            }
            else
            {
                prew.next = left;
                left.next = prewNext;
                leftPrew.next = leftNext;
                left = leftNext;
            }
        }
        return head;
    }
}