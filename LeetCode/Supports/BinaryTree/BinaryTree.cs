using System;
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
            ret.left = Create(nums, index * 2 + 1);
            ret.right = Create(nums, index * 2 + 2);
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
            PrintDGPre(root.left);
            Console.WriteLine(root.value);
            PrintDGPre(root.right);
        }
    }
    public void PrintDGPost(BinaryTreeNode<T> root)
    {
        if (root != null)
        {
            PrintDGPre(root.left);
            PrintDGPre(root.right);
            Console.WriteLine(root.value);
        }
    }
    public void PrintXunhuanPre()
    {

    }
    public void PrintXunhuanMiddle()
    {

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

            Console.WriteLine(node.value + "  ");
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
        int flag = 0;

        BinaryTreeNode<T> currentLayerEnd = root;
        BinaryTreeNode<T> nextLayerEnd = root;
        while (queue.Count > 0)
        {
            BinaryTreeNode<T> node = queue.Dequeue();
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

            if (currentLayerEnd == node)
            {
                if (flag % 2 == 0)
                {
                    for (int j = 0, count = vector.Count; j < count; ++j)
                    {
                        Console.Write(vector[j] + "  ");
                    }
                }
                else
                {
                    for(int j = vector.Count - 1; j >= 0; --j)
                    {
                        Console.Write(vector[j] + "  ");
                    }
                }
                vector.Clear();

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
        if (root != null)
        {
            int leftDepth = GetDepth(root.left);
            int rightDepth = GetDepth(root.right);
            int diff = Math.Abs(leftDepth - rightDepth);
            maxDiff = Math.Max(diff, maxDiff);
        }
    }
}