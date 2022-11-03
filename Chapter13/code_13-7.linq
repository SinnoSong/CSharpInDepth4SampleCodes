<Query Kind="Program" />

void Main()
{
	int x = 10;
	RefReturn(ref x)++;
	Console.WriteLine(x);
}
static ref int RefReturn(ref int p)
{
	return ref p;
}