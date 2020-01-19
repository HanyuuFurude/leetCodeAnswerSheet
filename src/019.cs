using System;
using System.Collections.Generic;
using System.Text;

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
using Number19;
namespace Number19
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
public partial class Solution
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        ListNode InnerHead = new ListNode(0);
        InnerHead.next = head;
        ListNode Fkey = InnerHead;
        ListNode Bkey = InnerHead;
        int count = 0;
        while(count<n && Fkey.next!=null)
        {
            Fkey = Fkey.next;
            ++count;
        }
        while(Fkey.next!=null)
        {
            Bkey = Bkey.next;
            Fkey = Fkey.next;
        }
        Bkey.next = Bkey.next.next;
            return InnerHead.next;
    }
}