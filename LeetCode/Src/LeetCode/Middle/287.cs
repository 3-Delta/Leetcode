using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_287
{
    public static void Func()
    {
        //  Floyd判圈算法
    }
    
    /*
     *  给定一个包含 n + 1 个整数的数组 nums ，其数字都在 1 到 n 之间（包括 1 和 n），可知至少存在一个重复的整数。
        假设 nums 只有 一个重复的整数 ，找出 这个重复的数
     */
    public static int FindDuplicate(int[] nums) 
    {
        /*
        int sum = 0;
        int length = nums.Length;
        for(int i = 0; i < length; ++ i)
        {
            sum += nums[i];
        }
        sum = sum - length * (length - 1) / 2;
        return sum;
        */

        // 将其看成是一个循环的链表，快慢指针循环
        int index1 = 0;
        int index2 = 0;
        do
        {
            index1 = nums[index1];
            index2 = nums[index2];
            index2 = nums[index2];
            
        }while (nums[index1] != nums[index2]);

        index1 = 0;
        // 找出在哪个位置为起始点，可证必定在圆圈起点相遇
        while(index1 != index2){
            index1 = nums[index1];
            index2 = nums[index2];
        }
        return index1;
    }
}
