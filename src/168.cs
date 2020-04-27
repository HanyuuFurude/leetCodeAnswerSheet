using System.Text;
public partial class Solution
{
    public string ConvertToTitle(int n)
    {
        StringBuilder res = new StringBuilder();
        while (n > 0)
        {
            res.Insert(0, (char)('A' + (n - 1) % 26));
            n = (n - 1) / 26;
        }
        return res.ToString();
    }
}
