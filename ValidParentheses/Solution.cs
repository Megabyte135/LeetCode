public class Solution
{
    public bool IsValid(string s)
    {
        Stack<char> opens = new();
        opens.Push('a');
        foreach (var c in s)
        {
            if (c == '{' || c == '[' || c == '(')
            {
                opens.Push(c);
            }
            else if ((opens.Peek() == '{' && c == '}')
                ||
                (opens.Peek() == '[' && c == ']')
                ||
                (opens.Peek() == '(' && c == ')')
                )
                opens.Pop();
            else
                return false;
        }
        if (opens.Count > 1)
            return false;
        return true;
    }
}