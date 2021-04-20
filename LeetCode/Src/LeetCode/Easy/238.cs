using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_238 {
    public static void Func() { }

    public static int[] ProductExceptSelf(int[] nums) {
        int length = nums.Length;
        int[] answer = new int[nums.Length];

        // answer[i] 表示0 ~ i-1  所有元素乘积
        // 注意不是：answer[i] 表示0 ~ i 所有元素乘积，不包括answer[i];
        answer[0] = 1;
        for (int i = 1; i < length; ++i) {
            answer[i] = answer[i - 1] * nums[i - 1];
        }

        // r 表示 i+1 到length的所有元素乘积
        // 倒着相乘
        int r = 1;
        for (int i = length - 1; i >= 0; --i) {
            answer[i] = answer[i] * r;
            r *= nums[i];
        }

        return answer;
    }
    
    // 除了nums[i]之外，左右最大值的和
    // 可以利用两个answer，一个从左到右，一个从右到左配合得到max
}
