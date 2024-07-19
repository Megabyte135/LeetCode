public class Solution
{
    public bool IsPalindrome(int x)
    {
        char[] repres = x.ToString().ToCharArray();
        int i = 0;
        int j = repres.Length - 1;

        while (i < j)
        {
            if (repres[i] != repres[j])
            {
                return false;
            }
            i++;
            j--;
        }
        return true;
    }
}