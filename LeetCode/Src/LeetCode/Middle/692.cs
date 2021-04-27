using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_692
{
    public static void Func()
    {
        string[] words = new string[] { "the", "day", "is", "sunny", "the", "the", "the", "sunny", "is", "is" };
        TopKFrequent(words, 3);
    }

    public static IList<string> TopKFrequent(string[] words, int k) {
        if (words != null && words.Length > 0) {
            List<string> ls = new List<string>();
            // 大堆去实现
            return ls;
        }
        return null;
    }
}