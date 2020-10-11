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
/* 递归
叶子节点是指没有子节点的节点；

另外这道题的关键是搞清楚递归结束条件
	叶子节点的定义是左孩子和右孩子都为 null 时叫做叶子节点
	当 root 节点左右孩子都为空时，返回 1
	当 root 节点左右孩子有一个为空时，返回不为空的孩子节点的深度
	当 root 节点左右孩子都不为空时，返回左右孩子较小深度的节点值
*/
public class Solution
{
    public int MinDepth(TreeNode root)
    {
        if (root == null)
            return 0;

        if (root.left == null && root.right == null)
            return 1;

        int length = 0;
		int mLeft = MinDepth(root.left);
		int mRight = MinDepth(root.right);
//        if (root.left != null && root.right != null)
//            length = Math.Min(mLeft, mRight) + 1;
//        else if (root.left != null && root.right == null)
//            length = mLeft +1;
//        else if (root.right != null && root.left == null)
//            length = mRight + 1;
//        return length;
      
 		 // 简化
        if(root.left == null || root.right == null)
			return mLeft+mRight+1;
		return Math.Min(mLeft, mRight) +1;
    }
}

// 广度优先
public class Solution1
{
    public int MinDepth(TreeNode root)
    {
        if (root == null)
            return 0;
        
        int length = 0;
        Queue<TreeNode> queque = new Queue<TreeNode>();
        queque.Enqueue(root);
        while (queque.Count != 0)
        {
            int size = queque.Count;
            while (size > 0)
            {
                TreeNode node = queque.Dequeue();
                if (node.left == null && node.right == null)
                {
                    length++;
                    return length;
                }

                if (node.left != null)
                    queque.Enqueue(node.left);

                if (node.right != null)
                    queque.Enqueue(node.right);
                size--;
            }
            length++;
        }

        return length;
    }
}
/*

复杂度分析

时间复杂度：O(N)，其中 NN 是树的节点数。对每个节点访问一次。
空间复杂度：O(N)，其中 NN 是树的节点数。空间复杂度主要取决于队列的开销，队列中的元素个数不会超过树的节点数

*/



/* 还有深度优先搜索
对于每一个非叶子节点，我们只需要分别计算其左右子树的最小叶子节点深度。
这样就将一个大问题转化为了小问题，可以递归地解决该问题。


*/
public class Solution2
{
    public int MinDepth(TreeNode root)
    {
        if (root == null)
            return 0;

        if (root.left == null && root.right == null)
            return 1;

        int min_depth = int.MaxValue;
        if (root.left != null)
        {
            min_depth = Math.Min(MinDepth(root.left), min_depth);
        }
        if (root.right != null)
        {
            min_depth = Math.Min(MinDepth(root.right), min_depth);
        }

        return min_depth + 1;
    }
}
/*
复杂度分析

时间复杂度：O(N)，其中 N 是树的节点数。对每个节点访问一次。

空间复杂度：O(H)，其中 H 是树的高度。空间复杂度主要取决于递归时栈空间的开销，最坏情况下，
树呈现链状，空间复杂度为 O(N)。平均情况下树的高度与节点数的对数正相关，空间复杂度为O(logN)。？？？

*/
