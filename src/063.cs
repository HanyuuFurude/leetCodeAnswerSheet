using System;
using System.Collections.Generic;
using System.Text;
using Number063;


public partial class Solution
{
    public int UniquePathsWithObstacles(int[][] obstacleGrid)
    {
        if(obstacleGrid[obstacleGrid.Length-1][obstacleGrid[0].Length-1]==1)
        { return 0; }
        var a = new C(obstacleGrid);
        return -a.search(0, 0);
    }
}
namespace Number063
{
    class C
    {
        private int[][] matrix;
        private int width, height;
        public C(int[][] src)
        {
            matrix = src;
            width = src[0].Length - 1;
            height = src.Length - 1;
        }
        public int search(int x, int y)
        {
            if (x == height && y == width)
            {
                matrix[x][y] = -1;
                return matrix[x][y];
            }
            if (x > height || y > width || matrix[x][y] == 1)
            { return 0; }
            if (matrix[x][y] < 0)
            { return matrix[x][y]; }
            matrix[x][y] += search(x + 1, y);
            matrix[x][y] += search(x, y + 1);
            if (matrix[x][y] == 0) { matrix[x][y] = 1; return 0; }
            return matrix[x][y];
        }
    }
}