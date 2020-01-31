using System;
using System.Collections.Generic;
using System.Text;

public partial class Solution
{
    public int[] SearchRange(int[] nums, int target)
    {
        int[] NotFound = { -1, -1 };
        if(nums.Length==0)
        { return NotFound; }
        int[] res = new int[2];

        int left = 0, right = nums.Length - 1, middle = (left + right) / 2;
        while (left < right)
        {
            middle = (left + right) / 2;
            if (nums[middle] < target)
            { left = middle + 1; }
            else if (nums[middle] > target)
            { right = middle - 1; }
            else
            { right = middle; }
        }
        if(nums[left]!=target)
        { return NotFound; }
        res[0] = right;left = 0;right = nums.Length - 1;
        while (left < right)
        {
            middle = (int)Math.Ceiling((left + right) / 2.0);
            if (nums[middle] < target)
            { left = middle + 1; }
            else if (nums[middle] > target)
            { right = middle - 1; }
            else
            { left = middle; }
        }
        res[1] = right;
        return res;
    }
}