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

// 61 递归
public class Solution
{
    public IList<int> PostorderTraversal(TreeNode root)
    {
        IList<int> ret = new List<int>();
        Postorder(ret, root);
        return ret;
    }

    public void Postorder(IList<int> ret, TreeNode root)
    {
        if (root != null)
        {
            Postorder(ret, root.left);
            Postorder(ret, root.right);
            ret.Add(root.val);
        }
    }
}

//75 迭代模拟递归
public class Solution1 {
	public IList<int> PostorderTraversal(TreeNode root) {
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
				    stack.Push(new ColorTreeNode() { Node = node, Color = NodeColor.Gray });
	                stack.Push(new ColorTreeNode() { Node = node.right, Color = NodeColor.White });
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
//https://leetcode-cn.com/problems/binary-tree-postorder-traversal/solution/er-cha-shu-qian-xu-zhong-xu-hou-xu-ceng-xu-bian-2/
//86  递归
class Solution3 {
    public List<int> PostorderTraversal(TreeNode root)
    {
        LinkedList<int> res = new LinkedList<int>();
        Stack<TreeNode> stack = new Stack<TreeNode>();
        while (root != null || stack.Count != 0)
        {
            while (root != null)
            {
                res.AddFirst(root.val); //插入队首
                stack.Push(root);
                root = root.right; //先右后左
            }
            root = stack.Pop();
            root = root.left;
        }
        return res.ToList();
    }
}

// 有问题
public List<int> PostorderTraversal(TreeNode root)
{
    if (root == null)
        return new List<int>();
    IList<int> fakeData = new List<int>();
    Stack<TreeNode> stack = new Stack<TreeNode>();
    stack.Push(root);
    while (stack.Count != 0)
    {
        TreeNode node = stack.Pop();
        fakeData.Add(node.val);
        if (node.right != null)
            stack.Push(node.right);

        if (node.left != null)
            stack.Push(node.left);
    }
    return fakeData.Reverse().ToList();
}




