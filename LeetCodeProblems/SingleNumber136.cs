using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class SingleNumber136
    {
        //https://leetcode.com/problems/single-number/
        public static int SingleNumber(int[] nums)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();
            foreach (int num in nums)
            {
                if (!result.ContainsKey(num))
                    result[num] = 0;
                result[num] +=1;
            }
            var res = result.Where(num => num.Value == 1).SingleOrDefault();
            return res.Key;
        }
    }
}
