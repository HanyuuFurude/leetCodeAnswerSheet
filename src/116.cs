﻿using System;
using System.Collections.Generic;
using System.Text;
using PublicClass;

/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}
*/
public partial class Solution
{
    public Node Connect(Node root)
    {
        if (root == null)
        { return root; }
        Node leftmost = root;
        while (leftmost.left != null)
        {
            Node head = leftmost;
            while (head != null)
            {
                head.left.next = head.right;
                if (head.next != null)
                {
                    head.right.next = head.next.left;
                }
                head = head.next;
            }
            leftmost = leftmost.left;
        }
        return root;
    }
}