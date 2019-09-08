using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_111
{
    public static void Func()
    {
        
    }
    public static int MinDepth(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }
        else
        {
            // 叶子
            if ((root.left == null) && (root.right == null))
            {
                return 1;
            }
            else
            {
                // 错误做法，会把depth为0的考虑进去 也就是为null的分支
                /*
                int left = MinDepth(root.left);
                int right = MinDepth(root.right);
                return Math.Min(left, right) + 1;
                */

                int min = int.MaxValue;
                if (root.left != null)
                {
                    min = Math.Min(MinDepth(root.left), min);
                }
                if (root.right != null)
                {
                    min = Math.Min(MinDepth(root.right), min);
                }
                return min + 1;
            }
        }
    }
}