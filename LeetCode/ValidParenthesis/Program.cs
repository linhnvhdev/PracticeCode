// See https://aka.ms/new-console-template for more information
string s = "(([])({}))";
Solution t = new Solution();
Console.WriteLine(t.IsValid(s));

public class Solution
{
    public bool IsValid(string s)
    {
        Stack<char> pStack = new Stack<char>();
        foreach(char c in s)
        {
            if(c.Equals('(') || c.Equals('[') || c.Equals('{'))
            {
                pStack.Push(c);
            }
            else
            {
                if (pStack.Count == 0)
                    return false;
                else
                {
                    char top = pStack.Pop();
                    if (c == ')' && top != '(') return false;
                    if (c == ']' && top != '[') return false;
                    if (c == '}' && top != '{') return false;
                }
            }
        }
        return pStack.Count == 0;
    }
}