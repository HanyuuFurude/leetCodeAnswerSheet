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
            int w = 3, h = 3;
            int[] array = Test.USE<int>.ListToArray(Test.USE<int>.StringToList("[1,2,0,0,00,0,0,0,0]"));
            a.SortColors(array);
            foreach(var i in array)
            { Console.WriteLine(i); };
            
            
        }
    }
}