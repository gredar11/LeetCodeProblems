using LeetCodeProblems.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LeetCodeProblems.LinkedList.MiddleOfTheLinkedList;

namespace TestLeetCodeProblems
{
    public class MiddleOfLinkedListTest
    {
        [Fact]
        public void Test1()
        {
            var dictionary = new Dictionary<int , int>();
           

            var algo = new MiddleOfTheLinkedList();
            var node5 = new ListNode(5, null);
            var node4 = new ListNode(4, node5);
            var node3 = new ListNode(3, node4);
            var node2= new ListNode(2, node3);
            var node1= new ListNode(1, node2);
            var actual = algo.MiddleNode(node1);
            var expected = node3;
            Assert.Equal(expected, actual);

        }
    }
}
