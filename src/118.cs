using System;
using System.Collections.Generic;
using System.Text;

public partial class Solution
{
    public IList<IList<int>> Generate(int numRows)
    {
        List<IList<int>> res = new List<IList<int>>();
        List<int> row = new List<int>();
        if (numRows == 0) { return res; }
        row.Add(1);
        res.Add(row);
        int count = 0;
        while (count < numRows - 1)
        {
            row = new List<int>();
            row.Add(1);
            for (var i = 0; i < res[count].Count - 1; ++i)
            {
                row.Add(res[count][i] + res[count][i + 1]);
            }
            row.Add(1);
            res.Add(row);
            ++count;
        }
        return res;
    }
}