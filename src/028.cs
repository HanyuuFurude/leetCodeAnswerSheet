using System;
using System.Collections.Generic;
using System.Text;

public partial class Solution
{
    public int StrStr(string haystack, string needle)
    {
        if (needle.Length == 0)
        { return 0; }
        int i = 0;
        while (i + needle.Length <= haystack.Length)
        {
            bool compare = true;
            for (var j = 0; j < needle.Length; ++j)
            {
                if (haystack[i + j] != needle[j])
                {
                    compare = false;
                }
            }
            if (compare)
            {
                return i;
            }
            else
            { ++i; }
        }
        return -1;
        //    if(needle=="")
        //    { return 0; }
        //    int[] next = new int[needle.Length];
        //    next[0] = -1;
        //    int k = -1, j = -1;
        //    while(j<needle.Length-1)
        //    {
        //        if (k==-1||needle[j] == needle[k])
        //        {
        //            ++j; ++k;
        //            if (needle[j] != needle[k])
        //            { next[j] = k; }
        //            else
        //            { next[j] = next[k]; }
        //        }
        //        else
        //        { k = next[k]; }
        //    }
        //    int key = 0;
        //    int handle = 0;
        //    while(key<haystack.Length)
        //    {
        //        if(handle==-1|| needle[handle]==haystack[key])
        //        { 
        //            ++key;++handle;
        //            if (handle == needle.Length)
        //            {return key - handle;}
        //        }
        //        else
        //        { handle = next[handle]; }
        //    }
        //    { return -1; };

    }
}