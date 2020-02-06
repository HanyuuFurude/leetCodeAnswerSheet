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
            var res = a.SolveNQueens(4);
            foreach (var i in res)
            {
                foreach (var j in i)
                {
                    Console.WriteLine(j);
                }
            }
            Console.WriteLine();

        }
    }
}