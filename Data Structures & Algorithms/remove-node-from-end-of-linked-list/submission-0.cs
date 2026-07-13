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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        List<ListNode> list = new List<ListNode>();

        ListNode cur = head;

        while (cur != null) {
            list.Add(cur);
            cur = cur.next;
        }

        int target = list.Count - n;

        if (target == 0)
            return head.next;
        else
            list[target - 1].next = list[target].next;

        return head;
    }
}
