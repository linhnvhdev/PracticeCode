// See https://aka.ms/new-console-template for more information
string s = "";

Console.WriteLine(LengthOfLongestSubstring(s));

int LengthOfLongestSubstring(string s)
{
    if (s.Length == 0) return 0;
    Dictionary<char, int> map = new Dictionary<char,int>();
    int cur = -1,max = 0;

    for(int i = 0;i < s.Length; i++)
    {
        char c = s[i];
        if (!map.ContainsKey(c))
        {
            map.Add(c, -1);
        }
        if (map[c] >= cur)
        {
            max = Math.Max(max, i - cur);
            cur = map[c] + 1;
        }
        map[c] = i;
    }
    max = Math.Max(max, s.Length - cur);
    return max;
}