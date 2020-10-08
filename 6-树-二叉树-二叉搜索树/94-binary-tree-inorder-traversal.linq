<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	
}


public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

// 递归 time space O(n)
public IList<int> InorderTraversal(TreeNode root)
{
    IList<int> ret = new List<int>();
    Inorder(ret, root);
    return ret;
}

public void Inorder(IList<int> ret, TreeNode root)
{
    if (root != null)
    {
        Inorder(ret, root.left);
        ret.Add(root.val);
        Inorder(ret, root.right);
    }
}

// https://leetcode-cn.com/problems/binary-tree-inorder-traversal/solution/yan-se-biao-ji-fa-yi-chong-tong-yong-qie-jian-ming/
public class Solution {
	public IList<int> InorderTraversal(TreeNode root) {
	    IList<int> ret = new List<int>();
	        Stack<ColorTreeNode> stack = new Stack<ColorTreeNode>();
	        stack.Push(new ColorTreeNode() { Node = root, Color= NodeColor.White});
	        while (stack.Count !=0)
	        {
	            ColorTreeNode node1 = stack.Pop();
	            if(node1 == null)
	                continue;
	            TreeNode node = node1.Node;
	            NodeColor color = node1.Color;
	            if(node == null)
	                continue;
	            if (color == NodeColor.White)
	            {
	                stack.Push(new ColorTreeNode() { Node = node.right, Color = NodeColor.White });
	                stack.Push(new ColorTreeNode() { Node = node, Color = NodeColor.Gray });
	                stack.Push(new ColorTreeNode() { Node = node.left, Color = NodeColor.White });
	            }
	            else {
	                ret.Add(node.val);
	            }
	        }
	        return ret;
	}

	public class ColorTreeNode
	{
	    public NodeColor Color { get; set; }
	    public TreeNode Node { get; set; }
	}
	
	public enum NodeColor
	{
	    White,
	    Gray
	}
}

// 栈与迭代 更快一些  time space ：On
public class Solution1{
	public IList<int> InorderTraversal(TreeNode root)
	{
	    IList<int> ret = new List<int>();
	    Stack<TreeNode> stack = new Stack<TreeNode>();
	    while (root != null|| stack.Count != 0)
	    {
	        while (root != null) { // while
	            stack.Push(root);
	            root = root.left;
	        }
	
	        root = stack.Pop();
	        ret.Add(root.val);
	        root = root.right;
	    }
	    return ret;
	}
}