using System;
using System.Collections.Generic;
using System.Text;

public partial class Solution
{
    public int LongestValidParentheses(string s)
    {
        int index = 0;
        int max = 0;
        while(index+max<s.Length)
        {
            int score = 0;
            int offset = 0;
            while(score>=0&&index+offset<s.Length)
            {
                if(s[index+offset]=='(')
                { ++score; }
                else
                { --score; }
                ++offset;
                if (score == 0)
                { max = max > offset ? max : offset; }
            }
            if (score < 0)
            { index += offset; }
            else
            { ++index; }
        }
        return max;
    }
}