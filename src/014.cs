using System;
public partial class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0)
        {
            return "";
        }
        int key = 0;
        string common = "";
        while (true)
        {
            bool failure = false;
            if (key >= strs[0].Length)
            { failure = true; }
            else
            {
                char ptr = strs[0][key];
                foreach (var i in strs)
                {
                    if (i.Length <= key || i[key] != ptr)
                    {
                        failure = true;
                        break;
                    }
                }
                if (failure)
                {
                    break;
                }
                common += ptr;
                ++key;
            }
            if (failure)
            {
                break;
            }
        }
        return common;
    }
}