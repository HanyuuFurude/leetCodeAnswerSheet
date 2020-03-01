using System;
using System.Collections.Generic;
using System.Text;
using PublicClass;

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public partial class Solution
{
    public void Flatten(TreeNode root)
    {
        if (root == null) { return; }
        if (root.left != null) { Flatten(root.left); }
        if (root.right != null) { Flatten(root.right); }
        if (root.left == null) { return; }
        TreeNode ptr = root.left;
        while (ptr.right != null) { ptr = ptr.right; }
        ptr.right = root.right;
        root.right = root.left;
        root.left = null;
    }
}