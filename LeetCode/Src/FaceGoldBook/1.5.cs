using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

// 面试题 01.05. 一次编辑
// 字符串有三种编辑操作:插入一个字符、删除一个字符或者替换一个字符。 给定两个字符串，编写一个函数判定它们是否只需要一次(或者零次)编辑。
public static class LC_GoldBook_1_5
{
    public static bool Func()
    {
        bool ret = OneEditAway("pale", "ple");
        return ret;
    }

    // 增删改
    public static bool OneEditAway(string first, string second)
    {
        if (first == second)
        {
            return true;
        }

        // 让短着居前，也就是first始终为短
        if (first.Length > second.Length)
        {
            // 交换
            string t = first;
            first = second;
            second = t;
        }

        for (int i = 0; i < first.Length; ++i)
        {
            if (first[i] != second[i])
            {
                // 改
                return first.Substring(i + 1) == second.Substring(i + 1) ||
                       //  长着删【其实和 短者增 是一样的】
                       first.Substring(i) == second.Substring(i + 1);
            }
        }

        // 长度差距在【0 - 1】之内
        return second.Length - first.Length <= 1;
    }
}