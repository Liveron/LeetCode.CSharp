namespace LeetCode;

public static partial class Solution
{
    // time complexity = O(n)
    // space complexity = O(1)
    public static bool IsAnagram(string s, string t)
    {
        var dict = new Dictionary<char, int>(26);

        foreach (char c in s)
        {
            if (dict.TryGetValue(c, out int value))
            {
                dict.Remove(c);
                dict.Add(c, value + 1);
            }
            else dict.Add(c, 1);
        }

        foreach (char c in t)
        {
            if (dict.TryGetValue(c, out int value))
            {
                dict.Remove(c);
                if (value != 1)
                    dict.Add(c, value - 1);
            }
            else return false;
        }

        return dict.Count == 0;
    }
}
