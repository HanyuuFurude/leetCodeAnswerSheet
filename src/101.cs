using System;
using System.Collections.Generic;
using System.Text;
using PublicClass;
using Number101;

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
    public bool IsSymmetric(TreeNode root)
    {
        return C.cmp(root.left, root.right);
    }
}
namespace Number101
{
    public class C
    {
        public static bool cmp(TreeNode p, TreeNode q)
        {
            if (p == null && q == null) { return true; }
            if (p != null && q != null)
            {
                if (p.val == q.val)
                { return cmp(p.left, q.right) && cmp(p.right, q.left); }
            }
            return false;
        }
    }
}