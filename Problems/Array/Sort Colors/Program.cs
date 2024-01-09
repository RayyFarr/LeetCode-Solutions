// See https://aka.ms/new-console-template for more information

int[] test1 = new int[] { 1, 0, 2, 1, 1,0 };
int[] test2 = new int[] { 2, 0, 1 };
int[] test3 = new int[] { 1, 2, 0 };

SortColors(test1);
SortColors(test2);
SortColors(test3);

WriteArray(test1, "TestCase 1");
WriteArray(test2, "TestCase 2");
WriteArray(test3, "TestCase 3");

void SortColors(int[] nums)
{
	int num0s = 0;
	int num2s = 0;
	for (int i = 0; i < nums.Length; i++)
	{
		SuperSwap(nums,i,num0s,num2s);
	}

}
void SuperSwap(int[] nums,int i,int num0s,int num2s)
{

	if (nums[i] == 0 && i > num0s)
	{
		Swap(nums, i, num0s);
		num0s++;
		SuperSwap(nums,i,num0s,num2s);
	}
	else if (nums[i] == 2 && i < (nums.Length - 1) - num2s)
	{
		Swap(nums, i, (nums.Length - 1) - num2s);
		num2s++;
		SuperSwap(nums, i, num0s, num2s);
	}
}
void Swap(int[] array, int index1, int index2)
{
	int temp = array[index1];
	array[index1] = array[index2];
	array[index2] = temp;
}

void WriteArray(Array array, string name)
{
	Console.WriteLine(name + " : ");
	Console.Write("[");
	for (int i = 0; i < array.Length; i++)
		Console.Write(array.GetValue(i) + ((i == array.Length - 1) ? "]\n" : ","));
}