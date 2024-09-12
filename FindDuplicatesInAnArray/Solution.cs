public class Solution
{
    public IList<int> FindDuplicates(int[] nums)
    {
        List<int> result = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] == nums[j])
                {
                    result.Add(nums[i]);
                }
            }
        }
        return result;
    }
}