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
using Number023;
public partial class Solution
{
    public ListNode MergeKLists(ListNode[] lists)
    {
        int Count = lists.Length;
        if(Count==0)
        {
            return null;
        }
        int SpecialNode = Count * 2;
        int[] tree = new int[Count];
        Func<int, int> Val = (src) =>
       {
           if (src < Count)
           { return tree[src]; }
           else if (src < Count * 2)
           {
               if (lists[src - Count] == null)
               { return int.MaxValue; }
               else
               { return lists[src - Count].val; }
           }
           else if (src == Count * 2)
           { return int.MinValue; }
           else
           {
               throw new Exception("?");
           }

       };
        for (var i = 0; i < Count; ++i)
        {
            tree[i] = SpecialNode;
        }
        for (var i = 0; i < Count; ++i)
        {
            int key = i + Count;
            int node = (i + Count) / 2;
            while (node > 0)
            {
                if (Val(Val(node)) < Val(key))
                { int temp = key; key = Val(node); tree[node] = temp; }
                node /= 2;
            }
            tree[node] = key;
        }
        ListNode resPreHead = new ListNode(0);
        ListNode resKey = resPreHead;
        while (true)
        {
            if (Val(tree[0])==int.MaxValue)
            { return resPreHead.next; }
            resKey.next = lists[tree[0]-Count];
            resKey = resKey.next;
            lists[tree[0]-Count] = lists[tree[0]-Count].next;
            int key = tree[0];
            int node = key / 2;
            while (node > 0)
            {
                if (Val(Val(node)) < Val(key))
                { int temp = key; key = Val(node); tree[node] = temp; }
                node /= 2;
            }
            tree[node] = key;
        }

    }
}
namespace Number023
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}