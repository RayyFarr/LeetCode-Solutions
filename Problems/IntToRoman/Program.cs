using System.Collections;

int[] values = new int[]
{
   1,
   4,
   5,
   9,
   10,
   40,
   50,
   90,
   100,
   400,
   500,
   900,
   1000
};

//Dictionary One managed to beat 99.32%
Dictionary<int, string> chars = new Dictionary<int, string>()
{
    {0, "I"},
    {1, "IV"},
    {2, "V"},
    {3, "IX"},
    {4, "X"},
    {5, "XL"},
    {6, "L"},
    {7, "XC"},
    {8, "C" },
    {9, "CD" },
    {10, "D" },
    {11, "CM" },
    {12, "M" },


};
//Array Solution.
/*string[] chars = new string[]
{
    "I",
    "IV",
    "V",
    "IX",
    "X",
    "XL",
    "L",
    "XC",
    "C",
    "CD",
    "D",
    "CM",
    "M"
};*/
string IntToRoman(int num)
{
    int decrement = values.Length-1;
    string roman = "";
    while (decrement >= 0)
    {
        if (num / values[decrement] > 0)
        {
            roman += chars[decrement];
            num -= values[decrement];
            continue;
        }
        else
        {
            decrement--;
        }
    }
    return roman;
}

Console.WriteLine(IntToRoman(3));
Console.WriteLine(IntToRoman(58)); 
Console.WriteLine(IntToRoman(1994));