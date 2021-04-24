using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://blog.csdn.net/qq_41593380/article/details/81146850
public class UnionSet
{
    public List<int> set = new List<int>();

    public UnionSet(List<int> set)
    {
        this.set = set;
    }
    public int GetRoot(int son)
    {
        int root = son;
        // t的上级不是自己，就继续向上
        while (root != set[root])
        {
            root = set[root];
        }

        // 路径压缩,提高查找效率
        while (son != root) //路径压缩
        {
            int parent = set[son]; // 获取son的上级
            set[son] = root;    // 设置son的新上级为root
            son = parent;          // son的老上级为新的son
        }
        return root;
    }

    // 合并朋友圈
    public void Merge(int sonLeft, int sonRight)
    {
        int x = GetRoot(sonLeft);
        int y = GetRoot(sonRight);
        if (x != y)
        {
            set[x] = y;
        }
    }
    public bool IsFriend(int sonLeft, int sonRight)
    {
        return GetRoot(sonLeft) == GetRoot(sonRight);
    }
}