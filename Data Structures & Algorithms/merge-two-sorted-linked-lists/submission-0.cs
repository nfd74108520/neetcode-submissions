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
            return list2;

        if (cur2 == null)
            return list1;

        ListNode mergeHead = null;
        ListNode mergeCur = null;

        while (cur1 != null && cur2 != null) {
            if (cur1.val < cur2.val) {
                if (mergeHead == null) {
                    mergeHead = cur1;
                    mergeCur = mergeHead;
                } else {
                    mergeCur.next = cur1;
                    mergeCur = cur1;
                }
                cur1 = cur1.next;
            } else {
                if (mergeHead == null) {
                    mergeHead = cur2;
                    mergeCur = mergeHead;
                } else {
                    mergeCur.next = cur2;
                    mergeCur = cur2;
                }
                cur2 = cur2.next;
            }
        }

        if (cur1 != null)
            mergeCur.next = cur1;
        if (cur2 != null)
            mergeCur.next = cur2;

        return mergeHead;
    }
}