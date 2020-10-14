<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	int[] data =new int[]{0,0,1,1,1,2,2,3,3,4};
	RemoveDuplicates(data).Dump();
}

/*
复杂度分析

时间复杂度：O(n)，假设数组的长度是 n，那么 i 和 j 分别最多遍历 n 步。

空间复杂度：O(1)。
*/
public int RemoveDuplicates(int[] nums) {
	if(nums.Length<2)
		return nums.Length;
	int j = 0;
	for(int i = 1;i<nums.Length; i++){
		
		if(nums[i]!=nums[j-1]){
		   nums[j]= nums[i];
		   j++;
		}
	}
	return j;
}

