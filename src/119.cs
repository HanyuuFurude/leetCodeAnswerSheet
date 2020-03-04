using System;
using System.Collections.Generic;
using System.Text;

public partial class Solution
{
    public IList<int> GetRow(int rowIndex)
    {
        int count = 0, temp = 1, newTemp;
        List<int> row = new List<int>();
        row.Add(1);
        while (count < rowIndex)
        {
            for (var i = 1; i < row.Count; ++i)
            {
                newTemp = row[i];
                row[i] += temp;
                temp = newTemp;
            }
            row.Add(1);
            ++count;
        }
        return row;
    }
}
