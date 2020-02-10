using System;
using System.Collections.Generic;
using System.Text;
using PublicClass;

namespace PublicTestTool
{
    public class Test
    {
        public class Print<T>
        {
            public static void PrintMatrix(IList<IList<T>> src)
            {
                foreach (var i in src)
                {
                    foreach (var j in i)
                    { Console.Write($"{j}\t"); }
                    Console.WriteLine();
                }
            }
        }
        public static void PrintLinkList(ListNode src)
        {
            while (src != null)
            { Console.Write($"{src.val}\t"); src = src.next; }
        }
        public static long Factorial(int src)
        {
            int fact = 1;
            for(var i = 1;i<=src;++i)
            {fact *= i;}
            return fact;
        }
    }
}