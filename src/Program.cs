using System;
using PublicClass;
using PublicTestTool;
namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Solution();
            int[][] demo = new int[1][];
            demo[0] = new int[1];
            demo[0][0] = 1;
            Console.WriteLine(a.UniquePathsWithObstacles(demo));
        }
    }
}