using System;
using System.Collections.Generic;
using System.Text;
using Number064;

public partial class Solution
{
    public int MinPathSum(int[][] grid)
    {
        var demo = new C(grid);
        return demo.search();
    }
}
namespace Number064
{
    class C
    {
        private int height, width;
        private int[][] matrix;
        private int[][] path;
        public C(int[][] src)
        {
            matrix = src;height = matrix.Length;width = matrix[0].Length;
            path = new int[height][];
            for(var i =0;i<height;++i)
            {
                path[i] = new int[width];
                for (var j = 0; j < width; ++j) { path[i][j] = -1; }
            }
        }
        public int search(int x=0,int y=0)
        {
            if (x >= height || y >= width) { return int.MaxValue; }
            if(path[x][y]>=0)
            { return path[x][y]; }
            if (x == height - 1 && y == width - 1)
            { path[x][y] = matrix[x][y]; return path[x][y]; }
            int additionR, additionD;
            path[x][y] = matrix[x][y];
            additionR = search(x + 1, y);
            additionD = search(x, y + 1);
            path[x][y] += additionD > additionR ? additionR : additionD;
            return path[x][y];
        }
    }
}