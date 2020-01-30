using System;
using System.Collections.Generic;
using System.Text;
public partial class Solution
{
    public int Search(int[] nums, int target)
    {
        if(nums.Length<2)
        {
            if(nums.Length==1&&nums[0]==target)
            { return 0; }
            else
            { return -1; }
        }
        int left = 0, right = nums.Length, middle;
        while (left + 1 < right)
        {
            middle = (left + right) / 2;
            if (nums[middle] > nums[0])
            { left = middle; }
            else
            { right = middle; }
        }
        if(target>=nums[0])
        { right = left;left = 0; }
        else
        { left = right;right = nums.Length - 1; }
        while(left<=right)
        {
            middle = (left + right) / 2;
            if(nums[middle]<target)
            { left = middle + 1; }
            else if(nums[middle]>target)
            { right = middle - 1; }
            else
            { return middle; }
        }
        return -1;
    }
}