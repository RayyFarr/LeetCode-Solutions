int GetCommon(int[] nums1, int[] nums2)
{
    HashSet<int> hash = new HashSet<int>(nums2);
    for (int i = 0; i < nums1.Length; i++)
    {
        if (hash.Contains(nums1[i])) return nums1[i];
    }
    return -1;
}