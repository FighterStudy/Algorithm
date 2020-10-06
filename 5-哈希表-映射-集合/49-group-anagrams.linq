<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	string[] data = new string[]{"eat", "tea", "tan", "ate", "nat", "bat"};
}

// 82.38% 用LINQ优化  time O(nklogk)  space O(nk)
public IList<IList<string>> GroupAnagrams(string[] strs)
{
    IList<IList<string>> data = new List<IList<string>>();
    Dictionary<string, IList<string>> dic = new Dictionary<string, IList<string>>();
    foreach (string item in strs)
    {
        char[] chars = item.ToCharArray();
        Array.Sort(chars);
        StringBuilder sb = new StringBuilder();
        foreach (var c in chars)
        {
            sb.Append(c);
        }

        if (dic.ContainsKey(sb.ToString()))
            dic[sb.ToString()].Add(item);
        else 
            dic[sb.ToString()] = new List<string>() { item};
    }

    return dic.Values.ToList();
}

// time()nk spack nk????
public  IList<IList<string>> GroupAnagrams1(string[] strs)
{
    IList<IList<string>> data = new List<IList<string>>();
    Dictionary<string, IList<string>> dic = new Dictionary<string, IList<string>>();
    foreach (string item in strs)
    {
        int[] table = new int[26];
        foreach (var c in item)
        {
            table[c - 'a']++;
        }
       
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < 26; i++)
        {
		    //# 一定要加上。 "bdddddddddd", "bbbbbbbbbbc" 是一样的
			// 01010
            sb.Append(table[i]).Append("#");
        }

        if (dic.ContainsKey(sb.ToString()))
            dic[sb.ToString()].Add(item);
        else 
            dic[sb.ToString()] = new List<string>() { item};
    }

    return dic.Values.ToList();
}