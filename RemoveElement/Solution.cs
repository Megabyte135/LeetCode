public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        int i = 0, j = nums.Length - 1, temp = 0, count = 0;
        foreach (var n in nums)
        {
            if (n != val)
                count++;
        }
        if (count > 0)
        {
            while (j > i)
            {
                if (nums[i] == val && nums[j] != val)
                {
                    temp = nums[j];
                    nums[j] = nums[i];
                    nums[i] = temp;
                    j--;
                    i++;
                }
                else if (nums[j] == val)
                {
                    j--;
                    continue;
                }
                else
                {
                    i++;
                }
            }
        }
        return count;
    }
}