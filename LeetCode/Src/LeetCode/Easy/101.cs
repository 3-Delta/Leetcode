using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_101
{
    public static void Func()
    {
        
    }
    public static bool isSymmetric(BinaryTreeNode<int> root)
    {
        return isMirror(root, root);
    }

    public static bool isMirror(BinaryTreeNode<int> t1, BinaryTreeNode<int> t2)
    {
        if (t1 == null && t2 == null) return true;
        if (t1 == null || t2 == null) return false;
        return (t1.value.Equals(t2.value)) && isMirror(t1.right, t2.left) && isMirror(t1.left, t2.right);
    }
}