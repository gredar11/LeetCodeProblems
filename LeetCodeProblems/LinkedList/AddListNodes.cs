using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.LinkedList
{
    public class AddListNodes
    {
        /// <summary>
        /// https://leetcode.com/problems/add-two-numbers/submissions/
        /// </summary>
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
        public static ListNode ConvertStringToListNode(string number)
        {
            ListNode result = new ListNode();
            for (int i = 0; i < number.Length; i++)
            {
                if (i == 0)
                {
                    result.val = Convert.ToInt32(number[i].ToString());
                }
                else
                {
                    ListNode tempnode = new ListNode(Convert.ToInt32(number[i].ToString()), result);
                    result = tempnode;
                }
            }
            return result;
        }
        public static ListNode AddTwoNumbers(ListNode listNode1, ListNode listNode2)
        {

            ListNode currL1 = listNode1;
            ListNode currL2 = listNode2;
            int countOfOperations = 0;
            while (currL1 != null || currL2 != null)
            {
                currL1 = currL1.next;
                currL2 = currL2.next;
                countOfOperations++;
                if (currL1 == null || currL2 == null)
                {
                    break;
                }
            }
            currL1 = listNode1;
            currL2 = listNode2;
            int addingDecimal = 0;
            ListNode result = null;
            ListNode nextListnode = null;
            for (int i = 0; i < countOfOperations; i++)
            {
                if (currL1 != null && currL2 != null)
                {
                    var summ = currL1.val + currL2.val + addingDecimal;
                    int value = 0;
                    if (summ >= 10)
                    {
                        value = summ % 10;
                        addingDecimal = 1;
                    }
                    else
                    {
                        value = summ;
                        addingDecimal = 0;
                    }
                    if (i == 0)
                    {
                        result = new ListNode(value);
                    }
                    else
                    {
                        var forwardNode = new ListNode(value);
                        if (i == 1)
                            result.next = forwardNode;
                        if (nextListnode != null)
                            nextListnode.next = forwardNode;
                        nextListnode = forwardNode;
                    }
                    currL1 = currL1.next;
                    currL2 = currL2.next;
                }
            }
            if (currL1 == null && currL2 == null)
            {
                if (addingDecimal != 0)
                {
                    if (nextListnode == null)
                    {
                        nextListnode = new ListNode(addingDecimal);
                        result.next = nextListnode;
                    }
                    else
                        nextListnode.next = new ListNode(addingDecimal);
                }
                return result;
            }
            ListNode mainList = null;
            if (currL1 != null)
                mainList = currL1;
            else
                mainList = currL2;
            if (nextListnode != null)
                nextListnode.next = mainList;
            else
                result.next = mainList;
            ListNode nextResult = mainList;
            while (nextResult != null)
            {
                var summ = nextResult.val + addingDecimal;
                if (summ >= 10)
                {
                    nextResult.val = summ % 10;
                    addingDecimal = 1;
                }
                else
                {
                    nextResult.val = summ;
                    addingDecimal = 0;
                }
                if (nextResult.next == null)
                    break;
                nextResult = nextResult.next;
            }
            if (addingDecimal > 0)
                nextResult.next = new ListNode(addingDecimal);
            return result;
        }

    }
}
