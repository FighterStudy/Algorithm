<Query Kind="Program" />

void Main()
{
	ClimbStairs1(6).Dump();
	
}


// Define other methods, classes and namespaces here


/*
懵逼的时候
暴力？ 基本情况？
找最近重复子问题
if else for while , recursion
1:1
2:2
3:f(1) + f(2)
4:f(2) + f(3)

f(n) = f(n-1) + f(n-2)
从相邻第一个台阶 跨一步 或者相邻第二个台阶 跨两步

*/
// Over time
int ClimbStairs(int n) {
	if(n<=2) return n;
  	return ClimbStairs(n-1) + ClimbStairs(n-2);
}

// 96
int ClimbStairs1(int n) {
   
	if(n<=2) return n;
	int f1 = 1;
	int f2 = 2;
	int f3 = 3;
	
	for(int i=3;i<=n;i++){
	  f3 = f1+ f2;
	  f1 = f2;
	  f2 = f3;
	}
	
	return f3;
}