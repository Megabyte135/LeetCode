public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        int maxLen = 0;

        for (int i = 0; i < s.Length; i++)
        {
            string sub = "" + s[i];
            int len = 1;
            bool isValid = true;
            for (int j = i + 1; j < s.Length && isValid; j++)
            {
                if (Contains(sub, s[j]))
                {
                    isValid = false;
                    break;
                }
                else
                    len++;
                sub += s[j];
            }
            if (len > maxLen)
                maxLen = len;
        }

        return maxLen;
    }

    public bool Contains(string s, char c)
    {
        bool isContains = false;

        foreach (var i in s)
        {
            if (i == c)
                isContains = true;
        }

        return isContains;
    }
}