<Query Kind="Program" />

void Main()
{
	Solution s = new Solution();
	s.TwoSum(new int[]{3,2,4},6).Dump();// 1 2
}

//暴力法
class Solution1{
	public int[] TwoSum(int[] nums, int target) {
	    int[] data = new int[2];
		for(int i = 0; i < nums.Length-1; i++){
			for(int j = i+1; j < nums.Length; j++){
				if (nums[i] + nums[j] == target)
				{
					data[0] = i;
					data[1] = j;
					return data;
				}
			}
		}
		
		return new int[0];
	}
}


/*
时间复杂度：O(N^2)，其中 N 是数组中的元素数量。最坏情况下数组中任意两个数都要被匹配一次。
空间复杂度：O(1)。
*/

//Hashmap  Dic：Key:数组值 Value:索引
class Solution2{
	public int[] TwoSum1(int[] nums, int target) {
	    Dictionary<int, int> data = new Dictionary<int, int>();
		int[] ret = new int[2];
		for(int i = 0; i < nums.Length; i++){
			if(data.ContainsKey(target - nums[i]))
			    return new int[]{data[target-nums[i]],i}; //这里放入的是索引
			if(!data.ContainsKey(nums[i]))
			   data.Add(nums[i],i);
		}
		return ret;
	}
}

/*
复杂度分析
时间复杂度：O(N)，其中 N 是数组中的元素数量。对于每一个元素 x，我们可以 O(1) 地寻找 target - x。
空间复杂度：O(N)，其中 N 是数组中的元素数量。主要为哈希表的开销。
*/

//左右夹逼
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] data = new int[2];
        int[] copyNums = new int[nums.Length];
        Array.Copy(nums, copyNums, nums.Length);
		Array.Sort(copyNums);
        int left = 0, right = copyNums.Length - 1;
        while (left < right)
        {
            int sum = copyNums[left] + copyNums[right];
            if (sum == target)
            {
                data[0] = copyNums[left];
                data[1] = copyNums[right];
				data.Dump();
                break;
            }
            else if (sum < target)
                left++;
            else
                right--;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (data[0] == nums[i])
            {
                data[0] = i;
                break;
            }
        }

        for (int i = nums.Length-1; i>=0; i--)
        {
            if (data[1] == nums[i])
            {
                data[1] = i;
                break;
            }
        }

        return data;
    }
}

/*
The general idea is:
step1 : copy an array, and sort it using quick sort, O(nlogn)
step2 : using start and end points to find a, b which satifys a+b==target, O(n)
step3 : find the index of a, b from origin array, O(n)
note: in step3, you should judge whethour a==b, if true, you must find the second index of b.
if you have any higher efficiency solution, contact me, please.
https://github.com/yangliguang
空间复杂度 O(n)
时间复杂度 O(nlogn) 
*/
