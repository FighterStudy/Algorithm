<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
    Method2();
}

void Method1(){
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



void Method2(){
   
	int[] data = new int[]{0,1,0,3,12};
	int j = 0;
	int temp = 0;
	for(int i =0; i<data.Length; i++){
		if(data[i]!=0){
			temp = data[i];
			data[i] = data[j];
			data[j++] = temp;
		}	
	}
	data.Dump();
}

// j表示为非0元素的位置

// others:
// 1. new array

