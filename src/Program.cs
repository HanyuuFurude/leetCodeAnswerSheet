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
            var b = a.IsScramble("abcde","acdbe");
            Console.Write(b);
        }
    }
}
