namespace LeetCode;

public static partial class Solution
{
    public static int[] TwoSum(int[] nums, int target)
    {
        var map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (map.TryGetValue(complement, out int value))
                return [value, i ];

            map[nums[i]] = i;
        }

        return [];
    }
}
