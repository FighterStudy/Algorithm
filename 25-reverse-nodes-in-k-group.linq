<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	
}

// Define other methods, classes and namespaces here

public ListNode ReverseKGroup(ListNode head, int k) {
      
      int count = k;
	  ListNode curr = head;
	  while(curr != null && count>0){
	  	 curr = curr.next;
		 count--;
	  }
	  
	  if(count == 0){
	      curr = ReverseKGroup(curr, k);
	  	  count = k;
		  while(count>0){
		    
		  	ListNode temp = head.next;
			head.next = curr;
			curr = head;
			head = temp;
		  	count--;
		  }
		  head = curr;
	  }
	  
	  return head;
}


public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }
}