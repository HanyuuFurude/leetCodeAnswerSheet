class Solution
{
  public:
	string longestPalindrome(string s)
	{
		int length = s.size();
		int max = 1;
		for (int i = 1; i < length - 1; i++)
		{
			int j = 1;
			while (i - j >= 0 && i + j < length)
			{
				if (s[i - j] != s[i + j])
				{
					max = max > j ? max : j;
					break;
				}
				++j;
			}
		}
		return max;
	}
};