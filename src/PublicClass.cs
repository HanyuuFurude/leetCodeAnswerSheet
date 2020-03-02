using System;
using System.Collections.Generic;
using System.Text;

namespace PublicClass
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
    public class Node
    {
        public int val;
        public Node left;
        public Node right;
        public Node next;
        public Node() { }
        public Node(int _val)
        { val = _val; }
        public Node(int _val, Node _left, Node _right, Node _next)
        {
            val = _val;
            left = _left;
            right = _right;
            next = _next;
        }
    }

}