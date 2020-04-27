using System.Text;
using System.Collections.Generic;
public partial class Solution
{
    public string FractionToDecimal(int num, int den)
    {
        if (num == 0) { return "0"; }
        long numerator = num, denominator = den;
        bool flag = true;
        string I;
        if (numerator < 0) { numerator = -numerator; flag = !flag; }
        if (denominator < 0) { denominator = -denominator; flag = !flag; }
        if (flag == false)
        { I = $"-{(numerator / denominator).ToString()}"; }
        else
        { I = $"{(numerator / denominator).ToString()}"; }
        numerator %= denominator;
        if (numerator == 0)
        { return I; }
        StringBuilder F_Buffer = new StringBuilder();
        string F = null;
        Dictionary<long, long> rec = new Dictionary<long, long>();
        int index = 0;
        while (numerator > 0)
        {
            if (rec.ContainsKey(numerator))
            {
                F = $"{F_Buffer.Insert((int)rec[numerator], "(").Append(")")})";
                break;
            }
            rec.Add(numerator, index);
            numerator *= 10;
            F_Buffer.Append(numerator / denominator);
            numerator %= denominator;
            ++index;
        }
        F = F ?? F_Buffer.ToString();
        return $"{I}.{F_Buffer}";
    }
}