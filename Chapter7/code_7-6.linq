<Query Kind="Program">
  <Namespace>System.Runtime.CompilerServices</Namespace>
</Query>

void Main()
{
	dynamic message = "Some message";
	ShowLine(message);
	ShowLine((string)message);
	ShowLine(message, GetLineNumber());
}

static void ShowLine(string message, [CallerLineNumber] int line = 0)
{
	Console.WriteLine($"{line}:{message}");
}
static int GetLineNumber([CallerLineNumber] int line = 0)
{
	return line;
}
