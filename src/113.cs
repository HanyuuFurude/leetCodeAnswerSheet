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
using Number113;
public partial class Solution
{
    public IList<IList<int>> PathSum(TreeNode root, int sum)
    {
        var demo = new C(root, sum);
        return demo.res;
    }
}
namespace Number113
{
    public class C
    {
        public List<IList<int>> res;
        List<int> tempRes;
        int target;
        public C(TreeNode root, int sum)
        {
            target = sum;
            tempRes = new List<int>();
            res = new List<IList<int>>();
            SearchTree(root, 0, 0);
        }
        public void SearchTree(TreeNode head, int depth, int sum)
        {
            if (head == null) { return; }
            if (tempRes.Count < depth + 1) { tempRes.Add(head.val); }
            else { tempRes[depth] = head.val; }
            if (head.left == null && head.right == null)
            {
                if ((sum + head.val) == target)
                {
                    List<int> temp = new List<int>();
                    for (var i = 0; i <= depth; ++i)
                    {
                        temp.Add(tempRes[i]);
                    }
                    res.Add(temp);
                }
                return;
            }
            SearchTree(head.left, depth + 1, sum + head.val);
            SearchTree(head.right, depth + 1, sum + head.val);
        }
    }
}