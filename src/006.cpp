class Solution
{
  public:
	string convert(string s, int numRows)
	{
		if (numRows == 1)
			return s;
		string bucket[numRows];
		int key = 0;
		int upward = 1;
		for (int i = 0; i < s.length(); ++i)
		{
			bucket[key] += s.at(i);
			key += upward;
			if (key == numRows)
			{
				upward = -1;
				key = numRows - 2;
			}
			else if (key == -1)
			{
				upward = 1;
				key = 1;
			}
			//cout<<key;
		}
		for (int i = 1; i < numRows; ++i)
		{
			bucket[0] += bucket[i];
		}
		return bucket[0];
	}
};