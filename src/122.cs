using System;
using System.Collections.Generic;
using System.Text;

public partial class Solution
{
    public int MaxProfit(int[] prices,int remove = 0)
    {
        if (prices.Length == 0) { return 0; }
        int res = 0;
        for (var i = 0; i < prices.Length - 1; ++i)
        { if (prices[i + 1] - prices[i] > 0) { res += prices[i + 1] - prices[i]; } }
        return res;
    }
}