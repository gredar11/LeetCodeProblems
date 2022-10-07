using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class ContainsDuplicateProblem
    {
        // https://leetcode.com/problems/contains-duplicate/
        public bool ContainsDuplicate(int[] nums)
        {
            var dictionary = new Dictionary<int, int>();
            foreach (var item in nums)
            {
                if (dictionary.ContainsKey(item))
                    return false;
                dictionary[item] = 1;
            }
            return false;
        }
    }
}
