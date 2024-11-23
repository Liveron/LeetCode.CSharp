namespace LeetCode;

public static partial class Solution
{
    public static double FindMaxAverage(int[] nums, int k)
    {
        int sum = 0;
        for (int i = 0; i < k; i++)
            sum += nums[i];

        double res = sum;

        for (int i = k;i < nums.Length; i++)
        {
            sum += nums[i] - nums[i - k];
            res = Math.Max(res, sum);
        }

        return res / k;
    }
}
