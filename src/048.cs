using System;
using System.Collections.Generic;
using System.Text;

public partial class Solution
{
    public void Rotate(int[][] matrix)
    {
        int width = matrix.Length;
        int border = width - 1;
        int r = (width + 1) / 2;
        int c = width / 2;
        int temp;
        for (var i = 0; i < r; ++i)
        {
            for (var j = 0; j < c; ++j)
            {
                temp = matrix[i][j];
                matrix[i][j] = matrix[border - j][i];
                matrix[border - j][i] = matrix[border - i][border - j];
                matrix[border - i][border - j] = matrix[j][border - i];
                matrix[j][border - i] = temp;
            }
        }
    }
}