/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
using PublicClass;
using System.Collections.Generic;
public class BSTIterator
{
    Stack<TreeNode> path;
    public BSTIterator(TreeNode root)
    {
        path = new Stack<TreeNode>();
        helper(root);
    }

    /** @return the next smallest number */
    public int Next()
    {
        var handle = path.Pop();
        if (handle.right != null)
        {
            helper(handle.right);
        }
        return handle.val;
    }
    private void helper(TreeNode pointer)
    {
        while (pointer != null)
        {
            path.Push(pointer);
            pointer = pointer.left;
        }
    }

    /** @return whether we have a next smallest number */
    public bool HasNext()
    {
        return path.Count > 0;
    }
}

/**
 * Your BSTIterator object will be instantiated and called as such:
 * BSTIterator obj = new BSTIterator(root);
 * int param_1 = obj.Next();
 * bool param_2 = obj.HasNext();
 */
 