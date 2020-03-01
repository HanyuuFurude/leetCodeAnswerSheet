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
using Number112;
public partial class Solution
{
    public bool HasPathSum(TreeNode root, int sum)
    {
        var demo = new C(sum);
        return demo.search(root, 0);
    }
}
namespace Number112
{
    public class C
    {
        int target;
        public C(int s)
        { target = s; }
        public bool search(TreeNode root, int sum)
        {
            if (root == null) { return false; }
            if (root.left == null && root.right == null)
            {
                if ((sum + root.val) == target)
                { return true; }
            }
            if (search(root.left, sum + root.val)) { return true; }
            if (search(root.right, sum + root.val)) { return true; }
            return false;
        }

    }
}