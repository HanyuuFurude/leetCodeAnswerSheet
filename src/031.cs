using System;
using System.Collections.Generic;
using System.Text;

public partial class Solution
{
    public void NextPermutation(int[] nums)
    {
        if (nums.Length <= 1)
        { return; }
        int right = nums.Length - 1,left = right;
        int temp;
        while (left > 0)
        {
            if (nums[left - 1] < nums[left])
            {
                int key = left;
                while (key<right&&nums[key+1] > nums[left - 1]) { ++key; }
                temp = nums[left - 1]; nums[left - 1] = nums[key]; nums[key] = temp;
                break;
            }
            --left;
        }
        while (left < right)
        {
            temp = nums[left]; nums[left] = nums[right]; nums[right] = temp;
            ++left;--right;
        }
        return;
    }
}