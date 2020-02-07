using System;

//using Number19;
using Number025;
namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Solution();
            //var res = a.SolveNQueens(4);
            //foreach (var i in res)
            //{
            //    foreach (var j in i)
            //    {
            //        Console.WriteLine(j);
            //    }
            //}
            //Console.WriteLine();
            int c = 3, r = 3;
            int[][] test = new int[r][];
            for (var i = 0; i < r; ++i)
            { test[i] = new int[c]; }
            for (var i = 0; i < r; ++i)
            {
                for (var j = 0; j < c; ++j)
                {
                    test[i][j] = i * c + j + 1;
                    Console.Write($"{test[i][j]}\t");
                }
                Console.WriteLine();
            }
            var res = a.SpiralOrder(test);
            foreach(var i in res)
            { Console.Write($"{i} "); }

        }
    }
}