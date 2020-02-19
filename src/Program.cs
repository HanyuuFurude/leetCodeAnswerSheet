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
            int[] demo = Test.USE<int>.ListToArray(Test.USE<int>.StringToList("[1,2,4,4,4]"));
            var res = a.SubsetsWithDup(demo);
            Test.USE<int>.PrintMatrix(res);
        }
    }
}
