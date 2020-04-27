public partial class Solution
{
    public int TitleToNumber(string s)
    {
        char[] ss = s.ToCharArray();
        int res = 0;
        for (var i = 0; i < ss.Length; ++i)
        {
            res *= 26;
            res += (int)(ss[i] - 'A' + 1);
        }
        return res;
    }
}