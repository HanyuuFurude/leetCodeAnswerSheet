using System;
using System.Collections.Generic;
using System.Text;

public partial class Solution
{
    public bool IsNumber(string s)
    {
        int front = 0; int back = s.Length - 1;
        while (front<s.Length&& s[front] == ' ') ++front;
        while (back>front&& s[back] == ' ') --back;
        s = s.Substring(front, back - front + 1);
        int state = 0; int res;
        foreach (var i in s)
         {
            if (i >= '0' && i <= '9') res = 1;
            else if (i == 'e') res = 2;
            else if (i == '+' || i == '-') res = 3;
            else if (i == '.') res = 4;
            else return false;
            switch (state)
            {
                case 0:
                    if (res == 3) { state = 1; }
                    else if (res == 1) { state = 2; }
                    else if (res == 4) { state = 8; }
                    else { return false; }
                    break;
                case 1:
                    if (res == 1) { state = 2; }
                    else if (res == 4) { state = 8; }
                    else { return false; }
                    break;
                case 2:
                    if (res == 1) { break; }
                    else if (res == 4) { state = 3; }
                    else if (res == 2) { state = 5; }
                    else { return false; }
                    break;
                case 3:
                    if (res == 1) { state = 4; }
                    else if (res == 2) { state = 5; }
                    else { return false; }
                    break;
                case 4:
                    if (res == 1) { break; }
                    else if (res == 2) { state = 5; }
                    else { return false; }
                    break;
                case 5:
                    if (res == 3) { state = 6; }
                    else if (res == 1) { state = 7; }
                    else { return false; }
                    break;
                case 6:
                    if (res == 1) { state = 7; }
                    else { return false; }
                    break;
                case 7:
                    if (res == 1) { break; }
                    else { return false; }
                case 8:
                    if (res == 1) { state = 4; }
                    else { return false; }
                    break;
            }
        }
        if (state == 2 || state == 4 ||state==3|| state == 7)
        { return true; }
        else { return false; }
    }
}