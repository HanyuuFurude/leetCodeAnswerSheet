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

            char[][] demo = new char[9][];
            char[] demo0 = { '5', '3', '.', '.', '7', '.', '.', '.', '.' };
            char[] demo1 = { '6', '.', '.', '1', '9', '5', '.', '.', '.' };
            char[] demo2 = { '.', '9', '8', '.', '.', '.', '.', '6', '.' };
            char[] demo3 = { '8', '.', '.', '.', '6', '.', '.', '.', '3' };
            char[] demo4 = { '4', '.', '.', '8', '.', '3', '.', '.', '1' };
            char[] demo5 = { '7', '.', '.', '.', '2', '.', '.', '.', '6' };
            char[] demo6 = { '.', '6', '.', '.', '.', '.', '2', '8', '.' };
            char[] demo7 = { '.', '.', '.', '4', '1', '9', '.', '.', '5' };
            char[] demo8 = { '.', '.', '.', '.', '8', '.', '.', '7', '9' };
            demo[0] = demo0;
            demo[1] = demo1;
            demo[2] = demo2;
            demo[3] = demo3;
            demo[4] = demo4;
            demo[5] = demo5;
            demo[6] = demo6;
            demo[7] = demo7;
            demo[8] = demo8;
            a.SolveSudoku(demo);

        }
    }
}