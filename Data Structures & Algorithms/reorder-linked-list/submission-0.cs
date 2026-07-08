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
    public void ReorderList(ListNode head) {
        List<ListNode> list = new List<ListNode>();
        ListNode cur = head;

        while (cur != null) {
            list.Add(cur);
            cur = cur.next;
        }

        int l = 0, r = list.Count - 1;

        while (l < r) {
            // Console.WriteLine(list[r].next);
            if(list[l].next == list[r]) break;
            list[r].next = list[l].next;
            list[l].next = list[r];

            l++;
            r--;
        }

        list[r].next = null;
    }
}
