using System;
using System.Collections.Generic;
using System.Linq;

public partial class Solution
{
    public IList<IList<int>> ThreeSum(int[] numbers)
    {
        List<IList<int>> res = new List<IList<int>>();
        int zero = 0;
        List<int> neg = new List<int>();
        List<int> pos = new List<int>();
        foreach (var i in numbers)
        {
            if (i <= 0)
            { neg.Add(i); if (i == 0) ++zero; }
            else if (i > 0)
            { pos.Add(i); }
        }
        neg.Sort();
        pos.Sort();
        if (zero > 2)
        {
            List<int> tmp = new List<int>();
            for (int i = 0; i < 3; ++i)
            {
                tmp.Add(0);
            }
            res.Add(tmp);
        }
        Action<List<int>> push = (src) =>
        {
            bool flag = false;
            foreach (var i in res)
            {
                if (i[0] == src[0] && i[1] == src[1] && i[2] == src[2])
                { flag = true; break; }
            }
            if (!flag)
            { res.Add(src); }
        };
        for (int i = 0; i < neg.Count;++i)
        {
            while(neg.Count>i+2 && neg[i]==neg[i+1]&&neg[i+1]==neg[i+2])
            {
                ++i;
            }
            int j = i + 1;
            int k = pos.Count - 1;
            while(j<neg.Count&&k>=0)
            {
                while(neg.Count>j+1&&neg[j]==neg[j+1])
                { ++j; }
                while(k>0&&pos[k]==pos[k-1])
                { --k; }
                if(neg[i]+neg[j]+pos[k]>0)
                { --k; }
                else if(neg[i]+neg[j]+pos[k]<0)
                { ++j; }
                else
                {
                    List<int> tmp = new List<int>();
                    tmp.Add(neg[i]);
                    tmp.Add(neg[j]);
                    tmp.Add(pos[k]);
                    push(tmp);
                    //res.Add(tmp);
                    --k; ++j;
                }
            }
        }
        for (int i = 0; i < pos.Count; ++i)
        {
            while (pos.Count > i + 2 && pos[i] == pos[i + 1] && pos[i + 1] == pos[i + 2])
            {
                ++i;
            }
            int j = 0;
            int k = pos.Count - 1;
            while (j < neg.Count && k > i)
            {
                if (pos[i] + neg[j] + pos[k] > 0)
                { --k; }
                else if (pos[i] + neg[j] + pos[k] < 0)
                { ++j; }
                else
                {
                    List<int> tmp = new List<int>();
                    tmp.Add(pos[i]);
                    tmp.Add(neg[j]);
                    tmp.Add(pos[k]);
                    push(tmp);
                    //res.Add(tmp);
                    --k; ++j;
                }
            }
        }
        //for (int i = 0; i < neg.Count; ++i)
        //{
        //    for (int j = i + 1; j < neg.Count; ++j)
        //    {
        //        if(pos.Contains(0-neg[i]-neg[j]))
        //        {
        //            List<int> tmp = new List<int>();
        //            tmp.Add(neg[i]);
        //            tmp.Add(neg[j]);
        //            tmp.Add(0 - neg[i] - neg[j]);
        //            res.Add(tmp);
        //        }
        //    }
        //}
        //for (int i = 0; i < pos.Count; ++i)
        //{
        //    for (int j = i+1; j < pos.Count; ++j)
        //    {
        //        if(neg.Contains(0-pos[i]-pos[j]))
        //        {
        //            List<int> tmp = new List<int>();
        //            tmp.Add(0 - pos[i] - pos[j]);
        //            tmp.Add(pos[i]);
        //            tmp.Add(pos[j]);
        //            res.Add(tmp);
        //        }
        //    }
        //}
        //Func<IList<int>, IList<int>, bool> equ = (IList<int> x, IList<int> y) =>
        //{
        //    if (x.Count != y.Count)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        for (int i = 0; i < x.Count; ++i)
        //        {
        //            if (x[i] != y[i])
        //            { return false; }
        //        }
        //        return true;
        //    }
        //};
        //List<IList<int>> temp = new List<IList<int>>();
        //foreach(var i in res)
        //{
        //    bool same  = true;
        //    if(temp.Count == 0)
        //    {
        //        same = false;
        //    }else
        //    {
        //        same = false;
        //        foreach (var j in temp)
        //        {
        //            if (equ(i, j))
        //            {
        //                same = true;
        //                break;
        //            }
        //        }
        //    }
        //    if (!same)
        //    {
        //        temp.Add(i);
        //    }
        //}
        // res = temp;
        return res;
    }
}