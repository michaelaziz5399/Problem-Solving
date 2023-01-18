using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
 */
namespace Easy
{
    public class Best_Time_to_Buy_and_Sell_Stock
    {
        public int MaxProfit(int[] prices)
        {
            if (prices.Length == 0)
            {
                return 0;
            }
            int[] dis = new int[prices.Length];
            int diff = -prices[0];

            for (int i = 1; i < prices.Length; i++)
            {
                dis[i] = Math.Max(dis[i - 1], prices[i] + diff);
                diff = Math.Max(diff, -prices[i]);
            }
            return dis[dis.Length - 1];
        }
    }
}
