using System;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution a = new Solution();
            int[] demo = {1, 0, -1, 0, -2, 2};
            int target = 0;
            var res = a.FourSum(demo, target);
            foreach(var i in res)
            {
                foreach(var j in i)
                {
                    Console.Write($"{j}\t");
                }
                Console.WriteLine();
            }
            //Console.WriteLine(res);
        }
    }
}
