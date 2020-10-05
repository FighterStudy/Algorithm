<Query Kind="Program" />

void Main()
{
    Int64.MaxValue.Dump();
	Fib(4).Dump();//3
}


// 65
 public int Fib1(int N) {
      if(N<=1) return N;
	  int f0 = 0;
	  int f1 = 1;
	  int f2 = 1;
	  for(int i = 2; i<=N; i++){
	  	f2 = f1+ f0;
		f0 = f1;
		f1 = f2;
	  }
	  return f2;
 }
 
//87 这个快的原因 有{2，1}缓存？ 去掉 {2，1} 也是65
public  Dictionary<int, int> fibdic = new Dictionary<int, int>() { { 0, 0 }, { 1, 1 }, { 2, 1 } };
public int Fib(int N) {
    if (!fibdic.ContainsKey(N))
	  fibdic.Add(N, Fib(N-2) + Fib(N-1));
    return fibdic[N];
}

// 32
public int Fib2(int N){
	 if(N<=1) return N;
	 return Fib2(N-1) + Fib2(N-2);
}

// 另外：https://leetcode-cn.com/problems/fei-bo-na-qi-shu-lie-lcof/


