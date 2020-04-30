using System;
public partial class Solution
{
    public int CalculateMinimumHP(int[][] dungeon)
    {
        if (dungeon.Length == 0 || dungeon[0].Length == 0) { return 0; }
        int width = dungeon[0].Length, height = dungeon.Length;
        int[][] calcMat = new int[height][];
        for (int h = height - 1; h >= 0; --h)
        {
            calcMat[h] = new int[width];
            for (int w = width - 1; w >= 0; --w)
            {
                int? res = null;
                if (w < width - 1)
                { res = calcMat[h][w + 1]; }
                if (h < height - 1)
                { res = Math.Min(res ?? calcMat[h + 1][w], calcMat[h + 1][w]); }
                calcMat[h][w] = Math.Max(1, (res ?? 1) - dungeon[h][w]);
            }
        }
        return calcMat[0][0];
    }
}