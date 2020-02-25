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
            int[] b = Test.USE<int>.ListToArray(
                Test.USE<int>.StringToList("[3,1,2,4]"));
            int[] c = Test.USE<int>.ListToArray(
                Test.USE<int>.StringToList("[1,2,3,4]"));
            var res = a.BuildTree(b, c);
             
        }
    }
}
