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
            var node1 = helper.ConvertArrayToListNode(new int[] { -10, -9, -6, -4, 1, 9, 9 });
            var node2 = helper.ConvertArrayToListNode(new int[] { -5, -3, 0, 7, 8, 8 });

            var res = helper.MergeTwoLists(node1, node2);
            Console.WriteLine();
        }
    }
}
