#region Methods
Dictionary<char, int> charValues = new Dictionary<char, int>
{
    {'I' , 1},
    {'V' , 5},
    {'X' , 10},
    {'L' , 50},
    {'C' , 100},
    {'D' , 500},
    {'M' , 1000},

};

int RomanToInt(string s)
{

    int ans = 0;
    for (int i = 0; i < s.Length-1; i++)
    {
        if (charValues[s[i]] >= charValues[s[i + 1]]) ans += charValues[s[i]];
        else {
            ans += charValues[s[i + 1]] - charValues[s[i]];
            i++;
        }
    }
    if (s.Length == 1 || charValues[s[s.Length - 2]] >= charValues[s[s.Length - 1]]) ans += charValues[s[s.Length - 1]];
    
    return ans;
}

//ChatGPT 'improved' this code but seems like it takes the same amount of runtime. The changes are quite obvious.
/*    
    int ans = charValues[s[s.Length - 1]];
    for (int i = 0; i < s.Length - 1; i++)
    {
        if (charValues[s[i]] >= charValues[s[i + 1]]) ans += charValues[s[i]];
        else ans -= charValues[s[i]];
    }
    return ans;
*/
#endregion

Console.WriteLine(RomanToInt("MCMXCIV"));
Console.WriteLine(RomanToInt("III"));
Console.WriteLine(RomanToInt("LVIII"));
Console.WriteLine(RomanToInt("D"));
