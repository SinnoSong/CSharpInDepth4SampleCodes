<Query Kind="Program" />

void Main()
{
	int x = 5;
	IncrementAndDouble(ref x, ref x);
	Console.WriteLine(x);
}
static void IncrementAndDouble(ref int p1, ref int p2)
{
	p1++;
	p2 *= 2;
}