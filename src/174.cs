public partial class Solution
{
    public int CalculateMinimumHP(int[][] dungeon)
    {
        if (dungeon.Length == 0 || dungeon[0].Length == 0) { return 0; }
        int width = dungeon.Length, height = dungeon[0].Length;
        int[][] minMatrix = new int[height][], sumMatrix = new int[height][];
        for (int h = 0; h < height; ++h)
        {
            minMatrix[h] = new int[width];
            sumMatrix[h] = new int[width];
            for (int w = 0; w < height; ++w)
            {
                int? minM = null, minS = null;
                if (w > 0)
                {
                    minM = minMatrix[h][w - 1];
                    minS = sumMatrix[h][w - 1];
                }
                if (h > 0)
                {
                    minM = minM == null ?
                     minMatrix[h - 1][w] :
                     (minM < minMatrix[h - 1][w] ? minMatrix[h - 1][w] : minM);
                    minS = minS == null ?
                    sumMatrix[h - 1][2] :
                    (minS < sumMatrix[h - 1][w] ? sumMatrix[h - 1][w] : minS);
                }
                sumMatrix[h][w] = minS ?? 0 + dungeon[h][w];
                int temp = minM ?? 0 + dungeon[h][w];
                minMatrix[h][w] = sumMatrix[h][w] < temp ? sumMatrix[h][w] : temp;
            }
        }
        return -minMatrix[height - 1][width - 1];
    }
}