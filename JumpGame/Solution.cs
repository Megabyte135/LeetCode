public class Solution
{
    public bool CanJump(int[] nums)
    {
        int end = nums.Length - 1;
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            if (i + nums[i] >= end)
            {
                if (i == 0) return true;
                end = i;
            }
        }
        return false;
    }
}