
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
using Number024;
public partial class Solution
{
    public ListNode SwapPairs(ListNode head)
    {
        ListNode res, ptr, a, b;
        res = new ListNode(0);
        ptr = res;
        ptr.next = head;
        while(ptr!=null && ptr.next!=null)
        {
            a = ptr.next;b = a.next;
            ptr.next = b;a.next = b.next;b.next = a;
            ptr = a;
        }
        return res.next;
    }
}
namespace Number024
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        { val = x; }
    }
}