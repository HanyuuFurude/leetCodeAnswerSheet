using System;
using System.Collections.Generic;
using System.Text;
using Number037;
public partial class Solution
{
    public void SolveSudoku(char[][] board)
    {
        C demo = new C(board);
        return;
    }
}
namespace Number037
{
    public class C
    {
        public const int width = 9;
        private bool[][] row = new bool[width][];
        private bool[][] col = new bool[width][];
        private bool[][] blo = new bool[width][];
        private char[][] result;
        public C(char[][] board)
        {
            result = board;
            for (var i = 0; i < width; ++i)
            { row[i] = new bool[width]; col[i] = new bool[width]; blo[i] = new bool[width]; }
            for (var i = 0; i < width; ++i)
            {
                for (var j = 0; j < width; ++j)
                {
                    int res = Convert(result[i][j]);
                    if (res != -1)
                    {
                        row[i][res] = true;
                        col[j][res] = true;
                        blo[(i * width + j) / 27 * 3 + (i * width) % 27 % 9 / 3][res] = true;
                    }
                }
            }
        }
        private int Convert(char src)
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
        }
        private char Unconvert(int src)
        {
            switch (src)
            {
                case 0: return '1';
                case 1: return '2';
                case 2: return '3';
                case 3: return '4';
                case 4: return '5';
                case 5: return '6';
                case 6: return '7';
                case 7: return '8';
                case 8: return '9';
                default: return '.';
            }
        }
        private bool fill(int r, int c)
        {
            int res = Convert(result[r][c]);
            if (res != -1)
            {
                for (var i = r; i < width; ++i)
                {
                    for (var j = c; j < width; ++j)
                    { if (Convert(result[r][c]) != -1) { fill(i, j); } }
                }
                return true;
            }
            bool[] used = new bool[width];
            for (var i = 0; i < width; ++i)
            { used[i] = false; }
            for (var i = 0; i < width; ++i)
            {
                used[i] = row[r][i] ? true : used[i];
                used[i] = col[c][i] ? true : used[i];
                used[i] = blo[r / 3 * 3 + c / 3][i] ? true : used[i];
            }
            for (var i = 0; i < width; ++i)
            {
                if (used[i] == false)
                {
                    result[r][c] = Unconvert(i);
                    row[r][i] = true; col[c][i] = true; blo[r / 3 * 3 + c / 3][i] = true;
                    if(fill(r,c))
                    { return true; }
                    row[r][i] = false; col[c][i] = false; blo[r / 3 * 3 + c / 3][i] = false;
                    result[r][c] = Unconvert(-1);
                }
            }
            return true;
        }
    }
}