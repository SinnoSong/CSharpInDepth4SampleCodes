<Query Kind="Statements" />

static void CheckBounds(object input)
{
	switch (input)
	{
		case int x when x > 1000:
		case long y when y > 10000L:
			Console.WriteLine("Value is too large");
			break;
		case int x when x < -1000:
		case long y when y < -10000L:
			Console.WriteLine("Value is too low");
			break;
		default:
			Console.WriteLine("Value is in range");
			break;
	}
}