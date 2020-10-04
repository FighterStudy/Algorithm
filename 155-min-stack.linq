<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	
}


// two stacks
class MinStack
{
    private Stack<int> data = new Stack<int>();
    private Stack<int> minStack = new Stack<int>();
    public MinStack()
    {
        minStack.Push(int.MaxValue);
    }

    public void push(int x)
    {
        data.Push(x);
        minStack.Push(Math.Min(minStack.Peek(), x));
    }

    public void pop()
    {
        data.Pop();
        minStack.Pop();
    }

    public int top()
    {
        return data.Peek();
    }

    public int getMin()
    {
        return minStack.Peek();
    }
}


// linkedlist
class MinStack1
{
    private Node head = null;

    public void Push(int x)
    {
        if (head == null)
        {
            head = new Node(x, x);
        }
        else
        {
            head = new Node(x, Math.Min(head.Min, x), head);
        }
    }

    public void Pop()
    {
        head = head.Next;
    }

    public int Top()
    {
        int x = head.Val;
        return x;
    }

    public int GetMin()
    {
        return head.Min;
    }

    class Node
    {
        public int Val { get; set; }
        public int Min { get; set; }
        public Node Next { get; set; }
        public Node(int val, int min)
        {
            this.Val = val;
            this.Min = min;
        }

        public Node(int val, int min, Node next)
        {
            this.Val = val;
            this.Min = min;
            this.Next = next;
        }
    }
}

// one stack

 
