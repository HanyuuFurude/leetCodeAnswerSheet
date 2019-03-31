class Solution {
public:
    string longestPalindrome(string s) {
        int strLength  = s.size();
        if (length == 1)
        {
            return s;
        }
        int key = 0;
        int length = 1;
        for (int i = 1; i < strLength - 1; ++i)
        {
            int j = 1;
            while(i-j>=0&&i+j<strLength)
            {
                if (s[i-j]!=s[i+j]) 
                {
                    if (2*j+1>length)
                    {
                        key=i-j;
                        length = 2*j+1;
                    }
                    break;
                }
                ++j;
            }
        }
        
        for (int i = 1; i < strLength - 1; ++i)
        {
            int j = 1;
            while(i-j+1>=0&&i+j<strLength)
            {
                if (s[i-j+1]!=s[i+j]) 
                {
                    if (2*j>length)
                    {
                        key=i-j+1;
                        length = 2*j+1;
                    }
                    break;
                }
                ++j;
            }
        }
        if(r==0)return s.substr(0,1);
        return s.substr(l,r);
    }
};