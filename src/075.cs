using System;
using System.Collections.Generic;
using System.Text;

public partial class Solution
{
    public void SortColors(int[] nums)
    {
        int left = -1, right = nums.Length, doge = -1;
        while (++doge < right)
        {
            if (nums[doge] == 0) 
            { int swap = nums[++left]; nums[left] = nums[doge]; nums[doge] = swap; }
            else if (nums[doge] == 2) 
            { int swap = nums[--right]; nums[right] = nums[doge]; nums[doge] = swap; }
        }
    }
}