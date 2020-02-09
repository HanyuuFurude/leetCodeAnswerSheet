using System;
using System.Collections.Generic;
using System.Text;
public partial class Solution
{
    public int LengthOfLastWord(string s)
    {
        int lastSpace = -1;
        int key = -1;
        int length = s.Length - 1;
        while (length >= 0 && s[length] == ' ') { --length; }
        while (++key <= length)
        { if (s[key] == ' ') { lastSpace = key; } }
        return length - lastSpace;
    }
}