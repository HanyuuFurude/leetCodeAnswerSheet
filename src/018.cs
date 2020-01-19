using System;
using System.Collections.Generic;
using System.Text;

public partial class Solution
{
    public IList<IList<int>> FourSum(int[] nums, int target)
    {
        List<IList<int>> res = new List<IList<int>>();
        List<int> src = new List<int>();
        foreach (var i in nums)
        { src.Add(i); }
        src.Sort();
        for (var i = 0; i < src.Count - 3; ++i)
        {
            for (var j = i + 1; j < src.Count - 2; ++j)
            {
                int k = j + 1;
                int l = src.Count - 1;
                while (k < l)
                {
                    int calcRes = src[i] + src[j] + src[k] + src[l];
                    if (calcRes > target)
                    { --l; }
                    else if (calcRes < target)
                    { ++k; }
                    else
                    {
                        List<int> item = new List<int>();
                        item.Add(src[i]); item.Add(src[j]); item.Add(src[k]); item.Add(src[l]);
                        res.Add(item);
                        ++k;--l;
                    }
                }
            }
        }
        List<IList<int>> newRes = new List<IList<int>>();
        foreach(var i in res)
        {
            bool repeat = false;

            foreach (var j in newRes)
            {
                bool same = true;
                for (var k = 0; k < 4; ++k)
                {
                    if (i[k] != j[k])
                    {
                        same = false;
                        break;
                    }
                }
                if (same)
                { repeat = true; break; }
            }
            if(!repeat)
            {
                newRes.Add(i);
            }
        }

        res = newRes;
        return res;
    }
}