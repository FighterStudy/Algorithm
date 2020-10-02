<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	
}

// Define other methods, classes and namespaces here
public ListNode DetectCycle(ListNode head) {
    if(head == null || head.next == null)
		return null;
	
	ListNode fast = head.next.next;
	ListNode slow = head.next;
	
	while(fast != slow){
		if(fast == null || fast.next == null)
			return null;
	    fast = fast.next.next;
		slow = slow.next;
	}
	
	return slow;
}


public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int x) {
        val = x;
        next = null;
    }
}