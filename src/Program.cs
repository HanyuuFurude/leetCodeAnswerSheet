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
            int[] demo = { 1,3,3};
            var res = a.PermuteUnique(demo);
            foreach(var i in res)
            {
                foreach(var j in i)
                { Console.Write($"{j} "); }
                Console.WriteLine();
            }

        }
    }
}