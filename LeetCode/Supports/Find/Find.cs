using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class Find
{
    // https://www.cnblogs.com/luoxn28/p/5767571.html
    public static bool BinaryFindXunhuan(List<int> list, int value, out int index)
    {
        bool ret = false;
        index = -1;
        if (list != null && list.Count > 0)
        {
            int left = 0;
            int right = list.Count - 1;
            
            while (left <= right) // 必须<=,例如：数组只有一个元素进行二分查找
            {
                int middle = (left + right) / 2;
                if (list[middle] == value)
                {
                    ret = true;
                    index = middle;
                    break;
                }
                else if (list[middle] > value)
                {
                    right = middle - 1;
                    // 不可以 right = middle;例如：如果是只有一个元素，那么就可能出现死循环的情况，如只有一个元素2，但是找1
                }
                else if (list[middle] < value)
                {
                    left = middle + 1;
                    // 不可以 left = middle;
                }
            }
            if (!ret)
            {
                index = right;
            }
        }
        return ret;
    }
    public static bool BinaryFindDG(List<int> list, int left, int right, int value, out int index)
    {
        bool ret = false;
        index = -1;
        if (list != null)
        {
            if (left <= right)
            {
                int middle = (left + right) / 2;
                if (list[middle] == value)
                {
                    ret = true;
                    index = middle;
                }
                else if (list[middle] > value)
                {
                    right = middle - 1;
                    ret = BinaryFindDG(list, left, right, value, out index);
                }
                else if (list[middle] < value)
                {
                    left = middle + 1;
                    ret = BinaryFindDG(list, left, right, value, out index);
                }
                // 因为整个递归连使用了一个index，因为都是out的
            }
            else
            {
                index = right;
            }
        }
        return ret;
    }
    // 查找第一个相等的元素，也就是说等于查找key值的元素有好多个，返回这些元素最左边的元素下标。
    public static int findFirstEqual(int[] array, int key)
    {
        int left = 0;
        int right = array.Length - 1;

        // 这里必须是 <=
        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (array[mid] >= key) 
            // 关键是这里：逐渐往左边收缩，举个例子，加入第一次mid就已经 == key,那么此时 right = mid - 1;的意思就是继续往左边收缩
            // 收缩到：此时right指向了第一个<key的值，而此时就只剩下左边left往右收缩。最终因为left>right跳出循环，自然此时left就是第一个>=的值
            {
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }
        if (left < array.Length && array[left] == key)
        {
            return left;
        }

        return -1;
    }
    public static int FindIndexInRange<T>(T target, List<T> nums, int left, int right)
    {
        int index = -1;
        if (nums != null && nums.Count > 0 && 0 <= left && left <= right && right < nums.Count)
        {
            for (int i = 0, count = nums.Count; i < count; ++i)
            {
                if (nums[i].Equals(target))
                {
                    index = i;
                    break;
                }
            }
        }
        return index;
    }
}