/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
using PublicClass;
public partial class Solution
{
    public ListNode RotateRight(ListNode head, int k)
    {
        if(head==null||head==null)
        { return head; }
        ListNode frontNode = head, handle;
        int length = 1;
        while (frontNode.next != null)
        { frontNode = frontNode.next; ++length; }
        frontNode.next = head;
        k %= length;
        frontNode = head;
        length -= k;
        while (--length > 0)
        { frontNode = frontNode.next; }
        handle = frontNode.next;
        frontNode.next = null;
        return handle;
    }
}
