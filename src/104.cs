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
    public int MaxDepth(TreeNode root)
    {
        if (root == null)
        { return 0; }
        int l = MaxDepth(root.left);
        int r = MaxDepth(root.right);
        return l > r ? l + 1 : r + 1;
    }
}