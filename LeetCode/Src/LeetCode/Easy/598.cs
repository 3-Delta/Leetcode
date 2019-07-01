using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

// https://leetcode-cn.com/problems/range-addition-ii/
// 又一个脑筋急转弯。。每次操作都是左上角区域从（0, 0）到（a, b）的矩形，必定重叠，所以找最小的a乘最小的b就行
public static class LC_598
{
    public static void Func()
    {
        List<Vector2Int> tuples = new List<Vector2Int>();
        tuples.Add(new Vector2Int(2, 2));
        tuples.Add(new Vector2Int(3, 3));

        Vector2Int result = tuples.Min();
        Console.WriteLine(result);
    }

    public static Vector2Int Min(this List<Vector2Int> ls)
    {
        Vector2Int ret = new Vector2Int(int.MaxValue, int.MaxValue);
        foreach (var one in ls)
        {
            ret = Vector2Int.Min(ret, one);
        }
        return ret;
    }
}