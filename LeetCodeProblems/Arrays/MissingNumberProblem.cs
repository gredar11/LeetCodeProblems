using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Arrays
{
    public class MissingNumberProblem
    {
        // source: https://leetcode.com/problems/missing-number/
        public int MissingNumber(int[] nums)
        {
            int sumExpected = 0;
            int sumActual = 0;
            int iteration = 0;
            while (iteration < nums.Length)
            {
                sumActual += nums[iteration];
                sumExpected += iteration;
                iteration++;
            }
            sumExpected += iteration;
            return sumExpected - sumActual;
        }
    }
}
