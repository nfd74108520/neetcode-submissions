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
        ListNode res = new ListNode(0);
        ListNode curRes = res;

        while (list1 != null && list2 != null) {
            if (list1.val < list2.val) {
                curRes.next = list1;
                list1 = list1.next;
            } else {
                curRes.next = list2;
                list2 = list2.next;
            }
            curRes = curRes.next;
        }

        if (list1 == null)
            curRes.next = list2;
        if (list2 == null)
            curRes.next = list1;

        return res.next;
    }
}