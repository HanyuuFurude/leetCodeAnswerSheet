using System;
using System.Collections.Generic;
using System.Text;
using PublicClass;
using Number098;
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
    public bool IsValidBST(TreeNode root)
    {
        return C.IsVaild(root, null, null);
    }
}
namespace Number098
{
    public class C
    {
        public static bool IsVaild(TreeNode node, int? min, int? max)
        {
            if (node == null) { return true; }
            if (
                (min == null && max == null) ||
                (min == null && node.val < max) ||
                (node.val > min && max == null) ||
                (node.val > min && node.val < max)
                )
            {
                return IsVaild(node.left, min, node.val) &&
                    IsVaild(node.right, node.val, max);
            }
            return false;
        }
    }
}