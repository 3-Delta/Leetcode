public static class LC_33 {
    // 33. 搜索旋转排序数组
    public static void Func() {
        int[] ls = new int[] { 4, 5, 6, 7, 0, 1, 2 };
        int rlt = Search(ls, 1);
    }

    // 将数组一分为二，其中一定有一个是有序的，另一个可能是有序，也能是部分有序。
    // 此时有序部分用二分法查找。无序部分再一分为二，其中一个一定有序，另一个可能有序，可能无序。就这样循环.
    public static int Search(int[] nums, int target) {
        int left = 0;
        int right = nums.Length - 1;

        // <=
        while (left <= right) {
            int mid = (left + right) / 2;
            if (nums[mid] == target)
                return mid;

            // 左边整体有序
            if (nums[left] <= nums[mid]) {
                if (nums[left] <= target && target < nums[mid])
                    right = mid - 1;
                else
                    left = mid + 1;
            }
            // 右边整体有序
            else {
                if (nums[mid] < target && target <= nums[right])
                    left = mid + 1;
                else
                    right = mid - 1;
            }
        }
        return -1;
    }
}