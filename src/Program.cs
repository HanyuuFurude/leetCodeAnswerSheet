using System;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution a = new Solution();
            var res = a.LetterCombinations("73465");
            foreach(var i in res)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(res);
        }
    }
}
