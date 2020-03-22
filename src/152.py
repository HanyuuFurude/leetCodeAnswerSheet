import json
from typing import *


class Solution:
    def maxProduct(self, nums: List[int]) -> int:
        self.nums = nums
        if len(nums) < 2:
            if len(nums) == 0:
                return 0
            return nums[0]
        ptr = 0
        res = 0
        left = 0
        leftNeg = -1
        rightNeg = -1
        countNeg = 0
        while ptr < len(nums):
            if nums[ptr] < 0:
                countNeg += 1
                if leftNeg == -1:
                    leftNeg = ptr
                else:
                    rightNeg = ptr
            if nums[ptr] == 0:
                right = ptr
                if left < ptr:
                    res = max(res, self.calc(left, ptr - 1,
                                        leftNeg, rightNeg, countNeg))
                left = ptr + 1
                leftNeg = -1
                rightNeg = -1
                countNeg = 0
            ptr += 1
        if left < ptr:
            res = max(res, self.calc(left, ptr - 1, leftNeg, rightNeg, countNeg))
        return res

    def calc(self, left: int, right: int, leftNeg: int, rightNeg: int, countNeg: int) -> int:
        if left == right:
            return self.nums[left]
        if countNeg % 2 == 0:
            res = 1
            for i in range(left, right + 1):
                res *= self.nums[i]
            return res
        elif countNeg == 1:
            resLeft = 1
            resRight = 1
            for i in range(left, leftNeg):
                resLeft *= self.nums[i]
            for i in range(leftNeg + 1, right+1):
                resRight *= self.nums[i]
            return max(resLeft, resRight)
        else:
            resLeft = 1
            resRight = 1
            resMiddle = 1
            for i in range(left, leftNeg + 1):
                resLeft *= self.nums[i]
            for i in range(rightNeg, right + 1):
                resRight *= self.nums[i]
            for i in range(leftNeg + 1, rightNeg):
                resMiddle *= self.nums[i]
            return resMiddle*min(resLeft, resRight)


if __name__ == '__main__':
    inputWord = input()
    inputWord = json.loads(inputWord)
    demo = Solution()
    res = demo.maxProduct(inputWord)
    print(res)
