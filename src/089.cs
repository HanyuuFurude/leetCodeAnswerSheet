using System;
using System.Collections.Generic;
using System.Text;

public partial class Solution
{
    public IList<int> GrayCode(int n)
    {
        List<int> res = new List<int>();
        int Limit = (int)Math.Pow(2, n);
        for (var i = 0; i < Limit; ++i)
        {
            int index = 0;
            for (var j = n; j > 0; --j)
            {
                index = index << 1;
                index = index | ((i >> j) & 1) ^ (i >> (j - 1) & 1);
            }
            res.Add(index);
        }
        return res;
    }
}