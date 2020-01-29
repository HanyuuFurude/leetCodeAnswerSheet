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

            var input = new string[3];
            input[0] = "bar";
            input[1] = "foo";
            input[2] = "the";
            //input[3] = "good";

            var res = a.FindSubstring("barfoofoobarthefoobarman", input);
            foreach(var i in res)
            {
                Console.WriteLine(i);
            }

        }
    }
}