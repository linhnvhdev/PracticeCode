

public class Solution
{

    ////   /**
    ////* Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode head = new ListNode(-9999);
        if (head == null) return list2;
        ListNode curNode = head;
        while (list1 != null || list2 != null)
        {
            if (list1 == null)
            {
                curNode.next = list2;
                list2 = list2.next;
            }
            else
            {
                if (list2 == null)
                {
                    curNode.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    if (list1.val < list2.val)
                    {
                        curNode.next = list1;
                        list1 = list1.next;
                    }
                    else
                    {
                        curNode.next = list2;
                        list2 = list2.next;
                    }
                }
            }
            curNode = curNode.next;
        }
        return head.next;
    }
}