using System;
using System.Collections.Generic;
using System.Text;

public partial class Solution
{
    //Tips：卡特兰数
    public int NumTrees(int n)
    {
        ulong res = 1;
        uint count = 0;
        while (++count < n)
        { res = res * (4 * count + 2) / (count + 2); }
        return (int)res;
    }
}