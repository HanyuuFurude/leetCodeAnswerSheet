using System;
using System.Collections.Generic;
using System.Text;

public partial class Solution
{
    public IList<string> FullJustify(string[] words, int maxWidth)
    {
        Func<int, string> NSpace = (src) =>
         { string additionSpace = ""; for (var i = 0; i < src; ++i) additionSpace += " "; return additionSpace; };
        int key = 0, offset = 0, count = 0, space = 0;
        List<string> res = new List<string>();
        if (words.Length == 0) { res.Add(NSpace(maxWidth)); return res; }
        while (true)
        {
            string statement = "";
            count = words[key].Length; offset = 0;
            while (
                words.Length > key + offset + 1 &&
                count + offset + 1 + words[key + offset + 1].Length <= maxWidth
                )
            {
                count += words[key + ++offset].Length;
            }
            if (offset > 0)
            {
                space = (maxWidth - count) / offset;
                statement = words[key];
            }
            else
            {
                space = maxWidth - count;
                statement = words[key] + NSpace(maxWidth - count);
            }
            string origBlank = NSpace(space);
            if (key + offset < words.Length - 1)
            {
                for (var i = 1; i <= offset; ++i)
                {
                    if (i <= (maxWidth-count)%offset)
                    { statement += origBlank + " "; }
                    else
                    { statement += origBlank; }
                    statement += words[key + i];
                }
            }
            else
            {
                for (var i = 1; i <= offset; ++i)
                {
                    statement += " ";
                    statement += words[key + i];
                }
                statement += NSpace(maxWidth - statement.Length);
                res.Add(statement);
                break;
            }
            res.Add(statement);
            key += offset + 1;
        }
        return res;
    }
}