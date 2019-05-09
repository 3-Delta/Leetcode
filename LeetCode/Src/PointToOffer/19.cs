using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class _19
{
    public static void Func()
    {
        BinaryTree<int> vt = new BinaryTree<int>();
        vt.Create(new List<int>(){1, 2, 3, 4, 5, 6, 7, 8, 9 });
        vt.PrintLayer();

        vt.Mirror(vt.root);
        vt.PrintLayer();
    }
}