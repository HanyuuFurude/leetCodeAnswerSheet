using System;
using System.Collections.Generic;
using System.Text;

public partial class Solution
{
    public int[][] Insert(int[][] intervals, int[] newInterval)
    {

        int[][] result;
        List<int[]> res = new List<int[]>();
        if (intervals.Length == 0)
        { result = new int[1][];result[0] = newInterval; }
        foreach (var i in intervals)
        { res.Add(i); }
        for (var i = 0; i < res.Count; ++i)
        {
            if (newInterval[1] < res[i][0])
            { res.Insert(i, newInterval); break; }
            else if (newInterval[0] <= res[i][1])
            {
                res[i][0] = res[i][0] < newInterval[0] ? res[i][0] : newInterval[0];
                res[i][1] = res[i][1] > newInterval[1] ? res[i][1] : newInterval[1];
                while (i + 1 < res.Count && res[i + 1][0] <= res[i][1])
                {
                    res[i][1] = res[i][1] > res[i + 1][1] ? res[i][1] : res[i + 1][1];
                    res.RemoveAt(i + 1);
                }
                break;
            }else if(i==res.Count-1)
            {
                res.Add(newInterval);
            }

        }
        result = new int[res.Count][];
        for (var i = 0; i < res.Count; ++i)
        { result[i] = res[i]; }
        return result;
    }
}