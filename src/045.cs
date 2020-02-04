using System;
using System.Collections.Generic;
using System.Text;

public partial class Solution
{
    public int Jump(int[] nums)
    {
        int back = 0, front = 0, target = nums.Length - 1, step = 0;
        if (front >= target) { return 0; }
        while(true)
        {
            ++step;
            int frontNew = front;
            for(var i =front;i>=back;--i)
            {
                if(frontNew<i+nums[i])
                {
                    frontNew = i + nums[i];
                    if (frontNew >= target) return step;
                }
            }
            back = front + 1;
            front = frontNew;
        }
    }
}