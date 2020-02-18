using System;
using System.Collections.Generic;
using System.Text;
using PublicClass;
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public partial class Solution
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        if (head == null || head.next == null)
        { return head; }
        ListNode handle = new ListNode(0), ptr = handle;
        handle.next = ptr;
        while (ptr.next.next != null)
        {
            if (ptr.next.val != ptr.next.next.val)
            { ptr = ptr.next; }
            else
            {
                ListNode dNode = ptr.next.next.next;
                while (dNode != null && dNode.val == ptr.next.val)
                { dNode = dNode.next; }
                ptr.next = dNode;
                if (ptr.next == null)
                { break; }
            }
        }
        return handle.next;
    }
}