using System;
using System.Collections.Generic;
using System.Text;
using Number093;
public partial class Solution
{
    public IList<string> RestoreIpAddresses(string s)
    {
        int[] MaxLeft = { 9, 6, 3, 0 };
        int[] MinLeft = { 3, 2, 1, 0 };
        var demo = new C(s, MaxLeft, MinLeft);
        return demo.res;
    }
}
/*
 * Tips:
 * cell范围[0,255]
 * 4位数组
 * 最长后缀 12，9，6，3
 * 最短后缀 4 ，3，2，1
 */
namespace Number093
{
    class C
    {
        public List<string> res;
        int[] maxLeft, minLeft, handle;
        string str;
        public C(string s, int[] max, int[] min)
        {
            str = s; maxLeft = max; minLeft = min;
            res = new List<string>();
            handle = new int[4];
            search(0, 0);

        }
        private void search(int left, int depth)
        {
            int minSelect = str.Length - left - maxLeft[depth];
            int maxSelect = str.Length - left - minLeft[depth];
            if (minSelect > 3 || maxSelect < 1) { return; }
            minSelect = minSelect >= 1 ? minSelect : 1;
            maxSelect = maxSelect <= 3 ? maxSelect : 3;
            for (var i = minSelect; i <= maxSelect; ++i)
            {
                handle[depth] = StringToInt(str.Substring(left, i));
                if(handle[depth]<256)
                {
                    if(depth==3)
                    {
                        res.Add($"{handle[0]}.{handle[1]}.{handle[2]}.{handle[3]}");
                        return;
                    }
                    search(left + i, depth + 1);
                }
            }
        }
        private int StringToInt(string str)
        {
            if(str.Length>1 && str[0] == '0') { return 256; }//错误输入
            int res = 0;
            foreach (var i in str) { res *= 10; res += i - 48; }
            return res;
        }

    }
}