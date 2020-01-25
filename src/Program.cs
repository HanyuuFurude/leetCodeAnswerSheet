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
			ListNode demo = new ListNode(0);
			ListNode key = demo;
			for (var i = 1; i < 23;++i)
            {
demo.next = new ListNode(i);
demo = demo.next;
			}
			var res = a.ReverseKGroup(key,4);
			while(res!=null)
            {
                Console.Write(res.val);
				Console.Write(" ");
				res = res.next;
            }

        }
    }
}
