<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	int[] data = new int[]{0,1,0,2,1,0,1,3,2,1,2,1};
	int result = trap(data).Dump();
	int ret = 6;
	
}

// Define other methods, classes and namespaces here
// 寻找左右最大，以及判断是否有雨水积累不明白
//时间复杂度： O(n^2)。数组中的每个元素都需要向左向右扫描。
//空间复杂度 O(1)的额外空间。
public int Trap(int[] height)
{
    int vol = 0;
    int size = height.Length;
    for (int i = 1; i < size - 1; i++)
    {
        int left = 0, right = 0;
        for (int j = i; j >= 0; j--)
        { //Search the left part for max bar size
            left = Math.Max(left, height[j]);
        }
        for (int j = i; j < size; j++)
        { //Search the right part for max bar size
            right = Math.Max(right, height[j]);
        }
        vol += Math.Min(left, right) - height[i];
    }
    return vol;
}

// 双指针
//时间复杂度：O(n)。单次遍历的时间O(n)。
//空间复杂度：O(1) 的额外空间。left, right, left_max 和 right_max 只需要常数的空间。
/*
left< right 处理短边，左边
	left>=maxleft left是递增状态，存不住水，修改最大值
		update maxleft
	left<max  left变短，可以存住水，存水由矮边left和自身差决定
		ans+= max-left
*/
public int Trap1(int[] height)
{
    int vol = 0;
    int left = 0;
    int right = height.Length - 1;
    int maxLeft = 0;
    int maxRight = 0;
    while (left < right) {
        if (height[left] < height[right])
        {
            if (height[left] >= maxLeft)
                maxLeft = height[left];
            else
                vol += (maxLeft - height[left]);
            left++;
        }
        else {
            if (height[right] >= maxRight)
                maxRight = height[right];
            else
                vol += (maxRight - height[right]);
            right--;
        }
    }
    return vol;
}

/*
栈的应用  
时间复杂度：O(n)。
单次遍历 O(n) ，每个条形块最多访问两次（由于栈的弹入和弹出），并且弹入和弹出栈都是 O(1)的。
空间复杂度：O(n)。 栈最多在阶梯型或平坦型条形块结构中占用 O(n)的空间。
如果我们发现一个条形块长于栈顶，我们可以确定栈顶的条形块被当前条形块和栈的前一个条形块界定，因此我们可以弹出栈顶元素并且累加答案到 \text{ans}ans
*/

public static int trap(int[] height)
{
    int ret = 0;
    int current = 0;
    Stack<int> stack = new Stack<int>();
    while (current < height.Length) {
        while (stack.Count != 0 && height[stack.Peek()] < height[current]) {
            int top = stack.Pop();
            if (stack.Count != 0) {
                int width = current - stack.Peek() - 1;
                int h = Math.Min(height[stack.Peek()], height[current]) - height[top];
                ret += width * h;
            }
        }

        stack.Push(current);
        current++;
    }

    return ret;
}
