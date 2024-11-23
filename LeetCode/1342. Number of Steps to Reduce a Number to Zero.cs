namespace LeetCode;

public static partial class Solution
{
    public static int NumberOfSteps(int num)
    {
        //int steps = 0;
        //while (num != 1)
        //{
        //    if (num % 2 == 0)
        //    {
        //        num /= 2;
        //        steps++;
        //    }
        //    if (num % 2 != 0)
        //    {
        //        num--;
        //        steps++;
        //    }
        //}

        //return steps;

        int steps = 0;
        while (num > 0)
        {
            if ((num & 1) == 0)
            {
                num >>= 1;
                steps++;
            }
            if ((num & 1) == 1)
            {
                num--;
                steps++;
            }
        }

        return steps;
    }
}
