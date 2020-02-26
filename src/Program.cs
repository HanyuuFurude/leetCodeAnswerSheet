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
            int[] c = Test.USE<int>.ListToArray(
                Test.USE<int>.StringToList("[-10,-3,0,5,9]"));
            var b = a.SortedArrayToBST(c);

        }
    }
}
