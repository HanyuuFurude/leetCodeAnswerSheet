using System;
using System.Collections.Generic;
using System.Text;

public partial class Solution
{
    public bool IsPalindrome(string s)
    {
        Func<char, char> LowerCase = (src) =>
        {
            if (src >= 'A' && src <= 'Z') { return (char)(src + 32); }
            if (src >= '0' && src <= '9' || src >= 'a' && src <= 'z') { return src; }
            return 'N';
        };
        int left = 0, right = s.Length - 1;
        while (left < right)
        {
            while (left < right && LowerCase(s[left]) == 'N') { ++left; }
            while (left < right && LowerCase(s[right]) == 'N') { --right; }
            if (LowerCase(s[left]) != LowerCase(s[right])) { return false; }
            ++left; --right;
        }
        return true;
    }
}
