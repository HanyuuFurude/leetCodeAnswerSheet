using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public partial class Solution
{
    public IList<string> GenerateParenthesis(int n)
    {
        n = n * 2;
        List<string> table = new List<string>();
        table.Add("");
        List<int> count = new List<int>();
        count.Add(0);
        for(var i = 0;i<n;++i)
        {
            List<string> tmpRes = new List<string>();
            List<int> tmpCount = new List<int>();
            for(var j = 0;j<table.Count;++j)
            {
                if(count[j]>0)
                {
                    tmpRes.Add(table[j] + ")");
                    tmpCount.Add(count[j] - 1);
                }
                if(count[j]<n-i)
                {
                    tmpRes.Add(table[j] + "(");
                    tmpCount.Add(count[j] + 1);
                }
            }
            table = tmpRes;
            count = tmpCount;
        }
        return table;

    }
    
}
