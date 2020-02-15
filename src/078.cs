using System;
using System.Collections.Generic;
using System.Text;
using Number078;

public partial class Solution
{
    public IList<IList<int>> Subsets(int[] nums)
    {
        var doge = new C(nums);
        return doge.resList;
    }
}
namespace Number078
{
    public class C
    {
        private int[] nums;
        private int depth, limit;
        public List<IList<int>> resList;
        private List<int> res;
        public C(int[] src)
        {
            nums = src;
            limit = src.Length;
            resList = new List<IList<int>>(); res = new List<int>();
            resList.Add(new List<int>());
            if (limit == 0) { return; }
            for (var lenghtOfSubset = 1; lenghtOfSubset <= limit; ++lenghtOfSubset)
            {
                res = new List<int>();
                depth = lenghtOfSubset;
                for (var i = 0; i < lenghtOfSubset; ++i)
                { res.Add(0); }
                search();
            }
        }
        public void search(int deep = 1, int leftLimit = 1)
        {
            for (var i = leftLimit; i <= limit - (depth - deep); ++i)
            {
                res[deep - 1] = nums[i-1];
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