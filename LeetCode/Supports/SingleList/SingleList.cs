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
    public SingleList(SingleListNode<T> targetHead)
    {
        if (targetHead != null)
        {
            int i = 0;
            SingleListNode<T> prev = null;
            for (var node = targetHead; node != null; node = node.next)
            {
                // 环形链表出口，否则死循环
                if (targetHead == node && prev != null)
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
    public SingleList(SingleList<T> target) : this(target?.head) { }
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
                break;
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
        // 完美的解决方法
        SingleListNode<T> prev = null;
        for (SingleListNode<T> current = head; current != null;)
        {
            SingleListNode<T> next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }
        head = prev;
    }
    public void ReverseDG()
    {
        head = ReverseDG(head, null);
    }
    public SingleListNode<T> ReverseDG(SingleListNode<T> head, SingleListNode<T> prev)
    {
        SingleListNode<T> ret = null;
        if (head != null)
        {
            SingleListNode<T> next = head.next;
            head.next = prev;
            ret = ReverseDG(next, head);
        }
        else
        {
            ret = prev;
        }
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
    public static SingleListNode<int> MergeOldDg(SingleListNode<int> left, SingleListNode<int> right)
    {
        if (left == null) // 注意这里条件是： == null,而不是!= null
        {
            return right;
        }
        else if (right == null)
        {
            return left;
        }
        else
        {
            SingleListNode<int> subHead;
            if (left.value < right.value)
            {
                subHead = MergeOldDg(left.next, right);
                left.next = subHead;
                return left;
            }
            else
            {
                subHead = MergeOldDg(left, right.next);
                right.next = subHead;
                return right;
            }
        }
    }
    public static SingleListNode<int> MergeOld(SingleListNode<int> l1, SingleListNode<int> l2)
    {
        SingleListNode<int> retHead = null;
        SingleListNode<int> prew = null;
        bool first = true;
        while (l1 != null && l2 != null)
        {
            bool flag = l1.value < l2.value;
            if (flag)
            {
                if (first)
                {
                    first = false;
                    prew = retHead = l1;
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
                    prew = retHead = l2;
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
                retHead = prew = l2;
            }
            else
            {
                // 先设置next
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
                retHead = prew = l1;
            }
            else
            {
                prew.next = l1;
                prew = prew.next;
            }
            l1 = l1.next;
        }
        return retHead;
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
        return new SingleList<int>(MergeDG(left.head, right.head));
    }
    public static SingleListNode<int> MergeDG(SingleListNode<int> left, SingleListNode<int> right)
    {
        SingleListNode<int> ret = null;
        if (left != null && right != null)
        {
            if (left.value < right.value)
            {
                ret = new SingleListNode<int>(left.value);
                ret.next = MergeDG(left.next, right);
            }
            else
            {
                ret = new SingleListNode<int>(right.value);
                ret.next = MergeDG(left, right.next);
            }
        }
        // 两个递归出口
        else if (left != null)
        {
            ret = left;
        }
        else if (right != null)
        {
            ret = right;
        }
        return ret;
    }
    public void DeleteBackK(int k)
    {
        SingleListNode<T> node = FindBackK(k);
        if (node != null)
        {
            if (node == head)
            {
                head = head.next;
            }
            else if (node.next != null)
            {
                SingleListNode<T> next = node.next;
                node.value = next.value;
                node.next = next.next;
            }
            else
            {
                SingleListNode<T> pre = head;
                while (pre.next != node)
                {
                    pre = pre.next;
                }
                pre.next = null;
            }
        }
    }
    public SingleListNode<T> FindBackK(int k)
    {
        SingleListNode<T> right = head;
        for (int i = 0; i < k; ++i)
        {
            if (right == null)
            {
                return null;
            }
            else
            {
                right = right.next;
            }
        }

        SingleListNode<T> left = head;
        while (right != null)
        {
            right = right.next;
            left = left.next;
        }
        return left;
    }

    public SingleListNode<T> DeleteDuplicates(SingleListNode<T> head)
    {
        if (head == null) { return null; }

        SingleListNode<T> left = head;
        SingleListNode<T> right = head.next;

        while (right != null)
        {
            if (right.value.Equals(left.value))
            {
                SingleListNode<T> next = right.next;
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
<<<<<<< HEAD
    public void ReverseKGroup(SingleListNode<int> prew, SingleListNode<int> left, SingleListNode<int> right)
    {
        // 前闭后开逆置
        // 使用头插法逆置
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
=======
    public SingleListNode<T> RotateRight(SingleListNode<T> head, int k)
    {
        // 注意k == count的時候，和形成环形的先后顺序。
        if (k <= 0) { return head; }

        SingleListNode<T> prew = null;
        SingleListNode<T> current = head;
        int count = 0;
        while (current != null)
        {
            ++count;
            prew = current;
            current = current.next;
        }

        if (count == 0) { return head; }
        k = k % count;
        if (k == 0)
        {
            return head;
        }
        if (prew != null)
            prew.next = head;

        {
            current = head;
            prew = null;
            int diff = count - k;
            int i = 0;
            while (current != null && i < diff)
            {
                prew = current;
                current = current.next;
                ++i;
            }

            if (prew != null)
                prew.next = null;
            head = current;
            return head;
>>>>>>> 8f4b9fdf018752172a3a8574a03bb2305a3fd030
        }
    }
}