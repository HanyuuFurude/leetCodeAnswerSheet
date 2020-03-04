using System;
using System.Collections.Generic;
using System.Text;

public partial class Solution
{
    public int MaxProfit(int[] prices, bool remove = true)
    {
        if (prices.Length == 0) { return 0; }
        int Length = prices.Length, res = int.MinValue;
        int[] f = new int[Length];
        int[] b = new int[Length];
        int min = prices[0];
        f[0] = 0; b[Length - 1] = 0;
        for (int i = 1; i < Length; ++i)
        {
            f[i] = prices[i] - min > f[i - 1] ? prices[i] - min : f[i - 1];
            min = min < prices[i] ? min : prices[i];
        }
        int max = prices[Length - 1];
        for (var i = Length - 2; i >= 0; --i)
        {
            b[i] = max - prices[i] > b[i + 1] ? max - prices[i] : b[i + 1];
            max = max > prices[i] ? max : prices[i];
        }
        for (var i = 0; i < Length; ++i)
        {
            res = res > f[i] + b[i] ? res : f[i] + b[i];
        }
        return res;
    }
}