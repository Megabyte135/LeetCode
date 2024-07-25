public class Solution
{
    public int MyAtoi(string s)
    {
        char sign = '0';
        bool digitFound = false;
        List<char> digits = new();
        for (int i = 0; i < s.Length; i++)
        {
            if (!digitFound)
            {
                if (Char.IsDigit(s[i]))
                {
                    digits.Add(s[i]);
                    digitFound = true;
                }
                else if (s[i] == ' ')
                    continue;
                else if (s[i] == '-' || s[i] == '+')
                {
                    sign = s[i];
                    digitFound = true;
                }
                else
                    break;
            }
            else
            {
                if (Char.IsDigit(s[i]))
                    digits.Add(s[i]);
                else
                    break;
            }
        }
        if (digits.Count > 0)
        {
            string str = "";
            str += sign;
            foreach (var c in digits)
            {
                str += c;
            }
            try
            {
                return Convert.ToInt32(str);
            }
            catch
            {
                if (sign == '-')
                    return Int32.MinValue;
                else
                    return Int32.MaxValue;
            }
        }
        else
            return 0;
    }
}