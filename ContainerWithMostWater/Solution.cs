public class Solution
{
    public int MaxArea(int[] height)
    {
        int l = 0, r = height.Length - 1;
        int highest = 0;
        while (l < r)
        {
            int smallest = 0;
            int distance = r - l;
            if (height[l] >= height[r])
            {
                smallest = height[r];
                r--;
            }
            else
            {
                smallest = height[l];
                l++;
            }
            int square = smallest * distance;
            if (highest < square)
            {
                highest = square;
            }
        }
        return highest;
    }
}