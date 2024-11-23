namespace LeetCode;

public static partial class Solution
{
    // O(n)
    public static int MaxProfit(int[] prices)
    {
        int buy = int.MaxValue, sell = 0, profit = 0;

        foreach (int price in prices)
        {
            if (price < sell)
            {
                profit += sell - buy;
                buy = price;
                sell = 0;
            }

            if (price < buy)
                buy = price;

            if (price > sell)
                sell = price;
        }

        return profit + sell - buy;
    }
}
