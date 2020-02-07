using System;
using System.Collections.Generic;
using System.Text;
using Number052;
public partial class Solution
{
    public int TotalNQueens(int n)
    {
        var demo = new C(n);
        return demo.getRes().Count;
    }
}
namespace Number052
{
    public class C
    {
        List<IList<string>> res;
        List<string> index;
        int[] table;
        int width;
        public C(int n)
        {
            width = n;
            res = new List<IList<string>>();
            index = new List<string>();
            for (var i = 0; i < n; ++i)
            {
                index.Add("");
                for (var j = 0; j < i; ++j) { index[i] += '.'; }
                index[i] += 'Q';
                for (var j = i + 1; j < n; ++j) { index[i] += '.'; }
            }
            table = new int[n];
            search();
        }
        public void search(int row = 0)
        {
            bool[] available = new bool[width];
            for (var i = 0; i < width; ++i)
            { available[i] = true; }
            for (var i = 0; i < row; ++i)
            {
                available[table[i]] = false;
                if (table[i] - (row - i) >= 0)
                { available[table[i] - (row - i)] = false; }
                if (table[i] + (row - i) < width)
                { available[table[i] + (row - i)] = false; }
            }
            for (var i = 0; i < width; ++i)
            {
                if (available[i])
                {
                    table[row] = i;
                    if (row < width - 1)
                    { search(row + 1); }
                    else
                    {
                        List<string> nRes = new List<string>();
                        foreach (var j in table)
                        { nRes.Add(index[j]); }
                        res.Add(nRes);
                    }
                }
            }
        }
        public IList<IList<string>> getRes()
        { return res; }
    }
}