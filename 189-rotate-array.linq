<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	int[] data = new int[]{1,2,3,4,5,6,7};
	Rotate(data,3);
	//[5,6,7,1,2,3,4]
}

// Define other methods, classes and namespaces here
// O(n) memory O(n) time
public void Rotate1(int[] nums, int k) {
	int[] data = new int[nums.Length];
	for(int i = 0;i< nums.Length; i++){
        int index = (i+k)%(nums.Length);
		data[index]= nums[i];
	}
	nums = data;
	nums.Dump();
}


public void Rotate(int[] nums, int k) {
	for(int i = 0;i< nums.Length; i++){
		int index = (i+k)%nums.Length;
		$"{nums[index]} {nums[i]}".Dump();
		//int temp = nums[i];
		//nums[i] = nums[index];
		//nums[index] = temp;
	}
	
}