<Query Kind="Program" />

void Main()
{
	ThreeSum(new int[]{-1, 0, 1, 2, -1, -4}).Dump();
}


// 1. 暴力求解 O(n^3)
public IList<IList<int>> ThreeSum(int[] nums) {
    IList<IList<int>> ret = new List<IList<int>>(); 
	 for(int i = 0; i< nums.Length-2;i++){
	 	for(int j = i+1; j<nums.Length-1; j++){
			for(int k = j+1; k<nums.Length; k++){
				if(nums[i]+ nums[j] + nums[k] == 0){
				    ret.Add(new List<int>(){nums[i],nums[j],nums[k]});
				}
			}
		}
	 }
	 return ret;
 }
 
 // 2. Hash表
 
 
 // 3. 双支针 O(n^2)
 
 
 
 