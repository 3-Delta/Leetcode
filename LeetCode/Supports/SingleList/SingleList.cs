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

    public SingleList(List<T> elements, bool circle = false)
    {
        CreateXunHuan(elements, circle);
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
            // 易错点
            if (jin != 0) { nums.Add(jin); }
            ret = new SingleList<int>(nums);
        }
        return ret;
    }
    public void PrintXunhuanPre()
    {
        for (SingleListNode<T> current = head; current != null; current = current.next)
        {
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
    public static SingleList<T> Connect(SingleList<T> left, SingleList<T> right)
    {
        SingleList<T> ret = null;
        return ret;
    }
    public static SingleList<T> Merge(SingleList<T> left, SingleList<T> right)
    {
        SingleList<T> ret = null;
        return ret;
    }
}