namespace LeetCode;

public static partial class Solution
{
    public static int MaximumWealth(int[][] accounts)
    {
        //int maxWealth = 0;

        //for (int i = 0; i < accounts.Length; i++)
        //{
        //    int sum = 0;

        //    for (int j = 0; j < accounts[i].Length; j++)
        //        sum += accounts[i][j];

        //    if (sum > maxWealth)
        //        maxWealth = sum;
        //}

        //return maxWealth;

        return accounts.Max(x => x.Sum());
    }
}
