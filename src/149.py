from typing import List
import math
import decimal


class Solution:
    def maxPoints(self, points: List[List[int]]) -> int:
        if len(points) < 3:
            return len(points)
        maxConn = 0
        for i in range(len(points) - 1):
            countDist = dict()
            plus = 0
            for j in range(i + 1, len(points)):
                k = regularize(points[i][0], points[i]
                               [1], points[j][0], points[j][1])
                if k not in countDist:
                    countDist[k] = 2
                else:
                    countDist[k] += 1
            if decimal.Decimal('-inf') in countDist:
                plus = countDist[decimal.Decimal('-inf')]-1
            for item in countDist:
                if item == decimal.Decimal('-inf'):
                    maxConn = max(maxConn, countDist[item])
                else:
                    maxConn = max(maxConn, countDist[item]+plus)
        return maxConn


def regularize(a: int, b: int, c: int, d: int) -> float:
    if a == c:
        if b == d:
            return decimal.Decimal('-inf')
        return decimal.Decimal('inf')
    return decimal.Decimal(d-b)/decimal.Decimal(c-a)


if __name__ == '__main__':
    demo = Solution()
    demoList = [[0, 0], [94911151, 94911150], [94911152, 94911151]]
    res = demo.maxPoints(demoList)
    print(res)
