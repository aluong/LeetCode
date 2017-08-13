<Query Kind="Program" />

void Main()
{
	Solution.Convert("PAYPALISHIRING", 3).Dump();
}

public static class Solution
{
	public static string Convert(string s, int numRows)
	{
		var index = 0;
		var rows = new StringBuilder[numRows];
		for (int i = 0; i < numRows; i++)
		{
			rows[i] = new StringBuilder();
		}

		while (index < s.Length)
		{
			for (int i = 0; i < numRows; i++)
			{
				if (index >= s.Length)
				{
					rows[i].Append("\t_");
				}
				else
				{
					rows[i].Append("\t"+s[index++]);
				}
			}

			for (int i = 1; i < numRows-1 && index < s.Length; i++)
			{
				for (int j = numRows - 1; j >= 0; j--)
				{
					if (j == (numRows - 1 - i) && j != 0 && j != numRows - 1 && index < s.Length)
					{
						rows[j].Append("\t"+s[index++]);
					}
					else
					{
						rows[j].Append("\t_");
					}
				}
			}
		}

		var final = new StringBuilder();
		foreach (var row in rows)
		{
			final.Append(row.Replace("\t", string.Empty).Replace("_", string.Empty));
			row.ToString().Dump();
		}
		
		return final.ToString();
	}
}