#include <iostream>
#include <string>
#include <map>
using namespace std;
// using std::map;
// using std::pair;
// using std::string;
class Solution
{
public:
    int res;
    int romanToInt(string s)
    {
        /*
        I             1
        V             5
        X             10
        L             50
        C             100
        D             500
        M             1000
        */
        int value[] = {1, 5, 10, 50, 100, 500, 1000};
        char key[] = {'I', 'V', 'X', 'L', 'C', 'D', 'M'};
        int sum = 0;
        int max = 0;
        for (int i = s.length() - 1; i >= 0; --i)
        {
            int opt = 0;
            char ptr = s.at(i);
            for (int j = 0; j < 7; ++j)
            {
                if (ptr == key[j])
                {
                    opt = value[j];
                    if (opt < max)
                    {
                        opt = -opt;
                    }
                    else if (opt > max)
                    {
                        max = opt;
                    }
                    sum += opt;
                    break;
                }
            }
        }
        return sum;
    }
};
int main(int argc, char **argv)
{
    Solution sol;
    printf("%d", sol.romanToInt("MCMXCIV"));
}
/*
 M CM XC IV
*/