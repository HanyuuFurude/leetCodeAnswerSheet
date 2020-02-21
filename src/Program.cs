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
            var b = a.RestoreIpAddresses("010010");
            foreach(var i in b)
            {
                Console.WriteLine(i);
            }
        }
    }
}
