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
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        List<IList<int>> res = new List<IList<int>>();
        List<TreeNode> layer, layerNext = new List<TreeNode>();
        layerNext.Add(root);
        do
        {
            layer = layerNext;
            layerNext = new List<TreeNode>();
            foreach (var i in layer)
            {
                if (i.left != null)
                { layerNext.Add(i.left); }
                if (i.right != null)
                { layerNext.Add(i.right); }
            }
            List<int> output = new List<int>();
            foreach (var i in layer)
            { output.Add(i.val); }
            res.Add(output);
        } while (layerNext.Count != 0);
        return res;
    }
}