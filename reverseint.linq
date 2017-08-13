<Query Kind="Program" />

void Main()
{
	Solution.Reverse(100).Dump();
	Solution.Reverse(102).Dump();
	Solution.Reverse(-998).Dump();
	(int.MaxValue).Dump();
	(int.Parse("2147483647") + 1).Dump();
}

public class Solution
{
	public static int Reverse(int x)
	{

		int start = x < 0 ? 1 : 0;

		string s = x.ToString().Substring(start);

		int reverse = 0;
		for (int i = 0; i < s.Length; i++)
		{
			var positionValue = (int)(((int)s[i]-48) * Math.Pow(10, i));

			var oldReverse = reverse;
			reverse += positionValue;

			if (oldReverse > reverse)
			{
				return 0;
			}

		}

		return x < 0 ? reverse * -1 : reverse;
	}
}