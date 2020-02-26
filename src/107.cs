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
public partial class Solution
{
    public IList<IList<int>> LevelOrderBottom(TreeNode root)
    {
        List<IList<int>> res = new List<IList<int>>();
        if (root == null) { return res; }
        List<TreeNode> layer;
        List<TreeNode> nextLayer = new List<TreeNode>();
        nextLayer.Add(root);
        while (nextLayer.Count != 0)
        {
            layer = nextLayer;
            nextLayer = new List<TreeNode>();
            foreach (var i in layer)
            {
                if (i.left != null) { nextLayer.Add(i.left); }
                if (i.right != null) { nextLayer.Add(i.right); }
            }
            res.Insert(0, new List<int>());
            foreach (var i in layer)
            { res[0].Add(i.val); }
        }
        return res;
    }
}