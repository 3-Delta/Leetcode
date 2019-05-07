using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class SingleListNode<T>
{
    public T value;
    public SingleListNode<T> next = null;

    public SingleListNode() : this(default(T), null) {}
    public SingleListNode(T value, SingleListNode<T> next = null) : this(value, next, null) { }
    public SingleListNode(T value, SingleListNode<T> next, SingleListNode<T> prev)
    {
        this.value = value;
        this.next = next;
        if (prev != null)
        {
            prev.next = this;
        }
    }
    public void Reset()
    {
        this.value = default(T);
        this.next = null;
    }
}
public class SingleList<T>
{
    public SingleListNode<T> head = null;

    public SingleList() { }
    public SingleList(List<T> elements, bool circle = false)
    {
        CreateXunHuan(elements, circle);
    }
    public SingleList(SingleList<T> target)
    {
        if (target != null)
        {
            int i = 0;
            SingleListNode<T> prev = null;
            for (var node = head; node != null; node = node.next)
            {
                // 环形链表出口，否则死循环
                if (target.head == node)
                {
                    // 构造环形链表
                    prev.next = head;
                    return;
                }
                prev = new SingleListNode<T>(node.value, null, prev);
                if (i == 0)
                {
                    head = prev;
                }
                ++i;
            }
        }
    }
    public void CreateXunHuan(List<T> elements, bool circle = false)
    {
        if (elements != null && elements.Count > 0)
        {
            SingleListNode<T> prev = null;
            for (int i = 0, count = elements.Count; i < count; ++i)
            {
                prev = new SingleListNode<T>(elements[i], null, prev);
                if (i == 0) { head = prev; }
            }

            if (circle)
            {
                prev.next = head;
            }
        }
    }
    public void CreateDG(List<T> elements, SingleListNode<T> prev = null, int index = 0, bool circle = false)
    {
        if (elements != null && elements.Count > 0)
        {
            if (index < elements.Count)
            {
                prev = new SingleListNode<T>(elements[index], null, prev);
                if (index == 0) { head = prev; }
                CreateDG(elements, prev, index + 1, circle);
            }
            else
            {
                prev.next = head;
            }
        }
    }
    public void Clear()
    {
        head.next = null;
    }
    public static SingleList<int> Add(SingleList<int> left, SingleList<int> right)
    {
        SingleList<int> ret = null;
        if (left != null && right != null)
        {
            SingleListNode<int> leftCurrent = left.head;
            SingleListNode<int> rightCurrent = right.head;
            List<int> nums = new List<int>();
            int jin = 0;
            int sum = 0;
            while (leftCurrent != null && rightCurrent != null)
            {
                sum = leftCurrent.value + rightCurrent.value + jin;
                nums.Add(sum % 10);
                jin = sum / 10;

                leftCurrent = leftCurrent.next;
                rightCurrent = rightCurrent.next;
            }
            while (leftCurrent != null)
            {
                sum = leftCurrent.value + jin;
                nums.Add(sum % 10);
                jin = sum / 10;

                leftCurrent = leftCurrent.next;
            }
            while (rightCurrent != null)
            {
                sum = rightCurrent.value + jin;
                nums.Add(sum % 10);
                jin = sum / 10;

                rightCurrent = rightCurrent.next;
            }
            // 易错点, 容易遗漏最高位的进位
            if (jin != 0) { nums.Add(jin); }
            ret = new SingleList<int>(nums);
        }
        return ret;
    }
    public void PrintXunhuanPre()
    {
        int circle = 0;
        for (SingleListNode<T> current = head; current != null; current = current.next)
        {
            if (current == head ) { ++circle; }
            if (circle > 1)
            {
                return;
            }
            Console.WriteLine(current.value);
        }
        Console.WriteLine("Over");
    }
    public void PrintXunhuanPost()
    {
        Stack<SingleListNode<T>> stack = new Stack<SingleListNode<T>>();
        for (SingleListNode<T> current = head; current != null; current = current.next)
        {
            stack.Push(current);
        }
        foreach (SingleListNode<T> current in stack)
        {
            Console.WriteLine(current);
        }
        Console.WriteLine("Over");
    }
    public void PrintDGPre(SingleListNode<T> head)
    {
        if (head != null)
        {
            Console.WriteLine(head.value);
            PrintDGPre(head.next);
        }
        else
        {
            Console.WriteLine("Over");
        }
    }
    public void PrintDGPost(SingleListNode<T> head)
    {
        if (head != null)
        {
            PrintDGPost(head.next);
            Console.WriteLine(head.value);
        }
        else
        {
            Console.WriteLine("Over");
        }
    }
    public void Delete(T value)
    {
        Delete(FindXunhuan(value));
    }
    // 非循环列表O(1)删除node
    public void Delete(SingleListNode<T> node)
    {
        if (node != null)
        {
            if (head == node)
            {
                head = head.next;
            }
            else
            {
                // 如果是尾指针
                if (node.next == null)
                {
                    var iter = head;
                    while (iter != null && !iter.next.Equals(node))
                    {
                        iter = iter.next;
                    }
                    iter.next = null;
                }
                else
                {
                    node.value = node.next.value;
                    node.next = node.next.next;
                }
            }
        }
    }
    public SingleListNode<T> BackN(int n)
    {
        SingleListNode<T> left = null;
        SingleListNode<T> right = head;

        if (n <= 0) { return left; }

        for(int i = 0; i < n; ++ i)
        {
            // 个数不足n个节点
            if (right == null)
            {
                return left;
            }
            right = right.next;
        }

        left = head;
        for (; right != null; left = left.next, right = right.next) {  }
        return left;
    }
    public bool IsCircle()
    {
        bool ret = false;
        SingleListNode<T> fast = head;
        SingleListNode<T> slow = head;

        while (fast != null)
        {
            int i = 0;
            while (i < 2 && fast != null)
            {
                fast = fast.next;
                ++i;
            }
            slow = slow.next;

            if (slow.Equals(fast))
            {
                ret = true;
                break;
            }
        }
        return ret;
    }
    public void ReverseXunhuan()
    {

    }
    public SingleListNode<T> ReverseDG(SingleListNode<T> head, SingleListNode<T> prev)
    {
        SingleListNode<T> ret = head;
        //if (head != null)
        //{
        //    ReverseDG(head.next, head);
        //}

        return ret;
    }
    public SingleListNode<T> FindXunhuan(T value)
    {
        SingleListNode<T> ret = head;
        for (; ret != null; ret = ret.next)
        {
            if (ret.value.Equals(value))
            {
                break;
            }
        }
        return ret;
    }
    public SingleListNode<T> FindDG(T value)
    {
        return FindDG(head, value);
    }
    public SingleListNode<T> FindDG(SingleListNode<T> head, T value)
    {
        SingleListNode<T> ret = head;
        if (ret != null)
        {
            if (!ret.value.Equals(value))
            {
                ret = FindDG(ret.next, value);
            }
        }
        return ret;
    }
    public static SingleList<T> Connect(SingleList<T> left, SingleList<T> right)
    {
        SingleList<T> ret = null;
        return ret;
    }
    public static SingleList<int> Merge(SingleList<int> left, SingleList<int> right)
    {
        SingleList<int> ret = null;

        if (left != null && right != null)
        {
            ret = new SingleList<int>();

            SingleListNode<int> leftNode = left.head;
            SingleListNode<int> rightNode = right.head;
            SingleListNode<int> prew = null;

            while (leftNode != null && rightNode != null)
            {
                prew = new SingleListNode<int>(0, null, prew);
                if (leftNode.value < rightNode.value)
                {
                    prew.value = leftNode.value;
                    leftNode = leftNode.next;
                }
                else
                {
                    prew.value = rightNode.value;
                    rightNode = rightNode.next;
                }
                if (ret.head == null) { ret.head = prew; }
            }
            while (leftNode != null)
            {
                prew = new SingleListNode<int>(leftNode.value, null, prew);
                leftNode = leftNode.next;
                if (ret.head == null) { ret.head = prew; }
            }
            while (rightNode != null)
            {
                prew = new SingleListNode<int>(rightNode.value, null, prew);
                rightNode = rightNode.next;
                if (ret.head == null) { ret.head = prew; }
            }
        }
        else if (left != null)
        {
            ret = new SingleList<int>(left);
        }
        else
        {
            ret = new SingleList<int>(right);
        }

        return ret;
    }

    public static SingleList<int> MergeDG(SingleList<int> left, SingleList<int> right)
    {
        return MergeDG(left.head, right.head);
    }
    public static SingleList<int> MergeDG(SingleListNode<int> left, SingleListNode<int> right)
    {
        SingleList<int> ret = null;
        if (left != null && right != null)
        {

        }
        return ret;
    }
}