<Query Kind="Program" />

void Main()
{
	var sln = new Solution();
	sln.LengthOfLongestSubstring("abcabcbb").Dump();
	sln.LengthOfLongestSubstring("bb").Dump();
	sln.LengthOfLongestSubstring("pwwkew").Dump();
	sln.LengthOfLongestSubstring("dvdf").Dump();
	sln.LengthOfLongestSubstring("anviaj").Dump();
	sln.LengthOfLongestSubstring("abba").Dump();
}

public class Solution
{
	public int LengthOfLongestSubstring(string s)
	{
		var map = new Dictionary<char, int>();
		
		int max, current;
		current = max = 0;

		for (int i = 0; i < s.Length; i++)
		{
			var ch = s[i];

			if (map.ContainsKey(ch))
			{
				current = Math.Max(current, map[ch] + 1);
				map[ch] = i;
			}
			else
			{
				map.Add(ch, i);
			}

			max = Math.Max(max, i - current + 1);
		}
		
		return max;
	}
}
