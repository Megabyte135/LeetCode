public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        string longest = "";
        int smallest = Int32.MaxValue;
        bool isSatisfied = true;
        foreach (var str in strs)
        {
            if (str.Length < smallest)
                smallest = str.Length;
        }
        for (int i = 1; i < smallest + 1 && isSatisfied; i++)
        {
            string candidate = strs[0].Substring(0, i);
            foreach (var str in strs)
            {
                if (!(str.Substring(0, i) == candidate))
                    isSatisfied = false;
            }
            if (isSatisfied)
                longest = candidate;
        }
        return longest;
    }
}