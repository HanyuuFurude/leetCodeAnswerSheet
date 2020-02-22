using System;
using System.Collections.Generic;
using System.Text;
using PublicClass;
using Number094;

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
    public IList<int> InorderTraversal(TreeNode root)
    {
        List<int> res = new List<int>();
        C.visit(root, res);
        return res;
    }
}
namespace Number094
{
    public class C
    {
        public static void visit(TreeNode node, IList<int> res)
        {
            if (node != null)
            {
                visit(node.left, res);
                res.Add(node.val);
                visit(node.right, res);
            }
        }
    }
}