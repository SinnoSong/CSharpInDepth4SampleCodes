<Query Kind="Statements" />

#nullable enable
static void PrintLength(string? text)
{
	if (!string.IsNullOrWhiteSpace(text))
	{
		Console.WriteLine($"{text}: {text!.Length}");
	}
	else
	{
		Console.WriteLine("Empty or null");
	}
}