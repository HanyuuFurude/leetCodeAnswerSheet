using System;
using System.Collections.Generic;
using System.Text;
using PublicClass;
using Number108;
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
    public TreeNode SortedArrayToBST(int[] nums)
    {
        if (nums.Length == 0) { return null; }
        var demo = new C(nums);
        return demo.root;
    }
}
namespace Number108
{
    public class C
    {
        public TreeNode root;
        int[] n;
        public C(int[] nums)
        {
            n = nums;
            root = new TreeNode(0);
            buildTree(root, 0, n.Length - 1);
        }
        private void buildTree(TreeNode root, int l, int r)
        {
            int index = (l + r) / 2;
            root.val = n[index];
            if (index > l)
            {
                root.left = new TreeNode(0);
                buildTree(root.left, l, index - 1);
            }
            if (index < r)
            {
                root.right = new TreeNode(0);
                buildTree(root.right, index + 1, r);
            }
        }
    }
}