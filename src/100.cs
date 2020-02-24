using System;
using System.Collections.Generic;
using System.Text;
using Number100;
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
//百题留念ヾ(•ω•`)oヾ(•ω•`)o
public partial class Solution
{
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        return C.cmp(p, q);
    }
}
namespace Number100
{
    class C
    {
        public static bool cmp(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
            { return true; }
            if (p != null && q != null)
            {
                if (p.val == q.val)
                { return cmp(p.left, q.left) && cmp(p.right, q.right); }
            }
            return false;
        }
    }
}