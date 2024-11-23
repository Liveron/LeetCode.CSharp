namespace LeetCode;

public static partial class Solution
{
    public static int[] Intersect(int[] nums1, int[] nums2)
    {
        Array.Sort(nums1);
        Array.Sort(nums2);

        int minLength = Math.Min(nums1.Length, nums2.Length);

        var result = new List<int>(minLength);

        int i = 0,j = 0;

        while (i < nums1.Length && j < nums2.Length)
        {
            if (nums1[i] == nums2[j])
            {
                result.Add(nums1[i]);
                i++;
                j++;
            }
            else if (nums1[i] < nums2[j]) i++;
            else j++;
        }

        return [.. result];
    }
}
