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
                    while (firstPointer.next != null && firstPointer.next.val <= secondPointer.val)
                    {
                        firstPointer = firstPointer.next;    
                    }
                    var tempfirst = firstPointer.next;
                    firstPointer.next = secondPointer;
                    firstPointer = tempfirst;
                }
                if(secondPointer.val < firstPointer.val)
                {
                    while (secondPointer.next != null && secondPointer.next.val <= firstPointer.val)
                    {
                        secondPointer = secondPointer.next;
                    }
                    var tempSecond = secondPointer.next;
                    secondPointer.next = firstPointer;
                    secondPointer = tempSecond;
                }
            }

            return list1.val < list2.val ? list1 : list2;
        }
    }

}
