using System.Text;

namespace LeetCode;

public static partial class Solution
{
    public static bool IsPalindrome(string s)
    {
        int start = 0, end = s.Length - 1;

        while (start < end)
        {
            char currStart = s[start];
            char currEnd = s[end];

            if (!IsAlphaNumeric(currStart, out char b))
            {
                start++;
            }
            else if (!IsAlphaNumeric(currEnd, out char d))
            {
                end--;
            }
            else
            {
                if (b != d) return false;
                start++;
                end--;
            }
        }

        return true;
    }

    private static bool IsAlphaNumeric(char c, out char b)
    {
        b = c;
        if (c >= 48 && c <= 57)
            return true;
        if (c >= 97 && c <= 122)
            return true;
        if (c >= 65 && c <= 90)
        {
            b = (char)(c + 32);
            return true;
        }

        return false;
    }
}

// 48 - 57 numbers
// 65 - 90 big letters
// 97 - 122 little letters