using System;
using System.Collections.Generic;
using System.Text;
using Number046;

public partial class Solution
{
    public IList<IList<int>> Permute(int[] nums)
    {
        var c = new C(nums);
        c.run();
        return c.getRes();
    }
}
namespace Number046
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
            if (key == 0) {
                set = new List<int>();
                foreach (var i in num) { set.Add(i); }
            }
            if(set.Count==1)
            {
                result[key] = set[0];
                int[] temp = new int[Length];
                for(var i = 0; i < Length; ++i) { temp[i] = result[i]; }
                res.Add(temp);
                return;
            }
            for(var i = 0;i<set.Count;++i)
            {
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