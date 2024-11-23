namespace LeetCode;

public static partial class Solution 
{
    // time complexity = O(n)
    // space complexity = O(1)
    public static int SingleNumber(int[] nums)
    {
        int answer = 0;

        foreach (int num in nums)
            answer ^= num;

        return answer;
    }
}
