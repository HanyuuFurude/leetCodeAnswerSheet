#include <limits.h>
class Solution
{
  public:
	int reverse(int x)
	{
		//cout<<INT_MAX<<endl;
		//cout<<INT_MIN<<endl;
		//cout<<x<<endl;
		long org = x;
		long tmp = 0;
		while (org != 0)
		{
			tmp *= 10;
			tmp += org % 10;
			org /= 10;
			//cout<<tmp<<endl;
		}
		if (tmp > INT_MAX || tmp < INT_MIN)
			return 0;
		return tmp;
	}
};