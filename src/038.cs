using System;
using System.Collections.Generic;
using System.Text;

public partial class Solution
{
    public string CountAndSay(int n)
    {
        if(n==1)
        { return "1"; }
        string src = CountAndSay(n - 1);
        string res = "";
        int index = src[0] - 48;
        int count = 1;
        for(var i = 1;i<src.Length;++i)
        {
            if(src[i]==index + 48)
            { ++count; }
            else
            {
                res += Convert.ToString(count);
                res += index;
                index = src[i] - 48;
                count = 1;
            }
        }
        res += Convert.ToString(count);
        res += index;
        return res;
    }
}