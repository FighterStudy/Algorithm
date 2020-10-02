<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	
}

// Define other methods, classes and namespaces here
//https://leetcode.com/problems/linked-list-cycle-ii/discuss/44774/Java-O(1)-space-solution-with-detailed-explanation.
//这个解释下面 画图那个更合适
public ListNode DetectCycle(ListNode head) {
    ListNode fast = head, slow = head;
	while(fast != null && fast.next != null){
	fast = fast.next.next;
	slow = slow.next;
	if (fast == slow){
	ListNode slow2 = head;
	while (slow != slow2){
		slow2 = slow2.next;
		slow = slow.next;
		 }
		return slow;
		}
	}
	return null;
}


public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int x) {
        val = x;
        next = null;
    }
}