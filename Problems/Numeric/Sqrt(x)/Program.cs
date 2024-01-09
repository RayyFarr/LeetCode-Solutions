//large test.

bool works = false;
for (int i = 0; i < 3000; i++)
{
	works = MySqrt(i) == (int)Math.Sqrt(i);
	if (!works)
	{

		Console.WriteLine($"Does not work when i = {i}. MySqrt({i}) = {MySqrt(i)} whereas sqrt of i is {Math.Sqrt(i)}.");
		return;
	}
}
Console.WriteLine("Finished");
/*int MySqrt(int x)
{

	for (long i = 0; true; i++)
		if (i * i > x) return (int)i - 1;
}
*/
//Binary Search. WIP

float EPSILON = 0.05f;

int MySqrt(int x)
{
	if (x <= 1) return x;
	long start = 0L;
	long end = x/2;

	long mid=0;
	while (start < end)
	{
		mid = (start+end) / 2;
		if(mid*mid < x)
		{
			start = mid+1;
			if(start*start > x) return (int)mid;
			else if (start * start == x) return (int)start;

		}
		else if(mid * mid > x)
		{
			end = mid - 1 ;
			if (end * end <= x) return (int)end;
		}
		else 
			return (int)mid;
	}
	return (int)start;
}