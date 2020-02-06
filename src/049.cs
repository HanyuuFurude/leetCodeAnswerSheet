using System;
using System.Collections.Generic;
using System.Text;

public partial class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        List<IList<string>> res = new List<IList<string>>();
        List<string> index = new List<string>();
        List<char> temp = new List<char>();
        Func<string, string> hash = (src) =>
         {
             string label = "";
             temp.Clear();
             foreach (var i in src)
             { temp.Add(i); }
             temp.Sort();
             foreach (var i in temp)
             { label += i; }
             return label;
         };
        foreach (var i in strs)
        {
            var label = hash(i);
            if (!index.Contains(label))
            {
                var handle = new List<string>();
                res.Add(handle);
                index.Add(label);
            }
            res[index.IndexOf(label)].Add(i);
        }
        return res;
    }
}