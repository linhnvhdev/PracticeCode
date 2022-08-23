using System.Numerics;

public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}
public class Solution
{

    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode head = new ListNode(0);
        ListNode tail = head;
        int carry = 0;
        while(l1 != null || l2 != null || carry != 0)
        {
            int val1 = (l1 != null) ? l1.val : 0;
            int val2 = (l2 != null) ? l2.val : 0;
            int val = val1 + val2 + carry;
            carry = val / 10;
            tail.next = new ListNode(val % 10);
            tail = tail.next;
            if (l1 != null) l1 = l1.next;
            if (l2 != null) l2 = l2.next;
        }
        return head.next;
    }
}