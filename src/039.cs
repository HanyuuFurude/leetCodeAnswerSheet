
using System;
using System.Collections.Generic;
using System.Text;

using Number039;
public partial class Solution
{
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        C demo = new C(candidates, target);
        return demo.run();
    }
}
namespace Number039
{
    public class C
    {
        int[] index;
        int tar;
        Dictionary<int, IList<IList<int>>> table;

        public C(int[] candidates,int target)
        {
            index = candidates;
            tar = target;
            table = new Dictionary<int, IList<IList<int>>>();
        }
        public IList<IList<int>> run()
        {
            return search(tar,tar);
        }
        private IList<IList<int>> search(int src,int max)
        {
            if (src <= 0)
            {
                List<IList<int>> empty = new List<IList<int>>();
                empty.Add(new List<int>());
                return empty;
            }
            List<IList<int>> res = new List<IList<int>>();
            foreach(var i in index)
            {
                if (i <= max && src >= i)
                {
                    var tempRes = search(src - i, i);
                    for (var j = 0; j < tempRes.Count; ++j)
                    { tempRes[j].Add(i); res.Add(tempRes[j]); }
                }
            }
            return res;
        }
    }
}