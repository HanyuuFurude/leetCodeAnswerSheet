using System;
using System.Collections.Generic;
using System.Text;

public partial class Solution
{
    public IList<int> SpiralOrder(int[][] matrix)
    {
        int x = 0, width = matrix.Length - 1, c = matrix.Length / 2;
        List<int> res = new List<int>();
        do
        {
            for (var i = x; i < width - x; ++i)
            { res.Add(matrix[x][i]); }
            for (var i = x; i < width - x; ++i)
            { res.Add(matrix[i][width - x]); }
            for (var i = x; i < width - x; ++i)
            { res.Add(matrix[width - x][width-i]); }
            for (var i = x; i < width - x; ++i)
            { res.Add(matrix[width - i][x]); }
        } while (++x < c);
        if((width&1)==0)
        {
            res.Add(matrix[c][c]);
        }
        return res;
    }
}