﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BinaryTreeNode<T>
{
    public T value;
    public BinaryTreeNode<T> left;
    public BinaryTreeNode<T> right;

    public BinaryTreeNode() : this(default(T), null, null)
    { }
    public BinaryTreeNode(T value, BinaryTreeNode<T> left = null, BinaryTreeNode<T> right = null)
    {
        this.value = value;
        this.left = left;
        this.right = right;
    }
}

public class BinaryTree<T>
{
    public BinaryTreeNode<T> root;

    // 数组构建一个完全二叉树，
    // [数组从1开始] 规则就是：root.index * 2 == left, root.index * 2 + 1 == right;
    // [数组从0开始] 规则就是：root.index * 2 + 1 == left, root.index * 2 + 2 == right;
    // 创建的是完全二叉树
    public BinaryTreeNode<T> Create(List<T> nums, int index = 0)
    {
        BinaryTreeNode<T> ret = null;
        if (nums != null && 0 <= index && index < nums.Count)
        {
            ret = new BinaryTreeNode<T>(nums[index]);
            if (index == 0)
            {
                root = ret;
            }
            ret.left = Create(nums, index * 2 + 1);
            ret.right = Create(nums, index * 2 + 2);
        }
        return ret;
    }

    // 1：无重复数字
    // 2: 数据合理
    public BinaryTreeNode<T> CreateByPreMiddleXunhuan(List<T> pres, List<T> middles)
    {
        BinaryTreeNode<T> ret = null;
        //if (pres != null && middles != null && pres.Count > 0 && middles.Count > 0 && pres.Count == middles.Count)
        //{
        //    int i = 0;
        //    int left = 0;
        //    int right = pres.Count - 1;
        //    Stack<System.Tuple<int, int, BinaryTreeNode<T>>> parents = new Stack<System.Tuple<int, int, BinaryTreeNode<T>>>();
        //    while (i < pres.Count)
        //    {
        //        while (left <= right)
        //        {
        //            int index = Find.FindIndexInRange<T>(pres[i], middles, left, right);
        //            BinaryTreeNode<T> node = null;
        //            if (index != -1)
        //            {
        //                node = new BinaryTreeNode<T>(pres[i]);
        //                if (i == 0)
        //                {
        //                    root = node;
        //                }

        //                right = index - 1;

        //                System.Tuple<int, int, BinaryTreeNode<T>> top = parents.Peek();
        //                if (top != null)
        //                {
        //                    top.Item3.left = node;
        //                }
        //                parents.Push(new Tuple<int, int, BinaryTreeNode<T>>(left, right, node));

        //                ++i;
        //            }
        //            else
        //            {
        //                // 找不到，借助stack保存的数据进行回溯
        //                System.Tuple<int, int, BinaryTreeNode<T>> top = parents.Peek();
        //                left = top.Item1;
        //                right = top.Item2;
        //                parents.Pop();
        //            }
        //        }
        //    }      
        //}
        return ret;
    }
    public BinaryTreeNode<T> CreateByPreMiddleDG(List<T> pres, List<T> middles)
    {
        return CreateByPreMiddleDG(pres, 0, pres.Count - 1, middles, 0, middles.Count - 1);
    }
    public BinaryTreeNode<T> CreateByPreMiddleDG(List<T> pres, int pLeft, int pRight, List<T> middles, int mLeft, int mRight)
    {
        BinaryTreeNode<T> ret = null;
        if (pres != null && middles != null && pres.Count > 0 && middles.Count > 0 && pres.Count == middles.Count && 0 <= pLeft && pLeft <= pRight && pRight < pres.Count && 0 <= mLeft && mLeft <= mRight && mRight < middles.Count)
        {
            T value = pres[pLeft];
            int indexInMiddle = Find.FindIndexInRange<T>(value, middles, mLeft, mRight);
            if (indexInMiddle != -1)
            {
                int leftLength = indexInMiddle - mLeft;
                ret = new BinaryTreeNode<T>(value);
                if (pLeft == 0)
                {
                    root = ret;
                }

                // 原则就是pre的区间对应middle的区间
                ret.left = CreateByPreMiddleDG(pres, pLeft + 1, pLeft + leftLength, middles, mLeft, indexInMiddle - 1);
                ret.right = CreateByPreMiddleDG(pres, pLeft + leftLength + 1, pRight, middles, indexInMiddle + 1, mRight);
            }
        }
        return ret;
    }
    public void PrintDGPre(BinaryTreeNode<T> root)
    {
        if (root != null)
        {
            Console.WriteLine(root.value);
            PrintDGPre(root.left);
            PrintDGPre(root.right);
        }
    }
    public void PrintDGMiddle(BinaryTreeNode<T> root)
    {
        if (root != null)
        {
            PrintDGMiddle(root.left);
            Console.WriteLine(root.value);
            PrintDGMiddle(root.right);
        }
    }
    public void PrintDGPost(BinaryTreeNode<T> root)
    {
        if (root != null)
        {
            PrintDGPost(root.left);
            PrintDGPost(root.right);
            Console.WriteLine(root.value);
        }
    }
    public void PrintXunhuanPre()
    {
        // 原始版本：
        //Stack<BinaryTreeNode<T>> stack = new Stack<BinaryTreeNode<T>>();
        //stack.Push(root);
        //while (stack.Count > 0)
        //{
        //    BinaryTreeNode<T> top = stack.Peek();
        //    Console.Write(top.value + "   ");
        //    // 如何避免：左边的节点在回溯的时候不会再次被执行？？
        //    if (top.left != null)
        //    {
        //        stack.Push(top.left);
        //    }
        //    else if (top.right != null)
        //    {
        //        stack.Push(top.right);
        //    }
        //    else
        //    {
        //        stack.Pop();
        //    }
        //}

        Stack<BinaryTreeNode<T>> stack = new Stack<BinaryTreeNode<T>>();
        BinaryTreeNode<T> node = root;
        while (node != null || stack.Count > 0)
        {
            // 往左遍历
            while (node != null)
            {
                Console.Write(node.value + "   ");
                // 保留将来回溯需要的parent
                stack.Push(node);
                node = node.left;
            }

            // 到达左边尽头，开始回溯
            if (stack.Count > 0)
            {
                BinaryTreeNode<T> top = stack.Peek();
                node = top.right;
                stack.Pop();
            }
        }
    }
    public void PrintXunhuanMiddle()
    {
        Stack<BinaryTreeNode<T>> stack = new Stack<BinaryTreeNode<T>>();
        BinaryTreeNode<T> node = root;
        while (node != null || stack.Count > 0)
        {
            // 往左遍历
            while (node != null)
            {
                // 保留将来回溯需要的parent
                stack.Push(node);
                node = node.left;
            }

            // 到达左边尽头，开始回溯
            if (stack.Count > 0)
            {
                BinaryTreeNode<T> top = stack.Peek();
                Console.Write(top.value + "   ");
                node = top.right;
                stack.Pop();
            }
        }
    }
    public void PrintXunhuanPost()
    {
        
    }
    public void PrintLayer()
    {
        Queue<BinaryTreeNode<T>> queue = new Queue<BinaryTreeNode<T>>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            BinaryTreeNode<T> node = queue.Dequeue();
            if (node.left != null)
            {
                queue.Enqueue(node.left);
            }
            if (node.right != null)
            {
                queue.Enqueue(node.right);
            }

            Console.Write(node.value + "  ");
        }

