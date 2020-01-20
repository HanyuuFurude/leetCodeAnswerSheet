using System;
using System.Collections.Generic;
using System.Text;

public partial class Solution
{
    public bool IsValid(string s)
    {
        bool res = true;
        int length = s.Length;
        char[] stack = new char[length];
        int pointer = 0;
        for (var key = 0; key < length; ++key)
        {
            switch(s[key])
            {
                case '(':
                    stack[pointer] = '(';++pointer;break;
                case '{':
                    stack[pointer] = '{';++pointer;break;
                case '[':
                    stack[pointer] = '[';++pointer;break;
                case ')':
                    if(pointer==0)
                    { return false; }
                    else if (stack[pointer - 1] == '(')
                    { --pointer; break; }
                    else
                    { return false; }
                case ']':
                    if (pointer == 0)
                    { return false; }
                    else if (stack[pointer - 1] == '[')
                    { --pointer; break; }
                    else
                    { return false; }
                case '}':
                    if (pointer == 0)
                    { return false; }
                    else if (stack[pointer - 1] == '{')
                    { --pointer; break; }
                    else
                    { return false; }
            }
        }
        if(pointer>0)
        { return false; }
        return res; 
    }
}