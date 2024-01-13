int currentStreak = 0;

int MajorityElement(int[] nums)
{
    Array.Sort(nums);
    if (nums.Length == 0) return nums[0];
    for (int i = 1; i < nums.Length; i++)
    {
        if (nums[i] != nums[i - 1]) currentStreak = 0;
        currentStreak++;
        if (currentStreak > nums.Length / 2) return nums[i];
    }
    return nums[0];
}