        Console.WriteLine("-----------------");
    }
    // 换行层级打印二叉树
    // 重点是如何知道什么时候换行？如果知道什么时候换行，那么也就可以实现之字形打印
    public void PrintLayerChangeLine()
    {
        Queue<BinaryTreeNode<T>> queue = new Queue<BinaryTreeNode<T>>();
        queue.Enqueue(root);

        BinaryTreeNode<T> currentLayerEnd = root;
        BinaryTreeNode<T> nextLayerEnd = root;
        while (queue.Count > 0)
        {
            BinaryTreeNode<T> node = queue.Dequeue();
            if (node.left != null)
            {
                queue.Enqueue(node.left);

                // 记录下一行结束符
                nextLayerEnd = node.left;
            }
            if (node.right != null)
            {
                queue.Enqueue(node.right);

                // 记录下一行结束符
                nextLayerEnd = node.right;
            }

            Console.Write(node.value + "  ");
            if (currentLayerEnd == node)
            {
                Console.WriteLine();
                currentLayerEnd = nextLayerEnd;
            }
        }

        Console.WriteLine("-----------------");
    }
    // 换行层级打印二叉树
    // 重点是如何知道什么时候换行？如果知道什么时候换行，那么也就可以实现之字形打印
    public void PrintLayerChangeLineZhiShape()
    {
        Queue<BinaryTreeNode<T>> queue = new Queue<BinaryTreeNode<T>>();
        List<T> vector = new List<T>();
        queue.Enqueue(root);
        vector.Add(root.value);
        int layerNumber = 0;

        BinaryTreeNode<T> currentLayerEnd = root;
        BinaryTreeNode<T> nextLayerEnd = root;
        while (queue.Count > 0)
        {
            BinaryTreeNode<T> node = queue.Dequeue();

            // 特殊处理第一行的输出，必须放到vector.Add的前面，因为如果放到后面。第一次输出的就是前面两行的数据
            if (layerNumber == 0)
            {
                Console.WriteLine(vector[0]);
                vector.Clear();
            }

            if (node.left != null)
            {
                queue.Enqueue(node.left);
                vector.Add(node.left.value);

                // 记录下一行结束符
                nextLayerEnd = node.left;
            }
            if (node.right != null)
            {
                queue.Enqueue(node.right);
                vector.Add(node.right.value);

                // 记录下一行结束符
                nextLayerEnd = node.right;
            }

            // 开始换行
            if (currentLayerEnd == node)
            {
                // 从左到右
                if (layerNumber % 2 == 0)
                {
                    for (int j = 0, count = vector.Count; j < count; ++j)
                    {
                        Console.Write(vector[j] + "  ");
                    }
                }
                // 从右到左
                else
                {
                    for (int j = vector.Count - 1; j >= 0; --j)
                    {
                        Console.Write(vector[j] + "  ");
                    }
                }
                vector.Clear();

                ++layerNumber;

                currentLayerEnd = nextLayerEnd;

                Console.WriteLine();
            }
        }

        Console.WriteLine("-----------------");
    }
    public int GetDepth(BinaryTreeNode<T> root)
    {
        int ret = 0;
        if (root != null)
        {
            int leftDepth = GetDepth(root.left);
            int rightDepth = GetDepth(root.right);
            ret = Math.Max(leftDepth, rightDepth) + 1;
        }
        return ret;
    }
    // 左右子树最大高度差, out表明 整个递归连只是用一个变量
    public void GetMaxDepthDiff(BinaryTreeNode<T> root, out int maxDiff)
    {
        maxDiff = 0;
    }
    public void Mirror(BinaryTreeNode<T> root)
    {
        if (root != null)
        {
            BinaryTreeNode<T> t = root.left;
            root.left = root.right;
            root.right = t;

            Mirror(root.left);
            Mirror(root.right);
        }
    }
    public bool IsBalance(BinaryTreeNode<T> root)
    {
        bool ret = true;
        if (root != null)
        {
            bool leftBalance = IsBalance(root.left);
            bool rightBalance = IsBalance(root.right);
            if (leftBalance && rightBalance)
            {
                int leftDepth = GetDepth(root.left);
                int rightDepth = GetDepth(root.right);
                ret = Math.Abs(leftDepth - rightDepth) <= 1;
            }
            else
            {
                ret = false;
            }
        }
        return ret;
    }
}