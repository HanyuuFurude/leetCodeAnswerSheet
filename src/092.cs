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
    public ListNode ReverseBetween(ListNode head, int m, int n)
    {
        Stack<ListNode> stack = new Stack<ListNode>();
        ListNode handle = new ListNode(0), ptr = handle, hang, following;
        int count = 1;
        handle.next = head;
        while (count < m) { ptr = ptr.next; ++count; }
        hang = ptr;ptr = ptr.next;
        while (count <= n) { stack.Push(ptr); ptr = ptr.next; ++count; }
        following = ptr; ptr = hang;
        while (stack.Count > 0)
        {
            ptr.next = stack.Pop();
            ptr = ptr.next;
        }
        ptr.next = following;
        return handle.next;

    }
}