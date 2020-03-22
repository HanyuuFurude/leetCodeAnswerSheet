from typing import *


class Solution:
    def findMin(self, nums: List[int]) -> int:
        if len(nums) < 2:
            if len(nums) == 0:
                return 0
            return nums[0]
        left = 0
        right = len(nums) - 1
        while left + 1 < right:
            middle = int((left + right) / 2)
            if nums[middle] >= nums[0]:
                left = middle
            else:
                right = middle
        return min(nums[right],nums[0])


if __name__ == '__main__':
    import json
    inputWord = input()
    demo = Solution()
    res = demo.findMin(json.loads(inputWord))
    print(res)
