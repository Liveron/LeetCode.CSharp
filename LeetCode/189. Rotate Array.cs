namespace LeetCode;

public static partial class Solution
{
    public static void Rotate(int[] nums, int k)
    {
        k %= nums.Length;

        for (int i = 0; i < nums.Length / 2; i++)
            (nums[i], nums[nums.Length - i - 1]) =
                (nums[nums.Length - i - 1], nums[i]);

        for (int i = 0; i < k / 2; i++)
            (nums[i], nums[k - i - 1]) = (nums[k - i - 1], nums[i]);

        for (int i = k; i < (nums.Length - k) / 2 + k; i++)
            (nums[i], nums[nums.Length - 1 - i + k]) =
                (nums[nums.Length - 1 - i + k], nums[i]);
    }
}
