using System;
using System.Collections.Generic;
using System.Text;

public partial class Solution
{
    public int[][] Merge(int[][] intervals)
    {
        List<int[]> res = new List<int[]>();
        foreach (var i in intervals)
        {
            if (res.Count == 0)
            { res.Add(i);  continue; }
            for (var j = 0; j < res.Count; ++j)
            {
                if (i[1] < res[j][0])
                { res.Insert(j, i); break; }
                else if (i[0] <= res[j][1])
                {
                    res[j][0] = res[j][0] < i[0] ? res[j][0] : i[0];
                    res[j][1] = res[j][1] > i[1] ? res[j][1] : i[1];
                    while (res.Count > j + 1 && res[j + 1][0] <= res[j][1])
                    {
                        res[j][1] = res[j][1] > res[j + 1][1] ? res[j][1] : res[j + 1][1];
                        res.RemoveAt(j + 1);
                    }
                    break;
                }
                else if (j == res.Count - 1)
                { res.Add(i); break; }
            }
        }
        int[][] result = new int[res.Count][];
        for (var i = 0; i < res.Count; ++i)
        { result[i] = res[i]; }
        return result;
    }
}