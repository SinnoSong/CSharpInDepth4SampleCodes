<Query Kind="Program" />

static void Main()
{
	int x = 10;
	PrintAndIncrementX();
	PrintAndIncrementX();
	Console.WriteLine($"After calls, x = {x}");

	void PrintAndIncrementX()
	{
		Console.WriteLine($"x= {x}");
		x++;
	}
}

