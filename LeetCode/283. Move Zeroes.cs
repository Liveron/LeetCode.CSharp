namespace LeetCode;

public static partial class Solution
{
    public static void MoveZeroes(int[] nums)
    {
        int left = 0, right = 0;

        while (right < nums.Length)
        {
            if (nums[right] != 0)
            {
                (nums[left], nums[right]) = (nums[right], nums[left]);
                left++;
            }                

            right++;
        }
    }
}
