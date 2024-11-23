namespace LeetCode;

public static partial class Solution
{
    // time complexity = O(log(n))
    public static int Reverse(int x)
    {
        int reversed = 0;

        while (x != 0)
        {
            int pop = x % 10;
            x /= 10;

            if (reversed > int.MaxValue / 10 ||
                (reversed == int.MaxValue && pop > 7))
                return 0;

            if (reversed < int.MinValue / 10 ||
                (reversed == int.MinValue / 10 && pop < -8))
                return 0;

            reversed = reversed * 10 + pop;
        }

        return reversed;
    }
}
