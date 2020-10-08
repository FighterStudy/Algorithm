<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	
}

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

// 96.40 递归
public class Solution
{
    public IList<int> Postorder(Node root)
    {
        IList<int> data = new List<int>();
        Postorder(root, data);
        return data;
    }

    public void Postorder(Node root, IList<int> data)
    {
        if (root != null)
        {
           
            if (root.children != null && root.children.Count != 0)
            {
                foreach (var item in root.children)
                {
                    Postorder(item, data);
                }
            }
			data.Add(root.val);
        }
    }
}

 // 迭代   84  [V11,V12,V13]  V1 [V21,V22,V23] V2 [V31,V32,V33] V3  R
public class Solution1
{
    public IList<int> Postorder(Node root)
    {
        IList<int> data = new List<int>();
        if (root == null)
            return data;
        Queue<int> fakeData = new Queue<int>();
        Stack<Node> stack = new Stack<Node>();
        stack.Push(root);
        while (stack.Count != 0)
        {
            Node node = stack.Pop();
            fakeData.Enqueue(node.val);
            var ret = node.children.Reverse();
            foreach (var item in ret)
            {
                stack.Push(item);
            }
        }

        data = fakeData.ToList();
        return data.Reverse().ToList();
    }
}

// 迭代
class Solution2
{
    public List<int> postorder(Node root)
    {
        Stack<Node> stack = new Stack<Node>();
        LinkedList<int> output = new LinkedList<int>();
        if (root == null)
            return output.ToList();

        stack.Push(root);
        while (stack.Count != 0)
        {
            Node node = stack.Pop();
            output.AddFirst(node.val);
            foreach (var item in node.children)
            {
                if (item != null)
                {
                    stack.Push(item);
                }
            }
        }
        return output.ToList();
    }
}