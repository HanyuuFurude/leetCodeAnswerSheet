using System;
using System.Collections.Generic;
using System.Text;
using Number105;
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
    public TreeNode BuildTree(int[] preorder, int[] inorder)
    {
        if (preorder.Length == 0) { return null; }
        var demo = new C(preorder, inorder);
        return demo.res;
    }
}
namespace Number105
{
    public class C
    {
        public TreeNode res;
        int[] p, i;
        public C(int[] preorder, int[] inorder)
        {
            p = preorder; i = inorder; res = new TreeNode(0);
            build(res, 0, i.Length - 1, 0, i.Length - 1);
        }
        private void build(TreeNode node, int pl, int pr, int il, int ir)
        {
            node.val = p[pl];
            int div = IndexOf(i, p[pl]);
            if (div > il)
            {
                node.left = new TreeNode(0);
                build(node.left, pl + 1, pl - il + div, il, div - 1);
            }
            if (div < ir)
            {
                node.right = new TreeNode(0);
                build(node.right, pl - il + div + 1, pr, div + 1, ir);
            }
        }
        private int IndexOf(int[] arr, int tar)
        {
            for (var i = 0; i < arr.Length; ++i) { if (arr[i] == tar) { return i; } }
            return -1;
        }
    }
}