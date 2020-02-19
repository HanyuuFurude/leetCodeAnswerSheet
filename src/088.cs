using System;
using System.Collections.Generic;
using System.Text;

public partial class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int num1Key = m, num2Key = n, writeKey = nums1.Length;
        while (num1Key > 0 && num2Key > 0)
        {
            if (nums1[num1Key - 1] < nums2[num2Key - 1])
            { nums1[--writeKey] = nums2[--num2Key]; }
            else
            { nums1[--writeKey] = nums1[--num1Key]; }
        }
        while (num2Key > 0)
        {
            nums1[--writeKey] = nums2[--num2Key];
        }
    }
}