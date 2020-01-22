#include <iostream>
#include <string>
using namespace std;

class Solution
{
public:
    string intToRoman(int num)
    {
        char charset[] = "IVXLCDM";
        string res = "";
        string temp = "";
        int ptr = 0;
        while (num > 0)
        {
            temp = "";
            int cut = num % 10;
            num /= 10;
            if (cut == 4)
            {
                temp = temp + charset[ptr] + charset[ptr + 1];
            }
            else if (cut == 9)
            {
                temp = temp + charset[ptr] + charset[ptr + 2];
            }
            else
            {
                if (cut >= 5)
                {
                    cut -= 5;
                    temp = charset[ptr + 1];
                }
                for (int i = 0; i < cut; ++i)
                {
                    temp += charset[ptr];
                }
            }
            res = temp + res;
            ptr += 2;
        }
        return res;
    }
};
int main(int argc, char *argv[])
{
    // int input;
    // cin >> input;
    string res;
    Solution solution;
    for (int i = 0; i < 100; ++i)
    {
        res = solution.intToRoman(i);
        cout << i << '\t' << res << '\n';
    }
    return 0;
}