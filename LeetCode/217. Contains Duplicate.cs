namespace LeetCode;

public static partial class Solution
{
    public static bool ContainsDuplicate(int[] nums)
    {
        var set = new HashSet<int>(nums.Length);

        foreach (int num in nums)
        {
            if (set.Contains(num)) return true;
            set.Add(num);
        }

        return false;
    }
}
