
using System.Text;

var strs = new string[]{ "flower", "flow", "flight" };
Console.WriteLine(LongestCommonPrefix(strs));

string LongestCommonPrefix(string[] strs)
{
	StringBuilder result = new StringBuilder();

	try
	{

		int progress = 0;
		while (progress <= 200)
		{
			char last = strs[0].ToCharArray()[progress];

			foreach (string str in strs)
			{
				if (str.ToCharArray()[progress] != last) return result.ToString();
			}

			result.Append(last);
			progress++;
		}
		return result.ToString();
	}
	catch
	{
		return result.ToString();
	}
}
