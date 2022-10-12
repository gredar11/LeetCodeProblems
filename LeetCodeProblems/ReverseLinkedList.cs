using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LeetCodeProblems.LinkedListCycle;

namespace LeetCodeProblems
{
    public class ReverseLinkedList
    {
        public ListNode ReverseList(ListNode head)
        {
            ListNode currentNode = head;
            while (currentNode != null)
            {
                var tempNode = currentNode.next;
                if (currentNode == head)
                    currentNode.next = null;
                if (tempNode != null)
                {
                    var tempForCurrent = tempNode.next;
                    tempNode.next = currentNode;
                    if (tempForCurrent != null)
                    {
                        tempForCurrent.next = tempNode;
                        currentNode = tempForCurrent;
                        continue;
                    }
                    break;
                }
                else
                {
                    break;
                }
            }
            return currentNode;
        }
    }
}
