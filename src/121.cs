using System;
using System.Collections.Generic;
using System.Text;

public partial class Solution
{
    public int MaxProfit(int[] prices)
    {
        if (prices.Length == 0) { return 0; }
        int[] leftMax = new int[prices.Length];
        int max = prices[prices.Length - 1], res = 0;
        for (var i = prices.Length - 1; i >= 0; --i)
        {
            max = prices[i] > max ? prices[i] : max;
            res = max - prices[i] > res ? max - prices[i] : res;
        }
        return res;
    }
}