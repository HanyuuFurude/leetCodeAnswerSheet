using System;
using System.Collections.Generic;
using System.Text;

public partial class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        if(nums.Length<=1)
        {
            return nums.Length;
        }
        int forward = 0;
        int backward = 0;
        while(forward<nums.Length)
        {
            if(nums[forward]!=val)
            {
                nums[backward] = nums[forward];
                backward++;forward++;
            }
            else
            {
                forward++;
            }
        }
        return backward;
    }
}