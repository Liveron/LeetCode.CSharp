namespace LeetCode;

public static partial class Solution
{
    public static int RemoveDuplicates(int[] nums)
    {
        int i = 0;
        foreach (int num in nums)
            if (nums[i] != num)
                nums[++i] = num;

        return i + 1;
    }
}
