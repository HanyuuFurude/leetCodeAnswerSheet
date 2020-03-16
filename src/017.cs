using System;
using System.Collections.Generic;
using System.Text;

public partial class Solution
{
    public IList<string> LetterCombinations(string digits)
    {
        string[] keyboard =
        {
            "","","abc","def",
            "ghi","jkl","mno",
            "pqrs","tuv","wxyz"
        };
        List<string> res = new List<string>();

        foreach (var i in digits)
        {
            int key = int.Parse(i.ToString());
            // char[] addList;
            List<string> tmpRes = new List<string>();
            foreach (var j in keyboard[key])
            {
                if (res.Count == 0)
                { tmpRes.Add(j.ToString()); }
                else
                {
                    foreach (var k in res)
                    { tmpRes.Add(k + j.ToString()); }
                }
            }
            res = tmpRes;
        }
        return res;
    }
}
