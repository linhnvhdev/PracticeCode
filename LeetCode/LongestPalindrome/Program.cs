// See https://aka.ms/new-console-template for more information

string s = "babad";

Console.WriteLine(LongestPalindrome(s));

string LongestPalindrome(string s)
{
    int n = s.Length;

    if (n <= 1) return s;
    (int, int) max = (0, 1);

    bool[,] palindrome = new bool[n, n];
    for (int i = 0; i < n; i++)
    {
        for (int j = i; j >= 0; j--)
        {
            if (s[i] == s[j])
            {
                if (i - j <= 1) palindrome[j, i] = true;
                else if (palindrome[j + 1, i - 1]) palindrome[j, i] = true;
            }
        }
    }

    for (int i = 0; i < n; i++)
    {
        for (int j = i + 1; j < n; j++)
        {
            //Console.WriteLine($"i : {i}, j: {j}, isPalin(i,j): {isPalindrome(i, j)}");
            if (isPalindrome(i, j))
            {   
                max = (j - i + 1 > max.Item2) ? (i, j - i + 1) : max;
            }
        }
    }

    bool isPalindrome(int from, int to)
    {
        return palindrome[from, to];
    }
    return s.Substring(max.Item1, max.Item2);
}