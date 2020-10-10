<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	
}

// 迭代
public class Solution
{
    Dictionary<int, int> steps = new Dictionary<int, int>();
    public int ClimbStairs(int n)
    {
        if (n <= 0)
            return 0;
        if (n == 1 || n == 2)
            return n;
        int fn1;
        if (steps.ContainsKey(n - 1))
            fn1 = steps[n - 1];
        else
        {
            fn1 = ClimbStairs(n - 1);
            steps.Add(n-1,fn1);
        }

        int fn2;
        if (steps.ContainsKey(n - 2))
            fn2 = steps[n - 2];
        else
        {
            fn2 = ClimbStairs(n - 2);
            steps.Add(n - 2, fn2);
        }

        return fn1+fn2;
    }
}

// 递归
public int ClimbStairs(int n)
{
   if (n <= 2)
        return n;
    int f1 = 1;
    int f2 = 2;
    int f3 = 3;
    for (int i = 3; i <= n; i++)
    {
        f3 = f2 + f1;
		// prepare data for the next loop
        f1 = f2;
        f2 = f3;
    }

    return f3;
}


/*
public void recur(int level, int param) { 
  // terminator  递归中止条件
  if (level > MAX_LEVEL) { 
    // process result 
    return; 
  }

  // process current logic 处理当前逻辑
  process(level, param); 

  // drill down 下探到下一层
  recur( level: level + 1, newParam); 

  // restore current status 清理当前层，全局变量...
 }
 
 */