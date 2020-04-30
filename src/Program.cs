using System;
using PublicClass;
// using Graph;
using PublicTestTool;
namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[][]{
                new int[]{-2, -3, 3},
                new int[]{-5, -10, 1},
                new int[]{10, 30, -5}
            };
            var a = new Solution();
            int res = a.CalculateMinimumHP(arr);
            Console.WriteLine(res);

        }
    }
}
