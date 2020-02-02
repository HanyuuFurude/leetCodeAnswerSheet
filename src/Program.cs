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
            int[] b = { 2, 3, 5};
            var res = a.CombinationSum(b, 8);
            foreach(var i in res)
            {
                foreach(var j in i)
                { Console.Write($"{j} "); }
                Console.WriteLine();
            }
        }
    }
}