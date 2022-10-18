using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LeetCodeProblems.LinkedList.LinkedListCycle;

namespace LeetCodeProblems.LinkedList
{
    public class ReverseLinkedList
    {
        // source: https://leetcode.com/problems/reverse-linked-list/submissions/
        public ListNode ReverseList(ListNode head)
        {
            ListNode previous = null;
            while (head != null)
            {
                var next = head.next;
                head.next = previous;
                previous = head;
                head = next;
            }
            return previous;
        }
        public static ListNode CreateListNodes(int count)
        {
            if (count < 1)
                throw new ArgumentException("Count must be greater than zero.");
            ListNode listNode = new(1);
            ListNode next = listNode;
            for (int i = 1; i < count; i++)
            {
                next.next = new ListNode(i + 1);
                next = next.next;
            }
            return listNode;
        }
    }
}
