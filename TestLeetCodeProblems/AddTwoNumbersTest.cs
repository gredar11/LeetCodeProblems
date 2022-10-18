using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeProblems.LinkedList;

namespace TestLeetCodeProblems
{
    public class AddTwoNumbersTest
    {
        [Fact]
        public void CheckSumm_11_12()
        {
            var node1 = AddListNodes.ConvertStringToListNode("199");
            var node2 = AddListNodes.ConvertStringToListNode("0");
            var node3 = AddListNodes.ConvertStringToListNode("1");
            var node4 = AddListNodes.AddTwoNumbers(node1, node3);
            Console.WriteLine();
        }
    }
}
