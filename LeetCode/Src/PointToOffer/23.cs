using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class _23
{
    public static void Func()
    {
        // 使用队列进行层级遍历
        BinaryTree<int> preTree = new BinaryTree<int>();
        List<int> array = new List<int> { 10, 5, 12, 4, 7 };
        preTree.Create(array);

        preTree.PrintLayer();
    }
}