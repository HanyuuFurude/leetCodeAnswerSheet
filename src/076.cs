using System;
using System.Collections.Generic;
using System.Text;

public partial class Solution
{
    public string MinWindow(string s, string t)
    {
        if (t.Length > s.Length) { return ""; }
        int leftKey = 0, rightKey = 0;
        int minLength = int.MaxValue, minLeft = -1;
        int[] slideWindow;
        bool expand = true, finish = false;

        List<char> tKey = new List<char>();
        List<int> tSum = new List<int>();
        foreach (var i in t)
        {
            int index = tKey.IndexOf(i);
            if (index >= 0) { ++tSum[index]; }
            else { tKey.Add(i); tSum.Add(1); }
        }
        slideWindow = new int[tSum.Count];

        Func<int[], List<int>, bool> checkComplete = (x, y) =>
            {
                for (var i = 0; i < x.Length; ++i)
                { if (x[i] < y[i]) return false; }
                return true;
            };
        for (var i = 0; i < t.Length; ++i)
        {
            int res = tKey.IndexOf(s[i]);
            if (res >= 0) { ++slideWindow[res]; }
        }
        rightKey = t.Length - 1;
        while (!finish)
        {
            while (expand && rightKey < s.Length)
            {
                if (checkComplete(slideWindow, tSum))
                {
                    expand = false;
                    if (rightKey - leftKey + 1 < minLength)
                    {
                        minLength = rightKey - leftKey + 1;
                        minLeft = leftKey;
                    }
                    break;
                }
                else
                {
                    while (true)
                    {
                        ++rightKey;
                        if (rightKey == s.Length)
                        { finish = true; break; }
                        int res = tKey.IndexOf(s[rightKey]);
                        if (res >= 0) { ++slideWindow[res]; break; }
                    }
                }
            }
            while (!expand)
            {
                if (checkComplete(slideWindow, tSum))
                {
                    while (true)
                    {
                        int res = tKey.IndexOf(s[leftKey]);
                        ++leftKey;
                        if (res >= 0) { --slideWindow[res]; break; }
                    }
                }
                else
                {
                    if (rightKey - leftKey + 2 < minLength)
                    {
                        minLength = rightKey - leftKey + 2;
                        minLeft = leftKey - 1;
                    }
                    expand = true;
                }
            }
        }
        if (minLeft >= 0)
        { return s.Substring(minLeft, minLength); }
        else
        { return ""; }
    }
}