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
		GenerateParenthesis(new StringBuilder(2*n), 0, 0, n, parens);
		
		return parens;
	}
	
	public void GenerateParenthesis(StringBuilder prefix, int l, int r, int max, IList<string> parens)
	{
		if (prefix.Length == max * 2)
		{
			parens.Add(prefix.ToString());
			return;
		}

		// Open Parens
		if (l < max)
		{
			prefix.Append("(");
			GenerateParenthesis(prefix, l + 1, r, max, parens);
			prefix.Remove(prefix.Length-1, 1);
		}

		// Close Parens
		if (l > r)
		{
			prefix.Append(")");
			GenerateParenthesis(prefix, l, r + 1, max, parens);
			prefix.Remove(prefix.Length-1, 1);
		}
	}
}