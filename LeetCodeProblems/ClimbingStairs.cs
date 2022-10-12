using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class ClimbingStairs
    {
        public int ClimbStairs(int n)
        {
            int a = 1, b = 1;
            while (n-- > 0)
                a = (b += a) - a;
            return a;
        }
    }
}
