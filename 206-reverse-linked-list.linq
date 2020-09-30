<Query Kind="Program" />

void Main()
{
}

//双指针迭代
public ListNode ReverseList(ListNode head) {
    ListNode prev = null;
    ListNode curr = head;
    while(curr != null){
        ListNode next = curr.next;
        curr.next = prev;
        prev = curr;
        curr = next;
    }
    return prev;
}

// 递归
public ListNode ReverseList1(ListNode head) {
    if(head == null || head.next == null) return head;
    ListNode p = ReverseList1(head.next);
    head.next.next = head;
    head.next = null;
    return p;
}
public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }
}


