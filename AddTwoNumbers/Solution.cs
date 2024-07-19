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

public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode head = new ListNode();
        ListNode result = head;
        int rem = 0;
        while (l1 != null || l2 != null || rem > 0)
        {
            result.val += rem;
            if (l1 != null)
            {
                result.val += l1.val;
                l1 = l1.next;
            }
            if (l2 != null)
            {
                result.val += l2.val;
                l2 = l2.next;
            }
            rem = result.val / 10;
            result.val = result.val % 10;

            if (l1 != null || l2 != null || rem > 0)
            {
                result.next = new ListNode();
                result = result.next;
            }
        }
        return head;
    }
}