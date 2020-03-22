class Solution:
    def reverseWords(self, s: str) -> str:
        trig = str.split(s, " ")
        res = ""
        for i in range(len(trig) - 1, -1, -1):
            if trig[i] != "":
                if res != "":
                    res += " "
                res = res + trig[i]
        return res


if __name__ == '__main__':
    inputWord = input()
    demo = Solution()
    res = demo.reverseWords(inputWord)
    print(res)
