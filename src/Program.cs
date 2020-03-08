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
            string[] demo = { "hat", "dot", "dog", "lot", "log", "cog" };
            var res = a.LadderLength("hit", "hot", demo);
            Console.WriteLine(res);
        }
    }
}
