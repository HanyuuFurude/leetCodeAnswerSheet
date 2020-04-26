using System.Text;
public partial class Solution
{
    public string FractionToDecimal(int numerator, int denominator)
    {
        bool cycle = false;
        string I = $"{(numerator / denominator).ToString()}{((numerator / denominator) != 0 ? "." : "")}";
        StringBuilder F = new StringBuilder();
        do
        {
            numerator = (numerator % denominator) * 10;
            F.Append(numerator / denominator);
            if ((F.Length & 1) == 0)
            {
                if (F.ToString().Substring(0, F.Length / 2) == F.ToString().Substring(F.Length / 2, F.Length / 2))
                { cycle = true; break; }
            }
        }
        while (numerator > 0);
        if (cycle == true)
        { return I + $"{(F.ToString().Substring(0, F.Length))}"; }
        else
        { return I + F; }
    }
}