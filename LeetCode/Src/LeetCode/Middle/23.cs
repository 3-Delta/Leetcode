using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }
}

public static class LC_23
{
    public static void Func()
    {
        
    }

    public static ListNode MergeKLists(ListNode[] lists)
    {
        if (lists.Length < 1) { return null; }
        else if (lists.Length == 1) { return lists[0]; }

        ListNode head = lists[0];
        for (int i = 1; i < lists.Length; ++i)
        {
            head = MergeList(head, lists[i]);
        }
        return head;
    }
    public static ListNode MergeList(ListNode left, ListNode right)
    {
        if (left == null)
        {
            return right;
        }
        if (right == null)
        {
            return left;
        }

        ListNode head = null;
        if (left.val < right.val)
        {
            head = left;
            head.next = MergeList(left.next, right);
        }
        else
        {
            head = right;
            head.next = MergeList(left, right.next);
        }
        return head;
    }
}