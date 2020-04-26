using System;
public partial class Solution
{
    public int CompareVersion(string version1, string version2)
    {
        var a = version1.Split('.');
        var b = version2.Split('.');
        int count = Math.Min(a.Length, b.Length);
        for (var i = 0; i < count; ++i)
        {
            if (int.Parse(a[i]) > int.Parse(b[i]))
            { return 1; }
            else if (int.Parse(a[i]) < int.Parse(b[i]))
            { return -1; }
        }
        var c = a.Length > b.Length ? a : b;
        for (var i = Math.Min(a.Length, b.Length); i < Math.Max(a.Length, b.Length); ++i)
        {
            if (int.Parse(c[i]) != 0)
            { return a.Length > b.Length ? 1 : -1; }
        }
        return 0;
    }
}