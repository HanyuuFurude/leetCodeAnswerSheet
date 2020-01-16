using System;
using System.Collections.Generic;
using System.Text;

public partial class Solution
{
    public int ThreeSumClosest(int[] nums, int target)
    {
        List<int> lis = new List<int>(nums);
        lis.Sort();
        int min = lis[0] + lis[1] + lis[2];
        for (var i = 0; i < lis.Count; ++i)
        {
            for (var j = i + 1; j < lis.Count-1; ++j)
            {
                int k = (j + lis.Count) / 2;
                int tmp = lis[i] + lis[j];
                int tmpMin = tmp + lis[j+1];
                bool changed = false;
                while (k > j && k < lis.Count)
                {
                    int calcRes = lis[k] + tmp;
                    if (calcRes > target)
                    { --k; if (Math.Abs(calcRes - target) > Math.Abs(tmpMin - target)) { break; } tmpMin = calcRes; }
                    else if (calcRes < target)
                    { ++k; if (Math.Abs(calcRes - target) > Math.Abs(tmpMin - target)) { break; } tmpMin = calcRes; }
                    else if (calcRes == target)
                    { return target; }
                    changed = true;
                }
                if (changed)
                {
                    min = Math.Abs(min - target) > Math.Abs(tmpMin - target) ? tmpMin : min;
                }
            }
        }
        return min;
    }
}