using System;

namespace LeetCodeProblems
{
    /// <summary>
    /// https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
    /// </summary>
    public class SellStock121
    {
        // https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
        public int MaxProfit(int[] prices)
        {
            int minValue = int.MaxValue;
            int maxProfit = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                if(minValue > prices[i])
                    minValue = prices[i];
                maxProfit = Math.Max(maxProfit, prices[i] - minValue);

            }
            return maxProfit;
        }
    }
}
