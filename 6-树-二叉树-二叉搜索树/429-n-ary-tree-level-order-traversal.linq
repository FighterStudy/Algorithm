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

    public Node(int _val, IList<Node> _children) {
        val = _val;
        children = _children;
    }
}


// 借助队列  96 On
class Solution
{
    public IList<IList<int>> levelOrder(Node root)
    {
        Queue<Node> queue = new Queue<Node>();//队列
        IList<IList<int>> res = new List<IList<int>>(); //结果数组
        if (root == null) return res;
        queue.Enqueue(root);//将跟节点入队
        while (queue.Count != 0)
        { //当队列不为空
            int size = queue.Count; //查看当前队列元素个数
            List<int> temp = new List<int>(); //临时结果数组
            while (size > 0)
            {
                Node node = queue.Dequeue(); //出队一个元素
                temp.Add(node.val); //将该元素加入临时结果数组
                                    //将该元素左右孩子入队
                node.children.ToList().ForEach(x => queue.Enqueue(x));
                size--;
            }
            res.Add(temp); //将临时结果数组加入结果数组

        }
        return res;
    }
}

// 不依赖栈，广度优先搜索
public class Solution1 {
    public IList<IList<int>> LevelOrder(Node root) {

        IList<IList<int>> res = new List<IList<int>>(); //结果数组
        if(root == null)
            return res;
        List<Node> lists = new List<Node>();
        lists.Add(root);
        while (lists.Count != 0) {
            List<int> data = new List<int>();
            List<Node> lists1 = new List<Node>();
            for (int i = 0; i < lists.Count; i++)
            {
                data.Add(lists[i].val);
                lists1.AddRange(lists[i].children);
            }
            lists = lists1;
            res.Add(data);
        }
        return res;
    }
}


// 递归
class Solution2
    {
        IList<IList<int>> res = new List<IList<int>>(); //结果数组
        public IList<IList<int>> levelOrder(Node root)
        {
            if (root == null)
                return res;
            traverseNode(root,0);
            return res;
        }

        private void traverseNode(Node node, int level)
        {
            if (res.Count <= level) {
                res.Add(new List<int>());
            }

            res[level].Add(node.val);
            foreach (var item in node.children)
            {
                traverseNode(item, level+1);
            }
        }


    }