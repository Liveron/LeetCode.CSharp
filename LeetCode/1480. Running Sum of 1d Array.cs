namespace LeetCode;

public static partial class Solution
{
    public static int[] RunningSum(int[] nums)
    {
        var prefixes = new int[nums.Length];
        prefixes[0] = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            prefixes[i] = nums[i] + prefixes[i - 1];
        }

        return prefixes;
    }
}
