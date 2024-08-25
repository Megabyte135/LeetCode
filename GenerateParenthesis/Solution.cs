public class Solution
{
    public IList<string> GenerateParenthesis(int n)
    {
        List<string> result = new List<string>();
        RecursiveGenerate(result, "(", 1, 0, n);
        return result;
    }

    public void RecursiveGenerate(List<string> result, string current, int open, int close, int n)
    {
        if (current.Length == 2 * n)
        {
            result.Add(current);
            return;
        }
        if (open < n)
        {
            RecursiveGenerate(result, current + "(", open + 1, close, n);
        }
        if (close < open)
        {
            RecursiveGenerate(result, current + ")", open, close + 1, n);
        }
    }
}