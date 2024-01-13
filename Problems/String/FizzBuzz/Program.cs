//This simple solution somehow beat 99.39%.

IList<string> FizzBuzz(int n)
{
    string[] s = new string[n];
    for (int i = 1; i <= n; i++)
    {
        if (i % 3 == 0) s[i - 1] = "Fizz";
        if (i % 5 == 0) s[i - 1] += "Buzz";
        if (i % 3 != 0 && i % 5 != 0) s[i - 1] = i.ToString();
    }
    return s;
}