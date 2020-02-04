
using System;
using System.Collections.Generic;
using System.Text;

public partial class Solution
{
    public bool IsMatch(string s, string p)
    {
        int si = 0, pi = 0, sii = -1, pii = -1, sLength = s.Length, pLength = p.Length;
        while (si < sLength)
        {
            if (pi < pLength && (s[si] == p[pi] || p[pi] == '?'))
            { ++si; ++pi; }
            else if (pi < pLength && p[pi] == '*')
            { sii = si; pii = pi++; }
            else if (sii >= 0)
            { si = ++sii; pi = pii + 1; }
            else { return false; }
        }
        while (pi < pLength && p[pi] == '*') ++pi;
        return pi == pLength;
    }
}
