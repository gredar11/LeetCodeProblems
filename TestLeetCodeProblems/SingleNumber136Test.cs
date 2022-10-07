using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeProblems;
namespace TestLeetCodeProblems
{
    public class SingleNumber136Test
    {
        [Fact]
        public void Check_If_1_isSingle_in_221()
        {
            var actual = SingleNumber136.SingleNumber(new int[] { 2, 2, 1 });
            Assert.Equal(1, actual);
        }
        [Fact]
        public void Check_If_4_isSingle_in_41212()
        {
            var actual = SingleNumber136.SingleNumber(new int[] { 4, 1, 2, 1, 2 });

            Assert.Equal(4, actual);
        }
    }
}
