<Query Kind="Program" />

void Main()
{
	ThreeSum3(new int[]{-1, 0, 1, 2, -1, -4}).Dump();
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
 
 
 // 3. 双支针 O(n^2)  98
public static IList<IList<int>> ThreeSum3(int[] nums)
{
    IList<IList<int>> ret = new List<IList<int>>();
	// Sort 要放在前面，数组这个Sort方法不常用，没想起来。
    Array.Sort(nums);
	// 数据检查工作还是要做的
    if (nums == null ||nums.Count() == 0 || nums[0] > 0)
        return ret;
    for (int i = 0; i < nums.Length - 2; i++)
    {
        if (i == 0 || i > 0 && nums[i] != nums[i - 1])
        {
            int left = i + 1;
            int right = nums.Length - 1;
            int sum = -nums[i];
            while (left < right)
            {
                if (nums[right] + nums[left] == sum)
                {
                    ret.Add(new List<int>() { nums[i], nums[left], nums[right] });
					// left < right left++ 要满足的条件
                    while (left < right && nums[left] == nums[left + 1]) left++;
                    while (left < right && nums[right] == nums[right - 1]) right--;
                    left++;
                    right--;
                }
                else if (nums[right] + nums[left] > sum)
                    right--;
                else
                    left++;
            }
        }
    }
    return ret;
}
 
 
 