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
    public ListNode OddEvenList(ListNode head) {
        if (head == null)
            return null;
        
        if (head.next == null || head.next.next == null)
        {
            return head;
        }
        
        ListNode temp = head;
        ListNode temp1 = head.next;
        ListNode even = temp1;
        
        while (temp1 != null && temp1.next != null)
        {
            temp.next = temp1.next;
            temp = temp.next;
            temp1.next = temp.next;
            temp1 = temp1.next;
        }
        temp.next = even;
        return head;
    }
}
