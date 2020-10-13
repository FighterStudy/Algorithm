<Query Kind="Program" />

void Main()
{
	int[] data = new int[]{2, 7, 11, 15};
	TwoSum1(data,9).Dump();
	TwoSum1(new int[]{2,5,5,11},10).Dump();
}

//64 暴力法
public int[] TwoSum(int[] nums, int target) {
    int[] data = new int[2];
	for(int i = 0; i < nums.Length-1; i++){
		for(int j = i+1; j < nums.Length; j++){
			if (nums[i] + nums[j] == target)
			{
				data[0] = i;
				data[1] = j;
				return data;//key from 56 -64
			}
		}
	}
	
	return new int[0];
}

/*
时间复杂度：O(N^2)，其中 N 是数组中的元素数量。最坏情况下数组中任意两个数都要被匹配一次。
空间复杂度：O(1)。
*/

//78 Hashmap  Dic：数组值 索引   返回值为索引
public int[] TwoSum1(int[] nums, int target) {
    Dictionary<int, int> data = new Dictionary<int, int>();
	int[] ret = new int[2];
	for(int i = 0; i < nums.Length; i++){
		if(data.ContainsKey(target - nums[i]))
		    return new int[]{data[target-nums[i]],i};
		if(!data.ContainsKey(nums[i]))
		   data.Add(nums[i],i);
	}
	return new int[0];
}

/*
复杂度分析
时间复杂度：O(N)，其中 N 是数组中的元素数量。对于每一个元素 x，我们可以 O(1) 地寻找 target - x。
空间复杂度：O(N)，其中 N 是数组中的元素数量。主要为哈希表的开销。

*/

// 国际网站 使用左右夹逼 更佳: 98.85%，分析了各个步骤的复杂度=》复杂度分析很重要，完成题解只是50%
