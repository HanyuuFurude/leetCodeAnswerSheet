using System;
using System.Collections.Generic;
using System.Text;

public partial class Solution
{
    public int Divide(int dividend, int divisor)
    {
        if (dividend == int.MinValue)
        {
            if (divisor == 1)
            { return int.MinValue; }
            else if (divisor == -1)
            { return int.MaxValue; }
        }
        if(dividend==int.MaxValue)
        {
            if(divisor==1)
            { return int.MaxValue; }
            else if(divisor==-1)
            { return -int.MaxValue; }
        }
        const int limit = int.MinValue >> 1;
        bool negative = dividend < 0 ^ divisor < 0;
        divisor = divisor > 0 ? -divisor : divisor;
        dividend = dividend > 0 ? -dividend : dividend;
        int res = 0;
        int index = 1;
        int value = divisor;
        while (value > dividend&&value>=limit)
        { index = index<<1; value =value<<1; }
        while(index>0&&dividend<0)
        {
            if(value>=dividend)
            { dividend -= value;res += index; }
            index = index >> 1; value = value >> 1;
        }
        if(negative)
        {
            res = -res;
        }
        return res;
    }
}