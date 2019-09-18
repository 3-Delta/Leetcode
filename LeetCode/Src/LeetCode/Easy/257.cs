using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_257
{
    public static void Func()
    {
    }

    public static IList<string> BinaryTreePaths(TreeNode root)
    {
        List<string> paths = new List<string>();
        BinaryTreePaths("", paths, root);
        return paths;
    }
    public static void BinaryTreePaths(string path, List<string> paths, TreeNode root)
    {
        if (root == null)
        {
            return;
        }
        else
        {
            path += root.val.ToString();
            if (IsLeaf(root))
            {
                paths.Add(path);
            }
            else
            {
                BinaryTreePaths(path, paths, root.left);
                BinaryTreePaths(path, paths, root.right);
            }
            path = path.Substring(0, path.Length - 1);
        }
    }

    public static bool IsLeaf(TreeNode node)
    {
        return node != null && node.left == null && node.right == null;
    }
}