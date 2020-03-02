using System;
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
        Queue<Node> Q = new Queue<Node>();
        Q.Enqueue(root);
        while (Q.Count > 0)
        {
            int size = Q.Count;
            for (var i = 0; i < size; ++i)
            {
                Node node = Q.Dequeue();
                if (i < size - 1)
                {
                    node.next = Q.Peek();
                }
                if (node.left != null)
                {
                    Q.Enqueue(node.left);
                }
                if (node.right != null)
                {
                    Q.Enqueue(node.right);
                }
            }
        }
        return root;
    }
}