using System;
using System.Collections.Generic;
using System.Text;
using Number040;
public partial class Solution
{
    public IList<IList<int>> CombinationSum2(int[] candidates, int target)
    {
        var c = new C(candidates, target);
        return c.run();
    }
}
namespace Number040
{
    class C
    {
        List<IList<int>> res = new List<IList<int>>();
        List<int> index = new List<int>();
        List<int> sum = new List<int>();
        int tar;
        public C(int[] candidates, int target)
        {
            tar = target;
            foreach (var i in candidates)
            { index.Add(i); }
            index.Sort((x, y) => -x.CompareTo(y));
            int temp = 0;
            for (var i = index.Count - 1; i > -1; --i)
            { temp += index[i]; sum.Insert(0, temp); }
        }
        public IList<IList<int>> run()
        {
            return search(0, tar);
        }
        public IList<IList<int>> search(int key, int target)
        {
            if (key >= index.Count || target <= 0 || sum[key] < target)
            {
                List<IList<int>> empty = new List<IList<int>>();
                return empty;
            }
            List<IList<int>> res = new List<IList<int>>();
            if (index[key] == target)
            {
                var me = new List<int>(); me.Add(index[key]);
                bool addable = true;
                foreach (var i in res) 
                { if (i.Count == 1 && i[0] == me[0]) { addable = false; break; } }
                if (addable) { res.Add(me); }
            }
            var tempRes = search(key + 1, target);
            foreach (var i in tempRes)
            {
                bool addable = true;
                foreach (var j in res)
                {
                    if (i.Count == j.Count)
                    {
                        addable = false;
                        for (var k = 0; k < j.Count; ++k)
                        { if (i[k] != j[k]) { addable = true; break; } }
                        if (!addable)
                        { break; }
                    }
                }
                if (addable)
                { res.Add(i); }
            }
            tempRes = search(key + 1, target - index[key]);
            for(var i = 0;i<tempRes.Count;++i)
            {
                tempRes[i].Add(index[key]);
                bool addable = true;
                foreach(var j in res)
                {
                    if (j.Count==tempRes[i].Count)
                    {
                        addable = false;
                        for (var k = 0; k < tempRes[i].Count; ++k)
                        { if (j[k] != tempRes[i][k]) { addable = true; break; } }
                    }
                    if (!addable) { break; }
                }
                if (addable)
                { res.Add(tempRes[i]); }
            }
            return res;
        }
    }
}