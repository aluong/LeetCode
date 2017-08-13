<Query Kind="Program" />

void Main()
{
	var sln = new Solution();
//	sln.LengthOfLongestSubstring("abcabcbb").Dump();
//	sln.LengthOfLongestSubstring("bb").Dump();
//	sln.LengthOfLongestSubstring("pwwkew").Dump();
//	sln.LengthOfLongestSubstring("dvdf").Dump();
	sln.LengthOfLongestSubstring("anviaj").Dump();
}

public class Solution
{
	public int LengthOfLongestSubstring(string s)
	{
		var map = new HashSet<char>();
		
		int max = 0;

		for (int i = 0; i < s.Length; i++)
		{
			var ch = s[i];

			if (map.Contains(ch))
			{
				map.Clear();

				//find the previous 'ch'
				for (int j = i - 1; j > 0; j--)
				{
					if (ch == s[j])
					{
						break;
					}				
					else
					{
						map.Add(s[j]);
					}
				}
			}

			map.Add(ch);
			
			var currentSize = map.Count();
			if (currentSize > max)
			{
				max = currentSize;
			}
		}
		
		return max;
	}
}
