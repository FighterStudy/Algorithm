<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	//IsAnagram("anagram","nagaram");
	char[] c1= new char[]{'a'};
	char[] c2= new char[]{'a'};
	  (c1.Equals(c2)).Dump();
	Array.Equals(c1,c2).Dump();
}

// Define other methods, classes and namespaces here
// Sort  time: nlogn  space:o1
public bool IsAnagram(string s, string t)
{
    if (s == null && t == null)
        return true;
    if (s != null && t != null && s.Length != t.Length)
        return false;
    char[] c1 = s.ToCharArray();
    char[] c2 = t.ToCharArray();
    Array.Sort(c1);
    Array.Sort(c2);
    for (int i = 0; i < c1.Length; i++)
    {
        if (c1[i] != c2[i])
            return false;
    }
    return true;
}


// Hash 90% time On space O1
public bool IsAnagram1(string s, string t)
{
    if (s == null && t == null)
        return true;
    if (s != null && t != null && s.Length != t.Length)
        return false;
    int[] data = new int[26];
    foreach (var item in s)
    {
        data[item - 'a']++;
    }
    foreach (var item in t)
    {
        data[item - 'a']--;
        if (data[item - 'a'] < 0)
            return false;
    }

    return true;
}

