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
            Console.Write(a.NumDecodings("232254"));
        }
    }
}
