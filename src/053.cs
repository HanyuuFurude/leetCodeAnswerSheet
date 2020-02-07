using System;
using System.Collections.Generic;
using System.Text;
using Number053;

public partial class Solution
{
    public int MaxSubArray(int[] nums)
    {
        if (nums.Length == 0)
        { return 0; }
        var demo = new C(nums);
        return demo.run(0, nums.Length - 1);
    }
}
namespace Number053
{
    class C
    {
        int[] num;
        public C(int[] nums)
        {
            num = nums;
        }
        public int run(int l,int r)
        {
            if(l>=r)
            { return num[l]; }
            int middle = (l + r) / 2;
            int sum = num[middle];
            int mres = sum;
            for (var i = middle - 1; i >= l; --i)
            { sum += num[i]; mres = sum > mres ? sum : mres; }
            sum = mres;
            for (var i = middle + 1; i <= r; ++i)
            { sum += num[i]; mres = sum > mres ? sum : mres; }
            var lres = run(l, middle - 1);
            var rres = run(middle + 1, r);
            mres = mres > lres ? mres : lres;
            mres = mres > rres ? mres : rres;
            return mres;
        }
    }
}