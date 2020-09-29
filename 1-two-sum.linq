<Query Kind="Program" />

void Main()
{
	int[] data = new int[]{2, 7, 11, 15};
	TwoSum1(data,9).Dump();
	TwoSum1(new int[]{2,5,5,11},10).Dump();
}

//64 loop
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

//78
public int[] TwoSum1(int[] nums, int target) {
    Dictionary<int, int> data = new Dictionary<int, int>();
	int[] ret = new int[2];
	for(int i = 0; i < nums.Length; i++){
		if(data.ContainsKey(target - nums[i]))
		{
		    return new int[]{data[target-nums[i]],i};
		} 
		if(!data.ContainsKey(nums[i]))
		{
		   data.Add(nums[i],i);
		}
	}
	return new int[0];
}

// 英文网站 使用左右夹逼 更佳: 98.85%，分析了各个步骤的复杂度=》复杂度分析很重要，完成题解只是50%