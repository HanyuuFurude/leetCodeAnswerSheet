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
using Number110;
public partial class Solution
{
    public bool IsBalanced(TreeNode root)
    {
        var demo = new C(root);
        return demo.result;
    }
}
namespace Number110
{
    public class C
    {
        public bool result;
        public C(TreeNode root)
        {
            result = true;
            SearchDepth(root);
        }
        public int SearchDepth(TreeNode root)
        {
            if (!result) { return 0; }
            if (root == null) { return 0; }
            int l = SearchDepth(root.left);
            int r = SearchDepth(root.right);
            if (l - r > 1 || r - l > 1)
            {
                result = false;
                return 0;
            }
            return l > r ? l + 1 : r + 1;
        }
    }
}