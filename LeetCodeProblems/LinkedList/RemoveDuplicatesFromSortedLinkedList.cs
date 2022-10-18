using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LeetCodeProblems.LinkedList.LinkedListCycle;

namespace LeetCodeProblems.LinkedList
{
    public class RemoveDuplicatesFromSortedLinkedList
    {
        // source: https://leetcode.com/problems/remove-duplicates-from-sorted-list/submissions/
        public ListNode DeleteDuplicates(ListNode head)
        {
            var currentNode = head?.next;
            var previous = head;
            while (currentNode != null)
            {
                var next = currentNode.next;
                if (currentNode.val == previous.val)
                {
                    previous.next = next;
                }
                else
                {
                    previous = currentNode;
                }
                currentNode = next;
            }
            return head;
        }
    }
}
