using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_100
{
    public static void Func()
    {
        
    }
    public static bool IsSameTree(BinaryTreeNode<int> p, BinaryTreeNode<int> q)
    {
        if (p != null && q != null)
        {
            if (p.value == q.value)
            {
                return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
            }
            else
            {
                return false;
            }
        }
        else if (p == null && q == null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}