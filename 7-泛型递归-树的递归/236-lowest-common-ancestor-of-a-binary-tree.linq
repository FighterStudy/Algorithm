<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	
}

// 必考题 最近公共祖先
//Definition for a binary tree node.
public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { val = x; }
}

// 保存父节点
class Solution
{
   //使用了迭代。
    public void DFS(TreeNode root, Dictionary<int, TreeNode> data)
    {
        if (data.Count == 0)
            data.Add(root.val, null);
			
        if (root.left != null)
        {
            data.Add(root.left.val, root);
            DFS(root.left, data);
        }
        if (root.right != null)
        {
            data.Add(root.right.val, root);
            DFS(root.right, data);
        }
    }

    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
	    Dictionary<int, TreeNode> parent = new Dictionary<int, TreeNode>(); // 存放的是子节点的值和其父节点， 根节点的父为null
        DFS(root, parent);
        List<int> visited = new List<int>();//存放的是元素路线上，所经历的节点的值。
        while (p != null)
        {
            visited.Add(p.val);
            p = parent[p.val];
        }
        while (q != null)
        {
            if (visited.Contains(q.val))
                return q;
            q = parent[q.val];
        }
        return null;
    }
}

/*
时间复杂度：O(N)，其中 N 是二叉树的节点数。二叉树的所有节点有且只会被访问一次，
从 p 和 q 节点往上跳经过的祖先节点个数不会超过 NN，因此总的时间复杂度为 O(N)。

空间复杂度：O(N) ，其中 N 是二叉树的节点数。递归调用的栈深度取决于二叉树的高度，
二叉树最坏情况下为一条链，此时高度为 N，因此空间复杂度为 O(N)，
哈希表存储每个节点的父节点也需要 O(N) 的空间复杂度，因此最后总的空间复杂度为 O(N)。
*/

//递归。 

class Solution1
{
    TreeNode node = null;
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        Judge(root, p, q);
        return node;
    }

    private bool Judge(TreeNode root, TreeNode p, TreeNode q)
    {
        if (root == null)
            return false;
        bool leftFlag = Judge(root.left, p, q);
        bool rightFlag = Judge(root.right, p, q);
        bool ret = (leftFlag && rightFlag) || ((root.val == p.val || root.val == q.val) && (leftFlag || rightFlag));//判断共同祖先 
        if (ret)
            this.node = root;

        return leftFlag || rightFlag || (root.val == p.val || root.val == q.val);//给root这个颗树打分
    }
}

/*
时间复杂度：O(N)，其中 N 是二叉树的节点数。二叉树的所有节点有且只会被访问一次，
从 p 和 q 节点往上跳经过的祖先节点个数不会超过 NN，因此总的时间复杂度为 O(N)。

空间复杂度：O(N) ，其中 N 是二叉树的节点数。递归调用的栈深度取决于二叉树的高度，
二叉树最坏情况下为一条链，此时高度为 NN，因此空间复杂度为 O(N)，
哈希表存储每个节点的父节点也需要 O(N) 的空间复杂度，因此最后总的空间复杂度为 O(N)。
*/
