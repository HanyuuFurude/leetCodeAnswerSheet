using System;
using System.Collections.Generic;
using System.Text;
using PublicClass;
using Number099;

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
    public void RecoverTree(TreeNode root)
    {
        if (root == null) { return; }
        //中序遍历
        var demo = new C(root);
    }
}
namespace Number099
{
    public class C
    {
        int count;
        List<int> giveup;
        public C(TreeNode root)
        {
            giveup = new List<int>();//实在想不到怎么找出两个错位节点了……
            count = 0;
            search(root);
            giveup.Sort();
            ret(root);
        }
        public void search(TreeNode node)
        {
            if (node == null) { return; }
            search(node.left);
            giveup.Add(node.val);
            search(node.right);
        }
        public void ret(TreeNode node)
        {
            if (node == null) { return; }
            ret(node.left);
            node.val = giveup[count++];
            ret(node.right);
        }
    }
}