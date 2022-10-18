using LeetCodeProblems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LeetCodeProblems.LinkedList.LinkedListCycle;

namespace TestLeetCodeProblems
{
    public class IsPalindromeLinkedListTest
    {
        [Fact]
        public void TestPalindrome()
        {
            ListNode n1 = new ListNode(2);
            ListNode n2 = new ListNode(1) { next = n1 };
            var linkedclass = new PalindromeLinkedList();
            var actualResult = linkedclass.IsPalindrome(n2);
            Assert.Equal(false, actualResult);
        }
    }
}
