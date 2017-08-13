<Query Kind="Program" />

void Main()
{
	var l1 = new ListNode {
	
	};
}

public class Solution
{
	public ListNode MergeKLists(ListNode[] lists)
	{
		if (lists == null)
		{
			return null;
		}

		if (lists.Length == 1)
		{
			return lists[0];
		}

		if (lists.Length == 2)
		{
			return Merge2Lists(lists[0], lists[1]);
		}

		var firstArray = lists.Take(lists.Length / 2).ToArray();
		var secondArray = lists.Skip(lists.Length / 2).ToArray();

		return Merge2Lists(MergeKLists(firstArray), MergeKLists(secondArray));

	}

	public ListNode Merge2Lists(ListNode list1, ListNode list2)
	{

		if (list1 == null && list2 == null)
		{
			return null;
		}
		else if (list1 == null)
		{
			return list2;
		}
		else if (list2 == null)
		{
			return list1;
		}
		
		ListNode cur;
		ListNode start = list1.val < list2.val ? list1 : list2;
		
		cur = start;

		while (list1 != null && list2 != null)
		{
			if (list1 == null)
			{
				cur.next = list2;
				return start;
			}
			else if (list2 == null)
			{
				cur.next = list1;
				return start;
			}
			else if (list1.val < list2.val)
			{
				cur.next = list1;
				list1 = list1.next;
			}
			else
			{
				cur.next = list2;
				list2 = list2.next;
			}
		}

		return start;
	}
}

public class ListNode
{
 	public int val;
 	public ListNode next;
 	public ListNode(int x) { val = x; }
}