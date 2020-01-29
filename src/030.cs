using System;
using System.Collections.Generic;
using System.Text;

public partial class Solution
{
    public IList<int> FindSubstring(string s, string[] words)
    {
        List<int> res = new List<int>();
        if(s.Length==0||words.Length==0)
        { return res; }
        List<string> pairValue = new List<string>();
        List<int> pairCount = new List<int>();
        int size = words.Length;
        int wordLength = words[0].Length;
        foreach(var i in words)
        {
            if(pairValue.Contains(i))
            { ++pairCount[pairValue.IndexOf(i)]; }
            else
            { pairValue.Add(i);pairCount.Add(1); }
        }
        int limits = s.Length - wordLength + 1;
        for (var offset = 0; offset < wordLength; ++offset)
        {
            List<int> pair = new List<int>();
            for (var ptr = 0; ptr+offset < limits; ptr += wordLength)
            { pair.Add(pairValue.IndexOf(s.Substring(offset + ptr, wordLength))); }
            int input = size-1;
            int[] window = new int[pairCount.Count];
            bool skip = true;
             while(input<pair.Count)
            {
                if (!skip)
                {
                    if (pair[input] == -1)
                    { skip = true; input += size; continue; }
                    ++window[pair[input]];
                    --window[pair[input - size]];
                    bool fastskip = false;
                    for (var i = 0; i < pairCount.Count; ++i)
                    {
                        if (pairCount[i] != window[i])
                        { ++input; fastskip = true; }
                    }
                    if(fastskip)
                    { continue; }
                    res.Add((input - size + 1) * wordLength + offset);
                    ++input;
                }
                else
                {
                    for (var i = 0; i < pairCount.Count; ++i)
                    { window[i] = 0; }
                    bool fastjump = false;
                    for (var i = 0; i < size; ++i)
                    {
                        if (pair[input - i] == -1)
                        { input = input - i + size; fastjump = true; break; }
                        else
                        { ++window[pair[input - i]]; }
                    }
                    if (fastjump)
                    { continue; }
                    skip = false;
                    bool same = true;
                    for (var i = 0; i < pairCount.Count; ++i)
                    {
                        if (pairCount[i] != window[i])
                        { same = false;break ; }
                    }
                    if (same)
                    {
                        res.Add((input - size + 1)*wordLength+offset);
                    }
                    ++input;
                }
            }
        }
        return res;
    }
}