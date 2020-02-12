using System;
using System.Collections.Generic;
using System.Text;

public partial class Solution
{
    public string AddBinary(string a, string b)
    {
        if (a.Length < b.Length) { string c = a; a = b; b = c; }
        int ptr = 0, EnddingA = a.Length - 1, EnddingB = b.Length - 1, flag = 0;
        string res = "";
        while (ptr <= EnddingB)
        {
            flag += a[EnddingA - ptr] + b[EnddingB - ptr] -96;
            res = (char)((flag & 1)+48) + res;
            flag = flag >> 1;++ptr;
        }
        while(ptr<=EnddingA)
        {
            flag += a[EnddingA - ptr] -48;
            res = (char)((flag & 1) + 48) + res;
            flag = flag >> 1;++ptr;
        }
        if (flag == 1) { res = "1" + res; }
        if (res.Length == 0) { return "0"; }
        return res;
    }
}