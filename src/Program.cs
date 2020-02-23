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
            var b = new TreeNode(int.MaxValue);
            Console.WriteLine(a.IsValidBST(b));

        }
    }
}
