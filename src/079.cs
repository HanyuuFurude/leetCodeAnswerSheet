using System;
using System.Collections.Generic;
using System.Text;
using Number079;

public partial class Solution
{
    public bool Exist(char[][] board, string word)
    {
        if (board.Length == 0 || board[0].Length == 0)
        { return false; }
        var demo = new C(board, word);
        return demo.run();
    }
}
namespace Number079
{
    public class C
    {
        //record walk history
        private int[] X, Y;
        private char[][] board;
        private string word;
        private int width, height;
        public C(char[][] matrix, string src)
        {
            board = matrix; word = src;
            X = new int[src.Length]; Y = new int[src.Length];
            height = matrix.Length; width = matrix[0].Length;
        }
        public bool run()
        {
            for (var i = 0; i < height; ++i)
            {
                for (var j = 0; j < width; ++j)
                {
                    if (search(i, j, 0))
                    { return true; }
                }
            }
            return false;
        }
        private bool search(int x, int y, int ptr)
        {
            if (board[x][y] == word[ptr])
            {
                X[ptr] = x; Y[ptr] = y;
                if (ptr == word.Length - 1) { return true; }
                if (x > 0 && !HadOccured(x - 1, y, ptr))
                { if (search(x - 1, y, ptr + 1)) { return true; } }
                if (x < height - 1 && !HadOccured(x + 1, y, ptr))
                { if (search(x + 1, y, ptr + 1)) { return true; } }
                if (y > 0 && !HadOccured(x, y - 1, ptr))
                { if (search(x, y - 1, ptr + 1)) { return true; } }
                if (y < width - 1 && !HadOccured(x, y + 1, ptr))
                { if (search(x, y + 1, ptr + 1)) { return true; } }
                return false;
            }
            return false;
        }
        private bool HadOccured(int x, int y, int deepth)
        {
            for (var i = 0; i < deepth; ++i)
            {
                if (X[i] == x && Y[i] == y)
                { return true; }
            }
            return false;
        }

    }
}