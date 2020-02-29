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
using Number111;
public partial class Solution
{
    public int MinDepth(TreeNode root)
    {
        return C.SearchMinDepth(root);
    }
}
namespace Number111
{
    public class C
    {
        public static int SearchMinDepth(TreeNode root)
        {
            if (root == null) { return 0; }
            int l = SearchMinDepth(root.left);
            int r = SearchMinDepth(root.right);
            if (l == 0 || r == 0) { return l + r + 1; }
            return l < r ? l + 1 : r + 1;
        }
    }
}