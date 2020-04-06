
/**
 * Definition for singly-linked list. public class ListNode { int val; ListNode
 * next; ListNode(int x) { val = x; next = null; } }
 */
import com.tool.ListNode;;

public class Solution {
    public ListNode getIntersectionNode(ListNode headA, ListNode headB) {
        if (headA == null || headB == null) {
            return null;
        }
        int counterA = 1, counterB = 1;
        ListNode keyA = headA, keyB = headB;
        while (keyA.next != null) {
            keyA = keyA.next;
            ++counterA;
        }
        while (keyB.next != null) {
            keyB = keyB.next;
            ++counterB;
        }
        if (keyA != keyB) {
            return null;
        }
        keyA = headA;
        keyB = headB;
        if (counterA > counterB) {
            for (var i = 0; i < counterA - counterB; ++i) {
                keyA = keyA.next;
            }
        } else {
            for (var i = 0; i < counterB - counterA; ++i) {
                keyB = keyB.next;
            }
        }
        while (keyA != null && keyB != null) {
            if (keyA == keyB) {
                return keyA;
            }
            keyA = keyA.next;
            keyB = keyB.next;
        }

        return null;
    }
}