using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_235
{
    public static void Func()
    {
    }

    public static TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        if (root == null)
        {
            return root;
        }
        else
        {
            if (root.val > p.val && root.val > q.val)
            {
                return LowestCommonAncestor(root.left, p, q);
            }
            else if (root.val < p.val && root.val < q.val)
            {
                return LowestCommonAncestor(root.right, p, q);
            }
            else
            {
                return root;
            }
        }
    }

}