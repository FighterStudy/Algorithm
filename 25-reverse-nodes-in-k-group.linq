<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	
}

// Define other methods, classes and namespaces here

public ListNode ReverseKGroup(ListNode head, int k){
	ListNode prev = null;
	ListNode curr = head;
	ListNode next = null;
	int count = k-1;
	while(curr != null && count>=0){
		if(curr == null)
			return head;
		next = curr.next;
		curr.next = prev;
		prev = curr;
		curr  = curr.next;
		curr.next = ReverseKGroup(curr.next, k);
	}
	return prev;	
}


public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }
}