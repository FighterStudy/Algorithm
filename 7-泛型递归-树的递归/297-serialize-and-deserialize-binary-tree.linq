<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	"1,2,#,#,3,4,#,#,5,#,#".Split(',').Dump();
}

/*
注意：说明: 不要使用类的成员 / 全局 / 静态变量来存储状态，你的序列化和反序列化算法应该是无状态的。
[1,2,3,null,null,4,5]
[]

*/


public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { val = x; }
}


// 递归
//https://leetcode.com/problems/serialize-and-deserialize-binary-tree/discuss/74253/Easy-to-understand-Java-Solution
public class Codec1
{
    // Encodes a tree to a single string.
    public string serialize(TreeNode root)
    {
        StringBuilder str = new StringBuilder();
        if (root == null) return str.Append("#").ToString();
        str.Append(root.val.ToString()).Append(",");
        str.Append(serialize(root.left)).Append(",");
        str.Append(serialize(root.right));
        return str.ToString();
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data)
    {
        return deserial(new Queue<String>(data.Split(',')));
    }

    private TreeNode deserial(Queue<String> q)
    {
        String val = q.Dequeue();
        if ("#".Equals(val)) return null;
        TreeNode root = new TreeNode(int.Parse(val));
        root.left = deserial(q);
        root.right = deserial(q);
        return root;
    }
}

//广度优先
public class Codec
{

    // Encodes a tree to a single string.
    public string serialize(TreeNode root)
    {
        if (root == null)
            return "[]";
        List<string> data = new List<string>();
        Queue<TreeNode> queque = new Queue<TreeNode>();
        queque.Enqueue(root);
        while (queque.Count != 0)
        {
            int size = queque.Count;
            while (size>0)
            {
                TreeNode node = queque.Dequeue();
                if (node != null)
                {
                    data.Add(node.val.ToString());
                    if (node != null)
                    {
                        queque.Enqueue(node.left);
                        queque.Enqueue(node.right);
                    }
                }
                else
                    data.Add("null");
                size--;
            }
            if (queque.All(x => x == null) == true)
                break;
        }

        return $"[{string.Join(",", data.ToArray())}]";
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data)
    {
        string[] strs = data.Split(new char[] { ',', '[', ']' }, StringSplitOptions.RemoveEmptyEntries);
        if (strs.Length == 0)
            return null;
        TreeNode root = null;
        Queue<TreeNode> queque = new Queue<TreeNode>();
        for (int i = 0; i < strs.Length; i++)
        {
            if (i == 0)
            {
                if (int.TryParse(strs[i], out int ret))
                {
                    root = new TreeNode(ret);
                    queque.Enqueue(root);
                    continue;
                }
                else
                    return null;
            }
            Queue<TreeNode> nodes = new Queue<TreeNode>();
            while (queque.Count != 0)
            {
                TreeNode node = queque.Dequeue();
                if (node == null)
                    continue;
                if (i < strs.Length)
                {
                    if (int.TryParse(strs[i], out int ret))
                        node.left = new TreeNode(ret);
                    else
                        node.left = null;
                    nodes.Enqueue(node.left);
                }

                i++;
                if (i < strs.Length)
                {
                    if (int.TryParse(strs[i], out int ret1))
                        node.right = new TreeNode(ret1);
                    else
                        node.right = null;
                    nodes.Enqueue(node.right);
                }
                i++; // attention
            }
            i--;
            queque = nodes;

        }
        return root;
    }
}