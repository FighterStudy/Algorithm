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

//public ListNode swapPairs(ListNode head) {
//    ListNode prev =new ListNode(0);
//    prev.next = head;
//    prev = change(prev);
//    return prev.next;
//}
//
//public ListNode change(ListNode head){
//    if(head == null || head.next == null || head.next.next == null)
//        return head;
//    ListNode start = head.next;
//    ListNode end = head.next.next;
//    head.next = end;
//    start.next = end.next;
//    end.next = start;
//    start = change(start);
//    return head;
//}

public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }
}


// 递归 65 
public ListNode SwapPairs1(ListNode head) {
     if(head == null || head.next == null)
	    return head;
	 ListNode next = head.next;
	 head.next = SwapPairs1(next.next);
	 next.next = head;
	 return next;
}