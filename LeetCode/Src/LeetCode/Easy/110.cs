using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_110
{
    public static void Func()
    {
        
    }
    public static bool IsBalanced(TreeNode root)
    {
        int depth = 0;
        return IsBalanced(root, ref depth);
    }
    public static bool IsBalanced(TreeNode root, ref int depth)
    {
        if (root == null)
        {
            depth = 0;
            return true;
        }
        else
        {
            int left = 0, right = 0;
            // 左右子树都平衡，还需要判断左右子树的高度差
            if (IsBalanced(root.left, ref left) && IsBalanced(root.right, ref right))
            {
                if (Math.Abs(left - right) <= 1)
                {
                    depth = Math.Max(left, right) + 1;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}