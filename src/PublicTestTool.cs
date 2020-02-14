using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using PublicClass;

namespace PublicTestTool
{
    public class Test
    {
        public class USE<T>
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
            public static void PrintList(IList<T> src)
            {
                foreach (var i in src)
                { Console.WriteLine($"{i} "); }
                Console.WriteLine();
            }
            public static List<T> StringToList(string src)
            { return JsonConvert.DeserializeObject<List<T>>(src); }
            public static List<List<T>> StringToMatrix(string src)
            { return JsonConvert.DeserializeObject<List<List<T>>>(src); }
            public static T[] ListToArray(List<T> src)
            {
                T[] array = new T[src.Count];
                for(var i = 0;i<src.Count;++i)
                {array[i] = src[i];}
                return array;
            }
            public static T[][] ListMatrixToArrayMatrix(List<List<T>> src)
            {
                T[][] res = new T[src.Count][];
                for (var i = 0; i < src.Count; ++i)
                {
                    res[i] = new T[src[0].Count];
                    for (var j = 0; j < src[0].Count; ++j)
                    {
                        res[i][j] = src[i][j];
                    }
                }
                return res;
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
            for (var i = 1; i <= src; ++i)
            { fact *= i; }
            return fact;
        }
    }
}