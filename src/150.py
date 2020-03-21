import operator


class Solution:
    def evalRPN(self, tokens: List[str]) -> int:
        ops = {'+': operator.add, '-': operator.sub,
               '*': operator.mul, '/': operator.truediv}
        stack = []
        for x in tokens:
            if x not in ops:
                stack.append(x)
            else:
                a = stack.pop()
                b = stack.pop()
                stack.append(int(ops[x](int(b), int(a))))
        return int(stack[0])