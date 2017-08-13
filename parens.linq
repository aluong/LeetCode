<Query Kind="Program" />

void Main()
{
	var sln = new Solution();
	sln.GenerateParenthesis(1).Dump();
	sln.GenerateParenthesis(2).Dump();
	sln.GenerateParenthesis(3).Dump();
	sln.GenerateParenthesis(4).Dump();
}

public class Solution
{
	
	public IList<string> GenerateParenthesis(int n)
	{
		var parens = new List<string>();
		GenerateParenthesis(string.Empty, n, n, 2 * n, parens);
		
		return parens;
	}
	
	public void GenerateParenthesis(string prefix, int l, int r, int max, IList<string> parens)
	{
		if (prefix.Length == max)
		{
			parens.Add(prefix);
			return;
		}

		// Open Parens
		if (l > 0)
		{
			GenerateParenthesis(prefix + "(", l - 1, r, max, parens);
		}

		// Close Parens
		if (l < r && r > 0)
		{
			GenerateParenthesis(prefix + ")", l, r - 1, max, parens);
		}
	}
}