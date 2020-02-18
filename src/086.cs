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
    public ListNode Partition(ListNode head, int x)
    {
        Func<ListNode, ListNode> umountNode = (src) =>
         {
             ListNode node = src.next;
             src.next = src.next.next;
             return node;
         };
        Func<ListNode, ListNode, ListNode> mountNode = (src, insertNode) =>
          {
              ListNode folling = src.next;
              src.next = insertNode;
              insertNode.next = folling;
              return insertNode;
          };
        ListNode hangNode = null, heading = new ListNode(0), ptr;
        heading.next = head; ptr = heading;
        while (ptr.next != null)
        {
            if (ptr.next.val >= x) { hangNode = ptr; break; }
            ptr = ptr.next;
        }
        while (ptr.next != null)
        {
            if (ptr.next.val < x)
            {
                ListNode swap = umountNode(ptr);
                hangNode = mountNode(hangNode, swap);
            }
            else
            { ptr = ptr.next; }
        }
        return heading.next;
    }
}