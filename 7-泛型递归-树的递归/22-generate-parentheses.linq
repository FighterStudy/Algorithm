<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	Solution s = new Solution();
	s.GenerateParenthesis(3).Dump();
}

// time: O(2^n)  
public class Solution
{
    List<string> data = new List<string>();
    public IList<string> GenerateParenthesis(int n)
    {
        GenerateParenthesis(0,0,n,"");
        return data;
    }

    private void GenerateParenthesis(int left, int right,int n, string str)
    {
        if (left == n && right == n) {
            data.Add(str);
            return;
        }

        if (left<n) GenerateParenthesis(left + 1, right, n, $"{str}(");
        if (left>right) GenerateParenthesis(left, right + 1, n, $"{str})");
    }
}
