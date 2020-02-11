using System;
using System.Collections.Generic;
using System.Text;

public partial class Solution
{
    public int[] PlusOne(int[] digits)
    {
        int key = digits.Length - 1;
        digits[key]++;
        while (key > 0)
        {
            if (digits[key] >= 10)
            {
                digits[key - 1]++;
                digits[key] -= 10;
            }
            else
            { break; }
            --key;
        }
        if (digits[0] >= 10)
        {
            int[] newRes = new int[digits.Length + 1];
            newRes[0] = 1;
            for (var i = 0; i < digits.Length; ++i)
            {
                newRes[i + 1] = digits[i];
            }
            newRes[1] -= 10;
            digits = newRes;
        }
        return digits;
    }
}