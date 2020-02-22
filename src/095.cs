using System;
using System.Collections.Generic;
using System.Text;
using PublicClass;
using Number095;

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
    public IList<TreeNode> GenerateTrees(int n)
    {
        if (n == 0) { return new List<TreeNode>(); }
        return C.BuildTree(1, n);
    }
}
namespace Number095
{
    class C
    {
        public static List<TreeNode> BuildTree(int start,int end)
        {
            List<TreeNode> tempRes = new List<TreeNode>();
            if (start > end) { tempRes.Add(null);return tempRes; }
            for(var i = start;i<=end;++i)
            {
                List<TreeNode> L = BuildTree(start, i - 1);
                List<TreeNode> R = BuildTree(i + 1, end);
                foreach (var l in L)
                {
                    foreach (var r in R)
                    {
                        TreeNode temp = new TreeNode(i);
                        temp.left = l;
                        temp.right = r;
                        tempRes.Add(temp);
                    }
                }
            }
            return tempRes;
        }
    }
}