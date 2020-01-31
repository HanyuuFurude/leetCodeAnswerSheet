using System;
using System.Collections.Generic;
using System.Text;

public partial class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;
        int middle;
        while(left<=right)
        {
            middle = (left + right) / 2;
            if(nums[middle]>target)
            { right = middle - 1; }
            else if(nums[middle]<target)
            { left = middle + 1;}
            else
            { return middle; }
        }
            return right + 1;
    }
}