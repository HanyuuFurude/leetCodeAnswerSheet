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
            int[] demo =
                Test.USE<int>.ListToArray(
                    Test.USE<int>.StringToList(
                        "[3,2,5,6]"
                        )
                    );
            var res = a.Subsets(demo);
            Test.USE<int>.PrintMatrix(res);
        }
    }
}