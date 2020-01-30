using System;

//using Number19;
using Number025;
namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Solution();

            int[] arr = { 4, 5, 6, 7, 1, 2, 3 };
            var res = a.Search(arr, 3);
            Console.WriteLine(res);

        }
    }
}