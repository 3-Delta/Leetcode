using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://leetcode-cn.com/problems/range-sum-query-immutable/
// 使用查表方式解决问题
public static class LC_404
{
    public static void Func()
    {
        BinaryTree<int> tree = new BinaryTree<int>();
        tree.Create(new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8});
        Console.WriteLine(SumOfLeftLeaves(tree.root));
    }

    public static int SumOfLeftLeaves(BinaryTreeNode<int> root)
    {
        int sum = 0;
        SumOfLeftLeaves(root, false, ref sum);
        return sum;
    }
    public static void SumOfLeftLeaves(BinaryTreeNode<int> root, bool left, ref int sum)
    {
        if (root == null)
        {
            sum += 0;
        }
        else
        {
            if (left && IsLeaf(root))
            {
                sum += root.value;
            }

            SumOfLeftLeaves(root.left, true, ref sum);
            SumOfLeftLeaves(root.right, false, ref sum);
        }
    }

    public static bool IsLeaf(BinaryTreeNode<int> root)
    {
        return root != null && root.left == null && root.right == null;
    }
}