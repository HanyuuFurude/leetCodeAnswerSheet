using System;
using System.Collections.Generic;
using System.Text;
using Number087;

public partial class Solution
{
    public bool IsScramble(string s1, string s2)
    {
        if (!C.cmp(s1, s2)) { return false; }
        return C.search(s1, s2);
    }
}
namespace Number087
{
    public class C
    {
        public static bool search(string s1, string s2)
        {
            if (s1 == s2) { return true; }
            string c1, c2, c3;
            for (var i = 1; i < s1.Length; ++i)
            {
                c1 = s1.Substring(0, i);
                c2 = s2.Substring(0, i);
                c3 = s2.Substring(s2.Length - i, i);
                if (cmp(c1, c2))
                {
                    string c4 = s1.Substring(i, s1.Length - i);
                    string c5 = s2.Substring(i, s2.Length - i);
                    if (search(c1, c2) && search(c4, c5))
                    { return true; }
                }
                if (cmp(c1, c3))
                {
                    string c4 = s1.Substring(i, s1.Length - i);
                    string c5 = s2.Substring(0, s2.Length - i);
                    if (search(c1, c3) && search(c4, c5))
                    { return true; }
                }
            }
            return false;
        }
        /// <summary>
        /// compare whether s1 and s2 have the same char
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public static bool cmp(string s1, string s2)
        {
            if (s1 == s2) { return true; }
            Dictionary<char, int> cpList = new Dictionary<char, int>();
            int temp;
            foreach (var i in s1)
            {
                if (cpList.ContainsKey(i))
                { ++cpList[i]; }
                else
                { cpList.Add(i, 1); }
            }
            foreach (var i in s2)
            {
                if (cpList.ContainsKey(i))
                { --cpList[i]; }
                else
                { return false; }
            }
            foreach (var i in cpList)
            { if (i.Value != 0) { return false; } }
            return true;
        }
    }

}