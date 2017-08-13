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
		return GenerateParenthesis(n, n);
	}
	
	public IList<string> GenerateParenthesis(int l, int r)
	{
		if (r == 0)
		{
			return new List<string>();
		}
		
		var parens = new List<string>();

		if (l > 0)
		{
			var left  = l - 1;
			var options = GenerateParenthesis(left, r);

			if (options.Count == 0)
			{
				parens.Add("(");
			}
			
			foreach (var option in options)
			{
				parens.Add("(" + option);
			}			
		}

		if (r > 0 && l < r)
		{
			var right = r - 1;
			var options = GenerateParenthesis(l, right);

			if (options.Count == 0)
			{
				parens.Add(")");
			}

			foreach (var option in options)
			{
				parens.Add(")" + option);
			}
		}
		
		return parens;
	}
}