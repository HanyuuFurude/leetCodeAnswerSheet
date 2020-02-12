using System;
using System.Collections.Generic;
using System.Text;

public partial class Solution
{
    public int MySqrt(int x)
    {
        if (x <= 2)
        { if (x == 2) { return 1; } return x; }
        int ans = (int)(Math.Pow(Math.E, (Math.Log(x) *0.5))+1e-5);
        return ans * (double)ans > x ? ans - 1 : ans;
        /**
         * 此处笔者使用.net core 3运行答案正确但是在leetcode oc上结果不一致，对2的特殊判断
         */
    }
}