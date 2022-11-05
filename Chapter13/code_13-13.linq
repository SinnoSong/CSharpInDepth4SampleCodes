<Query Kind="Program" />

void Main()
{
	int x = 10;
	InParameter(x,() => x++);

	int y = 10;
	ValueParameter(y,() => y++);
}
static void InParameter(in int p, Action action)
{
	Console.WriteLine("Start of InParameter method");
	Console.WriteLine($"p = {p}");
	action();
	Console.WriteLine($"p={p}");
}
static void ValueParameter(int p, Action action)
{
	Console.WriteLine("Start of ValueParameter method");
	Console.WriteLine($"p = {p}");
	action();
	Console.WriteLine($"p={p}");
}
