using System;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Solution();
            var b = a.GetPermutation(1, 1);
            Console.WriteLine(b);
            //for(var i = 1;i<=6;++i)
            //{
            //    Console.WriteLine(a.GetPermutation(3, i));
            //}
        }
    }
}