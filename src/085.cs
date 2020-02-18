//using System;
//using System.Collections.Generic;
//using System.Text;

//public partial class Solution
//{
//    public int MaximalRectangle(char[][] matrix)
//    {
//        Func<int[], int> calcSig = (lis) =>
//         {
//             Stack<int> stack = new Stack<int>();
//             stack.Push(-1);
//             int maxArea = 0;
//             for (var i = 0; i < lis.Length; ++i)
//             {
//                 while (stack.Peek() != -1 && lis[stack.Peek()] >= lis[i])
//                 {
//                     int tempRes = lis[stack.Pop()] * (lis.Length - stack.Peek() - 1);
//                     maxArea = maxArea > tempRes ? maxArea : tempRes;
//                 }
//                 stack.Push(i);
//             }
//             while (stack.Peek() != -1)
//             {
//                 int doge = lis[stack.Pop()] * (lis.Length - stack.Peek() - 1);
//                 maxArea = maxArea > doge ? maxArea : doge;
//             }
//             return maxArea;
//         };
//        if (matrix.Length == 0) { return 0; }
//        int res = 0;
//        int[] arr = new int[matrix[0].Length];
//        for (var i = 0; i < matrix.Length; ++i)
//        {
//            for (var j = 0; j < matrix[0].Length; ++j)
//            { arr[j] = matrix[i][j] == '1' ? arr[j] + 1 : 0; }
//            int cat = calcSig(arr);
//            res = res > cat ? res : cat;
//        }
//        return res;
//    }
//}