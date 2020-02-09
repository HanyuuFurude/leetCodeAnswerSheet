using System;
using System.Collections.Generic;
using System.Text;

public partial class Solution
{
    public int[][] GenerateMatrix(int n)
    {
        int[][] matrix = new int[n][];
        for (var i = 0; i < n; ++i)
        { matrix[i] = new int[n]; }
        int index = 0, limit = n * n, x = 0, y = -1, direct = 0;
        // direct: 0=right,1=down,2=left,3=up
        while (index < limit)
        {
            switch (direct)
            {
                case 0:
                    while (++y < n - x) matrix[x][y] = ++index;
                    --y; ++direct; break;
                case 1:
                    while (++x <= y) matrix[x][y] = ++index;
                    --x; ++direct; break;
                case 2:
                    while (--y >= n - x -1) matrix[x][y] = ++index;
                    ++y; ++direct; break;
                case 3:
                    while (--x > y) matrix[x][y] = ++index;
                    ++x; direct = 0; break;
                default: break;
            }
        }
        return matrix;
    }
}