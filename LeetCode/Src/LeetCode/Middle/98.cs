using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_98
{
    public static void Func()
    {
        IsValidBST(null);
    }

    public static bool IsValidBST(TreeNode root)
    {
        /*
        // 错误方式，因为可能出现右子树的左节点 大于 root节点的问题
        // 比如：5,1,4,null,null,3,6
        if (root != null)
        {
            if (root.left != null)
            {
                if (root.left.val >= root.val)
                {
                    return false;
                }
            }
            if (root.right != null)
            {
                if (root.right.val <= root.val)
                {
                    return false;
                }
            }
            return IsValidBST(root.left) && IsValidBST(root.right);
        }
        else { return true; }
        */
        long preVal = long.MinValue;
        return IsValidBST(root, ref preVal);
    }

    // preVal是中序遍历的前一个节点的val
    // 中序遍历，左中右， 也就是先全部往左走，然后回溯根，然后走右！
    public static bool IsValidBST(TreeNode root, ref long preVal)
    {
        if (root == null) { return true; }

        // 左子树不合理
        if (!IsValidBST(root.left, ref preVal))
        {
            return false;
        }

        if (root.val <= preVal)
        {
            return false;
        }

        preVal = root.val;
        return IsValidBST(root.right, ref preVal);
    }
}