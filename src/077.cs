using System;
using System.Collections.Generic;
using System.Text;
using Number077;

public partial class Solution
{
    public IList<IList<int>> Combine(int n, int k)
    {
        var ans = new C(n, k);
        return ans.resList;

    }
}
namespace Number077
{
    public class C
    {
        private int depth, limit;
        public List<IList<int>> resList;
        private List<int> res;
        public C(int lim, int dep)
        {
            limit = lim; depth = dep;
            resList = new List<IList<int>>(); res = new List<int>();
            if((lim & dep) == 0) { return; }
            for (var i = 0; i < depth; ++i) { res.Add(0); }
            search();
        }
        public void search(int deep = 1, int leftLimit = 1)
        {
            for (var i = leftLimit; i <= limit - (depth - deep); ++i)
            {
                res[deep - 1] = i;
                if (deep == depth)
                {
                    List<int> temp = new List<int>();
                    foreach (var j in res)
                    { temp.Add(j); }
                    resList.Add(temp);
                }
                else
                { search(deep + 1, i + 1); }
            }
        }
    }
}