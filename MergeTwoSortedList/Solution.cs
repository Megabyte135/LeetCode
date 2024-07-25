﻿public class Solution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1 == null)
            return list2;
        if (list2 == null)
            return list1;

        ListNode merged = new ListNode();
        ListNode current = merged;

        while (list1 != null && list2 != null)
        {
            int value = 0;
            if (list1.val <= list2.val)
            {
                value = list1.val;
                list1 = list1.next;
            }
            else
            {
                value = list2.val;
                list2 = list2.next;
            }
            ListNode t = new ListNode(value);
            current.next = t;
            current = current.next;
        }

        if (list1 == null)
            current.next = list2;
        else if (list2 == null)
            current.next = list1;

        return merged.next;
    }
}