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
using Number124;
public partial class Solution
{
    public int MaxPathSum(TreeNode root)
    {
        var demo = new C();
        demo.MaxPathSum(root);
        return demo.result;
    }
}
namespace Number124
{
    public class C
    {
        public int result = int.MinValue;
        public int MaxPathSum(TreeNode root)
        {
            if (root == null) { return 0; }
            int left = MaxPathSum(root.left);
            if (left < 0) { left = 0; }
            int right = MaxPathSum(root.right);
            if (right < 0) { right = 0; }
            result = result > left + right + root.val ? result : left + right + root.val;
            return root.val + (left > right ? left : right);
        }
    }
}