class Solution {
public:
    vector<int> twoSum(vector<int>& nums, int target) 
    {
        for (int i = 0 ; i < nums.size() ; i++)
        {
            for (int j = i + 1 ; j < nums.size() ; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    vector<int> res;
                    res.push_back(i);
                    res.push_back(j);
                    return res;
                }
            }
        }
        return vector<int>(-1,-1);
    }
};