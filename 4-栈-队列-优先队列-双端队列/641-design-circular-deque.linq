<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	MyCircularDeque obj = new MyCircularDeque(10);
	bool param_1 = obj.InsertFront(3);
	bool param_2 = obj.InsertLast(5);
	bool param_3 = obj.DeleteFront();
	bool param_4 = obj.DeleteLast();
	int param_5 = obj.GetFront();
	int param_6 = obj.GetRear();
	bool param_7 = obj.IsEmpty();
	bool param_8 = obj.IsFull();
}

public class MyCircularDeque
{
    // 1、不用设计成动态数组，使用静态数组即可
    // 2、设计 head 和 tail 指针变量
    // 3、head == tail 成立的时候表示队列为空
    // 4、tail + 1 == head

    private int capacity;
    private int[] arr;
    private int front;
    private int rear;

    public MyCircularDeque(int k)
    {
        capacity = k + 1;
        arr = new int[capacity];

        // 头部指向第 1 个存放元素的位置
        // 插入时，先减，再赋值
        // 删除时，索引 +1（注意取模）
        front = 0;
        // 尾部指向下一个插入元素的位置
        // 插入时，先赋值，再加
        // 删除时，索引 -1（注意取模）
        rear = 0;
    }

    public bool InsertFront(int value)
    {
        if (IsFull())
            return false;
        front = (front - 1 + capacity) % capacity;
        arr[front] = value;
        return true;
    }

   
    public bool InsertLast(int value)
    {
        if (IsFull())
            return false;
        arr[rear] = value;
        rear = (rear + 1) % capacity;
        return true;
    }

   
    public bool DeleteFront()
    {
        if (IsEmpty())
            return false;
        // front 被设计在数组的开头，所以是 +1
        front = (front + 1) % capacity;
        return true;
    }

    public bool DeleteLast()
    {
        if (IsEmpty())
            return false;
        // rear 被设计在数组的末尾，所以是 -1
        rear = (rear - 1 + capacity) % capacity;
        return true;
    }

    public int GetFront()
    {
        if (IsEmpty())
            return -1;
        return arr[front];
    }

    public int GetRear()
    {
        if (IsEmpty())
            return -1;
        // 当 rear 为 0 时防止数组越界
        return arr[(rear - 1 + capacity) % capacity];
    }

    public bool IsEmpty()
    {
        return front == rear;
    }
           
    public bool IsFull()
    {
        // 注意：这个设计是非常经典的做法
        return (rear + 1) % capacity == front;
    }
}
