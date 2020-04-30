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
            int[][] arr = new int[3][]{
                new int[3]{ -2, -3, 3},
                new int[3]{ -5, -10, 1},
                new int[3]{ 10, 30, -5}
            };
            var a = new Solution();
            int res = a.CalculateMinimumHP(arr);
            Console.WriteLine(res);

        }
    }
}
