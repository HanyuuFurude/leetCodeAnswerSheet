class Solution {
public:
    int lengthOfLongestSubstring(string s) {
        if (s=="") return 0;
        int lis[127];
        for (int i = 0; i < 127; i++)
        {
            lis[i] = -1;
        }
        int max = 0;
        int current = 0;
        for (int i = 0; i < s.size(); i++)
        {
            int res = (int)s[i];
            if (lis[res] >= current)
            {
                max = (max > i - current) ? max : (i - current);
                current = lis[res] + 1;
            }
            lis[res] = i;
        }
        max = max>(s.size()-current)?max:(s.size()-current);
        return max;
        }
};