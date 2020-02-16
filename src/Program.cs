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
            int[] demo = Test.USE<int>.ListToArray(
                Test.USE<int>.StringToList(
                    "[1,1,3]"
                    ));
            var lenght = a.Search(demo, 0, 0);
            Console.WriteLine(lenght);
        }
    }
}
