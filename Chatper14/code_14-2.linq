<Query Kind="Program" />

void Main()
{
	int i = 0;
	AddToI(5);
	AddToI(10);
	Console.WriteLine(i);
	void AddToI(int amount) => i += amount;
}

