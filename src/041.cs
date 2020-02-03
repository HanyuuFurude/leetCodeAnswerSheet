using System;
using System.Collections.Generic;
using System.Text;
using Number041;

public partial class Solution
{
    public int FirstMissingPositive(int[] nums)
    {
        int[] a = nums;
        C.sort(a);
        bool head = false;
        int last = 0;
        foreach(var i in a)
        {
            if(i<1)
            { continue; }
            if(head)
            {
                if (i == last)
                { continue; }
                else if (i == ++last)
                { continue; }
                else
                { return last; }
            }
            else
            {
                if (i != 1)
                { return 1; }
                else
                { head = true; last = 1; }
            }
        }
        return ++last;
    }
}
namespace Number041
{
    public class C
    {
        public static void sort(int[] src, int l = -1, int r = -1)
        {
            if (l == -1 && r == -1)
            { l = 0;r = src.Length-1; }
            if (src.Length <= 1)
            { return; }
            if(l>=r)
            { return; }
            int i = l, j = r + 1, temp;
            while(i<j)
            {
                while (i<j && src[--j] > src[l]) ;
                while (i<j && src[++i] <= src[l]) ;
                temp = src[i];src[i] = src[j];src[j] = temp;
            }
            temp = src[l];src[l] = src[j]; src[j] = temp;
            sort(src, l, i-1);sort(src, i+1,r );
        }
    }
}