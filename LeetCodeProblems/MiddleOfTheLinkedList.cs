using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class MiddleOfTheLinkedList
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public ListNode MiddleNode(ListNode head)
        {
            var currentNode = head;
            int indexOfLast = 1;
            while(currentNode.next != null)
            {
                currentNode = currentNode.next;
                indexOfLast++;
            }
            int middleIndex = indexOfLast / 2 + 1;
            currentNode = head;
            indexOfLast = 1;
            while(indexOfLast != middleIndex)
            {
                currentNode = currentNode.next;
                indexOfLast++;
            }
            return currentNode;
        }
    }
}
