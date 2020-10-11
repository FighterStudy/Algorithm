<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	
}


//Definition for a binary tree node.
public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { val = x; }
}

//递归
public class Solution
{
    public bool IsValidBST(TreeNode root)
    {
        return IsValidBST(root, null, null);
    }

    private bool IsValidBST(TreeNode root, int? lower, int? upper)
    {
        if (root == null)
            return true;

        // current
        if (lower != null && root.val <= lower)
            return false;

        if (upper != null && root.val >= upper)
            return false;

        // next
        if (root.left != null && !IsValidBST(root.left, lower, root.val))
            return false;

        if (root.right != null && !IsValidBST(root.right, root.val, upper))
            return false;

        return true;
    }

}

/*
复杂度分析

时间复杂度 : O(n)，其中 n 为二叉树的节点个数。在递归调用的时候二叉树的每个节点最多被访问一次，
			因此时间复杂度为 O(n)。

空间复杂度 : O(n)，其中 n 为二叉树的节点个数。递归函数在递归过程中需要为每一层递归函数分配栈空间，
			所以这里需要额外的空间且该空间取决于递归的深度，即二叉树的高度。最坏情况下二叉树为一条链，
			树的高度为 n ，递归最深达到 n 层，故最坏情况下空间复杂度为 O(n)。
*/


// 中序遍历=》中序遍历是递增的
public class Solution1
{
    public bool IsValidBST(TreeNode root)
    {
        IList<int> data = InOrder(root);
        for (int i = 0; i < data.Count-1; i++)
        {
            if (data[i+1]<=data[i])
                return false;
        }
        return true;
    }

    private IList<int> InOrder(TreeNode root) {
        IList<int> data = new List<int>();
        Stack<TreeNode> stack = new Stack<TreeNode>();
        while (root != null || stack.Count != 0)
        {
            while (root != null)
            {
                stack.Push(root);
                root = root.left;
            }

            root = stack.Pop();
            data.Add(root.val);
            root = root.right;
        }
        return data;
    }
}

/*
复杂度分析
时间复杂度 : O(n)，其中 n 为二叉树的节点个数。二叉树的每个节点最多被访问一次，因此时间复杂度为 O(n)。
空间复杂度 : O(n)，其中 n 为二叉树的节点个数。栈最多存储 n 个节点，因此需要额外的 O(n) 的空间。
*/


public class Solution2
{
    public bool IsValidBST(TreeNode root)
    {
        IList<int> data = InOrder(root);
        for (int i = 0; i < data.Count-1; i++)
        {
            if (data[i+1]<=data[i])
                return false;
        }
        return true;
    }

    private IList<int> InOrder(TreeNode root) {
        IList<int> data = new List<int>();
        InOrder(root, data);
        return data;
    }

    private void InOrder(TreeNode root, IList<int> data) {
        if (root == null)
            return;

        InOrder(root.left, data);
        data.Add(root.val);
        InOrder(root.right, data);
    }
}






