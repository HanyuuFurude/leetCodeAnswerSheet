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
using Number021;
namespace Number021
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
    public ListNode MergeTwoLists(ListNode l1, ListNode l2)
    {
        ListNode res = new ListNode(0);
        ListNode key = res;
        ListNode ll1 = l1;
        ListNode ll2 = l2;
        while(true)
        {
            if(ll1==null)
            {
                while(ll2!=null)
                {
                    key.next = ll2;
                    ll2 = ll2.next;key = key.next;
                }
                return res.next;
            }
            else if(ll2==null)
            {
                while(ll1!=null)
                {
                    key.next = ll1;
                    ll1 = ll1.next;key = key.next;
                }
                return res.next;
            }
            else
            {
                if(ll1.val>ll2.val)
                {
                    key.next = ll2;
                    ll2 = ll2.next;key = key.next;
                }
                else
                {
                    key.next = ll1;
                    ll1 = ll1.next;key = key.next;
                }
            }
        }
    }
}
