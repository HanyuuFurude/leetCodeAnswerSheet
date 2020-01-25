using System;
using System.Collections;
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
using Number025;
public partial class Solution
{
	public ListNode ReverseKGroup(ListNode head, int k)
	{
		ListNode[] storge = new ListNode [k];
		ListNode nodeHead = new ListNode(0);
		nodeHead.next = head;
		ListNode key = nodeHead;
		ListNode ptr = key.next;
		while (true)
		{
			for (var i = 0; i < k; ++i)
			{
				if (ptr == null)
				{ return nodeHead.next; }
				storge[i] = ptr;
				ptr = ptr.next;
			}
			ListNode following = ptr;
			for (var i = k-1; i >-1;--i)
			{
				key.next = storge[i];
				key = key.next;
			}
			key.next = following;
		}
		// return nodeHead.next;
	}
}
namespace Number025
{
	public class ListNode
	{
		public int val;
		public ListNode next;
		public ListNode(int x) { val = x; }
	}
}