<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	
}

// Define other methods, classes and namespaces here
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val,IList<Node> _children) {
        val = _val;
        children = _children;
    }
}

// 递归  98%
public class Solution
{
    public IList<int> Preorder(Node root)
    {
        IList<int> data = new List<int>();
        Preorder(root, data);
        return data;
    }

    public void Preorder(Node root, IList<int> data)
    {
        if (root != null)
        {
            data.Add(root.val);
            if (root.children != null && root.children.Count != 0)
            {
                foreach (var item in root.children)
                {
                    Preorder(item, data);
                }
            }
        }
    }
}

// 迭代   84
public class Solution1
{
    public IList<int> Preorder(Node root)
    {
        IList<int> data = new List<int>();
        if (root == null)
            return data;
        Stack<Node> stack = new Stack<Node>();
        stack.Push(root);
        while (stack.Count != 0)
        {
            Node node = stack.Pop();
            data.Add(node.val);
            var ret = node.children.Reverse();
            foreach (var item in ret)
            {
                stack.Push(item);
            }
        }
        return data;
    }


}