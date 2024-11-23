namespace LeetCode;

public static partial class Solution
{
    public static int FirstUniqueChar(string s)
    {
        var table = new Dictionary<char, int>(26);

        foreach (char c in s)
        {
            if (table.TryGetValue(c, out int times))
            {
                table.Remove(c);
                table.Add(c, times + 1);
            }
            else table.Add(c, 1);
        }

        for (int i = 0; i < s.Length; i++)
        {
            if (table[s[i]] == 1)
                return i;
        }

        return -1;
    }
}
