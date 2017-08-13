<Query Kind="Program" />

void Main()
{
	//Input: (2-> 4-> 3) +(5-> 6-> 4)
	//Output: 7-> 0-> 8
	var l1 = new ListNode(2); 
	var l2 = new ListNode(5);
	(l1.next = new ListNode(4)).next = new ListNode(3);
	(l2.next = new ListNode(6)).next = new ListNode(4);
	
	var l3 = new Solution().AddTwoNumbers(l1, l2);

	var l4 = new ListNode(3);
	var l5 = new ListNode(5);
	((l4.next = new ListNode(2)).next = new ListNode(4)).next = new ListNode(3);
	(l5.next = new ListNode(6)).next = new ListNode(4);
	var l6 = new Solution().AddTwoNumbers(l4, l5);
	
	var l7 = new ListNode(5);
	var l8 = new ListNode(5);
	
	var l9 = new Solution().AddTwoNumbers(l7, l8);

	var l10 = new ListNode(1);
	l10.next = new ListNode(8);
	var l11 = new ListNode(0);

	var l12 = new Solution().AddTwoNumbers(l10, l11);

}

public class Solution
{
	public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
	{
		if(l1 == null || (l1.next == null && l1.val == 0)) return l2;
		if(l2 == null || (l2.next == null && l2.val == 0)) return l1;
		
//		l1 = this.Reverse(l1);
//		l2 = this.Reverse(l2);
		
		ListNode result = null;
		ListNode head = null;
		
		var carry  = 0;
		while (l1 != null || l2 != null || carry == 1)
		{
			var val1 = l1?.val ?? 0;
			var val2 = l2?.val ?? 0;
			
			var sum = val1 + val2 + carry;
			var remainder = sum % 10;
			carry = sum >= 10 ? 1 : 0;

			$"c:{carry}, r:{remainder}".Dump();

			if (result == null)
			{
				result = new ListNode(remainder);
				head = result;
			}
			else
			{
				result.next = new ListNode(remainder);
				result = result.next;
			}
			
			l1 = l1?.next;
			l2 = l2?.next;
		}
		
		return head;
	}

//	public ListNode Reverse(ListNode node)
//	{
//		var cur = node;
//		ListNode prev = null;
//		while (cur != null)
//		{
//			var next = cur.next;
//			cur.next = prev;
//			prev = cur;
//			cur = next;
//		}
//		
//		return prev;
//	}
}

public class ListNode
{
    public int val;
     public ListNode next;
     public ListNode(int x) { val = x; }
}


