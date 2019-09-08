using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class _39
{
    public static void Func()
    {
        BinaryTree<int> tree = new BinaryTree<int>();
        tree.Create(new List<int>() { 1, 2, 3, 4, 5, 6, 7 }, 0);
        tree.PrintLayer();

        Console.WriteLine(tree.MaxDepth(tree.root));
        int diff;
        tree.GetMaxDepthDiff(tree.root, out diff);
        Console.WriteLine(diff);
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