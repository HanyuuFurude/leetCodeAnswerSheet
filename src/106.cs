using System;
using System.Collections.Generic;
using System.Text;
using PublicClass;
using Number106;
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
    public TreeNode BuildTree(int[] inorder, int[] postorder, int removeme = 0)
    {
        if (inorder.Length == 0) { return null; }
        var demo = new C(inorder, postorder);
        return demo.res;
    }
}
namespace Number106
{
    public class C
    {
        public TreeNode res;
        int[] p, i;
        public C(int[] inorder, int[] postorder)
        { p = postorder; i = inorder; res = new TreeNode(0); build(res, 0, i.Length - 1, 0, i.Length - 1); }

        private void build(TreeNode node, int pl, int pr, int il, int ir)
        {
            node.val = p[pr];
            int div = IndexOf(i, p[pr]);
            if (il < div)
            {
                node.left = new TreeNode(0);
                build(node.left, pl, pr + div - ir - 1, il, div - 1);
            }
            if (div < ir)
            {
                node.right = new TreeNode(0);
                build(node.right, pr + div - ir, pr - 1, div + 1, ir);
            }
        }
        private int IndexOf(int[] arr, int tar)
        {
            for (var i = 0; i < arr.Length; ++i) { if (arr[i] == tar) { return i; } }
            return -1;
        }
    }
}