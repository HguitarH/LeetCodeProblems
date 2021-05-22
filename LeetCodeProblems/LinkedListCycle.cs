using System;
using static LeetCodeProblems.Common;

namespace LeetCodeProblems
{
    public class LinkedListCycle
    {
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