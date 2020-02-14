public partial class Solution
{
    public void SetZeroes(int[][] matrix)
    {
        if (matrix.Length == 0 || matrix[0].Length == 0) { return; }
        bool IsFirstRowZero = false, IsFirstColZero = false;
        int LengthOfRow = matrix.Length, LengthOfCol = matrix[0].Length;
        for (var i = 0; i < LengthOfRow; ++i)
        { if (matrix[i][0] == 0) { IsFirstColZero = true; break; } }
        for (var i = 0; i < LengthOfCol; ++i)
        { if (matrix[0][i] == 0) { IsFirstRowZero = true; break; } }
        for (var i = 1; i < LengthOfRow; ++i)
        {
            for (var j = 1; j < LengthOfCol; ++j)
            {
                if (matrix[i][j] == 0) { matrix[0][j] = 0; matrix[i][0] = 0; }
            }
        }
        for (var i = 1; i < LengthOfRow; ++i)
        {
            if (matrix[i][0] == 0)
            { for (var j = 1; j < LengthOfCol; ++j) matrix[i][j] = 0; }
        }
        for (var i = 1; i < LengthOfCol; ++i)
        {
            if (matrix[0][i] == 0)
            { for (var j = 1; j < LengthOfRow; ++j) matrix[j][i] = 0; }
        }
        if (IsFirstColZero) { for (var i = 0; i < LengthOfRow; ++i) matrix[i][0] = 0; }
        if (IsFirstRowZero) { for (var i = 0; i < LengthOfCol; ++i) matrix[0][i] = 0; }

    }
}