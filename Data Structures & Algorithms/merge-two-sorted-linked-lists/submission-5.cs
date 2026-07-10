/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode cur1 = list1;
        ListNode cur2 = list2;

        if (cur1 == null)
            return cur2;
        if (cur2 == null)
            return cur1;

        ListNode res = null;

        if (cur1.val < cur2.val) {
            res = cur1;
            cur1 = cur1.next;
        } else {
            res = cur2;
            cur2 = cur2.next;
        }

        ListNode curRes = res;

        while (cur1 != null && cur2 != null) {
            if (cur1.val < cur2.val) {
                curRes.next = cur1;
                cur1 = cur1.next;
            } else {
                curRes.next = cur2;
                cur2 = cur2.next;
            }
            curRes = curRes.next;
        }

        if (cur1 != null)
            curRes.next = cur1;
        if (cur2 != null)
            curRes.next = cur2;

        return res;
    }
}