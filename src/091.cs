using System;
using System.Collections.Generic;
using System.Text;

public partial class Solution
{
    public int NumDecodings(string s)
    {
        if (s.Length == 0 || s[0]=='0')
        { return 0; }
        int[] arr = new int[s.Length + 1];
        arr[0] = 1; arr[1] = 1;
        for (var i = 1; i < s.Length; ++i)
        {
            if (s[i] != '0')
            {
                arr[i + 1] += arr[i];
            }
            if ((s[i - 1] == '1') || (s[i - 1] == '2' && s[i] <= '6'))
            {
                arr[i + 1] += arr[i - 1];
            }
        }
        return arr[s.Length];
    }
}