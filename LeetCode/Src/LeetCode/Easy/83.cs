using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_83
{
    public static void Func()
    {
    }
    public static SingleListNode<int> DeleteDuplicates(SingleListNode<int> head)
    {
        if (head == null) { return null; }

        SingleListNode<int> left = head;
        SingleListNode<int> right = head.next;

        while (right != null)
        {
            if (right.value.Equals(left.value))
            {
                SingleListNode<int> next = right.next;
                left.next = next;
                right = next;
            }
            else
            {
                left = right;
                right = right.next;
            }
        }
        return head;
    }
}