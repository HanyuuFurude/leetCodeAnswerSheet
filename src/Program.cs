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
            Console.WriteLine(a.MySqrt(2147483647
));
            for (var i = 0; i < 100; ++i)
            {
                Console.WriteLine($"{i}\t{a.MySqrt(i)}");
            }

        }
    }
}