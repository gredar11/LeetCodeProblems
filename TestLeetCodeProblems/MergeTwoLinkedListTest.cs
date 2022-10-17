using LeetCodeProblems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LeetCodeProblems.LinkedListCycle;

namespace TestLeetCodeProblems
{
    public class MergeTwoLinkedListTest
    {
        [Fact]
        public void TestMerges()
        {
            
            var helper = new MergeTwoSortedLists();
            var node1 = helper.ConvertArrayToListNode(new int[] { 1, 2, 4 });
            var node2 = helper.ConvertArrayToListNode(new int[] { 1, 3, 4 });

            var res = helper.MergeTwoLists(node1, node2);
            Console.WriteLine();
        }
    }
}
