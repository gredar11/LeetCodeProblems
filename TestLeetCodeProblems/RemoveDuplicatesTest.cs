using LeetCodeProblems.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LeetCodeProblems.LinkedList.LinkedListCycle;

namespace TestLeetCodeProblems
{
    public class RemoveDuplicatesTest
    {
        [Fact]
        public void TestMethod()
        {
            var helper = new RemoveElementIfItHasSameValueInLL();
            
            ListNode n3 = new ListNode(1);
            ListNode n2 = new ListNode(1) { next = n3 };
            ListNode n1 = new ListNode(1) { next = n2};
            //var tail = helper.(/*n1*/n1);
            Console.WriteLine();
        }
    }
}
