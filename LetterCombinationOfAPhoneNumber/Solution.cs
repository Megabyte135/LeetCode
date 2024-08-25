public class Solution
{
    static Dictionary<char, List<string>> keyboard = new Dictionary<char, List<string>>(){
                {'2', new List<string>{"a", "b", "c"}},
                {'3', new List<string>{"d", "e", "f"}},
                {'4', new List<string>{"g", "h", "i"}},
                {'5', new List<string>{"j", "k", "l"}},
                {'6', new List<string>{"m", "n", "o"}},
                {'7', new List<string>{"p", "q", "r", "s"}},
                {'8', new List<string>{"t", "u", "v"}},
                {'9', new List<string>{"w", "x", "y", "z"}}
                };
    public IList<string> LetterCombinations(string digits)
    {
        if (digits.Length == 0)
        {
            return new List<string>();
        }
        if (digits.Length == 1)
        {
            return keyboard[digits[0]];
        }
        return Multiply(keyboard[digits[0]], keyboard[digits[1]], digits, 1);
    }

    private List<string> Multiply(List<string> l1, List<string> l2, string digits, int k)
    {
        List<string> result = new();
        for (int i = 0; i < l1.Count; i++)
        {
            for (int j = 0; j < l2.Count; j++)
            {
                result.Add(l1[i] + l2[j]);
            }
        }
        k++;
        if (k == digits.Length)
            return result;
        return Multiply(result, keyboard[digits[k]], digits, k);
    }
}