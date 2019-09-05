using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class _24
{
    public static void Func()
    {
        BinaryTree<int> preTree = new BinaryTree<int>();
        List<int> array = new List<int> { 10, 5, 12, 4, 7 };
        preTree.Create(array);
        preTree.PrintLayer();
        preTree.GetSumPath(preTree.root, 0, 22, new List<BinaryTreeNode<int>>() { });
        preTree.PrintLayer();
    }
}