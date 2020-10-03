<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	string  str = "()[]{}";
	isValid(str).Dump();
}

public bool IsValid(string s) {
        Dictionary<char, char> resource = new Dictionary<char, char>();
        resource.Add(')', '(');
        resource.Add(']', '[');
        resource.Add('}', '{');
        Stack<char> data = new Stack<char>();
        foreach (var item in s)
        {
            if (data.Count != 0)
            {
                char d = data.Peek();
                if (resource.ContainsKey(item) &&  char.Equals(d, resource[item]))
                    data.Pop();
                else
                    data.Push(item);
            }
            else 
                data.Push(item);
        }

        return data.Count==0?true:false;
}


bool IsValid1(string s)
{
    Dictionary<char, char> resource = new Dictionary<char, char>();
    Stack<char> stack = new Stack<char>();
    foreach (var item in s)
    {
        switch (item)
        {
            case '(':
                stack.Push(')');
                break;
            case '[':
                stack.Push(']');
                break;
            case '{':
                stack.Push('}');
                break;
            default:
                if (stack.Count == 0 || stack.Pop() != item)
                    return false;
                break;
        }
    }

    return true;
}



