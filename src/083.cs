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
    /*
     * 该题函数签名与82题重复，故添加一无意义参数
     */
    public ListNode DeleteDuplicates(ListNode head,int removeme = 0)
    {
        if (head == null) { return head; }
        ListNode ptr = head;
        while (ptr.next != null)
        {
            if (ptr.next.val == ptr.val)
            { ptr.next = ptr.next.next; }
            else
            { ptr = ptr.next; }
        }
        return head;
    }
}