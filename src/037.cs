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
        private char[][] result;
        public C(char[][] board)
        {
            result = board;
            fill(0, 0);
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
            //print();
            int res = Convert(result[r][c]);
            if (res != -1)
            {
                bool first = true;
                for (var i = 0; i < width; ++i)
                {
                    for (var j = 0; j < width; ++j)
                    { if (first) { i = r; j = c; first = false; } if (Convert(result[i][j]) == -1) { return fill(i, j); } }
                }
                return true;
            }
            bool[] used = new bool[width];
            for (var i = 0; i < width; ++i)
            { used[i] = false; }
            for (var i = 0; i < width; ++i)
            {
                int tempRes = Convert(result[r][i]);
                if (tempRes != -1) { used[tempRes] = true; }
                tempRes = Convert(result[i][c]);
                if (tempRes != -1) { used[tempRes] = true; }
                tempRes = Convert(result[r / 3 * 3 + i / 3][c / 3 * 3 + i % 3]);
                if (tempRes != -1) { used[tempRes] = true; }
            }
            for (var i = 0; i < width; ++i)
            {
                if (used[i] == false)
                {
                    result[r][c] = Unconvert(i);
                    //print();
                    if (fill(r,c))
                    { return true; }
                    result[r][c] = Unconvert(-1);
                }
            }
            return false;
        }
        private void print()
        {
            for (var i = 0; i < width; ++i)
            {
                for (var j = 0; j < width; ++j)
                {
                    Console.Write($"{result[i][j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}