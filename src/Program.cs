using System;
using PublicClass;
// using Graph;
using PublicTestTool;
namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Solution();
            Console.WriteLine(a.TitleToNumber("A"));
            Console.WriteLine(a.TitleToNumber("Z"));
            Console.WriteLine(a.TitleToNumber("AA"));
            Console.WriteLine(a.TitleToNumber("AZ"));
            Console.WriteLine(a.TitleToNumber("BA"));
        }
    }
}
