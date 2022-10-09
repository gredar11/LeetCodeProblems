using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class LinkedListCycle
    {
        // source: https://leetcode.com/problems/linked-list-cycle/submissions/

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
        public bool HasCycle(ListNode head)
        {
            Dictionary<ListNode, int> cycle = new Dictionary<ListNode, int>();

            var currentNode = head;

            while (currentNode != null)
            {
                if (cycle.ContainsKey(currentNode))
                    return true;
                cycle.Add(currentNode, 1);
                currentNode = currentNode.next;
            }

            return false;
        }
    }
}
