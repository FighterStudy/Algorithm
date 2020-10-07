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

// 递归
public IList<int> InorderTraversal(TreeNode root)
{
    IList<int> ret = new List<int>();
    Add(ret, root);
    return ret;
}

public void Add(IList<int> ret, TreeNode root)
{
    if (root != null)
    {
        Add(ret, root.left);
        ret.Add(root.val);
        Add(ret, root.right);
    }
}

