using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class BinarySearch
    {
        public int Search(int[] nums, int target)
        {
            int l = 0;
            int h =nums.Length -1;
            while (l < h)
            {
                int mid = l + (h - l) / 2;
                if(nums[mid] == target)
                    return mid;
                if(nums[mid] > target)
                    h = mid;
                if (nums[mid] < target)
                    l = mid + 1;
            }
            if (nums[h] == target)
                return h;
            return -1;
        }
    }
}
