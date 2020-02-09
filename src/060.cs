using System;
using System.Collections.Generic;
using System.Text;

public partial class Solution
{
    public string GetPermutation(int n, int k)
    {
        Func<int, char> int2char = (src) => { return (char)(src + 48); };
        const int MAX = 10;
        int[] table = new int[MAX]; table[0] = 1;--k;string res = "";int turn = n, select;
        for (var i = 1; i < MAX; ++i) { table[i] = table[i - 1] * i; }table[0] = 0;
        List<int> numbertable = new List<int>();
        for (var i = 1; i <= n; ++i) { numbertable.Add(i); }
        while (turn > 0)
        {
            if (turn == 1) { select = 0; }
            else { select = k / table[turn - 1]; k %= table[turn - 1]; }
            res += int2char(numbertable[select]);
            numbertable.RemoveAt(select); --turn;
        }
        return res;
    }
}