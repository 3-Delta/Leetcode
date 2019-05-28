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
        int[] array = new int[] { 5, 7, 6, 9, 11, 10, 8 };
        Console.WriteLine(preTree.IsPreOrder(array));

        BinaryTree<int> middleTree = new BinaryTree<int>();
        array = new int[] { 5, 7, 6, 9, 11, 10, 8 };
        Console.WriteLine(middleTree.IsMiddleOrder(array));

        BinaryTree<int> postTree = new BinaryTree<int>();
        array = new int[] { 5, 7, 6, 9, 11, 10, 8 };
        Console.WriteLine(postTree.IsPostOrder(array));
    }
}