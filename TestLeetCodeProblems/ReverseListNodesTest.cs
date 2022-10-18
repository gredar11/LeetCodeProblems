using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeProblems.LinkedList;

namespace TestLeetCodeProblems
{
    public class ReverseListNodesTest
    {
        [Fact]
        public void TestListNodes()
        {
            var helper = new ReverseLinkedList();
            var head = ReverseLinkedList.CreateListNodes(5);
            var reversed = helper.ReverseList(head);
            Console.WriteLine();
        }
    }
}
