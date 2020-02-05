using System;
using System.Collections.Generic;
using System.Text;
using Number047;

public partial class Solution
{
    public IList<IList<int>> PermuteUnique(int[] nums)
    {
        var c = new C(nums);
        c.run();
        return c.getRes();
    }
}
namespace Number047
{
    public class C
    {
        int[] result;
        int[] num;
        int Length;
        List<IList<int>> res;
        public C(int[] Nums)
        {
            num = Nums;
            Length = Nums.Length;
            result = new int[Length];
            res = new List<IList<int>>();
        }
        public void run(int key = 0, List<int> set = null)
        {
            if (key == 0)
            {
                set = new List<int>();
                foreach (var i in num) { set.Add(i); }
                set.Sort();
            }
            if (set.Count == 1)
            {
                result[key] = set[0];
                int[] temp = new int[Length];
                for (var i = 0; i < Length; ++i) { temp[i] = result[i]; }
                res.Add(temp);
                return;
            }
            for (var i = 0; i < set.Count; ++i)
            {
                if (i + 1 < set.Count && set[i] == set[i + 1])
                { continue; }
                result[key] = set[i];
                set.RemoveAt(i);
                run(key + 1, set);
                set.Insert(i, result[key]);
            }
        }
        public IList<IList<int>> getRes()
        { return res; }
    }
}