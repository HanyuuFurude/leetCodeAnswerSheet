public partial class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {
        int[] res = new int[2];
        if (numbers.Length < 2) { return res; }
        int left = 0, right = numbers.Length - 1;
        int l = 1, r = numbers.Length;
        while (l < r)
        {
            right = l + (r - l) / 2;
            if (numbers[left] + numbers[right] > target)
            { r = right; }
            else if (numbers[left] + numbers[right] < target)
            { l = right + 1; }
            else
            { res[0] = 1; res[1] = right + 1; return res; }
        }
        while (left < right)
        {
            if (numbers[left] + numbers[right] > target)
            { --right; }
            else if (numbers[left] + numbers[right] < target)
            { ++left; }
            else
            { res[0] = left + 1; res[1] = right + 1; return res; }
        }
        return res;
    }
}