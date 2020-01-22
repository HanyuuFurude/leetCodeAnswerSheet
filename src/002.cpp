/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode(int x) : val(x), next(NULL) {}
 * };
 */
class Solution {
public:
    ListNode* addTwoNumbers(ListNode* l1, ListNode* l2) {
        ListNode * res = new ListNode(0);
        ListNode * ptr = res;
        ListNode * x1 = l1;
        ListNode * x2 = l2;
        int cache = 0;
        while(x1 != nullptr && x2 != nullptr)
        {
            ptr->next = new ListNode((x1->val+x2->val+cache)%10);
            cache = (x1->val+x2->val+cache)/10;
            ptr = (ptr->next);
            x1 = x1->next;
            x2 = x2->next;
        }
        if (x1!=nullptr)
        {
            while(x1 != nullptr)
            {
                ptr->next = new ListNode((cache+x1->val)%10);
                cache = (cache+x1->val)/10;
                ptr = (ptr->next);
                x1 = x1->next;
            }
        }
        if (x2!=nullptr)
        {
            while(x2 != nullptr)
            {
                ptr->next = new ListNode((cache+x2->val)%10);
                cache = (cache+x2->val)/10;
                ptr = (ptr->next);
                x2 = x2->next;
            }
        }
        //cout<<cache;
        if (x1==nullptr && x2==nullptr)
        {
            if (cache == 0) return res->next;
            ptr->next = new ListNode(cache);
            ptr = res->next;
            return ptr;
        }
        return res;
    }
};