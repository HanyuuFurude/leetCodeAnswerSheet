using System;
using System.Collections.Generic;
using System.Text;

public partial class Solution
{
    public int ThreeSumClosest(int[] nums, int target)
    {
        List<int> lis = new List<int>(nums);
        lis.Sort();
        int min = lis[0] + lis[1] + lis[2];
        for (var i = 0; i < lis.Count; ++i)
        {
            int left = i + 1;
            int right = lis.Count - 1;
            while(left<right)
            {
                int tmpRes = lis[i] + lis[left] + lis[right];
                if(tmpRes>target)
                {
                    --right;
                    min = Math.Abs(min - target) > Math.Abs(tmpRes - target) ? tmpRes : min;
                }
                if(tmpRes<target)
                {
                    ++left;
                    min = Math.Abs(min - target) > Math.Abs(tmpRes - target) ? tmpRes : min;
                }
                if(tmpRes==target)
                { return target; }
            }
        }
        return min;
    }
}