<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	int[] data = new int[]{1,2,3,4,5,6,7};
	Rotate3(data,3);
	//[5,6,7,1,2,3,4]
}

// Define other methods, classes and namespaces here
// O(n) memory O(n) time 使用额外的数组
public void Rotate1(int[] nums, int k) {
	int[] data = new int[nums.Length];
	for(int i = 0;i< nums.Length; i++){
        int index = (i+k)%(nums.Length);
		data[index]= nums[i];
	}
	nums = data;
	nums.Dump();
}

//使用反转 时间复杂度：O(n) 。 nn 个元素被反转了总共 3 次。
// 空间复杂度：O(1) 。 没有使用额外的空间。
public void Rotate(int[] nums, int k) {
	k = k% nums.Length; // attention k>= nums.Length
	Reverse(nums,0, nums.Length-1);
	Reverse(nums,0,k-1);
	Reverse(nums, k, nums.Length-1);
	
}

public void Reverse(int[] data, int start, int end){
	while(start < end){ // attention
		int temp = data[start];
		data[start]= data[end];
		data[end]= temp;
		start++;
		end--;
		
	}
}

// 暴力  
//时间复杂度：O(n*k) 。每个元素都被移动 1 步（O(n)） k次（O(k)） 
// 空间复杂度：O(1) 。没有额外空间被使用

public void Rotate2(int[] nums, int k) {
    for(int i = 0; i<k;i++){
	int previous = nums[nums.Length-1];
	for(int j = 0; j<nums.Length; j++){
		int temp = nums[j];
		nums[j] = previous;
		previous = temp;
	   }
    }
}

void rotate(int[] nums, int k) {
   int len  = nums.Length;
   k = k % len;
   int count = 0;         // 记录交换位置的次数，n个同学一共需要换n次
    for(int start = 0; count < len; start++) {
        int cur = start;       // 从0位置开始换位子
        int pre = nums[cur];   
        do{
            int next = (cur + k) % len;
            int temp = nums[next];    // 来到角落...
            nums[next] = pre;
            pre = temp;
            cur = next;
            count++;
        }while(start != cur)  ;     // 循环暂停，回到起始位置，角落无人
         
    }   
}  


