using System;
using System.Collections.Generic;
using System.Text;

public partial class Solution
{
    public double MyPow(double x, int n)
    {
        double sum = 1;
        double fact = x;
        if (n < 0) {
            fact = 1 / fact; n = -n;
            if(n==int.MinValue)
            {sum *= fact;n = int.MaxValue;}
        }
        while (n > 0)
        {
            if ((n & 1) == 1)
            { sum *= fact; }
            fact *= fact;
            n = n >> 1;
        }
        return sum;
    }
}