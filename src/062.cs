using System;
using System.Collections.Generic;
using System.Text;

public partial class Solution
{
    public int UniquePaths(int m, int n)
    {
        --m;--n;
        long a = 1, b = 1, sum = m + n;
        for (var i = m + 1; i <= sum; ++i)
        {
            a *= i;
            if (b <= n && a % b == 0)
            { a /= b; ++b; }
        }
        return (int)a;
    }
}