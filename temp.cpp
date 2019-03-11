class Solution {
public:
    string longestPalindrome(string s) {
        int length  = s.size();
        if (length == 1)
        {
            return s;
        }
        int l = 0;
        int r = 0;
        int max = 1;
        for (int i = 1; i < length - 1; i++)
        {
            int j = 1;
            while(i-j>=0&&i+j<length)
            {
                if (s[i-j]!=s[i+j])
                {
                    if (j>max)
                    {
                        l=i-j+1;
                        r=2*j-1;
                        max = j;
                    }
                    break;
                }
                ++j;
            }
        }

        for (int i = 1; i < length - 1; i++)
        {
            int j = 1;
            while(i-j>=0&&i+j-1<length)
            {
                if (s[i-j]!=s[i+j-1])
                {
                    if (j>max)
                    {
                        l=i-j+1;
                        r=2*j-2;
                        max = j;
                    }
                    break;
                }
                ++j;
            }
        }
        //if(r==0&&l==0)return s.substr(0,1);
        return s.substr(l,r);
    }
};