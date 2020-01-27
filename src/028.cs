using System;
using System.Collections.Generic;
using System.Text;

public partial class Solution
{
    public int StrStr(string haystack, string needle)
    {
        if(needle=="")
        { return 0; }
        int[] next = new int[needle.Length];
        next[0] = -1;
        int k = -1, j = -1;
        while(j<needle.Length-1)
        {
            if (k==-1||needle[j] == needle[k])
            {
                ++j; ++k;
                if (needle[j] != needle[k])
                { next[j] = k; }
                else
                { next[j] = next[k]; }
            }
            else
            { k = next[k]; }
        }
        int key = 0;
        int handle = 0;
        while(key<haystack.Length&&handle<needle.Length)
        {
            if(needle[handle]==haystack[key])
            { ++key;++handle; }
            else
            { key += handle - next[handle]; }
        }
        if(handle==needle.Length)
        {
            return key - handle;
        }
        else
        { return -1; };

    }
}