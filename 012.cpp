class Solution
{
public:
    string intToRoman(int num)
    {
        char[] charset = "IVXLCDM";
        string res = "";
        string temp = "";
        int ptr = 0;
        while (num > 0)
        {
            temp = "";
            int cut = num % 10;
            num /= 10;

            switch (cut)
            {
            case 4:
                temp = charset[ptr] + charset[ptr + 1];
                break;
            case 5:
            case 6:
            case 7:
            case 8:
            case 9:
                temp = charset[ptr + 1];
                temp -= 5;
            default:
                for (int i = 0; i < temp; ++i)
                {
                    temp += charset[ptr];
                }
                break;
            }
            res += temp;
            ptr += 2;
        }
        return res;
    }
};