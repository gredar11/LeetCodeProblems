using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LeetCodeProblems.LinkedListCycle;

namespace LeetCodeProblems
{
    public class RemoveElementIfItHasSameValueInLL
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            ListNode currentNode = head;
            ListNode previousNode = null;
            while (currentNode is not null)
            {
                if (previousNode is null && currentNode.val == val)
                {
                    head = currentNode.next;
                    currentNode = currentNode.next;
                    continue;
                }
                if (currentNode.val == val)
                {
                    previousNode.next = currentNode.next;
                    currentNode = currentNode.next;
                    continue;

                }
                previousNode = currentNode;
                currentNode = currentNode.next;

            }
            return head;
        }
    }
}
