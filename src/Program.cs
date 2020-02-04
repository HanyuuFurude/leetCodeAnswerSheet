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
            int[] demo = { 2,3,1,2,3,1,1,3,4,3};
            Console.WriteLine(a.Jump(demo));
        }
    }
}