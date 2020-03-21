# Definition for singly-linked list.
class ListNode:
    def __init__(self, x):
        self.val = x
        self.next = None


class Solution:
    def insertionSortList(self, head: ListNode) -> ListNode:
        if head is None or head.next is None:
            return head
        fetchHandle = head.next
        head.next = None
        while fetchHandle is not None:
            tempHandle = fetchHandle
            fetchHandle = fetchHandle.next
            insertHandle = head
            if tempHandle.val < head.val:
                tempHandle.next = head
                head = tempHandle
                continue
            while True:
                if insertHandle.next is not None and insertHandle.next.val > tempHandle.val:
                    insertHandle.next = insertHandle.next
                    break
                insertHandle = insertHandle.next
            tempHandle.next = insertHandle.next
            insertHandle.next = tempHandle