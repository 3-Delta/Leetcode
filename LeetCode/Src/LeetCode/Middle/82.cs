using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_82
{
    public static void Func()
    {
        SingleList<int> sl = new SingleList<int>(new List<int> { 1, 1, 2, 2, 4, 5 });
        sl.PrintXunhuanPre();
        sl.head = DeleteDuplicates(sl.head);
        sl.PrintXunhuanPre();
    }

    public static SingleListNode<int> DeleteDuplicates(SingleListNode<int> head)
    {
        SingleListNode<int> ret = head;
        SingleListNode<int> prew = null;
        SingleListNode<int> left = head;
        while (left != null)
        {
            int val = left.value;
            SingleListNode<int> right = left.next;
            bool serise = false;
            while (right != null && right.value == val)
            {
                serise = true;
                right = right.next;
            }

            if (serise)
            {
                if (prew == null)
                {
                    ret = right;
                }
                else
                {
                    prew.next = right;
                }
            }
            else
            {
                prew = left;
            }
            left = right;
        }
        return ret;
    }
}