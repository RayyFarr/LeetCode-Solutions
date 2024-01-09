


List<IList<int>> result = new();
IList<IList<int>> Subsets(int[] nums)
{
	nums = nums.Distinct().ToArray();

	Generate(nums, 0, new HashSet<int>());
	return result;
}
void Generate(int[] nums, int startIndex, HashSet<int> combination)
{
	if (startIndex > nums.Length) return;

	result.Add(new List<int>(combination));

	for (int i = startIndex; i < nums.Length; i++)
	{
		int current = nums[i];
		combination.Add(current);
		Generate(nums, i+1, combination);
		combination.Remove(current);
	}
}


for(int i = 0; i < 5; i++)
{
	int[] nums = new int[i];
	string A = "{";
	for (int j = 0; j < nums.Length; j++)
	{
		nums[j] = j + 1;
		A += $"{j + 1}{(j == nums.Length - 1 ? "":',')}";
	}
	A+= "}";
	Console.Write($"A = {A} thus, P(A) : ");

	string powerSet = "{";
	IList<IList<int>> subsets = Subsets(nums);
	RemoveDuplicates(subsets);
	for(int k = 0; k < subsets.Count; k++)
	{
		powerSet += "{";
		IList<int> subset = subsets[k];
		for(int l = 0; l < subset.Count;l++)
		{
			powerSet += subset[l].ToString() + (l == subset.Count - 1 ? "" : ',');
		}
		powerSet += k == subsets.Count - 1 ? "}" : "},";
	}
	powerSet += "}";
	Console.WriteLine(powerSet);

}
void RemoveDuplicates(IList<IList<int>> list)
{
	for(int i = 0;i < list.Count; i++)
	{
		for(int k = i+1;k< list.Count;k++)
		{
			bool equal = true;
			if (list[k].Count != list[i].Count) { continue; }
			for(int j = 0;j < list[i].Count;j++) 
			{
				if (list[i][j] != list[k][j]) { equal = false; }
			}
			if (equal) list.RemoveAt(k);
		}
	}
}