
using System.Numerics;

Console.WriteLine(Reverse(1534236469));
Console.WriteLine(Reverse(-123));
Console.WriteLine(Reverse(120));


//Solution 1.
/*int Reverse(int x){
   BigInteger n = Math.Sign(x) * Convert.ToInt64(new string(x.ToString().ToCharArray().Reverse().ToArray()).Replace("-", ""));
    if (n < int.MaxValue && n > int.MinValue)
        return (int)n;
    return 0;
}
*/

//Solution 2 faster.
int Reverse(int x)
{
    try
    {
        return Math.Sign(x) *
            Convert.ToInt32(new string(x.ToString().ToCharArray().Reverse().ToArray()).Replace("-", ""));
    }
    catch
    {
        return 0;
    }
}