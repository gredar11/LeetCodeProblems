using LeetCodeProblems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCodeProblems
{
    public class StringsWithBackspacesComparing
    {
        [Fact]
        public void Test1()
        {
            var helper = new BackspaceStringCompare();
            var resultActual = helper.BackspaceCompare("y#fo##f", "y#f#o##f");
            Assert.Equal(true, resultActual);
        }
    }
}
