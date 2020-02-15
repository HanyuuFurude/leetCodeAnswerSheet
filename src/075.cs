using System;
using System.Collections.Generic;
using System.Text;

public partial class Solution
{
    public void SortColors(int[] nums)
    {
        int left = 0, right = nums.Length - 1, doge = 0;
        while (doge <= right)
        {
            while (left < right && nums[left] == 0) { ++left; }
            while (left < right && nums[right] == 2) { --right; }
            if (left >= right) { return; }
            if (nums[left] == 1)
            {
                if (nums[right] == 0)
                { nums[left] = 0; nums[right] = 1; }
                else
                {
                    doge = doge > left ? doge : left;
                    while (++doge <= right)
                    {
                        if (nums[doge] == 0)
                        { nums[left] = 0; nums[doge] = 1; break; }
                        else if (nums[doge] == 2)
                        { nums[right] = 2; nums[doge] = 1; break; }
                    }
                }
            }
            else
            {
                if (nums[right] == 0)
                { nums[left] = 0; nums[right] = 2; }
                else
                { nums[left] = 1; nums[right] = 2; }
            }
        }
    }
}