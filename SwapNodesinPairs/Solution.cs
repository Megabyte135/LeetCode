public class Solution
{
    public ListNode SwapPairs(ListNode head)
    {
        if (head == null || head.next == null)
            return head;

        ListNode node = SwapPairs(head.next.next);

        ListNode temp = head;
        head = head.next;
        head.next = temp;

        head.next.next = node;

        return head;
    }
}