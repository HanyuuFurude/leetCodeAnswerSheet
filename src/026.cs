using System;
using System.Collections.Generic;
using System.Text;

public partial class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int count = nums.Length;
        if(count<1)
        { return count; }
        int i = 1;
        int k = 1;
        while(i<count)
        {
            if(nums[i]==nums[i-1])
            {++i;}
            else
            { nums[k] = nums[i];++i;++k; }
        }
        return k;
    }
}