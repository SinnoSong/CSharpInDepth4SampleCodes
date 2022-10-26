<Query Kind="Program" />

class SimpleNameof
{
	private string field;

	public static void Main(string[] args)
	{
		Console.WriteLine(nameof(SimpleNameof));
		Console.WriteLine(nameof(Main));
		Console.WriteLine(nameof(args));
		Console.WriteLine(nameof(field));
	}
}