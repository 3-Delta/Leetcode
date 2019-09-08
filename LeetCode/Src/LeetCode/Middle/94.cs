using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_94
{
    public static void Func()
    {
        BinaryTree<int> tree = new BinaryTree<int>();
        tree.Create(new List<int>{ 1, -1, 2, -1, -1, 3 });
        IList<int>  ls = InorderTraversal(tree.root);
        IntArray.Print(ls);
    }

    public static IList<int> InorderTraversal(BinaryTreeNode<int> root)
    {
        IList<int> ls = new List<int>();
        InorderTraversal(root, ls);
        return ls;

    }
    public static void InorderTraversal(BinaryTreeNode<int> root, IList<int> ls)
    {
        if (root != null)
        {
            InorderTraversal(root.left, ls);
            ls.Add(root.value);
            InorderTraversal(root.right, ls);
        }
    }
}