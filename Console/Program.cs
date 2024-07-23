Solution solution = new Solution();
ListNode l23 = new ListNode(4);
ListNode l22 = new ListNode(3, l23);
ListNode l21 = new ListNode(1, l22);
ListNode l13 = new ListNode(4);
ListNode l12 = new ListNode(2, l13);
ListNode l11 = new ListNode(1, l12);
Console.WriteLine(solution.MergeTwoLists(l11, l21));