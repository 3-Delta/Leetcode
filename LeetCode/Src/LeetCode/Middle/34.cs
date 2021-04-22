public static class LC_34 {
    public static void Func() {
        int[] ls = new int[] { 5, 7, 7, 8, 8, 10 };
        SearchRange(ls, 6);
        SearchRange(ls, 8);
    }

    public static int[] SearchRange(int[] nums, int target) {
        int begin = -1;
        int end = -1;

        // 先二分查找， 然后居中向左，向右查找
        int index = BinarySearch(nums, 0, nums.Length - 1, target);
        if (index != -1) {
            begin = index;
            for (int i = index - 1 ; i >= 0 ; i--) {
                if (nums[i] == target) {
                    begin = i;
                }
            }
            end = index;
            for (int i = end + 1 ; i < nums.Length ; i++) {
                if (nums[i] == target) {
                    end = i;
                }
            }
        }

        return new int[] { begin, end};
    }

    public static int BinarySearch(int[] nums, int l, int r, int target) {
        if (nums != null && nums.Length > 0) {
            while (l <= r) {
                int mid = (l + r) / 2;
                int v = nums[mid];
                if (target == v) {
                    return mid;
                }
                else if (target > v) {
                    l = mid + 1;
                }
                else {
                    r = mid - 1;
                }
            }
        }
        return -1;
    }
}