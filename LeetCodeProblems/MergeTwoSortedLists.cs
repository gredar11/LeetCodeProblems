using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LeetCodeProblems.LinkedListCycle;

namespace LeetCodeProblems
{
    public class MergeTwoSortedLists
    {
        public ListNode ConvertArrayToListNode(int[] array)
        {
            ListNode node = new ListNode(array[^1]);
            for (int i = array.Length - 2 ; i >= 0; i--)
            {
                var temp = new ListNode(array[i]) { next = node };
                node = temp;
            }
            return node;
        }
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode firstPointer = list1;
            ListNode secondPointer = list2;
            if (list1 == null && list2 == null)
                return null;
            if (list1 != null && list2 == null)
                return list1;
            if (list1 == null && list2 != null)
                return list2;
            while (firstPointer != null && secondPointer != null)
            {
                if (firstPointer.val < secondPointer.val)
                {
                    while (firstPointer.next != null && firstPointer.next.val < secondPointer.val)
                    {
                        firstPointer = firstPointer.next;
                        while (firstPointer.next != null && firstPointer.next.val == firstPointer.val)
                            firstPointer = firstPointer.next;
                    }
                    var temp = firstPointer.next;
                    firstPointer.next = secondPointer;
                    var temp2 = secondPointer.next;
                    secondPointer.next = temp;
                    firstPointer = firstPointer.next;
                    secondPointer = temp2;
                }
                else
                {
                    while (secondPointer.next != null && secondPointer.next.val < firstPointer.val)
                    {
                        secondPointer = secondPointer.next;
                        while (secondPointer.next != null && secondPointer.next.val == secondPointer.val)
                            secondPointer = secondPointer.next;
                    }
                    var temp = secondPointer.next;
                    secondPointer.next = firstPointer;
                    var temp2 = firstPointer.next;
                    firstPointer.next = temp;
                    firstPointer = temp2;
                    secondPointer = secondPointer.next;
                }
            }

            return list1.val < list2.val ? list1 : list2;
        }
    }

}
