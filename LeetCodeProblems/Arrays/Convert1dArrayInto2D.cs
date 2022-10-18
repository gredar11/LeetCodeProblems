using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Arrays
{
    public class Convert1dArrayInto2D
    {
        public int[][] Construct2DArray(int[] original, int m, int n)
        {
            int[][] array = new int[m][];
            if (m * n != original.Length)
                return new int[0][];
            int indexInOriginal = 0;
            for (int row = 0; row < m; row++)
            {
                array[row] = new int[n];
                for (int col = 0; col < n; col++)
                {
                    array[row][col] = original[indexInOriginal];
                    indexInOriginal++;
                }
            }
            return array;
        }
    }
}
