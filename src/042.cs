using System;
using System.Collections.Generic;
using System.Text;
using Number042;

public partial class Solution
{
    public int Trap(int[] height)
    {
        if(height.Length<1)
        { return 0; }
        int sum = 0, left, right;
        int[] SortedHeight = new int[height.Length];
        int[] SortedIndex = new int[height.Length];
        for (var i = 0; i < height.Length; ++i)
        { SortedIndex[i] = i; SortedHeight[i] = height[i]; }
        C.sort(SortedHeight, SortedIndex);
        left = SortedIndex[0]; right = SortedIndex[0];
        for (var i = 1; i < height.Length; ++i)
        {
            if (SortedIndex[i] < right && SortedIndex[i] > left)
            { continue; }
            if (SortedIndex[i] < left)
            {
                sum += (left - SortedIndex[i] - 1) * SortedHeight[i];
                for (var j = SortedIndex[i] + 1; j < left; ++j)
                { sum -= height[j]; }
                left = SortedIndex[i];
            }
            else
            {
                sum += (SortedIndex[i] - right - 1) * SortedHeight[i];
                for (var j = right + 1; j < SortedIndex[i]; ++j)
                { sum -= height[j]; }
                right = SortedIndex[i];
            }
        }
        return sum;
    }
}
namespace Number042
{
    public class C
    {
        public static void sort(int[] src, int[] index, int l = -1, int r = -1)
        {
            if (l == -1 && r == -1)
            { l = 0; r = src.Length - 1; }
            if (src.Length <= 1)
            { return; }
            if (l >= r)
            { return; }
            int i = l, j = r + 1, temp;
            while (i < j)
            {
                while (i < j && src[--j] < src[l]) ;
                while (i < j && src[++i] >= src[l]) ;
                temp = src[i]; src[i] = src[j]; src[j] = temp;
                temp = index[i]; index[i] = index[j]; index[j] = temp;
            }
            temp = src[l]; src[l] = src[j]; src[j] = temp;
            temp = index[l]; index[l] = index[j]; index[j] = temp;
            sort(src, index, l, i - 1); sort(src, index, i + 1, r);
        }
    }
}