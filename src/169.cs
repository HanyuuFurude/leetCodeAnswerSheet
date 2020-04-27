using System.Collections.Generic;
public partial class Solution
{
    public int MajorityElement(int[] nums)
    {
        Dictionary<int, int> counter = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; ++i)
        {
            if (!counter.ContainsKey(nums[i]))
            { counter.Add(nums[i], 0); }
            ++counter[nums[i]];
        }
        foreach (var i in counter)
        {
            if (i.Value > nums.Length / 2)
            { return i.Key; }
        }
        return 0;
    }
}