using System;
using System.Collections.Generic;
using System.Text;
using Number090;

public partial class Solution
{
    public IList<IList<int>> SubsetsWithDup(int[] nums)
    {
        var demo = new C(nums);
        return demo.res;

    }
}
namespace Number090
{
    public class C
    {
        public List<IList<int>> res;
        List<int> index, count;
        int[] available;
        int[] history;
        public C(int[] nums)
        {
            index = new List<int>();
            count = new List<int>();
            res = new List<IList<int>>();
            foreach (var i in nums)
            {
                int ind = index.IndexOf(i);
                if (ind == -1)
                { index.Add(i); count.Add(1); }
                else
                { ++count[ind]; }
            }
            available = new int[index.Count];
            //available[available.Length - 1] = 0;
            for (var i = available.Length - 2; i >= 0; --i)
            {
                available[i] = available[i + 1] + count[i + 1];
            }
            for (var i = 0; i <= nums.Length; ++i)
            {
                history = new int[i];
                search(i - 1);
            }
        }
        public void search(int deep, int limit = 0)
        {
            if (deep < 0)
            {
                List<int> commit = new List<int>();
                foreach (var i in history) { commit.Add(i); }
                res.Add(commit);
                return;
            }
            for (var i = limit; i < index.Count; ++i)
            {
                //history[deep] = index[i];
                int minSelect = deep - available[limit] + 1 > 1 ? deep - available[limit] + 1 : 1;
                int maxSelect = count[i] > deep + 1 ? deep + 1 : count[i];
                for (var j = 0; j < maxSelect; ++j)
                {
                    history[deep - j] = index[i];
                }
                for (var j = maxSelect; j >= minSelect; --j)
                {
                    search(deep - j, i + 1);
                }
            }
        }
    }
}