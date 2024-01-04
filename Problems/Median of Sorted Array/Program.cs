
//Current Solution. Not too clever but still beat about 99.11%.
double FindMedianSortedArrays(int[] nums1, int[] nums2) {
    List<int> nums = new List<int>(nums1);
    nums.AddRange(nums2);
    nums.Sort();
    if (nums.Count() % 2 != 0) return nums[nums.Count() / 2];
    return (nums[nums.Count() / 2 - 1] + nums[nums.Count() / 2]) / 2.0;
}