public class Solution
{
	public string LongestPalindrome(string s)
	{
		if (s == null || s == "")
			return "";

		string result = s[0] + "";

		for (int i = s.Length - 1; i > 0; i--)
		{
			char c = s[i];
			int index = s.IndexOf(c);
			if (index < 0 || index == i)
				continue;

			while (index != -1)
			{
				string str = s.Substring(index, i + 1 - index);
				if (str.Length <= 1)
					break;
				if (IsPalindrome(str) && str.Length > result.Length)
					result = str;
				index = s.IndexOf(c, index + 1);
			}
		}

		return result;
	}

	public bool IsPalindrome(string s)
	{
		char[] arr = s.ToCharArray();
		Array.Reverse(arr);
		return s.Equals(new string(arr));
	}
}