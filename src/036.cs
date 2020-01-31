using System;
using System.Collections.Generic;
using System.Text;

public partial class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        bool[] visitedR = new bool[9];
        bool[] visitedL = new bool[9];
        bool[] visitedI = new bool[9];
        const int width = 9;
        Func<char, int> convert = (src) =>
        {
            switch (src)
            {
                case '1': return 0;
                case '2': return 1;
                case '3': return 2;
                case '4': return 3;
                case '5': return 4;
                case '6': return 5;
                case '7': return 6;
                case '8': return 7;
                case '9': return 8;
                //case '.':return -1;
                default: return -1;
            }

        };
        for (var i = 0; i < width; ++i)
        {
            for (var key = 0; key < width; ++key)
            { visitedR[key] = false; visitedL[key] = false; visitedI[key] = false; }
            for (var j = 0; j < width; ++j)
            {
                int res = convert(board[i][j]);
                if (res != -1)
                {
                    if (visitedR[res])
                    { return false; }
                    else
                    { visitedR[res] = true; }
                }
                res = convert(board[j][i]);
                if (res != -1)
                {
                    if (visitedL[res])
                    { return false; }
                    else
                    { visitedL[res] = true; }
                }
                res = convert(board[(i / 3) * 3 + (j / 3)][(i % 3) * 3 + (j % 3)]);
                if (res != -1)
                {
                    if (visitedI[res])
                    { return false; }
                    else
                    { visitedI[res] = true; }
                }
            }
        }
        return true;
    }
}