//Just to suppress errors
public class ListNode
{
    public int val;
    public ListNode next;
}

public class Solution
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        if (head.next == null)
            return null;
        int currentLength = 1;
        var node = head;
        while (node.next is not null)
        {
            currentLength++;
            node = node.next;
        }

        if (currentLength - n + 1 == 1)
            return head.next;

        node = head;
        var save = head;

        for (int i = 1; i < currentLength + 1; i++)
        {
            if (i == currentLength - n)
            {
                save = node;
                if (currentLength < (i + 2))
                {
                    save.next = null;
                    break;
                }
            }
            if (i == currentLength - n + 2)
            {
                save.next = node;
            }
            node = node.next;
        }

        return head;
    }
}