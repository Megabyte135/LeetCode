public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        int i = 0, j = nums.Length - 1;
        if (target > nums[j])
            return j + 1;
        while (i < j)
        {
            if (target > nums[(i + j) / 2])
                i = (i + j) / 2 + 1;
            else if (target < nums[(i + j) / 2])
                j = (i + j) / 2;
            else
                return (i + j) / 2;
        }
        return i;
    }
}