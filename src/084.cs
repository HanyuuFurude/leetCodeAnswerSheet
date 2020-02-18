using System;
using System.Collections.Generic;
using System.Text;
using Number084;

public partial class Solution
{
    public int LargestRectangleArea(int[] heights)
    {
        var res = new C(heights);
        return res.res;
    }
}
namespace Number084
{
    class C
    {
        int[] array;
        public int res;
        public C(int[] arr) { array = arr; res = CalcMaxInterArea(0, arr.Length - 1); }
        private int IndexOfInterMin(int left, int right)
        {
            int minVal = array[left]; int Index = left;
            for (var i = left + 1; i <= right; ++i)
            { if (minVal > array[i]) { minVal = array[i]; Index = i; } }
            return Index;
        }
        public int CalcMaxInterArea(int left, int right)
        {
            int indexOfMin = IndexOfInterMin(left, right);
            int area = array[indexOfMin] * (right - left + 1);
            if (indexOfMin > left)
            {
                int areaLeft = CalcMaxInterArea(left, indexOfMin - 1);
                area = area > areaLeft ? area : areaLeft;
            }
            if (indexOfMin < right)
            {
                int areaRight = CalcMaxInterArea(indexOfMin + 1, right);
                area = area > areaRight ? area : areaRight;
            }
            return area;
        }
    }
}