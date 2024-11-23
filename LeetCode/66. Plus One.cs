namespace LeetCode;

public static partial class Solution
{
    public static int[] PlusOne(int[] digits)
    {
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            if (digits[i] + 1 != 10)
            {
                digits[i]++;
                return digits;
            }

            digits[i] = 0;
        }

        return [1, .. digits];
    }
}
