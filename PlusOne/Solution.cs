public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            if (i == 0 && digits[i] == 9)
            {
                digits[i] = 0;
                int[] res = new int[digits.Length + 1];
                res[0] = 1;
                Array.Copy(digits, 0, res, 1, digits.Length);
                return res;
            }
            if (digits[i] == 9)
                digits[i] = 0;
            else
            {
                digits[i]++;
                break;
            }
        }
        return digits;
    }
}