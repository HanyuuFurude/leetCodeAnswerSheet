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
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
    {
        List<IList<int>> res = new List<IList<int>>();
        List<TreeNode> layer, nextLayer = new List<TreeNode>();
        bool direction = true;//right = true;left = false
        nextLayer.Add(root);
        while (nextLayer.Count > 0)
        {
            layer = nextLayer; nextLayer = new List<TreeNode>();
            foreach (var i in layer)
            {
                if (i.left != null) { nextLayer.Add(i.left); }
                if (i.right != null) { nextLayer.Add(i.right); }
            }
            List<int> tempRes = new List<int>();
            if (direction)
            { for (var i = 0; i < layer.Count; ++i) { tempRes.Add(layer[i].val); } }
            else
            { for (var i = layer.Count - 1; i >= 0; --i) { tempRes.Add(layer[i].val); } }
            res.Add(tempRes);
            direction = !direction;
        }
        return res;
    }
}