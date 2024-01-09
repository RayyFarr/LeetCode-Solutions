

Console.WriteLine(IsPalindrome(121));
Console.WriteLine(IsPalindrome(32));
Console.WriteLine(IsPalindrome(0000));

bool IsPalindrome(int x)
{
    
    int tempX = x/10;
    int rev = x%10;

    while(tempX > 0)
    {
        rev = rev * 10 + tempX % 10;
        tempX /= 10;       
    }
    return (rev == x) && Math.Sign(x) != -1;
}
