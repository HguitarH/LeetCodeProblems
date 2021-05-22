using System;

namespace LeetCodeProblems
{
    public class LinkedListCycle
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x)
            {
                val = x;
                next = null;
            }
        }

        public bool Solve(ListNode head)
        {
            while (head != null)
            {
                if (head.val == Int32.MinValue)
                    return true;
                head.val = Int32.MinValue;
                head = head.next;
            }
            return false;
        }
    }
}