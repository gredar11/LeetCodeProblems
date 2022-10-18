using System.Text;
using static LeetCodeProblems.LinkedList.LinkedListCycle;

namespace LeetCodeProblems.LinkedList
{
    public class PalindromeLinkedList
    {
        public bool IsPalindrome(ListNode head)
        {
            StringBuilder stringBuilder = new StringBuilder();
            ListNode current = head;
            while (current is not null)
            {
                stringBuilder.Append(current.val);
                current = current.next;
            }
            var summ = stringBuilder.ToString();
            int middle = summ.Length / 2;
            string firstHalf = summ.Substring(0, middle);
            string secondHalfToReverse = summ[^middle..];
            char[] charArray = secondHalfToReverse.ToCharArray();
            Array.Reverse(charArray);
            string secondHalf = new string(charArray);
            return secondHalf == firstHalf;
        }
    }
}
