namespace LeetCode;

public static partial class Solution
{
    public static void ReverseString(char[] s)
    {
        for (int i = 0; i < s.Length / 2; i++)
            (s[i], s[^(i + 1)]) = (s[^(i + 1)], s[i]);
    }
}
