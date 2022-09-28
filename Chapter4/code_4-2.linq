<Query Kind="Statements" />

static void Add(dynamic d)
{
	Console.WriteLine(d + d);
}

Add("text");
Add(100);
Add(TimeSpan.FromMinutes(45));