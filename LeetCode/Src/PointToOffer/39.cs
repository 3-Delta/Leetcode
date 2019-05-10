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

        Console.WriteLine(tree.GetDepth(tree.root));
        int diff;
        tree.GetMaxDepthDiff(tree.root, out diff);
        Console.WriteLine(diff);
    }
}