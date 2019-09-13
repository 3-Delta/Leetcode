using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_141
{
    public static void Func()
    {
        SingleList<int> list = new SingleList<int>(new List<int>() { 1, 2, 3, 4, 5, 6 }, true);
        Console.WriteLine(HasCycle(list.head));
    }
    // 还可以双指针一起走的方式进行
    public static bool HasCycle(SingleListNode<int> head)
    {
        SingleListNode<int> node = head;
        bool hasCircle = false;
        HashSet<SingleListNode<int>> map = new HashSet<SingleListNode<int>>();
        while (node != null)
        {
            if (!map.Contains(node))
            {
                map.Add(node);
            }
            else
            {
                hasCircle = true;
                break;
            }
            node = node.next;
        }
        return hasCircle;
    }
}