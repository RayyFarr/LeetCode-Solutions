
Console.WriteLine(MyPow(3, 3));

double MyPow(double x, int n)
{
	double y = x;
	if (n > 0)
		while (n-- > 1)
			x *= y;
	else
		while (n++ < 1)
			x *= 1 / y;
	return x;
}
//2nd method
