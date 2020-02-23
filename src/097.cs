using System;
using System.Collections.Generic;
using System.Text;

public partial class Solution
{
    public bool IsInterleave(string s1, string s2, string s3)
    {
        //动态规划
        if (s1.Length + s2.Length != s3.Length) { return false; }
        int s1Length = s1.Length, s2Length = s2.Length;
        bool[] arr = new bool[s2Length + 1];
        for (var i = 0; i <= s1Length; ++i)
        {
            for (var j = 0; j <= s2Length; ++j)
            {
                if (i == 0 && j == 0)
                { arr[j] = true; }
                else if (i == 0)
                { arr[j] = arr[j - 1] && (s2[j - 1] == s3[i + j - 1]); }
                else if (j == 0)
                { arr[j] = arr[j] && (s1[i - 1] == s3[i + j - 1]); }
                else
                {
                    arr[j] = (arr[j] && (s1[i - 1] == s3[i + j - 1])) ||
                        (arr[j - 1] && (s2[j - 1] == s3[i + j - 1]));
                }
            }
        }
        return arr[s2Length];
    }
}