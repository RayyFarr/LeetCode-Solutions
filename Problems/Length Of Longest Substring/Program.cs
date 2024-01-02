Console.WriteLine(LengthOfLongestSubstring("wekewas12"));
Console.WriteLine(LengthOfLongestSubstring("abcabcbb"));
Console.WriteLine(LengthOfLongestSubstring("dvdf"));

int LengthOfLongestSubstring(string s)
{
    HashSet<char> combination = new HashSet<char>();
    int bestN = 0;
    int n = 0;
    int iter = 0;
    for(int i = 0; i < s.Length; i++)
    {
        if (!combination.Contains(s[i]))
        {
            combination.Add(s[i]);
            n++;
        }
        else
        {
            if (n > bestN) bestN = n;
            combination.Clear();
            iter++;
            combination.Add(s[iter]);
            i = iter;
            n = 1;
        }
    }

    return Math.Max(n,bestN);
}