using System;

//using Number19;
using Number023;
namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Solution();
            ListNode[] b = new ListNode[3];
            for(var i =0;i<3;++i)
            {
                b[i] = new ListNode(i);
            }
            b[0].next = new ListNode(5);
            b[1].next = new ListNode(4);
            b[2].next = new ListNode(8);
            var res = a.MergeKLists(b);
            while(res!=null)
            {
                Console.WriteLine(res.val);
                res = res.next;
            }

        }
    }
}
