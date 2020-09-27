<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
    //https://leetcode-cn.com/problems/move-zeroes/
	int[] data = new int[]{0,1,0,3,12};
	int j = 0;
	for(int i =0; i<data.Length; i++){
		if(data[i]!=0){
			data[j]=data[i];
			if(i!=j){
				data[i]=0;
			}
			j++;
		}	
	}
	data.Dump();
}

// Define other methods, classes and namespaces here
