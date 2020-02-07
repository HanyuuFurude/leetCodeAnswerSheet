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
            int[][] test = new int[2][];
            for (var i = 0; i < 2; ++i)
            { test[i] = new int[2]; }
            for (var i = 0; i < 2; ++i)
            {
                for (var j = 0; j < 2; ++j)
                {
                    test[i][j] = i * 2 + j + 1;
                }
            }
            var res = a.SpiralOrder(test);
            foreach(var i in res)
            { Console.WriteLine(i); }

        }
    }
}