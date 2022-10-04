<Query Kind="Program" />

void Main()
{
	var x = new { Name = "ABC" };
	var y = new { Name = "DEF", Source = 10 };
	PrintName(x);
	PrintName(y);
}

static void PrintName(dynamic obj)
{
	Console.WriteLine(obj.Name);
}
