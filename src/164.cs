using System;
public partial class Solution
{
    public int MaximumGap(int[] nums)
    {
        if (nums.Length <= 2)
        {
            if (nums.Length == 2) { return Math.Abs(nums[0] - nums[1]); }
            return 0;
        }
        int count = nums.Length - 1;
        Bucket[] bucketList = new Bucket[count + 1];
        int min = int.MaxValue, max = int.MinValue;
        for (var i = 0; i <= count; ++i)
        {
            bucketList[i] = new Bucket();
            min = min < nums[i] ? min : nums[i];
            max = max > nums[i] ? max : nums[i];
        }
        ++max;
        int space = (int)Math.Ceiling((max - min) / (decimal)count);
        for (var i = 0; i <= count; ++i)
        {
            int index = (nums[i] - min) / space;
            bucketList[index].used = true;
            bucketList[index].min = bucketList[index].min < nums[i] ? bucketList[index].min : nums[i];
            bucketList[index].max = bucketList[index].max > nums[i] ? bucketList[index].max : nums[i];
        }
        int lastMax = min, res = 0;
        for (var i = 0; i <= count; ++i)
        {
            if (bucketList[i].used == true)
            {
                res = res > (bucketList[i].min - lastMax) ? res : (bucketList[i].min - lastMax);
                lastMax = bucketList[i].max;
            }
        }
        return res;
    }
    private class Bucket
    {
        public bool used = false;
        public int min = int.MaxValue, max = int.MinValue;
    }
}