using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class SquaresOfASortedArray
    {
        // # 977
        // source: https://leetcode.com/problems/squares-of-a-sorted-array/

        public int[] SortedSquares(int[] nums)
        {
            int rightCounter = -1;
            int leftCounter = -1;
            // fist we need to set left and right counters to their lowest by value 
            // for exmaple in array [-5 -3 0 1 4] -> leftCounter = 1, rightCounter = 2
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] >= 0 && nums[i - 1] < 0)
                {
                    rightCounter = i;
                    leftCounter = i - 1;
                    break;
                }
            }
            int mainCounter = 0;
            int[] result = new int[nums.Length];
            if (rightCounter == -1 && leftCounter == -1)
            {
                if (nums[0] >= 0)
                {
                    // идем вправо
                    rightCounter = 0;
                    while (rightCounter <= nums.Length - 1)
                    {
                        result[mainCounter] = nums[rightCounter] * nums[rightCounter];
                        mainCounter++;
                        rightCounter++;
                    }
                    return result;
                }
                else
                {
                    // идем влево
                    leftCounter = nums.Length - 1;
                    while (leftCounter >= 0)
                    {
                        result[mainCounter] = nums[leftCounter] * nums[leftCounter];
                        mainCounter++;
                        leftCounter--;// сдвиг влево
                    }
                    return result;
                }
            }


            // выполняем до тех пор, пока с одной стороны не упремся в край массива,
            // а как упремся добавляем оставшиеся в одну сторону члены.
            while (leftCounter >= 0 && rightCounter <= nums.Length - 1)
            {
                if (Math.Abs(nums[rightCounter]) <= Math.Abs(nums[leftCounter]))
                {
                    result[mainCounter] = nums[rightCounter] * nums[rightCounter];
                    mainCounter++;
                    rightCounter++; // сдвиг вправо
                    continue;
                }
                if (Math.Abs(nums[leftCounter]) < Math.Abs(nums[rightCounter]))
                {
                    result[mainCounter] = nums[leftCounter] * nums[leftCounter];
                    mainCounter++;
                    leftCounter--;// сдвиг влево
                    continue;
                }
            }
            if(leftCounter == -1)
            {
                // двигаемся вправо
                while(rightCounter <= nums.Length - 1)
                {
                    result[mainCounter] = nums[rightCounter] * nums[rightCounter];
                    mainCounter++;
                    rightCounter++;
                }
            }
            
            if(rightCounter == nums.Length)
            {
                // двигаемся влево
                while(leftCounter >= 0)
                {
                    result[mainCounter] = nums[leftCounter] * nums[leftCounter];
                    mainCounter++;
                    leftCounter--;// сдвиг влево
                }
            }
            
            return result;
        }

    }
}
