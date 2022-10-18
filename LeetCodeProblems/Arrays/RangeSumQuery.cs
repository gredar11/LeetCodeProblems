using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Arrays
{
    public class RangeSumQuery
    {
        // source: https://seanprashad.com/leetcode-patterns/
        public class NumArray
        {
            int[] array;
            public NumArray(int[] nums)
            {
                array = nums;
            }

            public int SumRange(int left, int right)
            {
                int summ = 0;
                for (int i = left; i <= right; i++)
                {
                    summ += array[i];
                }
                return summ;
            }
        }
    }
}
