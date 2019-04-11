class Solution
{
  public:
	int myAtoi(string str)
	{
		//cout<<INT_MIN<<endl;
		long res = 0;
		int sig = 1;
		int length = str.length();
		const char *ptr = str.c_str();
		int i = 0;
		while (i < length && ptr[i] == ' ')
			++i;
		if (i < length && (ptr[i] == '-' || ptr[i] == '+'))
		{
			if (ptr[i] == '-')
				sig = -1;
			++i;
		}
		while (i < length && ptr[i] < 0x40 && ptr[i] >= 0x30)
		{
			res *= 10;
			res += (int)(ptr[i] - 0x30);
			++i;
			if (sig == 1)
			{
				if (res > INT_MAX)
				{
					//cout<<"MAX";
					return INT_MAX;
				}
			}
			else
			{
				if (res > -(long)INT_MIN)
				{
					//cout<<"MIN";
					return INT_MIN;
				}
			}
			//cout<<res<<endl;
		}
		//cout<<"Normal"<<endl;
		return res * sig;
	}
};