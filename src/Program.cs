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
            int[] b = { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
            var res = a.Trap(b);
            Console.Write(res);
        }
    }
}