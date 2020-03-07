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
            string[] demo = { "hot", "dot", "dog", "lot", "log", "cog" };
            a.LadderLength("hit", "dog", demo);
        }
    }
}
