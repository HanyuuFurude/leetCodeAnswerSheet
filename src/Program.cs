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
            Console.WriteLine(a.IsNumber("."));
            Console.WriteLine(a.IsNumber(".3"));
            Console.WriteLine(a.IsNumber("3."));
            Console.WriteLine(a.IsNumber("+.2e2"));
            Console.WriteLine(a.IsNumber("+.e3"));
            Console.WriteLine(a.IsNumber("+22.e3"));
        }
    }
}