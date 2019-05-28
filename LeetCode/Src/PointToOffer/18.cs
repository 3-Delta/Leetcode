using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class _18
{
    public static void Func()
    {
        BinaryTree<int> mainTree = new BinaryTree<int>();
        mainTree.Create(new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17});
        mainTree.PrintLayerChangeLine();

        BinaryTree<int> subTree1 = new BinaryTree<int>();
        subTree1.Create(new List<int>() { 1, 4, 5, 8 });
        subTree1.PrintLayerChangeLine();

        BinaryTree<int> subTree2 = new BinaryTree<int>();
        subTree2.Create(new List<int>() { 2, 4, 5, 8 });
        subTree2.PrintLayerChangeLine();

        BinaryTree<int> subTree3 = new BinaryTree<int>();
        subTree3.Create(new List<int>() { 2, 4, 5, 8, 9 });
        subTree3.PrintLayerChangeLine();

        Console.WriteLine(mainTree.IsSubTree(mainTree.root, subTree1.root));
        Console.WriteLine(mainTree.IsSubTree(mainTree.root, subTree2.root));
        Console.WriteLine(mainTree.IsSubTree(mainTree.root, subTree3.root));
    }
}