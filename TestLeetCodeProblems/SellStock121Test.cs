using LeetCodeProblems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCodeProblems
{
    public class SellStock121Test
    {
        [Fact]
        public void Test1()
        {
            var SellStockClass = new SellStock121();
            var actualProfit = SellStockClass.MaxProfit(new int[] {7, 1, 5, 3, 6, 4});
            Assert.Equal(5, actualProfit);
        }
        [Fact]
        public void Test2()
        {
            var SellStockClass = new SellStock121();
            var actualProfit = SellStockClass.MaxProfit(new int[] {1, 2, 5});
            Assert.Equal(4, actualProfit);
        }
        [Fact]
        public void Test3()
        {
            var SellStockClass = new SellStock121();
            var actualProfit = SellStockClass.MaxProfit(new int[] { 5, 2, 3, 2, 6, 6, 2, 9, 1, 0, 7, 4, 5, 0});
            Assert.Equal(7, actualProfit);
        }
    }
}
