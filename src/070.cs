using Number070;
public partial class Solution
{
    public int ClimbStairs(int n)
    {
        var demo = new C(n);
        return demo.search(n);
    }
}
namespace Number070
{
    public class C
    {
        private int[] count;
        private int n;
        public C(int target) { n = target; count = new int[n+1]; }
        public int search(int target)
        {
            if (count[target] > 0) { return count[target]; }
            if (target <= 2) { count[target] = target; return count[target]; }
            count[target] = search(target - 1) + search(target - 2);
            return count[target];
        }
    }
}