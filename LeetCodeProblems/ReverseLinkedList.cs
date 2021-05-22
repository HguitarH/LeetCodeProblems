using static LeetCodeProblems.Common;

namespace LeetCodeProblems
{
    public class ReverseLinkedList
    {
        public ListNode Solve(ListNode head)
        {
            if (head == null || head.next == null)
                return head;

            var tail = head.next;
            head.next = null;
            while (tail.next != null)
            {
                var temp = tail.next;
                tail.next = head;
                head = tail;
                tail = temp;
            }
            tail.next = head;
            return tail;
        }
    }
}