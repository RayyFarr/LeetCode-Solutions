int[][] mat1 = new int[][] {
	new int[] { 1, 3, 5, 7 },
	new int[] { 10, 11, 16, 20 },
	new int[] { 23, 30, 34, 60 }
};
int[][] mat2 = new int[][] {
	new int[] { 1, 3 },

}; 
int[][] mat3 = new int[][] {
	new int[] { 1, 3, 5, 7 },
	new int[] { 10, 11, 16, 20 },
	new int[] { 23, 30, 34, 60 }
};

Console.WriteLine(SearchMatrix(mat2, 3));


//Standard Linear search.
/*bool SearchMatrix(int[][] matrix, int target)
{
	for(int y = 0; y < matrix.Length; y++)
	{
		for(int x = 0; x < matrix[y].Length; x++)
		{
			if (matrix[y][x] == target) return true;
		}
	}
	return false;
}
*/

//Binary Search.
bool SearchMatrix(int[][] matrix, int target)
{
	int c = matrix[0].Length;
	int r = matrix.Length;

	int start = 0;
	int end = r * c - 1;
	int mid;

	while (start <= end)
	{
		mid = (start + end) / 2;
		int val = matrix[mid / c][mid % c];
		if (val < target)
		{
			start = mid + 1;
		}
		else if (val > target)
		{
			end = mid - 1;
		}
		else
			return true;
	}
	return false;
}