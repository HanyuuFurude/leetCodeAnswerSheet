using System;
using System.Collections.Generic;
using System.Text;
using Number043;

public partial class Solution
{
    public string Multiply(string num1, string num2)
    {
        var demo = new C(num1, num2);
        return demo.run();
    }
}
namespace Number043
{
    public class C
    {
        string x;
        string y;
        public C(string num1, string num2)
        {
            x = num1; y = num2;
        }
        public string run()
        {
            if (x == "0" && y == "0")
            { return "0"; }
            List<int> a = str2Lis(x); List<int> b = str2Lis(y); List<int> res = new List<int>();
            for (var i = 0; i < a.Count; ++i)
            {
                for (var j = 0; j < b.Count; ++j)
                { addToRes(res, i + j, a[i] * b[j]); }
            }
            return sum(res);
        }
        private void addToRes(List<int> res, int offset, int number)
        {
            while (res.Count <= offset)
            { res.Add(0); }
            res[offset] += number;
        }
        private string sum(List<int> res)
        {
            int ptr = 0;
            while (ptr < res.Count)
            {
                if (res[ptr] > 9)
                {
                    if (ptr + 1 >= res.Count)
                    { res.Add(0); }
                    res[ptr + 1] += res[ptr] / 10;
                    res[ptr] = res[ptr] % 10;
                }
                ++ptr;
            }
            string result = "";
            for (var i = res.Count - 1; i > -1; --i)
            { result += res[i]; }
            return result;
        }
        private List<int> str2Lis(string src)
        {
            List<int> res = new List<int>();
            foreach (var i in src)
            { res.Insert(0, chr2int(i)); }
            return res;
        }
        private int chr2int(char src)
        {
            switch (src)
            {
                case '0': return 0;
                case '1': return 1;
                case '2': return 2;
                case '3': return 3;
                case '4': return 4;
                case '5': return 5;
                case '6': return 6;
                case '7': return 7;
                case '8': return 8;
                case '9': return 9;
                default: throw new Exception("invaild character");
            }
        }
    }
}