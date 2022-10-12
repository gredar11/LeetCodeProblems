namespace LeetCodeProblems
{
    public class FindMajorityElement
    {
        public int MajorityElement(int[] nums)
        {
            Dictionary<int , int> countDictionary = new Dictionary<int, int>();
            int countOfPossibleMajor = 0;
            int majorityElement = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (countDictionary.ContainsKey(nums[i]))
                    countDictionary[nums[i]]++;
                else
                    countDictionary[nums[i]] = 1;
                if(countDictionary[nums[i]] > countOfPossibleMajor)
                {
                    countOfPossibleMajor = countDictionary[nums[i]];
                    majorityElement = nums[i];
                }
            }
            return majorityElement;
        }
    }
}
