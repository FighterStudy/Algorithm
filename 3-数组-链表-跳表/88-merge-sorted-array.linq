<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	Solution s = new Solution();
	int[] nums1 = {1,2,3,0,0,0};
	int[] nums2 = {2,5, 6};
	//[1,2,2,3,5,6]
	s.Merge(nums1, 3, nums2, 3);
	 
	 
}

// 方法1： 合并后排序，时间复杂度：（n+m）
public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
		Array.Copy(nums2, 0, nums1, m , n);
		Array.Sort(nums1);
		nums1.Dump();
    }
}