<Query Kind="Program" />

void Main()
{
	var counter = CreateCounter();
	counter();
	counter();
}
static Action CreateCounter()
{
	int count = 0;
	return Count;
	void Count() => Console.WriteLine(count++);
}

