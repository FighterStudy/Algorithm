<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	
}

// 非递归  85
public ListNode SwapPairs(ListNode head) {
 ListNode pre =new ListNode(0);
 pre.next = head;
 ListNode curr = pre;
 while(curr.next != null && curr.next.next != null){
 	ListNode start = curr.next;
	ListNode end = curr.next.next;
	curr.next = end;
	start.next = end.next;
	end.next = start;
	curr = start;
 }
 
 return pre.next;
}

public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }
}


// 递归 65 其实差不多
public ListNode SwapPairs1(ListNode head) {
     if(head == null || head.next == null)
	    return head;
	 ListNode next = head.next;
	 head.next = SwapPairs1(next.next);
	 next.next = head;
	 return next;
}