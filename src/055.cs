using System;
using System.Collections.Generic;
using System.Text;

public partial class Solution
{
    public bool CanJump(int[] nums)
    {
        int left = 0, right = 0, target = nums.Length - 1, newLeft, newRight;
        while (right < target)
        {
            newLeft = right; newRight = right;
            for (var i = left; i <= right; ++i)
            { newRight = newRight > i + nums[i] ? newRight : i + nums[i]; }
            if (newRight == right)
            { return false; }
            left = newLeft; right = newRight;
        }
        return true;
    }
}