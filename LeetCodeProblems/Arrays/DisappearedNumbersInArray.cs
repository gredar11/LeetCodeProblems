namespace LeetCodeProblems.Arrays
{
    // source : https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array/submissions/
    public class DisappearedNumbersInArray
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            var allNumbersArray = Enumerable.Range(1, nums.Length).ToList();
            for (int i = 0; i < nums.Length; i++)
            {
                allNumbersArray.Remove(nums[i]);
            }
            return allNumbersArray;
        }
    }
}
