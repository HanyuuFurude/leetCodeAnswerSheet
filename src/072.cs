using System;
using System.Collections.Generic;
using System.Text;

public partial class Solution
{
    public int MinDistance(string word1, string word2)
    {
        int LengthOf1 = word1.Length, LengthOf2 = word2.Length;
        if (LengthOf1 == 0 || LengthOf2 == 0) { return LengthOf1 + LengthOf2; }

        int[][] distance = new int[LengthOf1 + 1][];
        for (var i = 0; i < LengthOf1 + 1; ++i) { distance[i] = new int[LengthOf2 + 1]; }
        for (var i = 0; i < LengthOf1 + 1; ++i) { distance[i][0] = i; }
        for (var i = 1; i < LengthOf2 + 1; ++i) { distance[0][i] = i; }
        for (var i = 1; i < LengthOf1 + 1; ++i)
        {
            for (var j = 1; j < LengthOf2 + 1; ++j)
            {
                int left = distance[i - 1][j] + 1;
                int down = distance[i][j - 1] + 1;
                int slash = distance[i - 1][j - 1];
                if (word1[i - 1] != word2[j - 1]) { ++slash; }
                slash = slash < left ? slash : left;
                slash = slash < down ? slash : down;
                distance[i][j] = slash;
            }
        }
        return distance[LengthOf1][LengthOf2];
    }
}