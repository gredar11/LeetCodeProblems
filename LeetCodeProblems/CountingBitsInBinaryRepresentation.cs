using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class CountingBitsInBinaryRepresentation
    {
        // source = https://leetcode.com/problems/counting-bits/
        public int[] CountBits(int n)
        {
            int[] ans = new int[n + 1];
            for (int i = 0; i < n + 1; i++)
            {
                int countOfBits = Convert.ToString(i, 2).Count(x => x == '1');
                ans[i] = countOfBits;
            }
            return ans;
        }
    }
}
