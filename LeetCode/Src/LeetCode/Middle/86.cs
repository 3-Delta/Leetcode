using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_86
{
    public static void Func()
    {
        SingleList<int> sl = new SingleList<int>(new List<int> { 1, 4, 3, 2, 5, 2 });
        sl.PrintXunhuanPre();
        sl.head = Partition(sl.head, 3);
        sl.PrintXunhuanPre();

        sl = new SingleList<int>(new List<int> { 1, 4, 3, 2, 5, 2 });
        sl.head = Partition2(sl.head, 3);
        sl.PrintXunhuanPre();
    }

    public static SingleListNode<int> Partition(SingleListNode<int> head, int x)
    {
        SingleListNode<int> newHead = new SingleListNode<int>(0, head);
        SingleListNode<int> leftPrew = newHead;
        SingleListNode<int> left = head;
        SingleListNode<int> leftNext;

        SingleListNode<int> rightPrew = newHead;
        SingleListNode<int> right = head;
        SingleListNode<int> rightNext;
        while (right != null)
        {
            while (left != null && left.value < x)
            {
                leftPrew = left;
                left = left.next;
            }

            // 这里保证right始终在left
            right = left;
            while (right != null && right.value >= x)
            {
                rightPrew = right;
                right = right.next;
            }

            if (right != null)
            {
                leftNext = left.next;
                rightNext = right.next;
                leftPrew.next = right;
                right.next = left;
                rightPrew.next = rightNext;

                leftPrew = right;
                right = rightNext;
            }
        }
        return newHead.next;
    }

    public static SingleListNode<int> Partition2(SingleListNode<int> head, int x)
    {
        SingleListNode<int> left = new SingleListNode<int>(-1, null);
        SingleListNode<int> leftLast = left;
        SingleListNode<int> right = new SingleListNode<int>(-1, null);

        while (head != null)
        {
            SingleListNode<int> next = head.next;
            if (head.value < x)
            {
                leftLast.next = head;
                leftLast = leftLast.next;
                head.next = null;
            }
            else
            {
                SingleListNode<int> rightNext = right.next;
                right.next = head;
                head.next = rightNext;
            }
            head = next;
        }

        leftLast.next = right.next;
        return left.next;
    }
}