<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	
}


/*
测试用例
[3,9,20,null,null,15,7]
[1,2,3,4,null,null,5]
[]
*/

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { val = x; }
}

public class Solution
{
    private int length = 0;
    public int MaxDepth(TreeNode root)
    {
        CountDepth(root, 0);
        return length;
    }

    private void CountDepth(TreeNode node, int level) {
        if (node == null)
            return;
        if (node != null)
        {
            level++;
            if (level>length)
                length = level;
        }

        CountDepth(node.left, level);
        CountDepth(node.right, level);
    }
}

/*
递归
思路与算法

如果我们知道了左子树和右子树的最大深度 ll 和 rr，那么该二叉树的最大深度即为
	max(l,r)+1
而左子树和右子树的最大深度又可以以同样的方式进行计算。因此我们在计算当前二叉树的最大深度时，
可以先递归计算出其左子树和右子树的最大深度，然后在 O(1) 时间内计算出当前二叉树的最大深度。递归在访问到空节点时退出。

时间复杂度：O(n)，其中 n为二叉树节点的个数。每个节点在递归中只被遍历一次。
空间复杂度：OO(height)，其中 height 表示二叉树的高度。递归函数需要栈空间，而栈空间取决于递归的深度，因此空间复杂度等价于二叉树的高度。

*/
public class Solution1
{
    public int MaxDepth(TreeNode root)
    {
        return CountDepth(root);
    }

    private int CountDepth(TreeNode node)
    {
        int length = 0;
        if (node == null)
        {
            return 0;
        }

        length = Math.Max(CountDepth(node.left), CountDepth(node.right)) + 1;

        return length;
    }
}


/*

用序列：不是栈，这个一边dequeque 一边enqueque
广度优先搜索，一层一层地进行拓展，最后我们用一个变量length来维护拓展的次数

复杂度分析

时间复杂度：O(n)，其中 n 为二叉树的节点个数。与方法一同样的分析，每个节点只会被访问一次。
空间复杂度：此方法空间的消耗取决于队列存储的元素数量，其在最坏情况下会达到 O(n)。

*/
public class Solution2
{
    public int MaxDepth(TreeNode root)
    {
        if (root == null)
            return 0;
        Queue<TreeNode> stack = new Queue<TreeNode>();
        int length = 0;
        stack.Enqueue(root);
        while (stack.Count != 0)
        {
            int size = stack.Count;
            while (size > 0)
            {
                TreeNode node = stack.Dequeue();
                if (node.left != null)
                    stack.Enqueue(node.left);
                if (node.right != null)
                    stack.Enqueue(node.right);
                size--;
            }

            length++;
        }
        return length;
    }
}