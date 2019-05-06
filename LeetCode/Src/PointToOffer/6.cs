using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class _6
{
    public static List<int> pres = new List<int>() { 1, 2, 4, 7, 3, 5, 6, 8 };
    public static List<int> middles = new List<int>() { 4, 7, 2, 1, 5, 3, 8, 6 };

    public static void Func()
    {
        BinaryTree<int> tree = new BinaryTree<int>();

        //tree.Create(pres);

        tree.CreateByPreMiddleDG(pres, middles);

        tree.PrintDGMiddle(tree.root);
        Console.WriteLine("============");
        tree.PrintDGPost(tree.root);
        Console.WriteLine("============");
        tree.PrintDGPre(tree.root);
        Console.WriteLine("============");
        tree.PrintLayer();
        Console.WriteLine("============");
        tree.PrintLayerChangeLine();
        Console.WriteLine("============");
        tree.PrintLayerChangeLineZhiShape();
        Console.WriteLine("============");
        tree.PrintXunhuanPre();
        Console.WriteLine("============");
        tree.PrintXunhuanMiddle();
    }
}