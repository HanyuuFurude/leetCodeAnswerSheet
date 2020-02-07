using System;
using System.Collections.Generic;
using System.Text;

public partial class Solution
{
    public IList<int> SpiralOrder(int[][] matrix)
    {
        List<int> res = new List<int>();
        if(matrix.Length==0)
        { return res; }
        int x = 0, y = 0, layer = 0, height = matrix.Length, width = matrix[0].Length, totcal = height * width;
        do
        {
            while (y < width - layer)
            { res.Add(matrix[x][y++]); }
            --y; ++x; if (res.Count == totcal) { break; }
            while (x < height - layer)
            { res.Add(matrix[x++][y]); }
            --x; --y; if (res.Count == totcal) { break; }
            while (y >= layer)
            { res.Add(matrix[x][y--]); }
            ++y; --x; if (res.Count == totcal) { break; }
            while (x > layer)
            { res.Add(matrix[x--][y]); }
            ++x; ++y; ++layer; if (res.Count == totcal) { break; }
        } while (true);
        return res;
    }
}