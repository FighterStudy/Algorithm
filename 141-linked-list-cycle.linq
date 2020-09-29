<Query Kind="Program" />

void Main()
{
	int[] data = new int[]{3,2,0,-4};
	int pos = 1;
	ListNode head = null;
	foreach(var x in data){
	    if(head == null)
		    head = new ListNode(x);
		else 
		{
			head.next = new ListNode(x);
			head = head.next;
		}
	}
}

// Define other methods, classes and namespaces here  O(n)  84
public bool HasCycle(ListNode head) {
    if(head == null || head.next == null)
		return false;
	ListNode fast = head.next;
	ListNode slow = head;
	while(fast != slow){
	 	if(fast == null || fast.next == null)
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
