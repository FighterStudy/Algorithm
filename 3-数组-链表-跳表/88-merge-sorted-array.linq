<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	Solution1 s = new Solution1();
	int[] nums1 = {1};
	int[] nums2 = {};
	//[1,2,2,3,5,6]
	s.Merge(nums1, 1, nums2, 0);
	nums1.Dump();
	
	 
}



// 方法1：合并后排序 时间复杂度：O((n+m)log(n+m)) 空间复杂度：O(1)
public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
		Array.Copy(nums2, 0, nums1, m , n);
		Array.Sort(nums1);
		
    }
}

// 双指针法： 时间复杂度：O(n+m)
public class Solution1 {
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int len1 = m - 1;
        int len2 = n - 1;
        int len = m + n - 1;
        while (len1 >= 0 && len2 >= 0)
        {
            // 注意--符号在后面，表示先进行计算再减1，这种缩写缩短了代码
            nums1[len--] = nums1[len1] > nums2[len2] ? nums1[len1--] : nums2[len2--];
        }
        // 表示将nums2数组从下标0位置开始，拷贝到nums1数组中，从下标0位置开始，长度为len2+1
        Array.Copy(nums2, 0, nums1, 0, len2 + 1);
       
    }
}


/*
这道题的提示：
nums1.length == m + n
nums2.length == n
所以双指针法，尽管把nums2中余下的数字复制到nums1中，另外，如果nums2不剩下元素了，len2则为-1， -1+1为0，复制元素为0个。
*/