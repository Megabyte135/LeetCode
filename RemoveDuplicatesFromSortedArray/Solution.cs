public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int i = 1, u = 0;
        if (nums.Length == 0)
            return 0;
        while (i < nums.Length)
        {
            if (nums[i] != nums[u])
            {
                u++;
                nums[u] = nums[i];
            }
            i++;
        }
        return u + 1;
    }
}