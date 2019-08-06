class Solution {
public:
    bool isPalindrome(int x) {
        if (x<0)
            return false;
        int tmp = x;
        long rev = 0;
        while (tmp>0)
        {
            rev*=10;
            rev += tmp%10;
            tmp/=10;
        }
        if(rev!=x)
            return false;
        return true;

    }
};