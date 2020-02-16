using System;
using System.Collections.Generic;
using System.Text;

public partial class Solution
{
    /* 
     * 本题与26题函数签名重复，故增加一个无用参数removeme
     */
    public int RemoveDuplicates(int[] nums, int removeme = 0)
    {
        if (nums.Length == 0) { return 0; }
        int lastWord = nums[0], count = 1, backPtr = 0, forwardPtr = 0;
        while (++forwardPtr < nums.Length)
        {
            if (nums[forwardPtr] == lastWord)
            {
                if (count > 1) { continue; }
                ++count; ++backPtr;
                nums[backPtr] = nums[forwardPtr];
            }
            else
            {
                count = 1; ++backPtr;
                nums[backPtr] = nums[forwardPtr];
                lastWord = nums[backPtr];
            }
        }
        return ++backPtr;
    }
}