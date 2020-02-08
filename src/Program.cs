using System;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Solution();
            //int[] demo = { 2, 2, 1, 0, 4 };
            int[][] demo = new int[2][];
            demo[0] = new int[2];
            demo[1] = new int[2];
            demo[0][0] = 1;demo[0][1] = 4;
            demo[1][0] = 4;demo[1][1] = 5;
            var res = a.Merge(demo);
            foreach(var i in res)
            {
                foreach(var j in i)
                {
                    Console.Write($"{j}\t");
                }
                Console.WriteLine();
            }
        }
    }
}