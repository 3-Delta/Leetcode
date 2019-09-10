using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_21
{
    public static void Func()
    {
    }

    public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
    {
        ListNode head = null;
        ListNode prew = null;

        bool first = true;
        while (l1 != null && l2 != null)
        {
            bool flag = l1.val < l2.val;
            if (flag)
            {
                if (first)
                {
                    first = false;
                    head = l1;
                    prew = l1;
                }
                else
                {
                    prew.next = l1;
                    prew = prew.next;
                }
                l1 = l1.next;
            }
            else
            {
                if (first)
                {
                    first = false;
                    head = l2;
                    prew = l2;
                }
                else
                {
                    prew.next = l2;
                    prew = prew.next;
                }
                l2 = l2.next;
            }
        }
        while (l2 != null)
        {
            if (first)
            {
                first = false;
                head = prew = l2;
            }
            else
            {
                prew.next = l2;
                prew = prew.next;
            }
            l2 = l2.next;
        }
        while (l1 != null)
        {
            if (first)
            {
                first = false;
                head = prew = l1;
            }
            else
            {
                prew.next = l1;
                prew = prew.next;
            }
            l1 = l1.next;
        }
        return head;
    }
}