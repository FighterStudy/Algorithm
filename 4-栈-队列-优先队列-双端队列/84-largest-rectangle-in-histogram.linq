<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	LargestRectangleArea3(new int[]{2,1,5,6,2,3}).Dump(); // 10
	LargestRectangleArea3(new int[]{0}).Dump(); //0
	LargestRectangleArea3(new int[]{}).Dump(); //0
	LargestRectangleArea3(new int[]{0,9}).Dump(); // 9
	LargestRectangleArea3(new int[]{1,1}).Dump(); //2
	
}

// Define other methods, classes and namespaces here

//https://leetcode-cn.com/problems/largest-rectangle-in-histogram/solution/javade-5chong-jie-fa-xiao-lu-zui-gao-de-ji-bai-lia/
// loop
public  int LargestRectangleArea1(int[] heights)
{
    int max = 0;
    // 枚举左边界
    for (int left = 0; left < heights.Length; left++)
    {
        int minHeight = int.MaxValue;
        // 枚举右边界
        for (int right = left; right < heights.Length; right++)
        {
            // 确定高度
            minHeight = Math.Min(minHeight, heights[right]);
            // 计算面积
            max = Math.Max(max, (right - left + 1) * minHeight);
        }
    }
    return max;
}

// 找到的宽度
public  int LargestRectangleArea2(int[] heights)
{
    int area = 0;
	int width = 0;
    for(int i = 0; i< heights.Length; i++){
		width = 1;
		int j = i;
		while(--j>= 0 && heights[j]>=heights[i]){
			width ++;
		}
	    j =i;
		while(++j< heights.Length && heights[j]>=heights[i]){
			width ++;
		}
		
		area = Math.Max(area, width*heights[i]);
	}
	return area;
}

// 类似第二种的方法，搜索边界的判断条件不同
public  int LargestRectangleArea3(int[] heights)
{
    int area = 0;
	for(int i = 0; i<heights.Length; i++){
		int j = i;
		while(--j>=0){
			if(heights[j]<heights[i])
				break;
		}
		int left = j;
		j = i;
		
		while(++j <heights.Length){
			if(heights[j]<heights[i])
			   break;
		}
		int right = j;
		area = Math.Max(area, (right-left-1)*heights[i]);
	
	}
	return area;
}
public static int largestRectangleArea(int[] heights)
{
    int length = heights.Length;
    Stack<int> stack = new Stack<int>();
    int maxArea = 0;
    for (int i = 0; i <= length; i++)
    {
        int h = (i == length ? 0 : heights[i]);
        //如果栈是空的，或者当前柱子的高度大于等于栈顶元素所对应柱子的高度,
        //直接把当前元素压栈
        if (stack.Count==0 || h >= heights[stack.Peek()])
        {
            stack.Push(i);
        }
        else
        {
            int top = stack.Pop();
            int area = heights[top] * (stack.Count==0 ? i : i - 1 - stack.Peek());
            maxArea = Math.Max(maxArea, area);
            i--;
        }
    }
    return maxArea;
}







