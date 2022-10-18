using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class FindFirstGreaterChar
    {
        public char NextGreatestLetter(char[] letters, char target)
        {
            int upper = letters.Length - 1;
            int lower = 0;
            int res = 0;
            while (upper >= lower)
            {
                int mid = lower + (upper - lower) / 2;
                if (letters[mid] > target && lower == upper)
                {
                    res = mid;
                    break;
                }
                if (letters[mid] > target)
                {
                    upper = mid;
                    res = mid;
                }
                if (letters[mid] <= target)
                {
                    lower = mid + 1;
                }

            }
            return letters[res];
        }
    }
}
