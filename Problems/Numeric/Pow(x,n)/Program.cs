Console.WriteLine(MyPow(2, 10));
Console.WriteLine(MyPow(-2, 21231232));
Console.WriteLine(MyPow(3, -22));

//Uses Binary Exponentiation.
double MyPow(double x, int n)
{
    if (n == 0 || x == 1) return 1;
    bool inverse = n < 0;
    double mult = 1;
    while (n * Math.Sign(n)  != 1)
    {
        if (n % 2 != 0)
        {
            mult *= x;
        }
        x *= x;

        n /= 2;
    }
    return inverse ? 1 / (mult * x) : (mult * x);
}
//for 2^7 it looks like 2^7 => 2^6 * 2 => 4^3 * 2 => 4^2 * 2 * 4 => 16^1 * 2 * 4 => 32 * 4 => 128