using System;

using Number19;
namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Solution();
            var res = a.GenerateParenthesis(0);
            foreach(var i in res)
            {
                Console.WriteLine(i);
            }
        }
    }
}
