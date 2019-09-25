#include <iostream>
#include <string>
using namespace std;
class Solution
{
public:
    int romanToInt(string s)
    {
        int sum = 0;
        int i = 0;
        // cout << s.size() << " " << s.length();
        for (; i < s.size() - 1; ++i)
        {
            if (findint(s[i]) < findint(s[i + 1]))
                sum -= findint(s[i]);
            else
                sum += findint(s[i]);
        }
        sum += findint(s[i]);
        return sum;
    }
    int findint(char ch)
    {
        char char_[7] = {'I', 'V', 'X', 'L', 'C', 'D', 'M'};
        int sum = 1;
        for (int i = 0; i < 7; ++i)
        {
            if (char_[i] == ch)
                break;
            if (i % 2 == 0)
                sum *= 5;
            else
                sum *= 2;
        }

        return sum;
    }
};
int main(int argc, char *argv[])
{
    Solution demo;
    int res;
    res = demo.romanToInt("XV");
    cout << res << '\t';
    return 0;
}