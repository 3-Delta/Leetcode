using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { val = x; }
}

public static class LC_108
{
    public static void Func()
    {
        
    }
    public static TreeNode SortedArrayToBST(int[] nums)
    {
        return Create(nums, 0, nums.Length - 1);
    }

    private static TreeNode Create(int[] nums, int left, int right)
    {
        TreeNode node = null;
        if (left <= right)
        {
            int mid = (left + right) / 2;
            node = new TreeNode(nums[mid]);
            node.left = Create(nums, left, mid - 1);
            node.right = Create(nums, mid + 1, right);
        }
        else
        {
            node = null;
        }
        return node;
    }
}