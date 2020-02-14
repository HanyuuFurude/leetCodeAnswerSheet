using System;
using System.Collections.Generic;
using System.Text;
using Number074;

public partial class Solution
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        if (matrix.Length == 0 || matrix[0].Length == 0) { return false; }
        var c = new C(matrix, target);
        return c.result;
    }
}
namespace Number074
{
    class C
    {
        int[][] matrix; int target, LengthOfMatrix, LengthOfCol;
        public bool result;
        public C(int[][] mat, int tar)
        {
            matrix = mat; target = tar;
            LengthOfCol = matrix[0].Length;
            LengthOfMatrix = matrix.Length * LengthOfCol;
            result = !(search(0, LengthOfMatrix - 1) == -1);
        }
        private int fetchRow(int index)
        { return index / LengthOfCol; }
        private int fetchCol(int index)
        { return index % LengthOfCol; }
        private int search(int left, int right)
        {
            int middle, res;
            while (left <= right)
            {
                middle = (left + right) / 2;
                res = matrix[fetchRow(middle)][fetchCol(middle)];
                if (res == target) { return middle; }
                else if (res > target) { right = middle - 1; }
                else { left = middle + 1; }
            }
            return -1;
        }
    }
}