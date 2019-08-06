#include <iostream>
#include <vector>
#include <string>
using std::string;
using std::vector;

class Solution
{
public:
    int maxArea(vector<int> &height)
    {
        unsigned short count = height.size();
        int *data = new int[count];
        int flagL = 0, flagR = 0;
        int *dataL = new int[count];
        int *dataR = new int[count];
        int temp = height[0];
        for (int i = 0; i < count; ++i)
        {
            data[i] = height[i];
            if (data[i] > temp || i == 0)
            {
                dataL[flagL] = i;
                flagL += 1;
                temp = data[i];
                //printf("%d", data[i]);
            }
        }
        //printf("\n");
        temp = data[count - 1];
        for (int i = count - 1; i >= 0; --i)
        {
            if (temp < data[i] || i == count - 1)
            {
                dataR[flagR] = i;
                flagR += 1;
                temp = data[i];
                //printf("%d", data[i]);
            }
        }
        //printf("\n");

        int res = 0;
        int tmp;
        int h;
        for (int l = 0; l < flagL; ++l)
        {
            for (int r = 0; r < flagR; ++r)
            {
                if (dataR[r]<=dataL[l])
                {
                    break;
                }
                h = data[dataL[l]] < data[dataR[r]] ? data[dataL[l]] : data[dataR[r]];
                tmp = (dataR[r]-dataL[l]) * h;
                res = res > tmp ? res : tmp;
                //std::cout << l << ' ' << r <<' '<< dataL[l] << ' ' << dataR[r] << std::endl;
                //std::cout <<"tmp"<< tmp << std::endl;

            }
        }
        // std::cout << res;
        return res;
    }
};
int main()
{
    Solution exp;
    // std::cout << "Hanyuu" << std::endl;
    vector<int> test;
    //"1 8 6 2 5 4 8 3 7"
    int data[] = {1, 8, 6, 2, 5, 4, 8, 3, 7};
    for (int i = 0; i < 9; ++i)
    {
        test.push_back(data[i]);
    }
    // test.push_back(string("1 8 6 2 5 4 8 3 7"));
    int res;
    res = exp.maxArea(test);
    printf("%d" , res);
    system("pause");
    return 0;
}