using System;
using System.Collections.Generic;
using System.Text;

public partial class Solution
{
    public int MinimumTotal(IList<IList<int>> triangle)
    {
        //dp
        if (triangle.Count == 0) { return 0; }
        if (triangle.Count == 1) { return triangle[0][0]; }
        int count = 1, layerNumber = triangle.Count;
        while (count < layerNumber)
        {
            for (var i = 0; i <= count; ++i)
            {
                if (i == 0) { triangle[count][i] += triangle[count - 1][0]; }
                else if (i == count) { triangle[count][i] += triangle[count - 1][i - 1]; }
                else
                {
                    triangle[count][i] += triangle[count - 1][i - 1] < triangle[count - 1][i] ? triangle[count - 1][i - 1] : triangle[count - 1][i];
                }
            }
            ++count;
        }
        int min = triangle[layerNumber - 1][0];
        for (var i = 1; i < count; ++i)
        {
            min = min < triangle[layerNumber - 1][i] ? min : triangle[layerNumber - 1][i];
        }
        return min;
    }
}