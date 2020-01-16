using System;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution a = new Solution();
            int[] test = {-55, -24, -18, -11, -7, -3, 4, 5, 6, 9, 11, 23, 33};
            int target = 0;
            var res = a.ThreeSumClosest(test,target);
            Console.WriteLine(res);
        }
    }
}
