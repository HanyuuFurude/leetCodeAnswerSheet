using System;
using System.Collections.Generic;
using System.Text;

public partial class Solution
{
    public int[] PlusOne(int[] digits)
    {
        int key = digits.Length - 1;
        digits[key]++;
        while(key>0)
        {
            if (digits[key]>=10)
            {
                digits[key - 1]++;
                digits[key] -= 10;
            }
        }
    }
}