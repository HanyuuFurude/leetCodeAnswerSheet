using System;
using System.Collections.Generic;
using System.Text;
using PublicClass;
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
//思路：从中间截断分为两个数组，递归构建子树
using Number109;
public partial class Solution
{
    public TreeNode SortedListToBST(ListNode head)
    {
        List<int> valList = new List<int>();
        while (head != null)
        { valList.Add(head.val); head = head.next; }
        if (valList.Count == 0) { return null; }
        var demo = new C(valList);
        return demo.head;
    }
}
namespace Number109
{
    public class C
    {
        public TreeNode head;
        List<int> valList;
        public C(List<int> list)
        {
            valList = list;
            head = new TreeNode(valList[valList.Count / 2]);
            buildSubTree(head, 0, valList.Count - 1);
        }
        private void buildSubTree(TreeNode root, int left, int right)
        {
            int indexOfCenter = (left + right + 1) / 2;
            root.val = valList[indexOfCenter];

            Console.WriteLine(root.val);
            if (indexOfCenter > left)
            {
                root.left = new TreeNode(0);
                buildSubTree(root.left, left, indexOfCenter - 1);
            }
            if (indexOfCenter < right)
            {
                root.right = new TreeNode(0);
                buildSubTree(root.right, indexOfCenter + 1, right);
            }
        }
    }
}