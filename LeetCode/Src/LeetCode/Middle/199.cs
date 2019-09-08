using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

// 从上到下，从右到左遍历二叉树
public static class LC_199
{
    public static void Func()
    {
    }
    public static IList<int> RightSideView(BinaryTreeNode<int> root)
    {
        IList<int> ls = new List<int>();
        RightSideView(root, ls, 0);
        return ls;
    }
    public static void RightSideView(BinaryTreeNode<int> root, IList<int> ls, int depth)
    {
        if (root != null)
        {
            if (depth == ls.Count)
            {
                ls.Add(root.value);
            }
            // 先右后左
            RightSideView(root.right, ls, depth + 1);
            RightSideView(root.left, ls, depth + 1);
        }
    }
    /* 错误做法，还需要考虑到左子树
    public void RightSideView(TreeNode root, IList<int> ls) 
    {
        if(root != null)
        {
            ls.Add(root.val);
            if(root.right != null)
            {
                RightSideView(root.right, ls);  
            }
            else // 这里必须是else
            {
                RightSideView(root.left, ls);  
            }
        }
    }
    */
}