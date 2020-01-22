#include <iostream>
#include <string>
using namespace std;

class Solution
{
  public:
    string longestPalindrome(string s)
    {
        int strLength = s.size();
        // if (strLength == 1)
        // {
        //     return s;
        // }
        int key = 0;
        int length = 0;
        for (int i = 0; i < strLength; ++i)
        {
            int j = 0;
            while (i - j >= 0 && i + j < strLength)
            {
                if (s[i - j] != s[i + j])
                {
                    if (2 * j - 1 > length)
                    {
                        key = i - j + 1;
                        length = 2 * j - 1;
                    }
                    break;
                }
                ++j;
            }
            if (2 * j - 1 > length)
            {
                key = i - j + 1;
                length = 2 * j - 1;
            }
        }

        for (int i = 0; i < strLength; ++i)
        {
            int j = 1;
            while (i - j + 1 >= 0 && i + j < strLength)
            {
                if (s[i - j + 1] != s[i + j])
                {
                    if (2 * j - 2 > length)
                    {
                        key = i - j + 2;
                        length = 2 * j - 2;
                    }
                    break;
                }
                ++j;
            }
            if (2 * j - 2 > length)
            {
                key = i - j + 2;
                length = 2 * j - 2;
            }
        }
        return s.substr(key, length);
    }
};
int main()
{
    string a("a");
    Solution b;
    cout << b.longestPalindrome(a)<<endl;
}
