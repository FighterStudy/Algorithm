<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

//Func<int,int> triple=x=>x*3;
//var range = Enumerable.Range(1,3);
//var triples = range.Select(triple);
//triples.Dump();//3, 6, 9

//Func<int,bool> isOdd = x=>x%2==1;
//int[] original={7,6,1};
//var sorted = original.OrderBy(x=>x);
//var filtered = original.Where(isOdd);
//original.Dump();//7,6,1
//sorted.Dump();//1,6,7
//filtered.Dump();//7,1

//var original = new List<int>{5,7,1};
//original.Sort();
//original.Dump(); // 1, 5, 7

//Listing 1.3

//var nums = Enumerable.Range(-10000,20001).Reverse().ToList();
////Action task1 =()=>nums.Sum().Dump();
//Action task2 = ()=>{
//	nums.Sort();
//	nums.Sum().Dump();
//};
//Action task3=()=>{
//    nums.OrderBy(x=>x).Sum().Dump();
//};
//
//Parallel.Invoke(task3,task2);


Enumerable.Range(1,100).
	Where(x=>x%20==0).
	OrderBy(x=>-x).
	Select(i=>$"{i}%").
	Dump();

