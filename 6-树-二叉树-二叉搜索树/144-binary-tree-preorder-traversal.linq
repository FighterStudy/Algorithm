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


// 35  递归
public class Solution {
    public IList<int> PreorderTraversal(TreeNode root) {
        IList<int> ret = new List<int>();
    	Preorder(ret, root);
    	return ret;
    }
	
	private void Preorder(IList<int> ret,TreeNode root){
		if(root != null){
			ret.Add(root.val);
			Preorder(ret, root.left);
			Preorder(ret, root.right);
		}
	}
	
}


// 迭代  73
public class Solution1
{
    public IList<int> PreorderTraversal(TreeNode root)
    {
        IList<int> ret = new List<int>();
        Stack<TreeNode> stack = new Stack<TreeNode>();
        // 判断： 可能是空树
        if (root == null)
            return ret;
        stack.Push(root);
        while (stack.Count != 0)
        {
            TreeNode node = stack.Pop();
            ret.Add(node.val);
            if (node.right != null)
            {
                stack.Push(node.right);
            }
            if (node.left != null)
            {
                stack.Push(node.left);
            }
        }
        return ret;
    }


}

// 万能方法 模拟迭代
public class Solution2 {
	public IList<int> PreorderTraversal(TreeNode root) {
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
	                stack.Push(new ColorTreeNode() { Node = node.left, Color = NodeColor.White });
					stack.Push(new ColorTreeNode() { Node = node, Color = NodeColor.Gray });
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
class Solution4 {
    //迭代
	public List<int> preorderTraversal(TreeNode root)
	{
	    List<int> res = new List<int>();
	    Stack<TreeNode> stack = new Stack<TreeNode>();
	    while (root != null || stack.Count != 0)
	    {
	        while (root != null)
	        {
	            res.Add(root.val); //先将节点加入结果队列
	            stack.Push(root);  //不断将该节点左子树入栈
	            root = root.left;
	        }
	        root = stack.Pop(); //栈顶节点出栈
	        root = root.right; //转向该节点右子树的左子树（下一个循环）
	    }
	    return res;
}
    
}






