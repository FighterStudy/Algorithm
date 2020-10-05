<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	int[] data = new int[]{1,3,-1,-3,5,3,6,7};
	int[] ret = MaxSlidingWindow1(data, 3);
}

// Define other methods, classes and namespaces here
// violence  => overtime
public int[] MaxSlidingWindow(int[] nums, int k)
{
    int[] data = new int[nums.Length - k + 1];
    for (int i = 0; i < nums.Length - k + 1; i++)
    {
        int count = 0;
        int max = nums[i];

        while (++count <= k-1)
        {
            max = Math.Max(max, nums[i+count]);
        }
        data[i] = max;

    }
    return data;
}

// Dequeque => linkedList
// Overtime
// need to compare dequeque and linkedlist

public int[] MaxSlidingWindow1(int[] nums, int k)
{
    int[] data = new int[nums.Length - k + 1];
    LinkedList<int> dq = new LinkedList<int>();
    for (int i = 0; i < nums.Length; i++)
    {
        // push
        while (dq.Count != 0 && nums[dq.Last()] <= nums[i]) {
            dq.RemoveLast();
			"1".Dump();
        }
		  dq.AddLast(i);
		// move pop above push, do not if dq.Count !=0
		// pop
        if (dq.First.Value <= i - k) {
            dq.RemoveFirst();
        }

        // result
        if (i >= k - 1) {
            data[i - k + 1] = nums[dq.First()];
        }

    }
    return data;
}

//更优的方法 动态规划
// 回头再看