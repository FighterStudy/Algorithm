<Query Kind="Program" />

void Main()
{
	
}

// Define other methods, classes and namespaces here  O(n)  84
public bool HasCycle(ListNode head) {
    if(head == null || head.next == null)
		return false;
	ListNode fast = head.next;
	ListNode slow = head;
	while(fast != slow){
	 	if(fast == null || fast.next == null)// attention
			return false;
		fast = fast.next.next;
		slow = slow.next;
	}
	return false;
}
	
	

//Definition for singly-linked list.
public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int x) {
        val = x;
        next = null;
    }
}


// 暴力法和Hash
// 快慢指针
