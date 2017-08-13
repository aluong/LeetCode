<Query Kind="Program" />

void Main()
{
	var sln = new Solution();
	sln.IsValid("()").Dump();
	sln.IsValid(")(").Dump();
	sln.IsValid("()[]{}").Dump();
	sln.IsValid("(]").Dump();
	sln.IsValid("([)]").Dump();
	sln.IsValid("]").Dump();
}

public class Solution
{
	public bool IsValid(string s)
	{
		var stack = new Stack<char>();

		foreach (var ch in s)
		{
			if (ch == '(' || ch == '{' || ch == '[')
			{
				stack.Push(ch);
				continue;
			}

			if (stack.Count > 0)
			{
				if (
				(ch == ')' && stack.Peek() == '(') ||
				(ch == ']' && stack.Peek() == '[') ||
				(ch == '}' && stack.Peek() == '{')
				)
				{
					stack.Pop();
					continue;
				}
				else
				{
					return false;
				}
			}
			else
			{
				return false;
			}
		}

		return stack.Count == 0;
	}
}
