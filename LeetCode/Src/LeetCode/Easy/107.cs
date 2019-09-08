using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_107
{
    public static void Func()
    {
        BinaryTree<int> tree = new BinaryTree<int>();
        tree.Create(new List<int> { 1, 2, 3, 4, 5, 6, 7});
        tree.PrintLayerChangeLine();
    }

    // 1：插入的时候使用头插法
    // 2: 尾差法，最后进行一个Reverse
    public static List<List<int>> LevelOrderBottom(TreeNode root)
    {
        List<List<int>> res = new List<List<int>>();
        if (root != null)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            List<int> ls = new List<int>();
            TreeNode finalNodeInCurrentLine = root;
            TreeNode finalNodeInNextLine = root;
            while (queue.Count > 0)
            {
                TreeNode top = queue.Dequeue();
                if (top.left != null)
                {
                    queue.Enqueue(top.left);
                    finalNodeInNextLine = top.left;
                }
                if (top.right != null)
                {
                    queue.Enqueue(top.right);
                    finalNodeInNextLine = top.right;
                }

                ls.Add(top.val);

                if (top == finalNodeInCurrentLine)
                {
                    res.Insert(0, ls);
                    ls = new List<int>();
                    finalNodeInCurrentLine = finalNodeInNextLine;
                }
            }
        }

        return res;
    }
}