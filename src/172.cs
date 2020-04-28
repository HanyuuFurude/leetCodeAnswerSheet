public partial class Solution
{
    public int TrailingZeroes(int n)
    {
        int res = 0;
        while (n > 0)
        { n /= 5; res += n; }
        return res;
    }
}