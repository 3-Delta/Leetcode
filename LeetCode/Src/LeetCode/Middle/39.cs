using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_39
{
    public static void Func()
    {
        /*
         给定一个无重复元素的数组 candidates 和一个目标数 target ，找出 candidates 中所有可以使数字和为 target 的组合。
         candidates 中的数字可以无限制重复被选取。

         说明：
            所有数字（包括 target）都是正整数。
            解集不能包含重复的组合。
         */
    }
    public static IList<IList<int>> CombinationSum(int[] candidates, int target) {
        IList<IList<int>> ls2 = new List<IList<int>>();
        IList<int> ls1 = new List<int>();

        CombinationSum(candidates, target, 0, ls2, ls1);
        return ls2;
    }

    // 回溯
    public static void CombinationSum(int[] candidates, int target, int index, IList<IList<int>> ls2, IList<int> ls1) {
        if (index >= candidates.Length) {
            return;
        }

        if (target == 0) {
            // 注意这里的deepcopy
            ls2.Add(new List<int>(ls1));
            return;
        }

        // 8 = 2 + 2 + 2 + 2,也就是盯着某一个逐渐尝试下去
        CombinationSum(candidates, target, index + 1, ls2, ls1);

        // 第一个尝试之后，尝试之后的
        int current = candidates[index];
        if (target - current >= 0) {
            ls1.Add(current);
            CombinationSum(candidates, target - current, index, ls2, ls1);
            ls1.Remove(current);
        }
    }
}