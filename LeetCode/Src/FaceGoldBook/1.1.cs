using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;
/*
 * 作者：zhen-zhu-hao-hao-chi
 链接：https://leetcode-cn.com/problems/is-unique-lcci/solution/wei-yun-suan-fang-fa-si-lu-jie-shao-by-zhen-zhu-ha/
 来源：力扣（LeetCode）
 著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。 我们可以使用一个int类型的变量（下文用mark表示）来代替长度为26的bool数组。
*/
public static class LC_GoldBook_1_1
{
    public static bool Func()
    {
        return Gun("leetcode");
    }

    public static bool Gun(string input)
    {
        bool ret = false;
        int mark = 0;

        for (int i = 0, count = input.Length; i < count; ++i)
        {
            char current = input[i];
            int currentCharCode = current - 'a';

            // 当前位置已经非0
            if ((mark & (1 << currentCharCode)) != 0)
            {
                ret = false;
                break;
            }
            else
            {
                mark |= (1 << currentCharCode);
            }
        }

        return ret;
    }
}