// See https://aka.ms/new-console-template for more information
using System.Text;

string digits = "";

Solution t = new Solution();
var result = t.LetterCombinations(digits);
foreach(var item in result)
{
    Console.WriteLine($"{item}, ");
}


public class Solution
{
    public IList<string> LetterCombinations(string digits)
    {
        IList<string> strings = new List<string>();
        Dictionary<int, List<char>> phoneDict = new Dictionary<int, List<char>>();
        phoneDict.Add(2, new List<char>(new char[] { 'a','b','c' }));
        phoneDict.Add(3, new List<char>(new char[] { 'd', 'e', 'f' }));
        phoneDict.Add(4, new List<char>(new char[] { 'g', 'h', 'i' }));
        phoneDict.Add(5, new List<char>(new char[] { 'j', 'k', 'l' }));
        phoneDict.Add(6, new List<char>(new char[] { 'm', 'n', 'o' }));
        phoneDict.Add(7, new List<char>(new char[] { 'p', 'q', 'r', 's'}));
        phoneDict.Add(8, new List<char>(new char[] { 't', 'u', 'v' }));
        phoneDict.Add(9, new List<char>(new char[] { 'w', 'x', 'y', 'z' }));

        StringBuilder s = new StringBuilder();
        if(digits.Length > 0)
            makeString(s, 0);

        void makeString(StringBuilder s,int i)
        {
            Console.WriteLine($"### {s.ToString()},{i}");
            if (i == digits.Length)
            {
                strings.Add(s.ToString());
                return;
            }
            int digit = digits[i] - '0';
            foreach(char c in phoneDict[digit])
            {
                s.Append(c);
                makeString(s, i + 1);
                s.Remove(s.Length - 1, 1);
            }
        }

        return strings;
    }
}
