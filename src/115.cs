using System;
using System.Collections.Generic;
using System.Text;

public partial class Solution
{
    public int NumDistinct(string s, string t)
    {
        int[][] dp = new int[t.Length + 1][];
        for (var i = 0; i <= t.Length; ++i)
        { dp[i] = new int[s.Length + 1]; }
        for (var j = 0; j < s.Length + 1; ++j)
        { dp[0][j] = 1; }
        for (var i = 1; i < t.Length + 1; ++i)
        {
            for (var j = 1; j < s.Length + 1; ++j)
            {
                if (t[i - 1] == s[j - 1])
                {
                    dp[i][j] = dp[i - 1][j - 1] + dp[i][j - 1];
                }
                else
                {
                    dp[i][j] = dp[i][j - 1];
                }
            }
        }
        return dp[t.Length][s.Length];
    }
}